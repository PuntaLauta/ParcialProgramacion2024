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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Empresa
{
    public partial class abmEmpleados : Form
    {
        public abmEmpleados()
        {
            InitializeComponent();
            refresh();
        }

        private void refresh()
        {
            EmpleadosTableAdapter adapter = new EmpleadosTableAdapter();
            dsEmpresa.EmpleadosDataTable dt = adapter.GetData();
            dgEmpleados.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarEmpleado agregarEmpleado = new agregarEmpleado();
            agregarEmpleado.Show();
            this.Hide();
        }

        private int getDni()
        {
            return int.Parse(dgEmpleados.Rows[dgEmpleados.CurrentRow.Index].Cells[0].Value.ToString());
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int? dni = getDni();
            EmpleadosTableAdapter adapter = new EmpleadosTableAdapter();
            adapter.DeleteEmpleado((int)dni);
            refresh();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? dni = getDni();
            agregarEmpleado agregarEmpleado = new agregarEmpleado(dni);
            agregarEmpleado.Show();
            this.Hide();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void abmEmpleados_Load(object sender, EventArgs e)
        {

        }


    }
}
