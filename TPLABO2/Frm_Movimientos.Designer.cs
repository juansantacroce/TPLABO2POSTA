namespace TPLABO2
{
    partial class Frm_Movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Movimientos));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDifPrecios = new System.Windows.Forms.Label();
            this.gbPrecios = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nPrecioMax = new System.Windows.Forms.NumericUpDown();
            this.nPrecioMin = new System.Windows.Forms.NumericUpDown();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecioMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecioMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDifPrecios
            // 
            this.lblDifPrecios.AutoSize = true;
            this.lblDifPrecios.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifPrecios.Location = new System.Drawing.Point(16, 54);
            this.lblDifPrecios.Name = "lblDifPrecios";
            this.lblDifPrecios.Size = new System.Drawing.Size(736, 39);
            this.lblDifPrecios.TabIndex = 4;
            this.lblDifPrecios.Text = "Informe de Movimientos de Compra y Venta";
            // 
            // gbPrecios
            // 
            this.gbPrecios.AutoSize = true;
            this.gbPrecios.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gbPrecios.Controls.Add(this.label3);
            this.gbPrecios.Controls.Add(this.label2);
            this.gbPrecios.Controls.Add(this.nPrecioMax);
            this.gbPrecios.Controls.Add(this.nPrecioMin);
            this.gbPrecios.Controls.Add(this.lblFechaDesde);
            this.gbPrecios.Controls.Add(this.lblFechaHasta);
            this.gbPrecios.Location = new System.Drawing.Point(217, 266);
            this.gbPrecios.Name = "gbPrecios";
            this.gbPrecios.Size = new System.Drawing.Size(353, 121);
            this.gbPrecios.TabIndex = 9;
            this.gbPrecios.TabStop = false;
            this.gbPrecios.Text = "Rango de Precios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.label3.Location = new System.Drawing.Point(180, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.label2.Location = new System.Drawing.Point(180, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "$";
            // 
            // nPrecioMax
            // 
            this.nPrecioMax.DecimalPlaces = 2;
            this.nPrecioMax.Location = new System.Drawing.Point(54, 82);
            this.nPrecioMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nPrecioMax.Name = "nPrecioMax";
            this.nPrecioMax.Size = new System.Drawing.Size(120, 20);
            this.nPrecioMax.TabIndex = 3;
            // 
            // nPrecioMin
            // 
            this.nPrecioMin.DecimalPlaces = 2;
            this.nPrecioMin.Location = new System.Drawing.Point(54, 32);
            this.nPrecioMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nPrecioMin.Name = "nPrecioMin";
            this.nPrecioMin.Size = new System.Drawing.Size(120, 20);
            this.nPrecioMin.TabIndex = 2;
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
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMostrarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarReporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarReporte.Location = new System.Drawing.Point(644, 415);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(108, 23);
            this.btnMostrarReporte.TabIndex = 13;
            this.btnMostrarReporte.Text = "Mostrar Reporte";
            this.btnMostrarReporte.UseVisualStyleBackColor = false;
            this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tomato;
            this.btnSalir.Location = new System.Drawing.Point(28, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Frm_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarReporte);
            this.Controls.Add(this.gbPrecios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDifPrecios);
            this.Name = "Frm_Movimientos";
            this.Text = "Frm_Movimientos";
            this.gbPrecios.ResumeLayout(false);
            this.gbPrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecioMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrecioMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDifPrecios;
        private System.Windows.Forms.GroupBox gbPrecios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nPrecioMax;
        private System.Windows.Forms.NumericUpDown nPrecioMin;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Button btnMostrarReporte;
        private System.Windows.Forms.Button btnSalir;
    }
}