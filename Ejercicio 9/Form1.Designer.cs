namespace Ejercicio_9
{
    partial class Form1
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
            a = new TextBox();
            b = new TextBox();
            c = new TextBox();
            label2 = new Label();
            button1 = new Button();
            resultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(247, 47);
            label1.Name = "label1";
            label1.Size = new Size(303, 37);
            label1.TabIndex = 0;
            label1.Text = "¿Qué número es mayor?";
            // 
            // a
            // 
            a.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            a.Location = new Point(67, 189);
            a.MaximumSize = new Size(150, 100);
            a.Multiline = true;
            a.Name = "a";
            a.Size = new Size(150, 100);
            a.TabIndex = 1;
            a.TextAlign = HorizontalAlignment.Center;
            // 
            // b
            // 
            b.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            b.Location = new Point(335, 189);
            b.MaximumSize = new Size(150, 100);
            b.Multiline = true;
            b.Name = "b";
            b.Size = new Size(150, 100);
            b.TabIndex = 1;
            b.TextAlign = HorizontalAlignment.Center;
            // 
            // c
            // 
            c.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            c.Location = new Point(609, 189);
            c.MaximumSize = new Size(150, 100);
            c.Multiline = true;
            c.Name = "c";
            c.Size = new Size(150, 100);
            c.TabIndex = 1;
            c.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 126);
            label2.Name = "label2";
            label2.Size = new Size(207, 31);
            label2.TabIndex = 2;
            label2.Text = "Ingrese 3 números:";
            // 
            // button1
            // 
            button1.Location = new Point(201, 422);
            button1.Name = "button1";
            button1.Size = new Size(123, 50);
            button1.TabIndex = 3;
            button1.Text = "Hallar el número mayor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultado
            // 
            resultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            resultado.Location = new Point(361, 406);
            resultado.MaximumSize = new Size(150, 100);
            resultado.Multiline = true;
            resultado.Name = "resultado";
            resultado.ReadOnly = true;
            resultado.Size = new Size(143, 80);
            resultado.TabIndex = 1;
            resultado.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(c);
            Controls.Add(b);
            Controls.Add(resultado);
            Controls.Add(a);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox a;
        private TextBox b;
        private TextBox c;
        private Label label2;
        private Button button1;
        private TextBox resultado;
    }
}