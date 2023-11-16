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
    public partial class Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago : Form
    {
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        public Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago()
        {
            InitializeComponent();
        }

        private void Frm__Mostrar_Reporte_Info_Ventas_Forma_Pago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.SP_INFORMACION_VENTAS_POR_FORMA_PAGO' Puede moverla o quitarla según sea necesario.
            this.sP_INFORMACION_VENTAS_POR_FORMA_PAGOTableAdapter.Fill(this.dataSetGeneral.SP_INFORMACION_VENTAS_POR_FORMA_PAGO, fechaDesde, fechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
