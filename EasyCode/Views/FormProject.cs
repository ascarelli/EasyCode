using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EasyCode.Framework;
using EasyCode.Entities;
using static EasyCode.Framework.Utils;
using System.Text;

namespace EasyCode.Views
{
    public partial class FormProject : Form
    {
        private MongoDBCore _mDB;
        public FormProject()
        {
            InitializeComponent();
            _mDB = new MongoDBCore();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            project.NameSpace = txtProjectNameSpace.Text;

            //var projectClasses = dtgClass.DataSource as List<ProjectClass>;
            //if (projectClasses != null)
            //{
            //    foreach (var projectClass in projectClasses)
            //    {
            //        var projectAttrs = dtgAttributes.DataSource as List<ProjectAttribute>;
            //        if (projectAttrs != null)
            //        {
            //            foreach (var projectAttr in projectAttrs)
            //                projectClass.Attributes.Add(projectAttr);
            //        }
            //        project.ProjectClasses.Add(projectClass);
            //    }
            //}

            _mDB.add(project);
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if(validateAddClass())
            {
                ProjectClass projectClass = new ProjectClass();
                projectClass.Name = txtClass.Text;

                var projectClasses = dtgClass.DataSource as List<ProjectClass>;
                if (projectClasses == null)
                    projectClasses = new List<ProjectClass>();

                if (projectClasses.Any(x => x.Name.ToUpper().Trim() == projectClass.Name.ToUpper().Trim()))
                    MessageBox.Show("Classe já adicionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    projectClasses.Add(projectClass);

                dtgClass.DataSource = new List<ProjectClass>();
                dtgClass.DataSource = projectClasses;

                limparOperacaoAddClass();
            }  
        }


        private void dtgClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = sender as DataGridView;
            //if (dgv.Columns[e.ColumnIndex].Name == "Attributes")
            //{
            //    string className = dtgClass.Rows[e.RowIndex].Cells["ClassName"].Value?.ToString();
            //    grpAttr.Enabled = true;
            //    grpAttr.Text = "Atributos da classe " + className;
            //    txtAttrName.Focus();
            //}
            //else if (dgv.Columns[e.ColumnIndex].Name == "DeleteClass")
            //{
            //    UtilsFormsGrid.deleteFromgrid<ProjectClass>(dtgAttributes, e.RowIndex);
            //    dtgAttributes.DataSource = new List<ProjectAttribute>();
            //}   
        }

        private void dtgAttributes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = sender as DataGridView;
            //if (dgv.Columns[e.ColumnIndex].Name == "DeleteAttr")
            //    UtilsFormsGrid.deleteFromgrid<ProjectAttribute>(dtgAttributes, e.RowIndex);
        }

        private void btnAddAttr_Click(object sender, EventArgs e)
        { 
            //if(validateAddAttr())
            //{
            //    ProjectAttribute attr = new ProjectAttribute();
            //    attr.Name = txtAttrName.Text;
            //    attr.Nullable = (chkNullable.Checked ? (int)KDLogical.Yes : (int)KDLogical.No);

            //    if (!string.IsNullOrWhiteSpace(txtPrecision.Text) && !string.IsNullOrWhiteSpace(txtScale.Text))
            //        attr.PrecisionScale = txtPrecision.Text + ";" + txtScale.Text;

            //    int value = 0;
            //    int.TryParse(cbxType.SelectedValue.ToString(), out value);
            //    attr.Type = value;

            //    var projectAttributes = dtgAttributes.DataSource as List<ProjectAttribute>;
            //    if (projectAttributes == null)
            //        projectAttributes = new List<ProjectAttribute>();

            //    if (projectAttributes.Any(x => x.Name.ToUpper().Trim() == attr.Name.ToUpper().Trim()))
            //        MessageBox.Show("Atributo já adicionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    else
            //        projectAttributes.Add(attr);

            //    dtgAttributes.DataSource = new List<ProjectAttribute>();
            //    dtgAttributes.DataSource = projectAttributes;

            //    limparOperacaoAddAttr();
            //}
          
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int value = 0;
            //int.TryParse(cbxType.SelectedValue.ToString(),out value);
            //txtPrecision.Visible = txtScale.Visible = lblScale.Visible = lblPrecision.Visible =
            //(value == (int)ProjectAttribute.KDType.Decimal || value == (int)ProjectAttribute.KDType.Double);
        }

        private void FormProject_Load(object sender, EventArgs e)
        {
            //List<ComboBoxClass> cbxValues = new List<ComboBoxClass>();
            //var values = Enum.GetValues(typeof(ProjectAttribute.KDType)).Cast<ProjectAttribute.KDType>();
            //foreach (var item in values)
            //{
            //    ComboBoxClass cbx = new ComboBoxClass();
            //    cbx.Id = ((int)item).ToString();
            //    cbx.Value = item.ToString();
            //    cbxValues.Add(cbx);
            //}
            
            //cbxType.ValueMember = "Id";
            //cbxType.DisplayMember = "Value";
            //cbxType.DataSource = cbxValues;

            //grpAttr.Enabled = false;
        }

        private bool validateAddAttr()
        {
            StringBuilder msg = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtAttrName.Text))
                msg.AppendLine("Digite um nome para o atributo.");

            if (!string.IsNullOrWhiteSpace(msg.ToString()))
                MessageBox.Show(msg.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return string.IsNullOrWhiteSpace(msg.ToString());
        }
        private bool validateAddClass()
        {
            StringBuilder msg = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtClass.Text))
                msg.AppendLine("Digite uma classe para adicionar.");


            if (!string.IsNullOrWhiteSpace(msg.ToString()))
                MessageBox.Show(msg.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return string.IsNullOrWhiteSpace(msg.ToString());
        }


        private void limparOperacaoAddClass()
        {
            txtClass.Clear();
            txtClass.Focus();
        }

        private void limparOperacaoAddAttr()
        {
            txtAttrName.Clear();
            cbxType.SelectedIndex = 0;
            chkNullable.Checked = false;
            txtPrecision.Clear();
            txtScale.Clear();
            txtAttrName.Focus();
        }
    }
}
