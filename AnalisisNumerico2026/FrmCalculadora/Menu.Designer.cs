namespace Front
{
    partial class Menu
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
            btnMatriz = new Button();
            btnRaices = new Button();
            label1 = new Label();
            btnRegresion = new Button();
            SuspendLayout();
            // 
            // btnMatriz
            // 
            btnMatriz.Location = new Point(133, 208);
            btnMatriz.Margin = new Padding(3, 2, 3, 2);
            btnMatriz.Name = "btnMatriz";
            btnMatriz.Size = new Size(149, 22);
            btnMatriz.TabIndex = 0;
            btnMatriz.Text = "Calcular Matrices";
            btnMatriz.UseVisualStyleBackColor = true;
            btnMatriz.Click += btnMatriz_Click;
            // 
            // btnRaices
            // 
            btnRaices.Location = new Point(410, 208);
            btnRaices.Margin = new Padding(3, 2, 3, 2);
            btnRaices.Name = "btnRaices";
            btnRaices.Size = new Size(149, 22);
            btnRaices.TabIndex = 1;
            btnRaices.Text = "Calcular Raices";
            btnRaices.UseVisualStyleBackColor = true;
            btnRaices.Click += btnRaices_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 139);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione que desea calcular";
            // 
            // btnRegresion
            // 
            btnRegresion.Location = new Point(133, 272);
            btnRegresion.Name = "btnRegresion";
            btnRegresion.Size = new Size(149, 23);
            btnRegresion.TabIndex = 3;
            btnRegresion.Text = "Calcular Regresión";
            btnRegresion.UseVisualStyleBackColor = true;
            btnRegresion.Click += btnRegresion_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnRegresion);
            Controls.Add(label1);
            Controls.Add(btnRaices);
            Controls.Add(btnMatriz);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMatriz;
        private Button btnRaices;
        private Label label1;
        private Button btnRegresion;
    }
}