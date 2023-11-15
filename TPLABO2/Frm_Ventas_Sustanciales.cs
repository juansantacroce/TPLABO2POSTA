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
    public partial class Frm_Ventas_Sustanciales : Form
    {
        public Frm_Ventas_Sustanciales()
        {
            InitializeComponent();
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            Frm_Mostrar_Reporte_Ventas_Sustanciales mostrar = new Frm_Mostrar_Reporte_Ventas_Sustanciales();
            mostrar.fechaDesde = dtpFechaDesde.Value;
            mostrar.fechaHasta = dtoFechaHasta.Value;
            mostrar.monto = Convert.ToInt32(txtMonto.Text);
            mostrar.ShowDialog();
        }

        private void Frm_Ventas_Sustanciales_Load(object sender, EventArgs e)
        {

        }
    }
}
