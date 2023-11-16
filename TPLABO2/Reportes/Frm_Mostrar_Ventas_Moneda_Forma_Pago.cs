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
    public partial class Frm_Mostrar_Ventas_Moneda_Forma_Pago : Form
    {
        public string moneda { get; set; }
        public string pago { get; set; }
        public Frm_Mostrar_Ventas_Moneda_Forma_Pago()
        {
            InitializeComponent();
        }

        private void Frm_Mostrar_Ventas_Moneda_Forma_Pago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetGeneral.sp_consulta113885' Puede moverla o quitarla según sea necesario.
            this.sp_consulta113885TableAdapter.Fill(this.dataSetGeneral.sp_consulta113885,moneda,pago);

            this.reportViewer1.RefreshReport();
        }
    }
}
