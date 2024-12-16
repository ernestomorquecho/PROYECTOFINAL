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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortadaProyecto));
            panelImagenGrande = new Panel();
            label4 = new Label();
            label3 = new Label();
            btnIniciar = new Button();
            btnSalir = new Button();
            labelCarrera = new Label();
            label2 = new Label();
            label1 = new Label();
            labelFecha = new Label();
            labelEmiliano = new Label();
            labelErnesto = new Label();
            labelJesus = new Label();
            labelJose = new Label();
            pictureBox2 = new PictureBox();
            lblHora = new Label();
            lblFecha = new Label();
            fechaHora = new System.Windows.Forms.Timer(components);
            panelImagenGrande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelImagenGrande
            // 
            panelImagenGrande.Anchor = AnchorStyles.None;
            panelImagenGrande.BackColor = Color.Gray;
            panelImagenGrande.Controls.Add(lblFecha);
            panelImagenGrande.Controls.Add(lblHora);
            panelImagenGrande.Controls.Add(label4);
            panelImagenGrande.Controls.Add(label3);
            panelImagenGrande.Controls.Add(btnIniciar);
            panelImagenGrande.Controls.Add(btnSalir);
            panelImagenGrande.Controls.Add(labelCarrera);
            panelImagenGrande.Controls.Add(label2);
            panelImagenGrande.Controls.Add(label1);
            panelImagenGrande.Controls.Add(labelFecha);
            panelImagenGrande.Controls.Add(labelEmiliano);
            panelImagenGrande.Controls.Add(labelErnesto);
            panelImagenGrande.Controls.Add(labelJesus);
            panelImagenGrande.Controls.Add(labelJose);
            panelImagenGrande.Controls.Add(pictureBox2);
            panelImagenGrande.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelImagenGrande.Location = new Point(-115, 0);
            panelImagenGrande.Name = "panelImagenGrande";
            panelImagenGrande.Size = new Size(1121, 658);
            panelImagenGrande.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(411, 323);
            label4.Name = "label4";
            label4.Size = new Size(366, 24);
            label4.TabIndex = 14;
            label4.Text = "Nombre del sistema: OFFICETEMAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(411, 359);
            label3.Name = "label3";
            label3.Size = new Size(406, 24);
            label3.TabIndex = 13;
            label3.Text = "Docente: Dra. Georgina Salazar Partida";
            // 
            // btnIniciar
            // 
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = SystemColors.ButtonHighlight;
            btnIniciar.Location = new Point(491, 576);
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
            btnSalir.Location = new Point(994, 576);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 46);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseEnter += btnSalir_MouseEnter;
            btnSalir.MouseLeave += btnSalir_MouseLeave;
            // 
            // labelCarrera
            // 
            labelCarrera.AutoSize = true;
            labelCarrera.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarrera.ForeColor = Color.White;
            labelCarrera.Location = new Point(422, 246);
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
            label2.Location = new Point(477, 285);
            label2.Name = "label2";
            label2.Size = new Size(267, 24);
            label2.TabIndex = 8;
            label2.Text = "Materia: Programación II";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(411, 533);
            label1.Name = "label1";
            label1.Size = new Size(343, 21);
            label1.TabIndex = 6;
            label1.Text = "Juan Carlos Uriarte Padilla 281537 3°B";
            // 
            // labelFecha
            // 
            labelFecha.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(127, 9);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(183, 26);
            labelFecha.TabIndex = 5;
            labelFecha.Text = "Fecha: 17/12/2024";
            // 
            // labelEmiliano
            // 
            labelEmiliano.AutoSize = true;
            labelEmiliano.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            labelEmiliano.ForeColor = Color.White;
            labelEmiliano.Location = new Point(411, 501);
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
            labelErnesto.Location = new Point(411, 433);
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
            labelJesus.Location = new Point(411, 467);
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
            labelJose.Location = new Point(411, 398);
            labelJose.Name = "labelJose";
            labelJose.Size = new Size(402, 21);
            labelJose.TabIndex = 1;
            labelJose.Text = "Jose Alejandro Contreras Becerra 350876 3°C";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(316, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(578, 234);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.ForeColor = SystemColors.ButtonFace;
            lblHora.Location = new Point(154, 567);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(68, 28);
            lblHora.TabIndex = 15;
            lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = SystemColors.ButtonFace;
            lblFecha.Location = new Point(154, 595);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(80, 28);
            lblFecha.TabIndex = 16;
            lblFecha.Text = "Fecha";
            // 
            // fechaHora
            // 
            fechaHora.Enabled = true;
            fechaHora.Tick += fechaHora_Tick;
            // 
            // PortadaProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 658);
            Controls.Add(panelImagenGrande);
            Name = "PortadaProyecto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelImagenGrande.ResumeLayout(false);
            panelImagenGrande.PerformLayout();
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
        private Label labelCarrera;
        private Label label2;
        private Button btnSalir;
        private Button btnIniciar;
        private Label label4;
        private Label label3;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer fechaHora;
    }
}
