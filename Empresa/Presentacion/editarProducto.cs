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
    public partial class editarProducto : Form
    {
        private int? codigo;
        public editarProducto(int? codigo = null)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void editarProducto_Load(object sender, EventArgs e)
        {
            ProductoTableAdapter adapter = new ProductoTableAdapter();
            dsEmpresa.ProductoDataTable dt = adapter.GetDataByCodigo((int)codigo);
            dsEmpresa.ProductoRow row = (dsEmpresa.ProductoRow)dt.Rows[0];
            txtStock.Value = (int)row.StockMinimo;
            txtPrecio.Value = row.PrecioCosto;
            txtPorcentaje.Value = row.PorcentajeGanancia;
            lblProducto.Text = row.NombreProducto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProductoTableAdapter adapter = new ProductoTableAdapter();
            dsEmpresa.ProductoDataTable dt = adapter.GetDataByCodigo((int)codigo);
            int stockMinimo = (int)txtStock.Value;
            decimal precioCosto = (decimal)txtPrecio.Value;
            int porcentajeGanancia = (int)txtPorcentaje.Value;
            if (stockMinimo < 0 || precioCosto <= 0 || porcentajeGanancia < 0)
            {
                MessageBox.Show("Cantidades ingresadas no validas", "Error", MessageBoxButtons.OK);
            }
            else
            {
                adapter.UpdateProducto(precioCosto, stockMinimo, porcentajeGanancia, (int)codigo);
                this.Close();
            }
        }
    }
}
