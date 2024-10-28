namespace Empresa
{
    partial class compraDetalle
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
            lblCantidad = new Label();
            txtCantidad = new NumericUpDown();
            btnComprar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(128, 56);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(99, 107);
            txtCantidad.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(134, 27);
            txtCantidad.TabIndex = 1;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(293, 72);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(108, 44);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click_1;
            // 
            // compraDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 187);
            Controls.Add(btnComprar);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Name = "compraDetalle";
            Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCantidad;
        private NumericUpDown txtCantidad;
        private Button btnComprar;
    }
}