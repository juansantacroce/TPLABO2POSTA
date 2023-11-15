namespace TPLABO2
{
    partial class Frm_Ventas_Sustanciales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ventas_Sustanciales));
            this.lblVentasSus = new System.Windows.Forms.Label();
            this.lblCuerpo = new System.Windows.Forms.Label();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.dtoFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.gbMonto = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.gbFechas.SuspendLayout();
            this.gbMonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVentasSus
            // 
            this.lblVentasSus.AutoSize = true;
            this.lblVentasSus.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasSus.Location = new System.Drawing.Point(43, 29);
            this.lblVentasSus.Name = "lblVentasSus";
            this.lblVentasSus.Size = new System.Drawing.Size(335, 39);
            this.lblVentasSus.TabIndex = 6;
            this.lblVentasSus.Text = "Ventas Sustanciales";
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuerpo.Location = new System.Drawing.Point(47, 81);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(706, 51);
            this.lblCuerpo.TabIndex = 7;
            this.lblCuerpo.Text = resources.GetString("lblCuerpo.Text");
            this.lblCuerpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbFechas
            // 
            this.gbFechas.AutoSize = true;
            this.gbFechas.Controls.Add(this.dtoFechaHasta);
            this.gbFechas.Controls.Add(this.dtpFechaDesde);
            this.gbFechas.Controls.Add(this.lblFechaDesde);
            this.gbFechas.Controls.Add(this.lblFechaHasta);
            this.gbFechas.Location = new System.Drawing.Point(50, 164);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(353, 120);
            this.gbFechas.TabIndex = 8;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Fechas";
            // 
            // dtoFechaHasta
            // 
            this.dtoFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtoFechaHasta.Location = new System.Drawing.Point(52, 81);
            this.dtoFechaHasta.Name = "dtoFechaHasta";
            this.dtoFechaHasta.Size = new System.Drawing.Size(109, 20);
            this.dtoFechaHasta.TabIndex = 3;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(53, 29);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaDesde.TabIndex = 2;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(6, 32);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(6, 84);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFechaHasta.TabIndex = 1;
            this.lblFechaHasta.Text = "Hasta:";
            // 
            // gbMonto
            // 
            this.gbMonto.AutoSize = true;
            this.gbMonto.Controls.Add(this.txtMonto);
            this.gbMonto.Controls.Add(this.label3);
            this.gbMonto.Location = new System.Drawing.Point(415, 164);
            this.gbMonto.Name = "gbMonto";
            this.gbMonto.Size = new System.Drawing.Size(338, 120);
            this.gbMonto.TabIndex = 9;
            this.gbMonto.TabStop = false;
            this.gbMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(99, 29);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(108, 20);
            this.txtMonto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto a superar:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tomato;
            this.btnSalir.Location = new System.Drawing.Point(50, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(349, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMostrarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarReporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarReporte.Location = new System.Drawing.Point(645, 370);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(108, 23);
            this.btnMostrarReporte.TabIndex = 12;
            this.btnMostrarReporte.Text = "Mostrar Reporte";
            this.btnMostrarReporte.UseVisualStyleBackColor = false;
            this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
            // 
            // Frm_Ventas_Sustanciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarReporte);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbMonto);
            this.Controls.Add(this.gbFechas);
            this.Controls.Add(this.lblCuerpo);
            this.Controls.Add(this.lblVentasSus);
            this.Name = "Frm_Ventas_Sustanciales";
            this.Text = "Frm_Ventas_Sustanciales";
            this.Load += new System.EventHandler(this.Frm_Ventas_Sustanciales_Load);
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            this.gbMonto.ResumeLayout(false);
            this.gbMonto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentasSus;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.DateTimePicker dtoFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.GroupBox gbMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnMostrarReporte;
    }
}