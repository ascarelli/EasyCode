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
    }
}
