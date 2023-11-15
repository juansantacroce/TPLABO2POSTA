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
    public partial class Frm_Mostrar_Reporte_Ventas_Sustanciales : Form
    {
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        public int monto { get; set; }
        public Frm_Mostrar_Reporte_Ventas_Sustanciales()
        {
            InitializeComponent();
        }
 

        private void Frm_Mostrar_Reporte_Ventas_Sustanciales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.SP_CONSULTAR_VENTAS_POR_CLIENTE' Puede moverla o quitarla según sea necesario.
            this.sP_CONSULTAR_VENTAS_POR_CLIENTETableAdapter.Fill(this.dataSetGeneral.SP_CONSULTAR_VENTAS_POR_CLIENTE,fechaDesde,fechaHasta,monto);

            this.reportViewer1.RefreshReport();
        }
    }
}
