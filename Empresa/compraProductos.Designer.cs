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
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(720, 502);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(138, 46);
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
            dgProductos.CellContentClick += dgProductos_CellContentClick;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(231, 502);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(162, 47);
            btnComprar.TabIndex = 2;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(492, 502);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(122, 47);
            btnVender.TabIndex = 3;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // compraProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 597);
            Controls.Add(btnVender);
            Controls.Add(btnComprar);
            Controls.Add(dgProductos);
            Controls.Add(btnRegresar);
            Name = "compraProductos";
            Text = "Compras";
            Load += compraProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
        private DataGridView dgProductos;
        private Button btnComprar;
        private Button btnVender;
    }
}