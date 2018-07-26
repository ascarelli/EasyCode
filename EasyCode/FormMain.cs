using EasyCode.Entities;
using EasyCode.Framework;
using EasyCode.Views;
using MongoDB.Bson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCode
{
    public partial class formProject : Form
    {
        List<Project> Projects = new List<Project>();

        public formProject()
        {
            InitializeComponent();
            
        }

        //private void mockTreeView()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Project project = new Project();
        //        project.NameSpace = "Prodesp.Gsnet.Framework.Extension " + i;

        //        ProjectClass projectClass = new ProjectClass();
        //        projectClass.Name = "ETL " + i;

        //        Attribute attribute = new Attribute { Name = "Version " + i };
        //        projectClass.Attributes.Add(attribute);

        //        attribute = new Attribute { Name = "Project " + i };
        //        projectClass.Attributes.Add(attribute);

        //        attribute = new Attribute { Name = "Catalog " + i };
        //        projectClass.Attributes.Add(attribute);

        //        project.ProjectClasses.Add(projectClass);
        //        Projects.Add(project);
        //    }
        //}

        private void formProject_Load(object sender, EventArgs e)
        {
            //mockTreeView();
        }

        private void loadData() {
            Cursor.Current = Cursors.WaitCursor;
            List<TreeNode> nodesProjects = new List<TreeNode>();

            MongoDBCore mongoDBCore = new MongoDBCore();
            Projects = mongoDBCore.getAll<Project>();

            foreach (var project in Projects)
            {
                List<TreeNode> nodesClass = new List<TreeNode>();
                foreach (var projectClass in project.ProjectClasses)
                {
                    List<TreeNode> nodesAttr = new List<TreeNode>();
                    foreach (var attr in projectClass.Attributes)
                    {
                        TreeNode treeNodeAttr = new TreeNode(attr.Name + "");
                        treeNodeAttr.Tag = JsonConvert.SerializeObject(attr);
                        nodesAttr.Add(treeNodeAttr);
                    }

                    TreeNode treeNodeClass = new TreeNode(projectClass.Name, nodesAttr.ToArray());
                    treeNodeClass.Tag = JsonConvert.SerializeObject(projectClass);
                    nodesClass.Add(treeNodeClass);
                }

                TreeNode treeNodeProject = new TreeNode(project.NameSpace, nodesClass.ToArray());
                treeNodeProject.Tag = JsonConvert.SerializeObject(project);
                nodesProjects.Add(treeNodeProject);
            }

            TreeNode treeNodeProjects = new TreeNode("Projects", nodesProjects.ToArray());
            ObjectCode objectCode = new ObjectCode { ObjectType = (int)ObjectTypeEnum.ProjectHeader };
            treeNodeProjects.Tag = JsonConvert.SerializeObject(objectCode);
            treeViewProjects.Nodes.Add(treeNodeProjects);
            Cursor.Current = Cursors.Default;
        }

        private void treeViewProjects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dtgOperations.DataSource = null;
            var node = e.Node;

            try
            {
                var objectCode = JsonConvert.DeserializeObject<ObjectCode>(node.Tag.ToString());

                switch (objectCode.ObjectType)
                {
                    case (int)ObjectTypeEnum.Project:
                        var projects = JsonConvert.DeserializeObject<Project>(node.Tag.ToString());
                        this.decorateGridToClass(projects.ProjectClasses);
                        break;
                    case (int)ObjectTypeEnum.Class:
                        var classes = JsonConvert.DeserializeObject<ProjectClass>(node.Tag.ToString());
                        this.decorateGridToAttrs(classes.Attributes);
                        break;
                    case (int)ObjectTypeEnum.Attr:
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
            
            dtgOperations.DataSource = Projects;
        }

        private void decorateGridToClass(List<ProjectClass> prClasses)
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

        private void decorateGridToAttrs(List<Attribute> prAttrs)
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
            dtgOperations.DataSource = prAttrs;
        }

        private void createControlsToGrid(GridControls prGridControls)
        {
            if (prGridControls.DataGridViewTextBoxColumn != null)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = col.HeaderText = col.Name = prGridControls.Name;
                col.Width = prGridControls.Width;
                col.Visible = prGridControls.Visible;
                dtgOperations.Columns.Insert(0, col);
            }
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
    
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            FormProject fmr = new FormProject();
            fmr.ShowDialog();
        }

        private void formProject_Shown(object sender, EventArgs e)
        {
            loadData();   
        }
    }

    public enum ObjectTypeEnum
    {
        Project = 0,
        Class = 1,
        Attr = 2,
        ProjectHeader = 3
    }

    public class Attribute 
    {
        public Attribute()
        {
            this.ObjectType = (int)ObjectTypeEnum.Attr;
        }
        public string Name { get; set; }
        public int ObjectType { get; set; }
    }

    public class ObjectCode
    {
        public int ObjectType { get; set; }
    }

    public class GridControls
    {
        public GridControls()
        {
            this.DataGridViewTextBoxColumn = null;
        }
        public string Name { get; set; }
        public int Width { get; set; }
        public bool Visible { get; set; }
        public DataGridViewTextBoxColumn DataGridViewTextBoxColumn { get; set; }
    }

}

