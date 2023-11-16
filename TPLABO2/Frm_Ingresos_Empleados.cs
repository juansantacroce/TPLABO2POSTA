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
    public partial class Frm_Ingresos_Empleados : Form
    {
        public Frm_Ingresos_Empleados()
        {
            InitializeComponent();
        }

        private void Frm_Ingresos_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Mostrar_Reporte_Ingresos_Empleados frm = new Frm_Mostrar_Reporte_Ingresos_Empleados();
            frm.Cond = "MAS";
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Mostrar_Reporte_Ingresos_Empleados frm = new Frm_Mostrar_Reporte_Ingresos_Empleados();
            frm.Cond = "MENOS";
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
