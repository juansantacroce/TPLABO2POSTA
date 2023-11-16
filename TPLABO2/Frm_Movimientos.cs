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
    public partial class Frm_Movimientos : Form
    {
        public Frm_Movimientos()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Frm_Mostrar_Movimientos frmMov = new Frm_Mostrar_Movimientos();
            frmMov.PrecioMin = nPrecioMin.Value;
            frmMov.PrecioMax = nPrecioMax.Value;
            frmMov.ShowDialog();
        }
    }
}
