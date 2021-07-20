using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;
using ClosedXML.Excel;
using System.Threading;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Diagnostics;
using Microsoft.Reporting.WebForms;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;
using Warning = Microsoft.Reporting.WinForms.Warning;

namespace SGI
{
    public partial class Relatorio : Form
    {
        string pathFile;
        public Relatorio()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'MyCompanyDataSet2.Calculo'. Você pode movê-la ou removê-la conforme necessário.
            this.CalculoTableAdapter.Fill(this.MyCompanyDataSet2.Calculo);

            this.reportRelatorio.RefreshReport();
        }

        private void reportRelatorio_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            
        }

        private void reportRelatorio_Load(object sender, EventArgs e)
        {
            var fieldInfo = typeof(Microsoft.Reporting.WinForms.RenderingExtension).GetField("m_isVisible", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            foreach (var extension in this.reportRelatorio.LocalReport.ListRenderingExtensions())
            {
                fieldInfo.SetValue(extension, true);
            }
        }

        protected void exportarExcel()
        {
         

            Thread td = new Thread(new ThreadStart(this.buscaDiretorio));
            td.SetApartmentState(ApartmentState.STA);
            td.IsBackground = true;
            td.Start();

            
        }

        [STAThread]
        void buscaDiretorio()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel -'xls' | *.xls";
            string sfdname = saveFileDialog1.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Path.GetFullPath(sfd.FileName);
            }
            else
            {
                return;
            }
            string pathFull = Path.GetFullPath(sfd.FileName);
            pathFull.Replace(@"\\",@"\");
            pathFile = pathFull;

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;


            byte[] bytes = reportRelatorio.LocalReport.Render(
               "Excel", null, out mimeType, out encoding,
                out extension,
               out streamids, out warnings);


            FileStream fs = new FileStream(pathFile, FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

            MessageBox.Show("Arquivo exportado com sucesso !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportarExcel();
        }
    }
}
