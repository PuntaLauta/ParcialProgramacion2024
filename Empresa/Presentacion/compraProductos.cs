using Empresa.Datos;
using Empresa.Datos.dsEmpresaTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class compraProductos : Form
    {
        public compraProductos()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            Refresh();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Refresh()
        {
            ProductoTableAdapter adapter = new ProductoTableAdapter();
            dsEmpresa.ProductoDataTable dt = adapter.GetData();
            dgProductos.DataSource = dt;
        }

        private int getCodigo()
        {
            return int.Parse(dgProductos.Rows[dgProductos.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int? codigo = getCodigo();
            compraDetalle compraDetalle = new compraDetalle(codigo);
            compraDetalle.ShowDialog();
            Refresh();
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            int? codigo = getCodigo();
            ventaProducto ventaProducto = new ventaProducto(codigo);
            ventaProducto.ShowDialog();
            Refresh();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? codigo = getCodigo();
            editarProducto editarProducto = new editarProducto(codigo);
            editarProducto.ShowDialog();
            Refresh();
        }
    }
}
