namespace VISTA
{
    partial class Computadora
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
            btnCerrar = new Button();
            btnMinimizar = new Button();
            txtBuscarComputadoraId = new TextBox();
            btnBuscar = new Button();
            btnListarLaboratorio = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvComputadora = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvComputadora).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(754, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 33;
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
            btnMinimizar.TabIndex = 32;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // txtBuscarComputadoraId
            // 
            txtBuscarComputadoraId.ForeColor = SystemColors.GrayText;
            txtBuscarComputadoraId.Location = new Point(617, 93);
            txtBuscarComputadoraId.Name = "txtBuscarComputadoraId";
            txtBuscarComputadoraId.Size = new Size(135, 23);
            txtBuscarComputadoraId.TabIndex = 31;
            txtBuscarComputadoraId.Text = "Buscar Computadora";
            txtBuscarComputadoraId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(492, 88);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 30);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar por codigo";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnListarLaboratorio
            // 
            btnListarLaboratorio.FlatStyle = FlatStyle.Flat;
            btnListarLaboratorio.Location = new Point(321, 88);
            btnListarLaboratorio.Name = "btnListarLaboratorio";
            btnListarLaboratorio.Size = new Size(89, 30);
            btnListarLaboratorio.TabIndex = 29;
            btnListarLaboratorio.Text = "Listar";
            btnListarLaboratorio.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(220, 88);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(89, 30);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(116, 88);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 30);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(12, 88);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 30);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvComputadora
            // 
            dgvComputadora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComputadora.Location = new Point(12, 124);
            dgvComputadora.Name = "dgvComputadora";
            dgvComputadora.RowTemplate.Height = 25;
            dgvComputadora.Size = new Size(749, 314);
            dgvComputadora.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(257, 19);
            label2.Name = "label2";
            label2.Size = new Size(251, 25);
            label2.TabIndex = 24;
            label2.Text = "Gestionar Computadoras";
            // 
            // Computadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(txtBuscarComputadoraId);
            Controls.Add(btnBuscar);
            Controls.Add(btnListarLaboratorio);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvComputadora);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Computadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Computadora";
            ((System.ComponentModel.ISupportInitialize)dgvComputadora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnMinimizar;
        private TextBox txtBuscarComputadoraId;
        private Button btnBuscar;
        private Button btnListarLaboratorio;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvComputadora;
        private Label label2;
    }
}