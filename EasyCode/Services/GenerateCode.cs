using EasyCode.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCode.Services
{
    public class GenerateCode
    {
        //private GeneratorView aGeneratorView;
        private string aLocalModelo = @"C:\workspace";
        private System.Data.Odbc.OdbcConnection aConn = new System.Data.Odbc.OdbcConnection();
        private System.Data.DataTable aClassesDatabase = new System.Data.DataTable();
        private System.Data.DataTable aAtributosDatabase = new System.Data.DataTable();
        private BindingSource aClassesDataSource;
        private BindingSource aAtributosDataSource;
        private string aClasseSelected;
        private string aNamespace;
        private string aSchema;
        private List<ProjectAttribute> _Attrs;

        public GenerateCode()
        {

        }

        public void generateCode()
        {
            //Cursor.Current = Cursors.WaitCursor;
            //foreach (DataGridViewRow lDataGridViewRow in aGeneratorView.dtgClasses.SelectedRows)
            //{
            //    aClasseSelected = lDataGridViewRow.Cells["Class"].Value.ToString();
            //    aNamespace = aGeneratorView.edtNamespace.Text;
            //    aSchema = aGeneratorView.edtSchema.Text;
            //    _Attrs = new List<Atributo>();

            //    //  Atributos da Herança
            //    obterHeranca(_Attrs);

            //    //  Associacoes
            //    obterAssociacoes(_Attrs);

            //    //  Atributos da Classe
            //    foreach (DataRow oRow in aAtributosDatabase.Rows)
            //    {
            //        Atributo lAtributo = MIM_DescretizarEA(oRow["type"].ToString());
            //        lAtributo.Nome = oRow["Name"].ToString();

            //        _Attrs.Add(lAtributo);
            //    }

            //    //Scripts
            //    GerarScriptsBDTaskActivity lGerarScriptsBDTaskActivity = new GerarScriptsBDTaskActivity();
            //    lGerarScriptsBDTaskActivity.execute(aSchema, aClasseSelected, _Attrs);

            //    //Dominio
            //    GerarDominio lGerarAdaptador = new GerarDominio();
            //    lGerarAdaptador.execute(aNamespace, aClasseSelected, "", _Attrs);

            //    //Infra
            //    GerarInfra lGerarInfra = new GerarInfra();
            //    lGerarInfra.execute(aNamespace, aClasseSelected, _Attrs, aSchema);

            //    //Application
            //    GerarApplication lGerarApplication = new GerarApplication();
            //    lGerarApplication.execute(aNamespace, aClasseSelected, _Attrs);

            //    //Presentation
            //    GerarPresentation lGerarPresentation = new GerarPresentation();
            //    lGerarPresentation.execute(aNamespace, aClasseSelected, _Attrs);
        }

        //Cursor.Current = Cursors.Default;
        //MessageBox.Show("Classe(s) gerada(s) com sucesso.\nCaminho: c:\\plannerapps\\gerador\\DDD", "Coder", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
