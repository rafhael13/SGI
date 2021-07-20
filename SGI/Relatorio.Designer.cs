namespace SGI
{
    partial class Relatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CalculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyCompanyDataSet2 = new SGI.MyCompanyDataSet2();
            this.CalculoTableAdapter = new SGI.MyCompanyDataSet2TableAdapters.CalculoTableAdapter();
            this.reportRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CalculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculoBindingSource
            // 
            this.CalculoBindingSource.DataMember = "Calculo";
            this.CalculoBindingSource.DataSource = this.MyCompanyDataSet2;
            // 
            // MyCompanyDataSet2
            // 
            this.MyCompanyDataSet2.DataSetName = "MyCompanyDataSet2";
            this.MyCompanyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CalculoTableAdapter
            // 
            this.CalculoTableAdapter.ClearBeforeFill = true;
            // 
            // reportRelatorio
            // 
            this.reportRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportRelatorio.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CalculoBindingSource;
            this.reportRelatorio.LocalReport.DataSources.Add(reportDataSource1);
            this.reportRelatorio.LocalReport.ReportEmbeddedResource = "SGI.ReportRelatorio.rdlc";
            this.reportRelatorio.Location = new System.Drawing.Point(-1, 1);
            this.reportRelatorio.Name = "reportRelatorio";
            this.reportRelatorio.ServerReport.BearerToken = null;
            this.reportRelatorio.ShowExportButton = false;
            this.reportRelatorio.ShowToolBar = false;
            this.reportRelatorio.Size = new System.Drawing.Size(1141, 606);
            this.reportRelatorio.TabIndex = 2;
            this.reportRelatorio.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportRelatorio_RenderingComplete);
            this.reportRelatorio.Load += new System.EventHandler(this.reportRelatorio_Load);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1140, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportRelatorio);
            this.Name = "Relatorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyCompanyDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource CalculoBindingSource;
        private MyCompanyDataSet2 MyCompanyDataSet2;
        private MyCompanyDataSet2TableAdapters.CalculoTableAdapter CalculoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportRelatorio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}