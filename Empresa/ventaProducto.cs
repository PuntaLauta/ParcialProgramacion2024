using Empresa.dsEmpresaTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class ventaProducto : Form
    {
        private int? codigo;
        public ventaProducto(int? codigo = null)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            ProductoTableAdapter adapter = new ProductoTableAdapter();
            dsEmpresa.ProductoDataTable dt = adapter.GetDataByCodigo((int)codigo);
            dsEmpresa.ProductoRow row = (dsEmpresa.ProductoRow)dt.Rows[0];
            ClientesTableAdapter adapterC = new ClientesTableAdapter();
            dsEmpresa.ClientesDataTable dtC2 = adapterC.GetClienteByCod((int)cbClientes.SelectedValue);
            dsEmpresa.ClientesRow row2 = (dsEmpresa.ClientesRow)dtC2.Rows[0];
            int stockActual = (int)row.Stock;
            decimal ganancia = row.PorcentajeGanancia;
            decimal descuento = row2.Descuento;
            decimal montoViejo = row.PrecioCosto;
            int stockNuevo = (int)txtCantidad.Value;
            int stockFinal = stockActual - stockNuevo;
            int stockMinimo = (int)row.StockMinimo;
            if (stockFinal < stockMinimo || stockNuevo <= 0 || stockNuevo > stockActual)
            {
                MessageBox.Show("Cantidad no valida (Mayor que stock disponible o supera el stock minimo)", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                ComprobantesEmitidosTableAdapter adapterComp = new ComprobantesEmitidosTableAdapter();
                adapter.updateStock(stockFinal, (int)codigo);
                decimal monto = (stockNuevo * montoViejo * (ganancia/100 + 1)) * (1 - (descuento/100));
                adapterComp.addComprobante(2, DateTime.Now.ToString("yyyy-MM-dd"), UserSettings.id, (int)cbClientes.SelectedValue, monto);
                this.Close();
            }
        }

        private void ventaProducto_Load(object sender, EventArgs e)
        {
            ProductoTableAdapter adapter = new ProductoTableAdapter();
            dsEmpresa.ProductoDataTable dt = adapter.GetDataByCodigo((int)codigo);
            dsEmpresa.ProductoRow row = (dsEmpresa.ProductoRow)dt.Rows[0];
            ClientesTableAdapter adapterC = new ClientesTableAdapter();
            dsEmpresa.ClientesDataTable dtC = adapterC.GetAll();
            cbClientes.DataSource = dtC;
            cbClientes.DisplayMember = "nombrecompleto";
            cbClientes.ValueMember = "codigo";
            dsEmpresa.ClientesDataTable dtC2 = adapterC.GetClienteByCod((int)cbClientes.SelectedValue);
            dsEmpresa.ClientesRow row2 = (dsEmpresa.ClientesRow)dtC2.Rows[0];
            String mensajeDescuento = "El descuento de este cliente es: " + row2.Descuento.ToString() + "%";
            lblDescuento.Text = mensajeDescuento;
            cbClientes.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem != null)
            {
                ClientesTableAdapter adapterC = new ClientesTableAdapter();
                dsEmpresa.ClientesDataTable dtC = adapterC.GetClienteByCod((int)comboBox.SelectedValue);
                dsEmpresa.ClientesRow row = (dsEmpresa.ClientesRow)dtC.Rows[0];
                String mensajeDescuento = "El descuento de este cliente es: " + row.Descuento.ToString() + "%";
                lblDescuento.Text = mensajeDescuento;
            }
        }



    }
}
