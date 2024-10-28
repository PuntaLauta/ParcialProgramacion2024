namespace Empresa
{
    partial class listaMovimientos
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
            dgMovimientos = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgMovimientos).BeginInit();
            SuspendLayout();
            // 
            // dgMovimientos
            // 
            dgMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMovimientos.Location = new Point(133, 41);
            dgMovimientos.MultiSelect = false;
            dgMovimientos.Name = "dgMovimientos";
            dgMovimientos.ReadOnly = true;
            dgMovimientos.RowHeadersWidth = 51;
            dgMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMovimientos.Size = new Size(802, 452);
            dgMovimientos.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(800, 538);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(153, 53);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // listaMovimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 623);
            Controls.Add(btnVolver);
            Controls.Add(dgMovimientos);
            Name = "listaMovimientos";
            Text = "Movimientos";
            Load += listaMovimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgMovimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgMovimientos;
        private Button btnVolver;
    }
}