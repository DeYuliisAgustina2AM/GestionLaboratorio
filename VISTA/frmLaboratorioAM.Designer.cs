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
            cbListadoSedes = new ComboBox();
            label3 = new Label();
            txtCodigoComputadora = new TextBox();
            label1 = new Label();
            btnModificar = new Button();
            btnAgregar = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            label4.Location = new Point(15, 195);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 32;
            label4.Text = "Capacidad Máxima";
            // 
            // cbListadoSedes
            // 
            cbListadoSedes.FormattingEnabled = true;
            cbListadoSedes.Location = new Point(198, 104);
            cbListadoSedes.Name = "cbListadoSedes";
            cbListadoSedes.Size = new Size(214, 23);
            cbListadoSedes.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 107);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 30;
            label3.Text = "Agregar a la Sede:";
            // 
            // txtCodigoComputadora
            // 
            txtCodigoComputadora.Location = new Point(198, 59);
            txtCodigoComputadora.Name = "txtCodigoComputadora";
            txtCodigoComputadora.Size = new Size(214, 23);
            txtCodigoComputadora.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 57);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 28;
            label1.Text = "Nombre Laboratorio:";
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(244, 253);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 30);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(69, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 30);
            btnAgregar.TabIndex = 34;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(198, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 23);
            comboBox1.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 154);
            label5.Name = "label5";
            label5.Size = new Size(171, 20);
            label5.TabIndex = 36;
            label5.Text = "Agregar Computadora:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(198, 192);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(214, 23);
            numericUpDown1.TabIndex = 38;
            // 
            // frmAbmLaboratorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 295);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(cbListadoSedes);
            Controls.Add(label3);
            Controls.Add(txtCodigoComputadora);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAbmLaboratorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAbmLaboratorio";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Label label4;
        private ComboBox cbListadoSedes;
        private Label label3;
        private TextBox txtCodigoComputadora;
        private Label label1;
        private Button btnModificar;
        private Button btnAgregar;
        private ComboBox comboBox1;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}