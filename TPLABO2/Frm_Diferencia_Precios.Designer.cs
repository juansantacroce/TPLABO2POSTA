namespace TPLABO2
{
    partial class Frm_Diferencia_Precios
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
            this.lblDifPrecios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDifPrecios
            // 
            this.lblDifPrecios.AutoSize = true;
            this.lblDifPrecios.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifPrecios.Location = new System.Drawing.Point(53, 28);
            this.lblDifPrecios.Name = "lblDifPrecios";
            this.lblDifPrecios.Size = new System.Drawing.Size(364, 39);
            this.lblDifPrecios.TabIndex = 0;
            this.lblDifPrecios.Text = "Diferencia de Precios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Este informe mostrar las diferencias entre los precios de venta y de compra de aq" +
    "uellos \r\nproductos que se hayan comprado y vendido en el año ingresado por el us" +
    "uario. ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(92, 149);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 2;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(57, 152);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tomato;
            this.btnSalir.Location = new System.Drawing.Point(92, 222);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMostrarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarReporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarReporte.Location = new System.Drawing.Point(658, 222);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(108, 23);
            this.btnMostrarReporte.TabIndex = 13;
            this.btnMostrarReporte.Text = "Mostrar Reporte";
            this.btnMostrarReporte.UseVisualStyleBackColor = false;
            this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
            // 
            // Frm_Diferencia_Precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 270);
            this.Controls.Add(this.btnMostrarReporte);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDifPrecios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Diferencia_Precios";
            this.Text = "Frm_Diferencia_Precios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDifPrecios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarReporte;
    }
}