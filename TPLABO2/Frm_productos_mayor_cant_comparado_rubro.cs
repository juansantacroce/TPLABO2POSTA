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
    public partial class Frm_productos_mayor_cant_comparado_rubro : Form
    {
        Helper helper;
        public Frm_productos_mayor_cant_comparado_rubro()
        {
            InitializeComponent();
            helper = new Helper();
        }

        private void cargarCombo()
        {
            DataTable tabla = helper.consultarBD("sp_deposito");
            cboDeposito.DataSource = tabla;
            cboDeposito.DisplayMember = tabla.Columns[1].ColumnName;
            cboDeposito.ValueMember = tabla.Columns[0].ColumnName;
            cboDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarCombo2()
        {
            DataTable tabla = helper.consultarBD("sp_super_rubro");
            cboTipoProd.DataSource = tabla;
            cboTipoProd.DisplayMember = tabla.Columns[1].ColumnName;
            cboTipoProd.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoProd.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Frm_productos_mayor_cant_comparado_rubro_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarCombo2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            Frm_Mostrar_Compras_Sustanciales_Prod_rub mostrar = new Frm_Mostrar_Compras_Sustanciales_Prod_rub();
            mostrar.almacen = cboDeposito.Text;
            mostrar.producto = cboTipoProd.Text;
            mostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
