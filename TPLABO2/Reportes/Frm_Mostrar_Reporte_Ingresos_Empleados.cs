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
    public partial class Frm_Mostrar_Reporte_Ingresos_Empleados : Form
    {
        private string cond;

        public string Cond
        {
            get { return cond; }
            set { cond = value; }
        }

        public Frm_Mostrar_Reporte_Ingresos_Empleados()
        {
            InitializeComponent();
        }

        private void Frm_Mostrar_Reporte_Ingresos_Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.SP_OBTENER_EMPLEADOS_INGRESOS' Puede moverla o quitarla según sea necesario.
            this.sP_OBTENER_EMPLEADOS_INGRESOSTableAdapter.Fill(this.dataSetGeneral.SP_OBTENER_EMPLEADOS_INGRESOS,Cond);

            this.reportViewer1.RefreshReport();
        }
    }
}
