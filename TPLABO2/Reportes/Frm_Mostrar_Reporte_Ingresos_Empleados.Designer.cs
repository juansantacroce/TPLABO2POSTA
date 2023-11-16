namespace TPLABO2.Reportes
{
    partial class Frm_Mostrar_Reporte_Ingresos_Empleados
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
            this.dataSetGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPOBTENEREMPLEADOSINGRESOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_OBTENER_EMPLEADOS_INGRESOSTableAdapter = new TPLABO2.DataSetGeneralTableAdapters.SP_OBTENER_EMPLEADOS_INGRESOSTableAdapter();
            this.SP_OBTENER_EMPLEADOS_INGRESOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOBTENEREMPLEADOSINGRESOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_OBTENER_EMPLEADOS_INGRESOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetJere1";
            reportDataSource1.Value = this.SP_OBTENER_EMPLEADOS_INGRESOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TPLABO2.Reportes.ReporteIngresosEmpleados.rdlc";
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
            // dataSetGeneralBindingSource
            // 
            this.dataSetGeneralBindingSource.DataSource = this.dataSetGeneral;
            this.dataSetGeneralBindingSource.Position = 0;
            // 
            // sPOBTENEREMPLEADOSINGRESOSBindingSource
            // 
            this.sPOBTENEREMPLEADOSINGRESOSBindingSource.DataMember = "SP_OBTENER_EMPLEADOS_INGRESOS";
            this.sPOBTENEREMPLEADOSINGRESOSBindingSource.DataSource = this.dataSetGeneral;
            // 
            // sP_OBTENER_EMPLEADOS_INGRESOSTableAdapter
            // 
            this.sP_OBTENER_EMPLEADOS_INGRESOSTableAdapter.ClearBeforeFill = true;
            // 
            // SP_OBTENER_EMPLEADOS_INGRESOSBindingSource
            // 
            this.SP_OBTENER_EMPLEADOS_INGRESOSBindingSource.DataMember = "SP_OBTENER_EMPLEADOS_INGRESOS";
            this.SP_OBTENER_EMPLEADOS_INGRESOSBindingSource.DataSource = this.dataSetGeneral;
            // 
            // Frm_Mostrar_Reporte_Ingresos_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Mostrar_Reporte_Ingresos_Empleados";
            this.Text = "Frm_Mostrar_Reporte_Ingresos_Empleados";
            this.Load += new System.EventHandler(this.Frm_Mostrar_Reporte_Ingresos_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPOBTENEREMPLEADOSINGRESOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_OBTENER_EMPLEADOS_INGRESOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetGeneralBindingSource;
        private DataSetGeneral dataSetGeneral;
        private System.Windows.Forms.BindingSource SP_OBTENER_EMPLEADOS_INGRESOSBindingSource;
        private System.Windows.Forms.BindingSource sPOBTENEREMPLEADOSINGRESOSBindingSource;
        private DataSetGeneralTableAdapters.SP_OBTENER_EMPLEADOS_INGRESOSTableAdapter sP_OBTENER_EMPLEADOS_INGRESOSTableAdapter;
    }
}