namespace VISTA
{
    partial class frmComputadoraAM
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
            label1 = new Label();
            txtCodigoComputadora = new TextBox();
            label3 = new Label();
            cbListadoSedes = new ComboBox();
            label4 = new Label();
            cbListadoLaboratorios = new ComboBox();
            label5 = new Label();
            cbEstadoComputadora = new ComboBox();
            label6 = new Label();
            cbCondicionComputadora = new ComboBox();
            label7 = new Label();
            txcDescripcionComputadora = new TextBox();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 9);
            label2.Name = "label2";
            label2.Size = new Size(251, 25);
            label2.TabIndex = 8;
            label2.Text = "Gestionar Computadoras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 64);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 10;
            label1.Text = "Codigo Computadora:";
            // 
            // txtCodigoComputadora
            // 
            txtCodigoComputadora.Location = new Point(189, 66);
            txtCodigoComputadora.Name = "txtCodigoComputadora";
            txtCodigoComputadora.Size = new Size(214, 23);
            txtCodigoComputadora.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 120);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 12;
            label3.Text = "Agregar a Sede:";
            // 
            // cbListadoSedes
            // 
            cbListadoSedes.FormattingEnabled = true;
            cbListadoSedes.Location = new Point(189, 121);
            cbListadoSedes.Name = "cbListadoSedes";
            cbListadoSedes.Size = new Size(214, 23);
            cbListadoSedes.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 179);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 14;
            label4.Text = "Agregar al Laboratorio";
            // 
            // cbListadoLaboratorios
            // 
            cbListadoLaboratorios.FormattingEnabled = true;
            cbListadoLaboratorios.Location = new Point(189, 180);
            cbListadoLaboratorios.Name = "cbListadoLaboratorios";
            cbListadoLaboratorios.Size = new Size(214, 23);
            cbListadoLaboratorios.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 234);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 16;
            label5.Text = "Estado:";
            // 
            // cbEstadoComputadora
            // 
            cbEstadoComputadora.FormattingEnabled = true;
            cbEstadoComputadora.Items.AddRange(new object[] { "Actualizada", "Rota", "Error", "Soporte Técnico", "Freezada" });
            cbEstadoComputadora.Location = new Point(189, 233);
            cbEstadoComputadora.Name = "cbEstadoComputadora";
            cbEstadoComputadora.Size = new Size(214, 23);
            cbEstadoComputadora.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(9, 290);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 18;
            label6.Text = "Condición:";
            // 
            // cbCondicionComputadora
            // 
            cbCondicionComputadora.FormattingEnabled = true;
            cbCondicionComputadora.Items.AddRange(new object[] { "Hardware Funcionando ", "Software Funcionando", "Hardware No Funcionando", "Softare No Funcionando" });
            cbCondicionComputadora.Location = new Point(189, 289);
            cbCondicionComputadora.Name = "cbCondicionComputadora";
            cbCondicionComputadora.Size = new Size(214, 23);
            cbCondicionComputadora.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(9, 341);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 20;
            label7.Text = "Descripción:";
            // 
            // txcDescripcionComputadora
            // 
            txcDescripcionComputadora.ForeColor = SystemColors.GrayText;
            txcDescripcionComputadora.Location = new Point(189, 342);
            txcDescripcionComputadora.Multiline = true;
            txcDescripcionComputadora.Name = "txcDescripcionComputadora";
            txcDescripcionComputadora.Size = new Size(220, 78);
            txcDescripcionComputadora.TabIndex = 21;
            txcDescripcionComputadora.Text = "Ingrese una descripción del estado de la computadora...";
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(293, 437);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 30);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(118, 437);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(89, 30);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(475, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(445, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 24;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // frmAbmComputadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 479);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txcDescripcionComputadora);
            Controls.Add(label7);
            Controls.Add(cbCondicionComputadora);
            Controls.Add(label6);
            Controls.Add(cbEstadoComputadora);
            Controls.Add(label5);
            Controls.Add(cbListadoLaboratorios);
            Controls.Add(label4);
            Controls.Add(cbListadoSedes);
            Controls.Add(label3);
            Controls.Add(txtCodigoComputadora);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAbmComputadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAbmComputadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtCodigoComputadora;
        private Label label3;
        private ComboBox cbListadoSedes;
        private Label label4;
        private ComboBox cbListadoLaboratorios;
        private Label label5;
        private ComboBox cbEstadoComputadora;
        private Label label6;
        private ComboBox cbCondicionComputadora;
        private Label label7;
        private TextBox txcDescripcionComputadora;
        private Button btnModificar;
        private Button btnAgregar;
        private Button btnCerrar;
        private Button btnMinimizar;
    }
}