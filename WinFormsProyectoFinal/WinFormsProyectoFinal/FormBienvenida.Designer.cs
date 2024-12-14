namespace WinFormsProyectoFinal
{
    partial class FormBienvenida
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
            lblBienvenida = new Label();
            lblDPermisos = new Label();
            lblPermisos = new Label();
            btn1 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(266, 88);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(232, 15);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "!Bienvenido, Usuario (Nombre de Usuario)!";
            // 
            // lblDPermisos
            // 
            lblDPermisos.AutoSize = true;
            lblDPermisos.Location = new Point(65, 138);
            lblDPermisos.Name = "lblDPermisos";
            lblDPermisos.Size = new Size(313, 15);
            lblDPermisos.TabIndex = 1;
            lblDPermisos.Text = "Te recoradmos que en esta cuenta solo podrás hacer esto: ";
            // 
            // lblPermisos
            // 
            lblPermisos.AutoSize = true;
            lblPermisos.Location = new Point(65, 182);
            lblPermisos.Name = "lblPermisos";
            lblPermisos.Size = new Size(450, 15);
            lblPermisos.TabIndex = 2;
            lblPermisos.Text = "En este label pretendo que se impriman los permisos de cada usuario, queda con ifs.";
            // 
            // btn1
            // 
            btn1.Location = new Point(688, 406);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 3;
            btn1.Text = "Siguiente";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(60, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn1);
            Controls.Add(lblPermisos);
            Controls.Add(lblDPermisos);
            Controls.Add(lblBienvenida);
            Name = "FormBienvenida";
            Text = "Form2";
            Load += FormBienvenida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblDPermisos;
        private Label lblPermisos;
        private Button btn1;
        private Button button1;
    }
}