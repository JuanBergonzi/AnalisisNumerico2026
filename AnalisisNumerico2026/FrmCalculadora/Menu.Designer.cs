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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnMatriz
            // 
            btnMatriz.Location = new Point(132, 201);
            btnMatriz.Name = "btnMatriz";
            btnMatriz.Size = new Size(170, 29);
            btnMatriz.TabIndex = 0;
            btnMatriz.Text = "Calcular Matrices";
            btnMatriz.UseVisualStyleBackColor = true;
            btnMatriz.Click += btnMatriz_Click;
            // 
            // btnRaices
            // 
            btnRaices.Location = new Point(448, 201);
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
            label1.Location = new Point(278, 108);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccione que desea calcular";
            // 
            // button1
            // 
            button1.Location = new Point(448, 274);
            button1.Name = "button1";
            button1.Size = new Size(170, 29);
            button1.TabIndex = 3;
            button1.Text = "Calcular Intregaciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(132, 274);
            button2.Name = "button2";
            button2.Size = new Size(170, 29);
            button2.TabIndex = 4;
            button2.Text = "Calcular Lineales";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
    }
}