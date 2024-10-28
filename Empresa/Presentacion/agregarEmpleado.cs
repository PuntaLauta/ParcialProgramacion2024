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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Empresa
{
    public partial class agregarEmpleado : Form
    {
        private int? dni;
        public agregarEmpleado(int? dni = null)
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.dni = dni;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void agregarEmpleado_Load(object sender, EventArgs e)
        {
            if (dni != null)
            {
                EmpleadosTableAdapter adapter = new EmpleadosTableAdapter();
                dsEmpresa.EmpleadosDataTable dt = adapter.GetDataByDni((int)dni);
                dsEmpresa.EmpleadosRow row = (dsEmpresa.EmpleadosRow)dt.Rows[0];
                txtDocumento.Value = row.DNI;
                txtDocumento.Enabled = false;
                txtNombre.Text = row.Nombre;
                txtApellido.Text = row.Apellido;
                txtTelefono.Text = row.Telefono;
                dtFechaNac.Value = row.FechaNac;
                txtUsuario.Text = row.Usuario;
                txtPassword.Text = row.Clave;
                cbRol.SelectedIndex = row.Rol - 1;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dniNuevo = (int)txtDocumento.Value;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String telefono = txtTelefono.Text;
            DateTime fechaNac = dtFechaNac.Value.Date;
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;
            int rol;
            String rolNombre = cbRol.Text;
            switch (rolNombre)
            {
                case "Admin":
                    rol = 1;
                    break;

                case "Auditor":
                    rol = 2;
                    break;

                case "Operador":
                    rol = 3;
                    break;

                default:
                    rol = 3;
                    break;
            }
            EmpleadosTableAdapter adapter = new EmpleadosTableAdapter();
            if (dni == null)
            {
                adapter.add(dniNuevo, nombre, apellido, telefono, fechaNac.ToString(), usuario, password, rol);
            }
            else
            {
                adapter.UpdateEmpleado(dniNuevo, nombre, telefono, apellido, fechaNac.ToString(), usuario, password, rol);
            }
            abmEmpleados abmEmpleados = new abmEmpleados();
            abmEmpleados.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            abmEmpleados abmEmpleados = new abmEmpleados();
            abmEmpleados.Show();
            this.Hide();
        }
    }
}
