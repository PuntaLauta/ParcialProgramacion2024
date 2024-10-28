using Empresa.dsEmpresaTableAdapters;

namespace Empresa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String username = txtUsuario.Text;
            String password = txtPassword.Text;
            EmpleadosTableAdapter adapter = new EmpleadosTableAdapter();
            dsEmpresa.EmpleadosDataTable dt = adapter.GetDataBy11(username, password);
            if (dt.Rows.Count > 0)
            {
                int valorRol = (int)dt.Rows[0]["Rol"];
                int valorDni = (int)dt.Rows[0]["DNI"];
                String nombre = dt.Rows[0]["Nombre"].ToString();
                UserSettings.Login(valorRol, valorDni , username, nombre);
                Menu menu = new Menu(valorRol);
                menu.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Credenciales invalidas", "ERROR", MessageBoxButtons.OK);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
