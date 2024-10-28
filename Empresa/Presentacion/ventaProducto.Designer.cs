namespace Empresa
{
    partial class ventaProducto
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
            lblCliente = new Label();
            cbClientes = new ComboBox();
            label2 = new Label();
            txtCantidad = new NumericUpDown();
            lblDescuento = new Label();
            btnVender = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(72, 75);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(185, 75);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(151, 28);
            cbClientes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 210);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(185, 210);
            txtCantidad.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 27);
            txtCantidad.TabIndex = 3;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(152, 130);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(0, 20);
            lblDescuento.TabIndex = 4;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(459, 130);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(115, 58);
            btnVender.TabIndex = 5;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 210);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Cantidad";
            // 
            // ventaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 334);
            Controls.Add(btnVender);
            Controls.Add(lblDescuento);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cbClientes);
            Controls.Add(lblCliente);
            Name = "ventaProducto";
            Text = "Ventas";
            Load += ventaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private ComboBox cbClientes;
        private Label label2;
        private NumericUpDown txtCantidad;
        private Label lblDescuento;
        private Button btnVender;
        private Label label1;
    }
}