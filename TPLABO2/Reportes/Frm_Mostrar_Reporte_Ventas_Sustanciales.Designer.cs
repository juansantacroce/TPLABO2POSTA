namespace TPLABO2.Reportes
{
    partial class Frm_Mostrar_Reporte_Ventas_Sustanciales
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_CONSULTAR_VENTAS_POR_CLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGeneral = new TPLABO2.DataSetGeneral();
            this.sP_CONSULTAR_VENTAS_POR_CLIENTETableAdapter = new TPLABO2.DataSetGeneralTableAdapters.SP_CONSULTAR_VENTAS_POR_CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_VENTAS_POR_CLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_CONSULTAR_VENTAS_POR_CLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPLABO2.Reportes.ReporteVentasSustanciales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_CONSULTAR_VENTAS_POR_CLIENTEBindingSource
            // 
            this.SP_CONSULTAR_VENTAS_POR_CLIENTEBindingSource.DataMember = "SP_CONSULTAR_VENTAS_POR_CLIENTE";
            this.SP_CONSULTAR_VENTAS_POR_CLIENTEBindingSource.DataSource = this.dataSetGeneral;
            // 
            // dataSetGeneral
            // 
            this.dataSetGeneral.DataSetName = "DataSetGeneral";
            this.dataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_CONSULTAR_VENTAS_POR_CLIENTETableAdapter
            // 
            this.sP_CONSULTAR_VENTAS_POR_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Mostrar_Reporte_Ventas_Sustanciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Mostrar_Reporte_Ventas_Sustanciales";
            this.Text = "Frm_Mostrar_Reporte_Ventas_Sustanciales";
            this.Load += new System.EventHandler(this.Frm_Mostrar_Reporte_Ventas_Sustanciales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_VENTAS_POR_CLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetGeneral dataSetGeneral;
        private DataSetGeneralTableAdapters.SP_CONSULTAR_VENTAS_POR_CLIENTETableAdapter sP_CONSULTAR_VENTAS_POR_CLIENTETableAdapter;
        private System.Windows.Forms.BindingSource SP_CONSULTAR_VENTAS_POR_CLIENTEBindingSource;
    }
}