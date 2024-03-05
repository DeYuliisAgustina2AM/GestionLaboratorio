namespace VISTA
{
    partial class frmCrearTicketAM
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
            btnCerrar = new Button();
            btnMinimizar = new Button();
            label3 = new Label();
            dtpFechaTicket = new DateTimePicker();
            label4 = new Label();
            cbTipoTicket = new ComboBox();
            label5 = new Label();
            cbCategoriaTicket = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            cbEstadoTicket = new ComboBox();
            cbUrgenciaTicket = new ComboBox();
            cbUbicacionTicket = new ComboBox();
            btnModificarTicket = new Button();
            btnAgregarTicket = new Button();
            txtDescripcionTicket = new TextBox();
            txtAsignadoTicket = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(167, 12);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 8;
            label2.Text = "Ticket";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 44);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 9;
            label1.Text = "Crear Caso";
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(389, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(359, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 13;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 101);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 15;
            label3.Text = "Fecha Inicio:";
            // 
            // dtpFechaTicket
            // 
            dtpFechaTicket.Location = new Point(144, 99);
            dtpFechaTicket.Name = "dtpFechaTicket";
            dtpFechaTicket.Size = new Size(214, 23);
            dtpFechaTicket.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 152);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 17;
            label4.Text = "Tipo:";
            // 
            // cbTipoTicket
            // 
            cbTipoTicket.FormattingEnabled = true;
            cbTipoTicket.Location = new Point(144, 149);
            cbTipoTicket.Name = "cbTipoTicket";
            cbTipoTicket.Size = new Size(214, 23);
            cbTipoTicket.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 202);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 19;
            label5.Text = "Categoria:";
            // 
            // cbCategoriaTicket
            // 
            cbCategoriaTicket.FormattingEnabled = true;
            cbCategoriaTicket.Location = new Point(144, 199);
            cbCategoriaTicket.Name = "cbCategoriaTicket";
            cbCategoriaTicket.Size = new Size(214, 23);
            cbCategoriaTicket.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 257);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 21;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 311);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 22;
            label7.Text = "Urgencia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(28, 373);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 23;
            label8.Text = "Ubicación:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(29, 428);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 24;
            label9.Text = "Asignado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(29, 485);
            label11.Name = "label11";
            label11.Size = new Size(96, 20);
            label11.TabIndex = 26;
            label11.Text = "Descripcion:";
            // 
            // cbEstadoTicket
            // 
            cbEstadoTicket.FormattingEnabled = true;
            cbEstadoTicket.Location = new Point(145, 254);
            cbEstadoTicket.Name = "cbEstadoTicket";
            cbEstadoTicket.Size = new Size(214, 23);
            cbEstadoTicket.TabIndex = 27;
            // 
            // cbUrgenciaTicket
            // 
            cbUrgenciaTicket.FormattingEnabled = true;
            cbUrgenciaTicket.Location = new Point(145, 312);
            cbUrgenciaTicket.Name = "cbUrgenciaTicket";
            cbUrgenciaTicket.Size = new Size(214, 23);
            cbUrgenciaTicket.TabIndex = 28;
            // 
            // cbUbicacionTicket
            // 
            cbUbicacionTicket.FormattingEnabled = true;
            cbUbicacionTicket.Location = new Point(145, 374);
            cbUbicacionTicket.Name = "cbUbicacionTicket";
            cbUbicacionTicket.Size = new Size(214, 23);
            cbUbicacionTicket.TabIndex = 29;
            // 
            // btnModificarTicket
            // 
            btnModificarTicket.FlatStyle = FlatStyle.Flat;
            btnModificarTicket.Location = new Point(227, 619);
            btnModificarTicket.Name = "btnModificarTicket";
            btnModificarTicket.Size = new Size(89, 30);
            btnModificarTicket.TabIndex = 32;
            btnModificarTicket.Text = "Modificar";
            btnModificarTicket.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTicket
            // 
            btnAgregarTicket.FlatStyle = FlatStyle.Flat;
            btnAgregarTicket.Location = new Point(79, 619);
            btnAgregarTicket.Name = "btnAgregarTicket";
            btnAgregarTicket.Size = new Size(89, 30);
            btnAgregarTicket.TabIndex = 31;
            btnAgregarTicket.Text = "Agregar";
            btnAgregarTicket.UseVisualStyleBackColor = true;
            // 
            // txtDescripcionTicket
            // 
            txtDescripcionTicket.Location = new Point(140, 485);
            txtDescripcionTicket.Multiline = true;
            txtDescripcionTicket.Name = "txtDescripcionTicket";
            txtDescripcionTicket.Size = new Size(252, 109);
            txtDescripcionTicket.TabIndex = 33;
            // 
            // txtAsignadoTicket
            // 
            txtAsignadoTicket.Location = new Point(144, 429);
            txtAsignadoTicket.Name = "txtAsignadoTicket";
            txtAsignadoTicket.Size = new Size(215, 23);
            txtAsignadoTicket.TabIndex = 34;
            // 
            // frmAbmCrearTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 661);
            Controls.Add(txtAsignadoTicket);
            Controls.Add(txtDescripcionTicket);
            Controls.Add(btnModificarTicket);
            Controls.Add(btnAgregarTicket);
            Controls.Add(cbUbicacionTicket);
            Controls.Add(cbUrgenciaTicket);
            Controls.Add(cbEstadoTicket);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbCategoriaTicket);
            Controls.Add(label5);
            Controls.Add(cbTipoTicket);
            Controls.Add(label4);
            Controls.Add(dtpFechaTicket);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAbmCrearTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCrearTicket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Label label3;
        private DateTimePicker dtpFechaTicket;
        private Label label4;
        private ComboBox cbTipoTicket;
        private Label label5;
        private ComboBox cbCategoriaTicket;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private ComboBox cbEstadoTicket;
        private ComboBox cbUrgenciaTicket;
        private ComboBox cbUbicacionTicket;
        private Button btnModificarTicket;
        private Button btnAgregarTicket;
        private TextBox txtDescripcionTicket;
        private TextBox txtAsignadoTicket;
    }
}