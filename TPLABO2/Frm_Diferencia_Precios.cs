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
    public partial class Frm_Diferencia_Precios : Form
    {
        public Frm_Diferencia_Precios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            Frm_Mostrar_Reporte_Diferencia_Precios mostrar = new Frm_Mostrar_Reporte_Diferencia_Precios();
            mostrar.año = Convert.ToInt32(txtAño.Text);
            mostrar.ShowDialog();
        }
    }
}
