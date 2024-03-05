namespace VISTA
{
    partial class frmLaboratorioAM
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
            btnCerrar = new Button();
            btnMinimizar = new Button();
            label4 = new Label();
            cmbListadoSedes = new ComboBox();
            label3 = new Label();
            txtNombreLaboratorio = new TextBox();
            label1 = new Label();
            btnModificar = new Button();
            btnAgregar = new Button();
            cmbListadoComputadoras = new ComboBox();
            label5 = new Label();
            numCapacidadMaxima = new NumericUpDown();
            lblAgregaroModificar = new Label();
            ((System.ComponentModel.ISupportInitialize)numCapacidadMaxima).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 9);
            label2.Name = "label2";
            label2.Size = new Size(231, 25);
            label2.TabIndex = 9;
            label2.Text = "Gestionar Laboratorios";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(407, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 27;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(377, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 26;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 223);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 32;
            label4.Text = "Capacidad Máxima";
            // 
            // cmbListadoSedes
            // 
            cmbListadoSedes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListadoSedes.FormattingEnabled = true;
            cmbListadoSedes.Location = new Point(198, 132);
            cmbListadoSedes.Name = "cmbListadoSedes";
            cmbListadoSedes.Size = new Size(214, 23);
            cmbListadoSedes.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 135);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 30;
            label3.Text = "Agregar a la Sede:";
            // 
            // txtNombreLaboratorio
            // 
            txtNombreLaboratorio.Location = new Point(198, 83);
            txtNombreLaboratorio.Name = "txtNombreLaboratorio";
            txtNombreLaboratorio.Size = new Size(214, 23);
            txtNombreLaboratorio.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 86);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 28;
            label1.Text = "Nombre Laboratorio:";
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(244, 276);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 30);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(69, 276);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 30);
            btnAgregar.TabIndex = 34;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbListadoComputadoras
            // 
            cmbListadoComputadoras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListadoComputadoras.FormattingEnabled = true;
            cmbListadoComputadoras.Location = new Point(198, 179);
            cmbListadoComputadoras.Name = "cmbListadoComputadoras";
            cmbListadoComputadoras.Size = new Size(214, 23);
            cmbListadoComputadoras.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 182);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 36;
            label5.Text = "Agregar Computadora:";
            // 
            // numCapacidadMaxima
            // 
            numCapacidadMaxima.Location = new Point(198, 220);
            numCapacidadMaxima.Name = "numCapacidadMaxima";
            numCapacidadMaxima.Size = new Size(214, 23);
            numCapacidadMaxima.TabIndex = 38;
            // 
            // lblAgregaroModificar
            // 
            lblAgregaroModificar.AutoSize = true;
            lblAgregaroModificar.Location = new Point(121, 44);
            lblAgregaroModificar.Name = "lblAgregaroModificar";
            lblAgregaroModificar.Size = new Size(177, 15);
            lblAgregaroModificar.TabIndex = 39;
            lblAgregaroModificar.Text = "Agregar o Modificar Laboratorio";
            // 
            // frmLaboratorioAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 332);
            Controls.Add(lblAgregaroModificar);
            Controls.Add(numCapacidadMaxima);
            Controls.Add(cmbListadoComputadoras);
            Controls.Add(label5);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(cmbListadoSedes);
            Controls.Add(label3);
            Controls.Add(txtNombreLaboratorio);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLaboratorioAM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAbmLaboratorio";
            Load += frmLaboratorioAM_Load;
            ((System.ComponentModel.ISupportInitialize)numCapacidadMaxima).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Label label4;
        private ComboBox cmbListadoSedes;
        private Label label3;
        private TextBox txtNombreLaboratorio;
        private Label label1;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox cmbListadoComputadoras;
        private Label label5;
        private NumericUpDown numCapacidadMaxima;
        private Label lblAgregaroModificar;
    }
}