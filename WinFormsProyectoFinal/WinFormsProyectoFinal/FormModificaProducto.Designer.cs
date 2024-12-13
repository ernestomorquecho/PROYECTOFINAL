namespace WinFormsAppIdeaProy
{
    partial class FormModificaProducto
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
            comboBoxCategoriaModf = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            textBoxStock = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxPrecioUn = new TextBox();
            textBoxNomProd = new TextBox();
            labelOption = new Label();
            buttonModf = new Button();
            label5 = new Label();
            textBoxDescrp = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 39);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "Form para modificar datos ";
            label1.Click += label1_Click;
            // 
            // comboBoxCategoriaModf
            // 
            comboBoxCategoriaModf.FormattingEnabled = true;
            comboBoxCategoriaModf.Location = new Point(257, 289);
            comboBoxCategoriaModf.Margin = new Padding(3, 4, 3, 4);
            comboBoxCategoriaModf.Name = "comboBoxCategoriaModf";
            comboBoxCategoriaModf.Size = new Size(122, 28);
            comboBoxCategoriaModf.TabIndex = 38;
            comboBoxCategoriaModf.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 297);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 37;
            label6.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 248);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 36;
            label4.Text = "Stock disponible";
            // 
            // textBoxStock
            // 
            textBoxStock.Location = new Point(257, 241);
            textBoxStock.Margin = new Padding(3, 4, 3, 4);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(122, 27);
            textBoxStock.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 195);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 34;
            label3.Text = "Precio unitario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 100);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 33;
            label2.Text = "Nombre del producto";
            // 
            // textBoxPrecioUn
            // 
            textBoxPrecioUn.Location = new Point(257, 188);
            textBoxPrecioUn.Margin = new Padding(3, 4, 3, 4);
            textBoxPrecioUn.Name = "textBoxPrecioUn";
            textBoxPrecioUn.Size = new Size(122, 27);
            textBoxPrecioUn.TabIndex = 32;
            // 
            // textBoxNomProd
            // 
            textBoxNomProd.Location = new Point(257, 93);
            textBoxNomProd.Margin = new Padding(3, 4, 3, 4);
            textBoxNomProd.Name = "textBoxNomProd";
            textBoxNomProd.Size = new Size(122, 27);
            textBoxNomProd.TabIndex = 31;
            textBoxNomProd.TextChanged += textBoxNomProd_TextChanged;
            // 
            // labelOption
            // 
            labelOption.AutoSize = true;
            labelOption.Location = new Point(321, 39);
            labelOption.Name = "labelOption";
            labelOption.Size = new Size(49, 20);
            labelOption.TabIndex = 39;
            labelOption.Text = "          ";
            // 
            // buttonModf
            // 
            buttonModf.Location = new Point(176, 353);
            buttonModf.Margin = new Padding(3, 4, 3, 4);
            buttonModf.Name = "buttonModf";
            buttonModf.Size = new Size(126, 39);
            buttonModf.TabIndex = 40;
            buttonModf.Text = "Modificar";
            buttonModf.UseVisualStyleBackColor = true;
            buttonModf.Click += buttonModf_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 144);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 42;
            label5.Text = "Descripcion";
            // 
            // textBoxDescrp
            // 
            textBoxDescrp.Location = new Point(257, 137);
            textBoxDescrp.Margin = new Padding(3, 4, 3, 4);
            textBoxDescrp.Name = "textBoxDescrp";
            textBoxDescrp.Size = new Size(122, 27);
            textBoxDescrp.TabIndex = 41;
            // 
            // button1
            // 
            button1.Location = new Point(55, 452);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 43;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(360, 457);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 44;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormModificaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 533);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBoxDescrp);
            Controls.Add(buttonModf);
            Controls.Add(labelOption);
            Controls.Add(comboBoxCategoriaModf);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(textBoxStock);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPrecioUn);
            Controls.Add(textBoxNomProd);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormModificaProducto";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCategoriaModf;
        private Label label6;
        private Label label4;
        private TextBox textBoxStock;
        private Label label3;
        private Label label2;
        private TextBox textBoxPrecioUn;
        private TextBox textBoxNomProd;
        private Label labelOption;
        private Button buttonModf;
        private Label label5;
        private TextBox textBoxDescrp;
        private Button button1;
        private Button button2;
    }
}