using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCode.Framework
{
    public class GridControls
    {
        public GridControls()
        {
            this.DataGridViewTextBoxColumn = null;
        }
        public string Name { get; set; }
        public string HeaderText { get; set; }
        public int Width { get; set; }
        public bool Visible { get; set; }
        public DataGridViewTextBoxColumn DataGridViewTextBoxColumn { get; set; }
    }
}
