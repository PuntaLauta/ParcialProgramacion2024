namespace Empresa
{
    partial class compraProductos
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
            btnRegresar = new Button();
            dgProductos = new DataGridView();
            btnComprar = new Button();
            btnVender = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(840, 505);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(161, 46);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(74, 49);
            dgProductos.MultiSelect = false;
            dgProductos.Name = "dgProductos";
            dgProductos.ReadOnly = true;
            dgProductos.RowHeadersWidth = 51;
            dgProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProductos.Size = new Size(927, 403);
            dgProductos.TabIndex = 1;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(74, 502);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(162, 47);
            btnComprar.TabIndex = 2;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(587, 504);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(162, 47);
            btnVender.TabIndex = 3;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(339, 502);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(162, 47);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // compraProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 597);
            Controls.Add(btnModificar);
            Controls.Add(btnVender);
            Controls.Add(btnComprar);
            Controls.Add(dgProductos);
            Controls.Add(btnRegresar);
            Name = "compraProductos";
            Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
        private DataGridView dgProductos;
        private Button btnComprar;
        private Button btnVender;
        private Button btnModificar;
    }
}