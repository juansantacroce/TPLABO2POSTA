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
    public partial class Frm_Mostrar_Compras_Sustanciales_Prod_rub : Form
    {
        public string almacen { get; set; }
        public string producto { get; set; }

        public Frm_Mostrar_Compras_Sustanciales_Prod_rub()
        {
            InitializeComponent();
        }

        private void Frm_Mostrar_Compras_Sustanciales_Prod_rub_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.sp_consulta113885_2' Puede moverla o quitarla según sea necesario.
            this.sp_consulta113885_2TableAdapter.Fill(this.dataSetGeneral.sp_consulta113885_2,almacen,producto);

            this.reportViewer1.RefreshReport();
        }
    }
}
