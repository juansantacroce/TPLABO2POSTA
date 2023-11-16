using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPLABO2.Reportes;

namespace TPLABO2
{
    public partial class Frm_Info_Ventas_Por_Forma_Pago : Form
    {
        public Frm_Info_Ventas_Por_Forma_Pago()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago mostrar = new Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago();
            mostrar.fechaDesde = dtpDesde.Value;
            mostrar.fechaHasta = dtpHasta.Value;
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
