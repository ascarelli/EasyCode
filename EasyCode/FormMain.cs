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
        public formProject()
        {
            InitializeComponent();
            
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormSolution();
            frm.Show();
        }
    }
}

