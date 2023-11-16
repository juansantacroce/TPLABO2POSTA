﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPLABO2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ventasSustancialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ventas_Sustanciales frm_Ventas_Sustanciales = new Frm_Ventas_Sustanciales();
            frm_Ventas_Sustanciales.ShowDialog();
        }

        private void diferenciaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Diferencia_Precios frm_Diferencia = new Frm_Diferencia_Precios();
            frm_Diferencia.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Ingresos_Empleados frm  = new Frm_Ingresos_Empleados();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_Movimientos frm_Movimientos = new Frm_Movimientos();
            frm_Movimientos.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_productos_mayor_cant_comparado_rubro frmK = new Frm_productos_mayor_cant_comparado_rubro();
            frmK.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_Ventas_sustanciales_por_moneda_y_forma_pago frmK2 = new Frm_Ventas_sustanciales_por_moneda_y_forma_pago();
            frmK2.ShowDialog();
        }

        private void infoDeVentasPorFormaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Info_Ventas_Por_Forma_Pago  frmG = new Frm_Info_Ventas_Por_Forma_Pago();
            frmG.ShowDialog();
        }
    }
}
