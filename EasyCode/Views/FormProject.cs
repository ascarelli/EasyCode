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
        private Project _Project;
        private string _CurrenteClassName = string.Empty;

        public FormProject()
        {
            InitializeComponent();
            _mDB = new MongoDBCore();
            _Project = new Project();
        }
        private void FormProject_Load(object sender, EventArgs e)
        {
            List<ComboBoxClass> cbxValues = new List<ComboBoxClass>();
            var values = Enum.GetValues(typeof(ProjectAttribute.KDType)).Cast<ProjectAttribute.KDType>();
            foreach (var item in values)
            {
                ComboBoxClass cbx = new ComboBoxClass();
                cbx.Id = ((int)item).ToString();
                cbx.Value = item.ToString();
                cbxValues.Add(cbx);
            }

            cbxType.ValueMember = "Id";
            cbxType.DisplayMember = "Value";
            cbxType.DataSource = cbxValues;

            grpAttr.Enabled = false;
        }
        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            if(validateSaveProject())
            {
                _Project.NameSpace = txtProjectNameSpace.Text;
                if (_mDB.add(_Project) == null)
                    MessageBox.Show("Não foi possível salvar o projeto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Projeto salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if(validateAddClass())
            {
                ProjectClass projectClass = new ProjectClass();
                projectClass.Name = txtClass.Text;

                if (_Project.ProjectClasses.Any(x => x.Name.ToUpper().Trim() == projectClass.Name.ToUpper().Trim()))
                    MessageBox.Show("Classe já adicionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    _Project.ProjectClasses.Add(projectClass);

                dtgClass.DataSource = new List<ProjectClass>();
                dtgClass.DataSource = _Project.ProjectClasses;

                limparOperacaoAddClass();
            }  
        }
        private void dtgClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].Name == "Attributes")
            {
                string className = dtgClass.Rows[e.RowIndex].Cells["ClassName"].Value?.ToString();
                grpAttr.Enabled = true;
                grpAttr.Text = "Atributos da classe " + className;
                txtAttrName.Focus();
                _CurrenteClassName = className;
                dtgAttributes.DataSource = new List<ProjectAttribute>();
                var currentProjectClass = _Project.ProjectClasses.FirstOrDefault(x => x.Name == _CurrenteClassName);
                if (currentProjectClass != null)
                    dtgAttributes.DataSource = currentProjectClass.Attributes;
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "DeleteClass")
            {
                UtilsFormsGrid.deleteFromgrid<ProjectClass>(dtgClass, e.RowIndex);
                dtgClass.DataSource = new List<ProjectClass>();
            }
        }
        private void dtgAttributes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].Name == "DeleteAttr")
                UtilsFormsGrid.deleteFromgrid<ProjectAttribute>(dtgAttributes, e.RowIndex);
        }
        private void btnAddAttr_Click(object sender, EventArgs e)
        {
            if (validateAddAttr())
            {
                ProjectAttribute attr = new ProjectAttribute();
                attr.Name = txtAttrName.Text;
                attr.Nullable = (chkNullable.Checked ? (int)KDLogical.Yes : (int)KDLogical.No);

                if (!string.IsNullOrWhiteSpace(txtPrecision.Text) && !string.IsNullOrWhiteSpace(txtScale.Text))
                    attr.PrecisionScale = txtPrecision.Text + ";" + txtScale.Text;

                int value = 0;
                int.TryParse(cbxType.SelectedValue.ToString(), out value);
                attr.Type = value;

                var currentProjectClass = _Project.ProjectClasses.FirstOrDefault(x => x.Name == _CurrenteClassName);
                if(currentProjectClass != null)
                {
                    if (currentProjectClass.Attributes.Any(x => x.Name.ToUpper().Trim() == attr.Name.ToUpper().Trim()))
                        MessageBox.Show("Atributo já adicionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        currentProjectClass.Attributes.Add(attr);

                    dtgAttributes.DataSource = new List<ProjectAttribute>();
                    dtgAttributes.DataSource = currentProjectClass.Attributes;

                    limparOperacaoAddAttr();
                }
            }
        }
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(cbxType.SelectedValue.ToString(), out value);
            txtPrecision.Visible = txtScale.Visible = lblScale.Visible = lblPrecision.Visible =
            (value == (int)ProjectAttribute.KDType.Decimal || value == (int)ProjectAttribute.KDType.Double);
        }
        private bool validateSaveProject()
        {
            StringBuilder msg = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtProjectNameSpace.Text))
                msg.AppendLine("Digite um nome para o projeto.");

            if (!string.IsNullOrWhiteSpace(msg.ToString()))
                MessageBox.Show(msg.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return string.IsNullOrWhiteSpace(msg.ToString());
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

        private void limparTela()
        {
            txtProjectNameSpace.Clear();

            _Project = new Project();
            _CurrenteClassName = string.Empty;

            dtgAttributes.DataSource = new List<ProjectAttribute>();
            dtgClass.DataSource = new List<ProjectClass>();
            
            limparOperacaoAddClass();
            limparOperacaoAddAttr();
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

