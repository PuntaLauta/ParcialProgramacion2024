namespace Empresa
{
    partial class agregarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            dtFechaNac = new DateTimePicker();
            lblDni = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblFechaNac = new Label();
            lblUsuario = new Label();
            lblPassword = new Label();
            btnAgregar = new Button();
            lblRol = new Label();
            cbRol = new ComboBox();
            txtDocumento = new NumericUpDown();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)txtDocumento).BeginInit();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(354, 159);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(354, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(354, 272);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(354, 394);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(354, 335);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 5;
            // 
            // dtFechaNac
            // 
            dtFechaNac.Location = new Point(343, 219);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(303, 27);
            dtFechaNac.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(152, 41);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 7;
            lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(150, 95);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(153, 159);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(153, 272);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Telefono";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(153, 224);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(146, 20);
            lblFechaNac.TabIndex = 11;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(150, 338);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(137, 20);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "Nombre de usuario";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(150, 397);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 20);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Contraseña";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(168, 509);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(156, 452);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(31, 20);
            lblRol.TabIndex = 15;
            lblRol.Text = "Rol";
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "Admin", "Auditor", "Operador" });
            cbRol.Location = new Point(343, 452);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(151, 28);
            cbRol.TabIndex = 16;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(343, 34);
            txtDocumento.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(150, 27);
            txtDocumento.TabIndex = 17;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(581, 509);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(131, 44);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // agregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 588);
            Controls.Add(btnVolver);
            Controls.Add(txtDocumento);
            Controls.Add(cbRol);
            Controls.Add(lblRol);
            Controls.Add(btnAgregar);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(lblFechaNac);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Controls.Add(dtFechaNac);
            Controls.Add(txtUsuario);
            Controls.Add(txtPassword);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Name = "agregarEmpleado";
            Text = "Agregar / Modificar";
            Load += agregarEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)txtDocumento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private DateTimePicker dtFechaNac;
        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblFechaNac;
        private Label lblUsuario;
        private Label lblPassword;
        private Button btnAgregar;
        private Label lblRol;
        private ComboBox cbRol;
        private NumericUpDown txtDocumento;
        private Button btnVolver;
    }
}