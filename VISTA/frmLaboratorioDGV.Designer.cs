namespace VISTA
{
    partial class frmLaboratorioDGV
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
            label2 = new Label();
            dgvLaboratorio = new DataGridView();
            txtBuscarLaboratorioId = new TextBox();
            btnBuscarLaboratorio = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorio).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(257, 19);
            label2.Name = "label2";
            label2.Size = new Size(231, 25);
            label2.TabIndex = 8;
            label2.Text = "Gestionar Laboratorios";
            // 
            // dgvLaboratorio
            // 
            dgvLaboratorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLaboratorio.Location = new Point(12, 124);
            dgvLaboratorio.Name = "dgvLaboratorio";
            dgvLaboratorio.RowTemplate.Height = 25;
            dgvLaboratorio.Size = new Size(749, 314);
            dgvLaboratorio.TabIndex = 15;
            // 
            // txtBuscarLaboratorioId
            // 
            txtBuscarLaboratorioId.ForeColor = SystemColors.GrayText;
            txtBuscarLaboratorioId.Location = new Point(617, 93);
            txtBuscarLaboratorioId.Name = "txtBuscarLaboratorioId";
            txtBuscarLaboratorioId.Size = new Size(135, 23);
            txtBuscarLaboratorioId.TabIndex = 21;
            txtBuscarLaboratorioId.Text = "Buscar Laboratorio ";
            txtBuscarLaboratorioId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuscarLaboratorio
            // 
            btnBuscarLaboratorio.FlatStyle = FlatStyle.Flat;
            btnBuscarLaboratorio.Location = new Point(522, 88);
            btnBuscarLaboratorio.Name = "btnBuscarLaboratorio";
            btnBuscarLaboratorio.Size = new Size(89, 30);
            btnBuscarLaboratorio.TabIndex = 20;
            btnBuscarLaboratorio.Text = "Buscar por Id";
            btnBuscarLaboratorio.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(220, 88);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 30);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(116, 88);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 30);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(12, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 30);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(754, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 23;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(724, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 22;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // frmLaboratorioDGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(txtBuscarLaboratorioId);
            Controls.Add(btnBuscarLaboratorio);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvLaboratorio);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLaboratorioDGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLaboratorio";
            ((System.ComponentModel.ISupportInitialize)dgvLaboratorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvLaboratorio;
        private TextBox txtBuscarLaboratorioId;
        private Button btnBuscarLaboratorio;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnCerrar;
        private Button btnMinimizar;
    }
}