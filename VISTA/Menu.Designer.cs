namespace VISTA
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnSedeMenu = new Button();
            btnLaboratorioMenu = new Button();
            btnComputadoraMenu = new Button();
            btnTicketMenu = new Button();
            btnHistorialMenu = new Button();
            btnMinimizarMenu = new Button();
            btnInformacion = new Button();
            btnCerrarMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 26);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 51);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 1;
            label2.Text = "Sistema Gestión";
            // 
            // btnSedeMenu
            // 
            btnSedeMenu.FlatStyle = FlatStyle.Flat;
            btnSedeMenu.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSedeMenu.Location = new Point(129, 94);
            btnSedeMenu.Name = "btnSedeMenu";
            btnSedeMenu.Size = new Size(88, 63);
            btnSedeMenu.TabIndex = 2;
            btnSedeMenu.Text = "Gestionar Sede";
            btnSedeMenu.UseVisualStyleBackColor = true;
            btnSedeMenu.Click += btnSedeMenu_Click;
            // 
            // btnLaboratorioMenu
            // 
            btnLaboratorioMenu.FlatStyle = FlatStyle.Flat;
            btnLaboratorioMenu.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLaboratorioMenu.Location = new Point(129, 176);
            btnLaboratorioMenu.Name = "btnLaboratorioMenu";
            btnLaboratorioMenu.Size = new Size(88, 63);
            btnLaboratorioMenu.TabIndex = 3;
            btnLaboratorioMenu.Text = "Gestionar Laboratorio";
            btnLaboratorioMenu.UseVisualStyleBackColor = true;
            btnLaboratorioMenu.Click += btnLaboratorioMenu_Click;
            // 
            // btnComputadoraMenu
            // 
            btnComputadoraMenu.FlatStyle = FlatStyle.Flat;
            btnComputadoraMenu.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnComputadoraMenu.Location = new Point(129, 257);
            btnComputadoraMenu.Name = "btnComputadoraMenu";
            btnComputadoraMenu.Size = new Size(88, 63);
            btnComputadoraMenu.TabIndex = 4;
            btnComputadoraMenu.Text = "Gestionar Computadoras";
            btnComputadoraMenu.UseVisualStyleBackColor = true;
            btnComputadoraMenu.Click += btnComputadoraMenu_Click;
            // 
            // btnTicketMenu
            // 
            btnTicketMenu.FlatStyle = FlatStyle.Flat;
            btnTicketMenu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTicketMenu.Location = new Point(129, 339);
            btnTicketMenu.Name = "btnTicketMenu";
            btnTicketMenu.Size = new Size(88, 63);
            btnTicketMenu.TabIndex = 5;
            btnTicketMenu.Text = "Gestionar Ticket";
            btnTicketMenu.UseVisualStyleBackColor = true;
            btnTicketMenu.Click += btnTicketMenu_Click;
            // 
            // btnHistorialMenu
            // 
            btnHistorialMenu.FlatStyle = FlatStyle.Flat;
            btnHistorialMenu.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistorialMenu.Location = new Point(129, 417);
            btnHistorialMenu.Name = "btnHistorialMenu";
            btnHistorialMenu.Size = new Size(88, 63);
            btnHistorialMenu.TabIndex = 6;
            btnHistorialMenu.Text = "Historial Tickets";
            btnHistorialMenu.UseVisualStyleBackColor = true;
            btnHistorialMenu.Click += btnHistorialMenu_Click;
            // 
            // btnMinimizarMenu
            // 
            btnMinimizarMenu.FlatStyle = FlatStyle.Flat;
            btnMinimizarMenu.Location = new Point(280, 5);
            btnMinimizarMenu.Name = "btnMinimizarMenu";
            btnMinimizarMenu.Size = new Size(24, 24);
            btnMinimizarMenu.TabIndex = 7;
            btnMinimizarMenu.Text = "-";
            btnMinimizarMenu.UseVisualStyleBackColor = true;
            btnMinimizarMenu.Click += btnMinimizarMenu_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Location = new Point(310, 5);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(36, 24);
            btnInformacion.TabIndex = 8;
            btnInformacion.UseVisualStyleBackColor = true;
            // 
            // btnCerrarMenu
            // 
            btnCerrarMenu.FlatStyle = FlatStyle.Flat;
            btnCerrarMenu.Location = new Point(352, 5);
            btnCerrarMenu.Name = "btnCerrarMenu";
            btnCerrarMenu.Size = new Size(24, 24);
            btnCerrarMenu.TabIndex = 9;
            btnCerrarMenu.Text = "X";
            btnCerrarMenu.UseVisualStyleBackColor = true;
            btnCerrarMenu.Click += btnCerrarMenu_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 503);
            Controls.Add(btnCerrarMenu);
            Controls.Add(btnInformacion);
            Controls.Add(btnMinimizarMenu);
            Controls.Add(btnHistorialMenu);
            Controls.Add(btnTicketMenu);
            Controls.Add(btnComputadoraMenu);
            Controls.Add(btnLaboratorioMenu);
            Controls.Add(btnSedeMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSedeMenu;
        private Button btnLaboratorioMenu;
        private Button btnComputadoraMenu;
        private Button btnTicketMenu;
        private Button btnHistorialMenu;
        private Button btnMinimizarMenu;
        private Button btnInformacion;
        private Button btnCerrarMenu;
    }
}
