namespace Empresa
{
    partial class editarProducto
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
            lblProducto = new Label();
            lblPrecio = new Label();
            lblPorcentaje = new Label();
            lblStock = new Label();
            txtPrecio = new NumericUpDown();
            txtPorcentaje = new NumericUpDown();
            txtStock = new NumericUpDown();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(232, 30);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(51, 92);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(90, 20);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio costo";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(51, 161);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(142, 20);
            lblPorcentaje.TabIndex = 2;
            lblPorcentaje.Text = "Porcentaje ganancia";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(51, 231);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 20);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock minimo";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(222, 92);
            txtPrecio.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(134, 27);
            txtPrecio.TabIndex = 4;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(222, 159);
            txtPorcentaje.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(134, 27);
            txtPorcentaje.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(222, 224);
            txtStock.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(134, 27);
            txtStock.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(433, 253);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 60);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // editarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 346);
            Controls.Add(btnGuardar);
            Controls.Add(txtStock);
            Controls.Add(txtPorcentaje);
            Controls.Add(txtPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblPrecio);
            Controls.Add(lblProducto);
            Name = "editarProducto";
            Text = "editarProducto";
            Load += editarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private Label lblPrecio;
        private Label lblPorcentaje;
        private Label lblStock;
        private NumericUpDown txtPrecio;
        private NumericUpDown txtPorcentaje;
        private NumericUpDown txtStock;
        private Button btnGuardar;
    }
}