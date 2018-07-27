using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyCode.Framework;
using EasyCode.Entities;

namespace EasyCode.Views
{
    public partial class FormProject : Form
    {
        private List<ProjectClass> _ProjectClasses = new List<ProjectClass>();
        private string _OpGridClass = "";
        public FormProject()
        {
            InitializeComponent();
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            MongoDBCore mDB = new MongoDBCore();

            Project project = new Project();
            project.NameSpace = txtProjectNameSpace.Text;
            mDB.create<Project>(project);
        }

        private void FormProject_Shown(object sender, EventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
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
        }

        private void dtgClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idClass = dtgClass.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
        }
    }
}
