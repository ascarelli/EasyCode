using EasyCode.Entities;
using EasyCode.Framework;
using EasyCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace EasyCode.Views
{
    public partial class FormSolution : Form
    {
        public FormSolution()
        {
            InitializeComponent();
        }

        UtilsForms utilsForms = new UtilsForms();
        List<Project> _ProjectsToTreeView = new List<Project>();
        List<Project> _ProjectsToGenarate = new List<Project>();

        private void FormSolution_Load(object sender, EventArgs e)
        {
        
        }
        private void FormSolution_Shown(object sender, EventArgs e)
        {
            loadData();
        }
        private void btnNewProject_Click(object sender, EventArgs e)
        {
            FormProject fmr = new FormProject();
            fmr.ShowDialog();
        }
        private void btnGenareCode_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPathSln.Text))
            {
                MessageBox.Show("Digite o caminho da Solution SLN.");
            }
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    _ProjectsToGenarate = new List<Project>();
                    foreach (var project in _ProjectsToTreeView)
                    {
                        TreeNode projectNode = treeViewProjects.Nodes.Find(project.NameSpace, true).FirstOrDefault();
                        if (projectNode != null && projectNode.Checked)
                        {
                            GenerateCode generateCode = new GenerateCode();
                            generateCode.PathSolution = txtPathSln.Text + "\\";
                            generateCode.Entity = project.ProjectClasses[0].Name;
                            GenerateCodeService codeService = new GenerateCodeService(project, generateCode);
                            codeService.executeDDD();
                        }
                    }
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar Solution.");
                }
            }
        }
        private void loadData()
        {
            Cursor.Current = Cursors.WaitCursor;
            List<TreeNode> nodesProjects = new List<TreeNode>();

            MongoDBCore mongoDBCore = new MongoDBCore();
            _ProjectsToTreeView = mongoDBCore.getAll<Project>();

            foreach (var project in _ProjectsToTreeView)
            {
                List<TreeNode> nodesClass = new List<TreeNode>();
                foreach (var projectClass in project.ProjectClasses)
                {
                    List<TreeNode> nodesAttr = new List<TreeNode>();
                    foreach (var attr in projectClass.Attributes)
                    {
                        TreeNode treeNodeAttr = new TreeNode(attr.Name);
                        treeNodeAttr.Tag = $"{attr.ObjectType};{project.NameSpace};{projectClass.Name};{attr.Name}";
                        nodesAttr.Add(treeNodeAttr);
                    }

                    TreeNode treeNodeClass = new TreeNode(projectClass.Name, nodesAttr.ToArray());
                    treeNodeClass.Tag = $"{projectClass.ObjectType};{project.NameSpace};{projectClass.Name}";
                    nodesClass.Add(treeNodeClass);
                }

                TreeNode treeNodeProject = new TreeNode(project.NameSpace, nodesClass.ToArray());
                treeNodeProject.Tag = $"{project.ObjectType};{project.NameSpace}";
                treeNodeProject.Name = project.NameSpace;
                nodesProjects.Add(treeNodeProject);
            }

            TreeNode treeNodeProjects = new TreeNode("Projects", nodesProjects.ToArray());
            treeNodeProjects.Tag = $"{(int)KDObjectType.ProjectHeader}";
            treeViewProjects.Nodes.Add(treeNodeProjects);
            Cursor.Current = Cursors.Default;
        }
        private void treeViewProjects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dtgOperations.DataSource = null;
            var node = e.Node;

            try
            {
                var objType = node.Tag.ToString().Split(';');

                int ObjectType = 0;
                int.TryParse(objType[0], out ObjectType);

                switch (ObjectType)
                {
                    case (int)KDObjectType.Project:

                        var projects = _ProjectsToTreeView.FirstOrDefault(x => x.NameSpace == objType[1]);
                        this.decorateGridToClass(projects.ProjectClasses);
                        break;
                    case (int)KDObjectType.Class:
                        var projectClass = _ProjectsToTreeView.FirstOrDefault(x => x.NameSpace == objType[1])
                                           .ProjectClasses.FirstOrDefault(x => x.Name == objType[2]);

                        this.decorateGridToAttrs(projectClass.Attributes);
                        break;
                    case (int)KDObjectType.Attr:
                        break;
                    default:
                        if (treeViewProjects.GetNodeCount(true) <= 1)
                            loadData();
                        else
                            this.decorateGridToProject();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as definições do projeto, tenta novamente mais tarde.");
            }
        }
        private void treeViewProjects_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    utilsForms.CheckAllChildNodes(e.Node, e.Node.Checked);
                }

                utilsForms.CheckAllRootNodes(e.Node, e.Node.Checked);
            }

        }
        private void decorateGridToProject()
        {
            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "NameSpace",
                Visible = true,
                Width = 250
            });

            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "ObjectType",
                Visible = false,
                Width = 100
            });

            dtgOperations.DataSource = _ProjectsToTreeView;
        }
        private void decorateGridToClass(IList<ProjectClass> prClasses)
        {
            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "Name",
                Visible = true,
                Width = 250
            });
            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "ObjectType",
                Visible = false,
                Width = 100
            });

            dtgOperations.DataSource = prClasses;
        }
        private void decorateGridToAttrs(IList<ProjectAttribute> prAttrs)
        {
            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "Name",
                HeaderText = "Nome",
                Visible = true,
                Width = 210
            });

            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "Type",
                HeaderText = "Tipo",
                Visible = true,
                Width = 70
            });

            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "Nullable",
                HeaderText = "Nulo",
                Visible = true,
                Width = 70
            });

            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "ObjectType",
                Visible = false
            });

            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "PrecisionScale",
                Visible = false
            });

            createControlsToGrid(new GridControls
            {
                DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn(),
                Name = "EnumDescription",
                Visible = false
            });


            dtgOperations.DataSource = prAttrs;
        }
        private void createControlsToGrid(GridControls prGridControls)
        {
            if (prGridControls.DataGridViewTextBoxColumn != null)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = col.Name = prGridControls.Name;
                col.HeaderText = prGridControls.HeaderText;
                col.Width = prGridControls.Width;
                col.Visible = prGridControls.Visible;
                dtgOperations.Columns.Insert(0, col);
            }
        }
    }

 
}
