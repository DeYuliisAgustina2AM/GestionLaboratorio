namespace VISTA
{
    partial class frmHistorialDGV
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
            dgvTickets = new DataGridView();
            label2 = new Label();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            btnCargarTickets = new Button();
            btnEliminarTicket = new Button();
            txtBuscarTicketId = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // dgvTickets
            // 
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(12, 105);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowTemplate.Height = 25;
            dgvTickets.Size = new Size(749, 290);
            dgvTickets.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(308, 9);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 27;
            label2.Text = "Historial Tickets";
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(749, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 24);
            btnCerrar.TabIndex = 35;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Location = new Point(719, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(24, 24);
            btnMinimizar.TabIndex = 34;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCargarTickets
            // 
            btnCargarTickets.FlatStyle = FlatStyle.Flat;
            btnCargarTickets.Location = new Point(12, 69);
            btnCargarTickets.Name = "btnCargarTickets";
            btnCargarTickets.Size = new Size(100, 30);
            btnCargarTickets.TabIndex = 36;
            btnCargarTickets.Text = "Cargar Tickets";
            btnCargarTickets.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTicket
            // 
            btnEliminarTicket.FlatStyle = FlatStyle.Flat;
            btnEliminarTicket.Location = new Point(129, 69);
            btnEliminarTicket.Name = "btnEliminarTicket";
            btnEliminarTicket.Size = new Size(89, 30);
            btnEliminarTicket.TabIndex = 37;
            btnEliminarTicket.Text = "Eliminar";
            btnEliminarTicket.UseVisualStyleBackColor = true;
            // 
            // txtBuscarTicketId
            // 
            txtBuscarTicketId.ForeColor = SystemColors.GrayText;
            txtBuscarTicketId.Location = new Point(626, 76);
            txtBuscarTicketId.Name = "txtBuscarTicketId";
            txtBuscarTicketId.Size = new Size(135, 23);
            txtBuscarTicketId.TabIndex = 39;
            txtBuscarTicketId.Text = "Buscar Ticket Por Id";
            txtBuscarTicketId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(531, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 30);
            btnBuscar.TabIndex = 38;
            btnBuscar.Text = "Buscar ";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 407);
            Controls.Add(txtBuscarTicketId);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminarTicket);
            Controls.Add(btnCargarTickets);
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Controls.Add(label2);
            Controls.Add(dgvTickets);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHistorial";
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTickets;
        private Label label2;
        private Button btnCerrar;
        private Button btnMinimizar;
        private Button btnCargarTickets;
        private Button btnEliminarTicket;
        private TextBox txtBuscarTicketId;
        private Button btnBuscar;
    }
}