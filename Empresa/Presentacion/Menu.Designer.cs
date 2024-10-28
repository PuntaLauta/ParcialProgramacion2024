namespace Empresa
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            lblBienvenido = new Label();
            btnEmpleados = new Button();
            btnProducto = new Button();
            btnMovimientos = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(369, 55);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(0, 50);
            lblBienvenido.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Location = new Point(181, 179);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(149, 69);
            btnEmpleados.TabIndex = 1;
            btnEmpleados.Text = "ABM Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(457, 179);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(149, 69);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "Compra / Venta Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(726, 179);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(149, 69);
            btnMovimientos.TabIndex = 4;
            btnMovimientos.Text = "Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(726, 460);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 71);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 436);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(325, 95);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1074, 605);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnMovimientos);
            Controls.Add(btnProducto);
            Controls.Add(btnEmpleados);
            Controls.Add(lblBienvenido);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Button btnEmpleados;
        private Button btnProducto;
        private Button btnMovimientos;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}