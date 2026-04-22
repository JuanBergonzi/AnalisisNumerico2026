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
            SuspendLayout();
            // 
            // btnMatriz
            // 
            btnMatriz.Location = new Point(152, 278);
            btnMatriz.Name = "btnMatriz";
            btnMatriz.Size = new Size(170, 29);
            btnMatriz.TabIndex = 0;
            btnMatriz.Text = "Calcular Matrices";
            btnMatriz.UseVisualStyleBackColor = true;
            btnMatriz.Click += btnMatriz_Click;
            // 
            // btnRaices
            // 
            btnRaices.Location = new Point(468, 278);
            btnRaices.Name = "btnRaices";
            btnRaices.Size = new Size(170, 29);
            btnRaices.TabIndex = 1;
            btnRaices.Text = "Calcular Raices";
            btnRaices.UseVisualStyleBackColor = true;
            btnRaices.Click += btnRaices_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 185);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccione que desea calcular";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRaices);
            Controls.Add(btnMatriz);
            Name = "Menu";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMatriz;
        private Button btnRaices;
        private Label label1;
    }
}