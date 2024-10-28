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
    public partial class listaMovimientos : Form
    {
        public listaMovimientos()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            Refresh();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Refresh()
        {
            ComprobantesEmitidosTableAdapter adapter = new ComprobantesEmitidosTableAdapter();
            dsEmpresa.ComprobantesEmitidosDataTable dt = adapter.GetData();
            dgMovimientos.DataSource = dt;
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void listaMovimientos_Load(object sender, EventArgs e)
        {

        }
    }
}
