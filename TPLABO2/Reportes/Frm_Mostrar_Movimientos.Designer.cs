namespace TPLABO2.Reportes
{
    partial class Frm_Mostrar_Movimientos
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
            this.sPCONSULTARMOVIMIENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CONSULTAR_MOVIMIENTOSTableAdapter = new TPLABO2.DataSetGeneralTableAdapters.SP_CONSULTAR_MOVIMIENTOSTableAdapter();
            this.SP_CONSULTAR_MOVIMIENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARMOVIMIENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_MOVIMIENTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetJere2";
            reportDataSource1.Value = this.SP_CONSULTAR_MOVIMIENTOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPLABO2.Reportes.ReporteMovimientos.rdlc";
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
            // sPCONSULTARMOVIMIENTOSBindingSource
            // 
            this.sPCONSULTARMOVIMIENTOSBindingSource.DataMember = "SP_CONSULTAR_MOVIMIENTOS";
            this.sPCONSULTARMOVIMIENTOSBindingSource.DataSource = this.dataSetGeneral;
            // 
            // sP_CONSULTAR_MOVIMIENTOSTableAdapter
            // 
            this.sP_CONSULTAR_MOVIMIENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // SP_CONSULTAR_MOVIMIENTOSBindingSource
            // 
            this.SP_CONSULTAR_MOVIMIENTOSBindingSource.DataMember = "SP_CONSULTAR_MOVIMIENTOS";
            this.SP_CONSULTAR_MOVIMIENTOSBindingSource.DataSource = this.dataSetGeneral;
            // 
            // Frm_Mostrar_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Mostrar_Movimientos";
            this.Text = "Frm_Mostrar_Movimientos";
            this.Load += new System.EventHandler(this.Frm_Mostrar_Movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCONSULTARMOVIMIENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSULTAR_MOVIMIENTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPCONSULTARMOVIMIENTOSBindingSource;
        private DataSetGeneral dataSetGeneral;
        private DataSetGeneralTableAdapters.SP_CONSULTAR_MOVIMIENTOSTableAdapter sP_CONSULTAR_MOVIMIENTOSTableAdapter;
        private System.Windows.Forms.BindingSource SP_CONSULTAR_MOVIMIENTOSBindingSource;
    }
}