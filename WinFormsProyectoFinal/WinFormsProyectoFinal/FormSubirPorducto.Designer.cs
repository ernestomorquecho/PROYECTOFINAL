namespace WinFormsAppIdeaProy
{
    partial class FormSubirPorducto
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
            label1 = new Label();
            textBoxNomProd = new TextBox();
            textBoxPrecioUn = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxStock = new TextBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            comboBoxCategoria = new ComboBox();
            label7 = new Label();
            textBoxDescrip = new TextBox();
            btnRegresar = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 22);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "Form para añadir productos";
            // 
            // textBoxNomProd
            // 
            textBoxNomProd.Location = new Point(151, 75);
            textBoxNomProd.Name = "textBoxNomProd";
            textBoxNomProd.PlaceholderText = "Nom Prod";
            textBoxNomProd.Size = new Size(138, 23);
            textBoxNomProd.TabIndex = 21;
            // 
            // textBoxPrecioUn
            // 
            textBoxPrecioUn.Location = new Point(151, 146);
            textBoxPrecioUn.Name = "textBoxPrecioUn";
            textBoxPrecioUn.PlaceholderText = "$";
            textBoxPrecioUn.Size = new Size(138, 23);
            textBoxPrecioUn.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 78);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 23;
            label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 149);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 24;
            label3.Text = "Precio unitario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 189);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 26;
            label4.Text = "Stock disponible";
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(151, 186);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.PlaceholderText = "pz";
            textBoxStock.Size = new Size(138, 23);
            textBoxStock.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(340, 58);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 27;
            label5.Text = "Seleccionar Imagen";
            // 
            // button1
            // 
            button1.Location = new Point(212, 263);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 28;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 225);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 29;
            label6.Text = "Categoria";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(151, 222);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(138, 23);
            comboBoxCategoria.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 110);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 32;
            label7.Text = "Descipcion";
            // 
            // textBoxDescrip
            // 
            textBoxDescrip.Location = new Point(151, 107);
            textBoxDescrip.Name = "textBoxDescrip";
            textBoxDescrip.PlaceholderText = "Descripcion";
            textBoxDescrip.Size = new Size(138, 23);
            textBoxDescrip.TabIndex = 31;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(42, 336);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 33;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(375, 336);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 34;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormSubirPorducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 402);
            Controls.Add(btnLogout);
            Controls.Add(btnRegresar);
            Controls.Add(label7);
            Controls.Add(textBoxDescrip);
            Controls.Add(comboBoxCategoria);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxStock);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPrecioUn);
            Controls.Add(textBoxNomProd);
            Controls.Add(label1);
            Name = "FormSubirPorducto";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNomProd;
        private TextBox textBoxPrecioUn;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxStock;
        private Label label5;
        private Button button1;
        private Label label6;
        private ComboBox comboBoxCategoria;
        private Label label7;
        private TextBox textBoxDescrip;
        private Button btnRegresar;
        private Button btnLogout;
    }
}