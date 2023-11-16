using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPLABO2.Reportes
{
    public partial class Frm_Mostrar_Movimientos : Form
    {
        private decimal precioMin;
        private decimal precioMax;

        public decimal PrecioMax
        {
            get { return precioMax; }
            set { precioMax = value; }
        }


        public decimal PrecioMin
        {
            get { return precioMin; }
            set { precioMin = value; }
        }

        public Frm_Mostrar_Movimientos()
        {
            InitializeComponent();
        }

        private void Frm_Mostrar_Movimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.SP_CONSULTAR_MOVIMIENTOS' Puede moverla o quitarla según sea necesario.
            this.sP_CONSULTAR_MOVIMIENTOSTableAdapter.Fill(this.dataSetGeneral.SP_CONSULTAR_MOVIMIENTOS,precioMin,PrecioMax);

            this.reportViewer1.RefreshReport();
        }
    }
}
