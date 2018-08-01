using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace EasyCode.Framework
{
    public class UtilsForms
    {
        public void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                    this.CheckAllChildNodes(node, nodeChecked);
            }
        }

        public void CheckAllRootNodes(TreeNode treeNode, bool nodeChecked)
        {
            if(treeNode.Parent != null)
            {
                treeNode.Parent.Checked = nodeChecked;
                this.CheckAllRootNodes(treeNode.Parent, nodeChecked);
            }          
        }


        public bool HasCheckedChildNodes(TreeNode node)
        {
            if (node.Nodes.Count == 0)
                return false;

            foreach (TreeNode childNode in node.Nodes)
            {
                if (childNode.Checked)
                    return true;

                if (HasCheckedChildNodes(childNode))
                    return true;
            }
            return false;
        }
    }  

    public static class UtilsFormsGrid
    {

        public static void deleteFromgrid<T>(DataGridView prDtg, int prIndex)
        {
            var lst = prDtg.DataSource as List<T>;
            if (lst != null && lst.Any())
            {
                lst.RemoveAt(prIndex);
                prDtg.DataSource = new List<T>();
                prDtg.DataSource = lst;
            }
        }
    }

    public class ComboBoxClass
    {
        public ComboBoxClass()
        {

        }
        public string Id { get; set; }
        public string Value { get; set; }
    }
}
