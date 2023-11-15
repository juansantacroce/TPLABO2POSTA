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
    public partial class Frm_Mostrar_Reporte_Diferencia_Precios : Form
    {
        public int año { get; set; }
        public Frm_Mostrar_Reporte_Diferencia_Precios()
        {
            InitializeComponent();
        }

        private void Frm_Mostrar_Reporte_Diferencia_Precios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.SP_MOSTRAR_PRECIO_VENTA' Puede moverla o quitarla según sea necesario.
            this.sP_MOSTRAR_PRECIO_VENTATableAdapter.Fill(this.dataSetGeneral.SP_MOSTRAR_PRECIO_VENTA,año);

            this.reportViewer1.RefreshReport();
        }
    }
}
