namespace VISTA
{
    partial class frmSedeDGV
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
            dgvSede = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtBuscarSede = new TextBox();
            label2 = new Label();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            btnBuscarSede = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSede).BeginInit();
            SuspendLayout();
            // 
            // dgvSede
            // 
            dgvSede.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSede.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSede.Location = new Point(12, 124);
            dgvSede.Name = "dgvSede";
            dgvSede.RowTemplate.Height = 25;
            dgvSede.Size = new Size(749, 314);
            dgvSede.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(12, 84);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 30);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(116, 84);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 30);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(220, 84);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 30);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtBuscarSede
            // 
            txtBuscarSede.ForeColor = SystemColors.GrayText;
            txtBuscarSede.Location = new Point(617, 89);
            txtBuscarSede.Name = "txtBuscarSede";
            txtBuscarSede.Size = new Size(135, 23);
            txtBuscarSede.TabIndex = 6;
            txtBuscarSede.Text = "por Nombre o ID";
            txtBuscarSede.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(273, 9);
            label2.Name = "label2";
            label2.Size = new Size(172, 25);
            label2.TabIndex = 7;
            label2.Text = "Gestionar Sedes";
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(745, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(715, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 10;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnBuscarSede
            // 
            btnBuscarSede.Location = new Point(522, 84);
            btnBuscarSede.Name = "btnBuscarSede";
            btnBuscarSede.Size = new Size(89, 30);
            btnBuscarSede.TabIndex = 13;
            btnBuscarSede.Text = "Buscar";
            btnBuscarSede.UseVisualStyleBackColor = true;
            btnBuscarSede.Click += btnBuscarSede_Click;
            // 
            // frmSedeDGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(btnBuscarSede);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(label2);
            Controls.Add(txtBuscarSede);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvSede);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSedeDGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSede";
            Load += frmSedeDGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSede).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSede;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtBuscarSede;
        private Label label2;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Button btnBuscarSede;
    }
}