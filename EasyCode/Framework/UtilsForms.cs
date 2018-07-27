using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System;

namespace EasyCode.Framework
{
    public static class UtilsForms
    {
   
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
