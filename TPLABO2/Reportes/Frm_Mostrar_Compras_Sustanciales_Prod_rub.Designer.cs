namespace TPLABO2.Reportes
{
    partial class Frm_Mostrar_Compras_Sustanciales_Prod_rub
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
            this.sp_consulta113885_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGeneral = new TPLABO2.DataSetGeneral();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spconsulta1138852BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_consulta113885_2TableAdapter = new TPLABO2.DataSetGeneralTableAdapters.sp_consulta113885_2TableAdapter();
            this.sp_consulta113885BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spconsulta113885BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_consulta113885TableAdapter = new TPLABO2.DataSetGeneralTableAdapters.sp_consulta113885TableAdapter();
            this.spconsulta1138852BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sp_consulta113885_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spconsulta1138852BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_consulta113885BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spconsulta113885BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spconsulta1138852BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_consulta113885_2BindingSource
            // 
            this.sp_consulta113885_2BindingSource.DataMember = "sp_consulta113885_2";
            this.sp_consulta113885_2BindingSource.DataSource = this.dataSetGeneral;
            // 
            // dataSetGeneral
            // 
            this.dataSetGeneral.DataSetName = "DataSetGeneral";
            this.dataSetGeneral.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMateo2";
            reportDataSource1.Value = this.sp_consulta113885_2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPLABO2.Reportes.ReporteVentasSusProdRub.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // spconsulta1138852BindingSource
            // 
            this.spconsulta1138852BindingSource.DataMember = "sp_consulta113885_2";
            this.spconsulta1138852BindingSource.DataSource = this.dataSetGeneral;
            // 
            // sp_consulta113885_2TableAdapter
            // 
            this.sp_consulta113885_2TableAdapter.ClearBeforeFill = true;
            // 
            // sp_consulta113885BindingSource
            // 
            this.sp_consulta113885BindingSource.DataMember = "sp_consulta113885";
            this.sp_consulta113885BindingSource.DataSource = this.dataSetGeneral;
            // 
            // spconsulta113885BindingSource
            // 
            this.spconsulta113885BindingSource.DataMember = "sp_consulta113885";
            this.spconsulta113885BindingSource.DataSource = this.dataSetGeneral;
            // 
            // sp_consulta113885TableAdapter
            // 
            this.sp_consulta113885TableAdapter.ClearBeforeFill = true;
            // 
            // spconsulta1138852BindingSource1
            // 
            this.spconsulta1138852BindingSource1.DataMember = "sp_consulta113885_2";
            this.spconsulta1138852BindingSource1.DataSource = this.dataSetGeneral;
            // 
            // Frm_Mostrar_Compras_Sustanciales_Prod_rub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Mostrar_Compras_Sustanciales_Prod_rub";
            this.Text = "Frm_Mostrar_Compras_Sustanciales_Prod_rub";
            this.Load += new System.EventHandler(this.Frm_Mostrar_Compras_Sustanciales_Prod_rub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_consulta113885_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spconsulta1138852BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_consulta113885BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spconsulta113885BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spconsulta1138852BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_consulta113885_2BindingSource;
        private DataSetGeneral dataSetGeneral;
        private System.Windows.Forms.BindingSource spconsulta1138852BindingSource;
        private DataSetGeneralTableAdapters.sp_consulta113885_2TableAdapter sp_consulta113885_2TableAdapter;
        private System.Windows.Forms.BindingSource sp_consulta113885BindingSource;
        private System.Windows.Forms.BindingSource spconsulta113885BindingSource;
        private DataSetGeneralTableAdapters.sp_consulta113885TableAdapter sp_consulta113885TableAdapter;
        private System.Windows.Forms.BindingSource spconsulta1138852BindingSource1;
    }
}