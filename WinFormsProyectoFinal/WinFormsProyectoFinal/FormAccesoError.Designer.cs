namespace WinFormsProyectoFinal
{
    partial class FormAccesoError
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
            lbl1 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(327, 37);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(127, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "¡Acceso no autorizado!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 87);
            label1.Name = "label1";
            label1.Size = new Size(327, 15);
            label1.TabIndex = 1;
            label1.Text = "Verifica que la cuenta seleccionada y la contraseña coincidan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 130);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(73, 163);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 3;
            button1.Text = "Salir del sistema";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(545, 163);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 4;
            button2.Text = "Volver a intentarlo";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormAccesoError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 222);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl1);
            Name = "FormAccesoError";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}