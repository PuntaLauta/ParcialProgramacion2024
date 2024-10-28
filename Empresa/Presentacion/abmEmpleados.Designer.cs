namespace Empresa
{
    partial class abmEmpleados
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
            dgEmpleados = new DataGridView();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnModificar = new Button();
            btnRefrescar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgEmpleados
            // 
            dgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpleados.Location = new Point(56, 56);
            dgEmpleados.MultiSelect = false;
            dgEmpleados.Name = "dgEmpleados";
            dgEmpleados.ReadOnly = true;
            dgEmpleados.RowHeadersWidth = 51;
            dgEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEmpleados.Size = new Size(962, 394);
            dgEmpleados.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(66, 491);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 55);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(269, 491);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(139, 55);
            btnQuitar.TabIndex = 2;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(478, 491);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 55);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(686, 491);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(127, 55);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "Refrescar lista";
            btnRefrescar.UseCompatibleTextRendering = true;
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(882, 491);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(117, 55);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // abmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 611);
            Controls.Add(btnRegresar);
            Controls.Add(btnRefrescar);
            Controls.Add(btnModificar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(dgEmpleados);
            Name = "abmEmpleados";
            Text = "ABM Empleados";
            ((System.ComponentModel.ISupportInitialize)dgEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgEmpleados;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnModificar;
        private Button btnRefrescar;
        private Button btnRegresar;
    }
}