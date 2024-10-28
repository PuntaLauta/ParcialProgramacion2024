namespace Empresa
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnIngresar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(236, 158);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(119, 41);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(486, 172);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(205, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(486, 256);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(205, 27);
            txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(211, 242);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(168, 41);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(439, 427);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(172, 60);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(373, 60);
            label2.Name = "label2";
            label2.Size = new Size(297, 40);
            label2.TabIndex = 6;
            label2.Text = "Gestor de Empresa";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 608);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "Login";
            Text = "Ingresar";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnIngresar;
        private Label label2;
    }
}
