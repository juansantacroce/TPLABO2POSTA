using System;
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
    }
}
