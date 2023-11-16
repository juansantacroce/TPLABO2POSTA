namespace TPLABO2.Reportes
{
    partial class Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago
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
            this.dataSetGeneral = new TPLABO2.DataSetGeneral();
            this.sPINFORMACIONVENTASPORFORMAPAGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_INFORMACION_VENTAS_POR_FORMA_PAGOTableAdapter = new TPLABO2.DataSetGeneralTableAdapters.SP_INFORMACION_VENTAS_POR_FORMA_PAGOTableAdapter();
            this.SP_INFORMACION_VENTAS_POR_FORMA_PAGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPINFORMACIONVENTASPORFORMAPAGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_INFORMACION_VENTAS_POR_FORMA_PAGOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetGaston";
            reportDataSource1.Value = this.SP_INFORMACION_VENTAS_POR_FORMA_PAGOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPLABO2.Reportes.ReporteInfoVentasPorFormaPago.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetGeneral
            // 
            this.dataSetGeneral.DataSetName = "DataSetGeneral";
            this.dataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPINFORMACIONVENTASPORFORMAPAGOBindingSource
            // 
            this.sPINFORMACIONVENTASPORFORMAPAGOBindingSource.DataMember = "SP_INFORMACION_VENTAS_POR_FORMA_PAGO";
            this.sPINFORMACIONVENTASPORFORMAPAGOBindingSource.DataSource = this.dataSetGeneral;
            // 
            // sP_INFORMACION_VENTAS_POR_FORMA_PAGOTableAdapter
            // 
            this.sP_INFORMACION_VENTAS_POR_FORMA_PAGOTableAdapter.ClearBeforeFill = true;
            // 
            // SP_INFORMACION_VENTAS_POR_FORMA_PAGOBindingSource
            // 
            this.SP_INFORMACION_VENTAS_POR_FORMA_PAGOBindingSource.DataMember = "SP_INFORMACION_VENTAS_POR_FORMA_PAGO";
            this.SP_INFORMACION_VENTAS_POR_FORMA_PAGOBindingSource.DataSource = this.dataSetGeneral;
            // 
            // Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago";
            this.Text = "Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago";
            this.Load += new System.EventHandler(this.Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPINFORMACIONVENTASPORFORMAPAGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_INFORMACION_VENTAS_POR_FORMA_PAGOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_INFORMACION_VENTAS_POR_FORMA_PAGOBindingSource;
        private DataSetGeneral dataSetGeneral;
        private System.Windows.Forms.BindingSource sPINFORMACIONVENTASPORFORMAPAGOBindingSource;
        private DataSetGeneralTableAdapters.SP_INFORMACION_VENTAS_POR_FORMA_PAGOTableAdapter sP_INFORMACION_VENTAS_POR_FORMA_PAGOTableAdapter;
    }
}