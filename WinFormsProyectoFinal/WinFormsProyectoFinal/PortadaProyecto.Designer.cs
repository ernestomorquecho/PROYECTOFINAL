namespace WinFormsProyectoFinal
{
    partial class PortadaProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortadaProyecto));
            panelImagenGrande = new Panel();
            btnIniciar = new Button();
            btnSalir = new Button();
            slogan = new Label();
            labelCarrera = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            labelFecha = new Label();
            labelEmiliano = new Label();
            labelErnesto = new Label();
            labelJesus = new Label();
            labelJose = new Label();
            pictureBox2 = new PictureBox();
            panelImagenGrande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelImagenGrande
            // 
            panelImagenGrande.Anchor = AnchorStyles.None;
            panelImagenGrande.BackColor = Color.Gray;
            panelImagenGrande.Controls.Add(btnIniciar);
            panelImagenGrande.Controls.Add(btnSalir);
            panelImagenGrande.Controls.Add(slogan);
            panelImagenGrande.Controls.Add(labelCarrera);
            panelImagenGrande.Controls.Add(label2);
            panelImagenGrande.Controls.Add(pictureBox3);
            panelImagenGrande.Controls.Add(label1);
            panelImagenGrande.Controls.Add(labelFecha);
            panelImagenGrande.Controls.Add(labelEmiliano);
            panelImagenGrande.Controls.Add(labelErnesto);
            panelImagenGrande.Controls.Add(labelJesus);
            panelImagenGrande.Controls.Add(labelJose);
            panelImagenGrande.Controls.Add(pictureBox2);
            panelImagenGrande.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelImagenGrande.Location = new Point(8, 1);
            panelImagenGrande.Name = "panelImagenGrande";
            panelImagenGrande.Size = new Size(1224, 606);
            panelImagenGrande.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = SystemColors.ButtonHighlight;
            btnIniciar.Location = new Point(497, 433);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(253, 46);
            btnIniciar.TabIndex = 12;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            btnIniciar.MouseEnter += btnIniciar_MouseEnter;
            btnIniciar.MouseLeave += btnIniciar_MouseLeave;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(1110, 551);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 41);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseEnter += btnSalir_MouseEnter;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            // 
            // slogan
            // 
            slogan.BackColor = Color.Gray;
            slogan.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            slogan.ForeColor = Color.Transparent;
            slogan.Location = new Point(196, 265);
            slogan.Name = "slogan";
            slogan.Size = new Size(824, 54);
            slogan.TabIndex = 10;
            slogan.Text = "\"Con officetemas, tus ideas no tienen dilemas\"";
            slogan.TextAlign = ContentAlignment.TopCenter;
            slogan.UseMnemonic = false;
            // 
            // labelCarrera
            // 
            labelCarrera.AutoSize = true;
            labelCarrera.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarrera.ForeColor = Color.White;
            labelCarrera.Location = new Point(429, 331);
            labelCarrera.Name = "labelCarrera";
            labelCarrera.Size = new Size(378, 28);
            labelCarrera.TabIndex = 9;
            labelCarrera.Text = "Ing. Sistemas Computacionales\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(468, 376);
            label2.Name = "label2";
            label2.Size = new Size(310, 24);
            label2.TabIndex = 8;
            label2.Text = "Dra. Georgina Salazar Partida";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoOfficetemas;
            pictureBox3.Location = new Point(342, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(539, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 568);
            label1.Name = "label1";
            label1.Size = new Size(343, 21);
            label1.TabIndex = 6;
            label1.Text = "Juan Carlos Uriarte Padilla 281537 3°B";
            // 
            // labelFecha
            // 
            labelFecha.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(12, 9);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(213, 26);
            labelFecha.TabIndex = 5;
            labelFecha.Text = "Fecha: 17/12/2024";
            // 
            // labelEmiliano
            // 
            labelEmiliano.AutoSize = true;
            labelEmiliano.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            labelEmiliano.ForeColor = Color.White;
            labelEmiliano.Location = new Point(12, 536);
            labelEmiliano.Name = "labelEmiliano";
            labelEmiliano.Size = new Size(414, 21);
            labelEmiliano.TabIndex = 4;
            labelEmiliano.Text = "Emiliano de Jesus Esparza Ramirez 336604 3°C";
            // 
            // labelErnesto
            // 
            labelErnesto.AutoSize = true;
            labelErnesto.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            labelErnesto.ForeColor = Color.White;
            labelErnesto.Location = new Point(12, 468);
            labelErnesto.Name = "labelErnesto";
            labelErnesto.Size = new Size(419, 21);
            labelErnesto.TabIndex = 3;
            labelErnesto.Text = "Ernesto Alonso Morquecho Canales 351214 3°B";
            // 
            // labelJesus
            // 
            labelJesus.AutoSize = true;
            labelJesus.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            labelJesus.ForeColor = Color.White;
            labelJesus.Location = new Point(12, 502);
            labelJesus.Name = "labelJesus";
            labelJesus.Size = new Size(373, 21);
            labelJesus.TabIndex = 2;
            labelJesus.Text = "Jesus Alberto Damasco Lopez 345820 3°B";
            // 
            // labelJose
            // 
            labelJose.AutoSize = true;
            labelJose.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJose.ForeColor = Color.White;
            labelJose.Location = new Point(12, 433);
            labelJose.Name = "labelJose";
            labelJose.Size = new Size(402, 21);
            labelJose.TabIndex = 1;
            labelJose.Text = "Jose Alejandro Contreras Becerra 350876 3°C";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(937, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PortadaProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 607);
            Controls.Add(panelImagenGrande);
            Name = "PortadaProyecto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelImagenGrande.ResumeLayout(false);
            panelImagenGrande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelImagenGrande;
        private Label labelFecha;
        private Label labelEmiliano;
        private Label labelErnesto;
        private Label labelJesus;
        private Label labelJose;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label labelCarrera;
        private Label label2;
        private Label slogan;
        private Button btnSalir;
        private Button btnIniciar;
    }
}
