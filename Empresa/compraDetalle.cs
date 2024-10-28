using Empresa.dsEmpresaTableAdapters;
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
    public partial class compraDetalle : Form
    {
        private int? codigo;

        public compraDetalle(int? codigo = null)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void btnComprar_Click_1(object sender, EventArgs e)
        {
            ProductoTableAdapter adapter = new ProductoTableAdapter();
            dsEmpresa.ProductoDataTable dt = adapter.GetDataByCodigo((int)codigo);
            dsEmpresa.ProductoRow row = (dsEmpresa.ProductoRow)dt.Rows[0];
            decimal montoViejo = row.PrecioCosto;
            int stockActual = (int)row.Stock;
            int stockNuevo = (int)txtCantidad.Value;
            int stockFinal = stockActual + stockNuevo;
            int stockMinimo = (int)row.StockMinimo;
            if (stockFinal < stockMinimo || stockNuevo <= 0)
            {
                MessageBox.Show("Cantidad no valida (Mayor que stock disponible o supera el stock minimo)", "ERROR", MessageBoxButtons.OK);
            }
            else
            {
                ComprobantesEmitidosTableAdapter adapterC = new ComprobantesEmitidosTableAdapter();
                adapter.updateStock(stockFinal, (int)codigo);
                decimal monto = stockNuevo * montoViejo;
                adapterC.addComprobante(1, DateTime.Now.ToString("yyyy-MM-dd"), UserSettings.id, 0, monto);
                this.Close();
            }
        }
    }
}
