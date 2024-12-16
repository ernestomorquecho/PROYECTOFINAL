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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            btnPausa = new Button();
            btnReproducir = new Button();
            btnIngresar = new Button();
            panelRayita2 = new Panel();
            txtContra = new TextBox();
            labelContraseña = new Label();
            panelRayita = new Panel();
            btnCerrar = new Button();
            btnPortada = new Button();
            slogan = new Label();
            txtUsuario = new TextBox();
            labelUsuario = new Label();
            pictureBox1 = new PictureBox();
            horaFecha = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblHora);
            panel1.Controls.Add(btnPausa);
            panel1.Controls.Add(btnReproducir);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(panelRayita2);
            panel1.Controls.Add(txtContra);
            panel1.Controls.Add(labelContraseña);
            panel1.Controls.Add(panelRayita);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnPortada);
            panel1.Controls.Add(slogan);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(labelUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 481);
            panel1.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ButtonHighlight;
            lblFecha.Location = new Point(12, 438);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(72, 24);
            lblFecha.TabIndex = 22;
            lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonHighlight;
            lblHora.Location = new Point(12, 412);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(72, 24);
            lblHora.TabIndex = 21;
            lblHora.Text = "label1";
            // 
            // btnPausa
            // 
            btnPausa.FlatAppearance.BorderColor = Color.Gray;
            btnPausa.FlatStyle = FlatStyle.Flat;
            btnPausa.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPausa.ForeColor = SystemColors.ButtonHighlight;
            btnPausa.Location = new Point(886, 61);
            btnPausa.Name = "btnPausa";
            btnPausa.Size = new Size(49, 60);
            btnPausa.TabIndex = 20;
            btnPausa.Text = "| |\r\n\r\n";
            btnPausa.UseVisualStyleBackColor = true;
            btnPausa.Click += btnPausa_Click;
            // 
            // btnReproducir
            // 
            btnReproducir.FlatAppearance.BorderColor = Color.Gray;
            btnReproducir.FlatStyle = FlatStyle.Flat;
            btnReproducir.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReproducir.ForeColor = SystemColors.ButtonHighlight;
            btnReproducir.Location = new Point(890, 3);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(45, 52);
            btnReproducir.TabIndex = 19;
            btnReproducir.Text = "▶";
            btnReproducir.TextAlign = ContentAlignment.TopCenter;
            btnReproducir.UseVisualStyleBackColor = true;
            btnReproducir.Click += btnReproducir_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(435, 412);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 36);
            btnIngresar.TabIndex = 18;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            btnIngresar.MouseEnter += btnIngresar_MouseEnter;
            btnIngresar.MouseLeave += btnIngresar_MouseLeave;
            // 
            // panelRayita2
            // 
            panelRayita2.BackColor = Color.Black;
            panelRayita2.Location = new Point(392, 387);
            panelRayita2.Name = "panelRayita2";
            panelRayita2.Size = new Size(232, 2);
            panelRayita2.TabIndex = 17;
            // 
            // txtContra
            // 
            txtContra.BackColor = Color.LightGray;
            txtContra.BorderStyle = BorderStyle.None;
            txtContra.Location = new Point(392, 366);
            txtContra.Margin = new Padding(3, 4, 3, 4);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(232, 20);
            txtContra.TabIndex = 16;
            txtContra.UseSystemPasswordChar = true;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContraseña.ForeColor = SystemColors.ButtonHighlight;
            labelContraseña.Location = new Point(263, 364);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(110, 22);
            labelContraseña.TabIndex = 15;
            labelContraseña.Text = "Contraseña: ";
            // 
            // panelRayita
            // 
            panelRayita.BackColor = Color.Black;
            panelRayita.Location = new Point(392, 340);
            panelRayita.Name = "panelRayita";
            panelRayita.Size = new Size(232, 2);
            panelRayita.TabIndex = 14;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ButtonHighlight;
            btnCerrar.Location = new Point(832, 433);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 36);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            btnCerrar.MouseLeave += btnCerrar_MouseLeave;
            // 
            // btnPortada
            // 
            btnPortada.BackColor = Color.Gray;
            btnPortada.FlatStyle = FlatStyle.Flat;
            btnPortada.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPortada.ForeColor = SystemColors.ButtonHighlight;
            btnPortada.Location = new Point(12, 13);
            btnPortada.Name = "btnPortada";
            btnPortada.Size = new Size(192, 36);
            btnPortada.TabIndex = 12;
            btnPortada.Text = "Volver a la portada";
            btnPortada.UseVisualStyleBackColor = false;
            btnPortada.Click += btnPortada_Click;
            btnPortada.MouseEnter += btnPortada_MouseEnter;
            btnPortada.MouseLeave += btnPortada_MouseLeave;
            // 
            // slogan
            // 
            slogan.BackColor = Color.Gray;
            slogan.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            slogan.ForeColor = Color.Transparent;
            slogan.Location = new Point(63, 250);
            slogan.Name = "slogan";
            slogan.Size = new Size(820, 54);
            slogan.TabIndex = 11;
            slogan.Text = "\"Con officetemas, tus ideas no tienen dilemas\"";
            slogan.TextAlign = ContentAlignment.TopCenter;
            slogan.UseMnemonic = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.LightGray;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(392, 319);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(232, 20);
            txtUsuario.TabIndex = 3;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = SystemColors.ButtonHighlight;
            labelUsuario.Location = new Point(298, 319);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(75, 22);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoOfficetemas;
            pictureBox1.Location = new Point(246, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 219);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // EntradaSistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 480);
            Controls.Add(panel1);
            Name = "EntradaSistema";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelUsuario;
        private TextBox txtUsuario;
        private Label slogan;
        private Button btnPortada;
        private Button btnCerrar;
        private Panel panelRayita;
        private Panel panelRayita2;
        private TextBox txtContra;
        private Label labelContraseña;
        private Button btnIngresar;
        private Button btnPausa;
        private Button btnReproducir;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer horaFecha;
    }
}