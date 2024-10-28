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
    public partial class Menu : Form
    {
        private int? rol;
        public Menu(int? rol = null)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.rol = UserSettings.rol;
            switch (this.rol)
            {
                case 1:
                    break;

                case 2:
                    btnEmpleados.Enabled = false;
                    break;

                case 3:
                    btnEmpleados.Enabled = false;
                    btnMovimientos.Enabled = false;
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abmEmpleados abmEmpleados = new abmEmpleados();
            abmEmpleados.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            compraProductos compraProductos = new compraProductos();
            compraProductos.Show();
            this.Hide();
        }

        private void btnVentaProducto_Click(object sender, EventArgs e)
        {
            compraProductos compraProductos = new compraProductos();
            compraProductos.Show();
            this.Hide();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            listaMovimientos listaMovimientos = new listaMovimientos();
            listaMovimientos.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            UserSettings.Logout();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido, " + UserSettings.nombre;
        }
    }
}
