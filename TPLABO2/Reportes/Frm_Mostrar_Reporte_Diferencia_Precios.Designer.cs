namespace TPLABO2.Reportes
{
    partial class Frm_Mostrar_Reporte_Diferencia_Precios
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
            this.sP_MOSTRAR_PRECIO_VENTATableAdapter = new TPLABO2.DataSetGeneralTableAdapters.SP_MOSTRAR_PRECIO_VENTATableAdapter();
            this.dataSetGeneral = new TPLABO2.DataSetGeneral();
            this.sPMOSTRARPRECIOVENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_MOSTRAR_PRECIO_VENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARPRECIOVENTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_MOSTRAR_PRECIO_VENTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.SP_MOSTRAR_PRECIO_VENTABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPLABO2.Reportes.ReporteDiferenciaPrecios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sP_MOSTRAR_PRECIO_VENTATableAdapter
            // 
            this.sP_MOSTRAR_PRECIO_VENTATableAdapter.ClearBeforeFill = true;
            // 
            // dataSetGeneral
            // 
            this.dataSetGeneral.DataSetName = "DataSetGeneral";
            this.dataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPMOSTRARPRECIOVENTABindingSource
            // 
            this.sPMOSTRARPRECIOVENTABindingSource.DataMember = "SP_MOSTRAR_PRECIO_VENTA";
            this.sPMOSTRARPRECIOVENTABindingSource.DataSource = this.dataSetGeneral;
            // 
            // SP_MOSTRAR_PRECIO_VENTABindingSource
            // 
            this.SP_MOSTRAR_PRECIO_VENTABindingSource.DataMember = "SP_MOSTRAR_PRECIO_VENTA";
            this.SP_MOSTRAR_PRECIO_VENTABindingSource.DataSource = this.dataSetGeneral;
            // 
            // Frm_Mostrar_Reporte_Diferencia_Precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Mostrar_Reporte_Diferencia_Precios";
            this.Text = "Frm_Mostrar_Reporte_Diferencia_Precios";
            this.Load += new System.EventHandler(this.Frm_Mostrar_Reporte_Diferencia_Precios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPMOSTRARPRECIOVENTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_MOSTRAR_PRECIO_VENTABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetGeneralTableAdapters.SP_MOSTRAR_PRECIO_VENTATableAdapter sP_MOSTRAR_PRECIO_VENTATableAdapter;
        private System.Windows.Forms.BindingSource sPMOSTRARPRECIOVENTABindingSource;
        private DataSetGeneral dataSetGeneral;
        private System.Windows.Forms.BindingSource SP_MOSTRAR_PRECIO_VENTABindingSource;
    }
}