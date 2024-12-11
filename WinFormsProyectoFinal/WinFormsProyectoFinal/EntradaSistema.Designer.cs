namespace WinFormsProyectoFinal
{
    partial class EntradaSistema
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
            panel1 = new Panel();
            panelMenuLateral = new Panel();
            btnSalir = new Button();
            panelUsuarios = new Panel();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnAdmin = new Button();
            btnUsuarios = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelMenuLateral.SuspendLayout();
            panelUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(panelMenuLateral);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1229, 610);
            panel1.TabIndex = 0;
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.Gray;
            panelMenuLateral.Controls.Add(btnSalir);
            panelMenuLateral.Controls.Add(panelUsuarios);
            panelMenuLateral.Controls.Add(btnUsuarios);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 610);
            panelMenuLateral.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(64, 64, 64);
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(0, 561);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(250, 49);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Regresar";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // panelUsuarios
            // 
            panelUsuarios.BackColor = Color.Gray;
            panelUsuarios.Controls.Add(button2);
            panelUsuarios.Controls.Add(button1);
            panelUsuarios.Controls.Add(button6);
            panelUsuarios.Controls.Add(button5);
            panelUsuarios.Controls.Add(button4);
            panelUsuarios.Controls.Add(button3);
            panelUsuarios.Controls.Add(btnAdmin);
            panelUsuarios.Dock = DockStyle.Top;
            panelUsuarios.Location = new Point(0, 50);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(250, 276);
            panelUsuarios.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10.2F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 240);
            button2.Name = "button2";
            button2.Padding = new Padding(35, 0, 0, 0);
            button2.Size = new Size(250, 40);
            button2.TabIndex = 6;
            button2.Text = "Invitado";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.2F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 200);
            button1.Name = "button1";
            button1.Padding = new Padding(35, 0, 0, 0);
            button1.Size = new Size(250, 40);
            button1.TabIndex = 5;
            button1.Text = "JCUP";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Gray;
            button6.FlatAppearance.MouseOverBackColor = Color.Silver;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Tahoma", 10.2F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(0, 160);
            button6.Name = "button6";
            button6.Padding = new Padding(35, 0, 0, 0);
            button6.Size = new Size(250, 40);
            button6.TabIndex = 4;
            button6.Text = "EJER";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Gray;
            button5.FlatAppearance.MouseOverBackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Tahoma", 10.2F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 120);
            button5.Name = "button5";
            button5.Padding = new Padding(35, 0, 0, 0);
            button5.Size = new Size(250, 40);
            button5.TabIndex = 3;
            button5.Text = "JADL";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Gray;
            button4.FlatAppearance.MouseOverBackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 10.2F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 80);
            button4.Name = "button4";
            button4.Padding = new Padding(35, 0, 0, 0);
            button4.Size = new Size(250, 40);
            button4.TabIndex = 2;
            button4.Text = "EAMC";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 10.2F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 40);
            button3.Name = "button3";
            button3.Padding = new Padding(35, 0, 0, 0);
            button3.Size = new Size(250, 40);
            button3.TabIndex = 1;
            button3.Text = "JACB";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Gray;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Tahoma", 10.2F);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(35, 0, 0, 0);
            btnAdmin.Size = new Size(250, 40);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Administrador";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(64, 64, 64);
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(10, 0, 0, 0);
            btnUsuarios.Size = new Size(250, 50);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoOfficetemas;
            pictureBox1.Location = new Point(358, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 219);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // EntradaSistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 607);
            Controls.Add(panel1);
            Name = "EntradaSistema";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panelMenuLateral.ResumeLayout(false);
            panelUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelMenuLateral;
        private Button btnSalir;
        private Panel panelUsuarios;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnAdmin;
        private Button btnUsuarios;
    }
}