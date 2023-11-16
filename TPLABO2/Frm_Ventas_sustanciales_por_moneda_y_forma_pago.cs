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
    public partial class Frm_Ventas_sustanciales_por_moneda_y_forma_pago : Form
    {
        Helper helper;
        public Frm_Ventas_sustanciales_por_moneda_y_forma_pago()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void cargarCombo()
        {
            DataTable tabla = helper.consultarBD("sp_Monedas");
            cboMoneda.DataSource = tabla;
            cboMoneda.DisplayMember = tabla.Columns[1].ColumnName;
            cboMoneda.ValueMember = tabla.Columns[0].ColumnName;
            cboMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarCombo2()
        {
            DataTable tabla = helper.consultarBD("sp_Forma_Pago");
            cboFormaPago.DataSource = tabla;
            cboFormaPago.DisplayMember = tabla.Columns[1].ColumnName;
            cboFormaPago.ValueMember = tabla.Columns[0].ColumnName;
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Frm_Ventas_sustanciales_por_moneda_y_forma_pago_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarCombo2();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            Frm_Mostrar_Ventas_Moneda_Forma_Pago mostrar = new Frm_Mostrar_Ventas_Moneda_Forma_Pago();
            mostrar.moneda = cboMoneda.Text;
            mostrar.pago = cboFormaPago.Text;
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
