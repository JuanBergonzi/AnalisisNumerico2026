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
<<<<<<< HEAD
            btnRegresion = new Button();
=======
            button1 = new Button();
            button2 = new Button();
>>>>>>> Trapecios
            SuspendLayout();
            // 
            // btnMatriz
            // 
<<<<<<< HEAD
            btnMatriz.Location = new Point(133, 208);
            btnMatriz.Margin = new Padding(3, 2, 3, 2);
=======
            btnMatriz.Location = new Point(132, 201);
>>>>>>> Trapecios
            btnMatriz.Name = "btnMatriz";
            btnMatriz.Size = new Size(149, 22);
            btnMatriz.TabIndex = 0;
            btnMatriz.Text = "Calcular Matrices";
            btnMatriz.UseVisualStyleBackColor = true;
            btnMatriz.Click += btnMatriz_Click;
            // 
            // btnRaices
            // 
<<<<<<< HEAD
            btnRaices.Location = new Point(410, 208);
            btnRaices.Margin = new Padding(3, 2, 3, 2);
=======
            btnRaices.Location = new Point(448, 201);
>>>>>>> Trapecios
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
<<<<<<< HEAD
            label1.Location = new Point(261, 139);
=======
            label1.Location = new Point(278, 108);
>>>>>>> Trapecios
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione que desea calcular";
            // 
<<<<<<< HEAD
            // btnRegresion
            // 
            btnRegresion.Location = new Point(133, 272);
            btnRegresion.Name = "btnRegresion";
            btnRegresion.Size = new Size(149, 23);
            btnRegresion.TabIndex = 3;
            btnRegresion.Text = "Calcular Regresión";
            btnRegresion.UseVisualStyleBackColor = true;
            btnRegresion.Click += btnRegresion_Click;
=======
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
>>>>>>> Trapecios
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(700, 338);
            Controls.Add(btnRegresion);
=======
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
>>>>>>> Trapecios
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
<<<<<<< HEAD
        private Button btnRegresion;
=======
        private Button button1;
        private Button button2;
>>>>>>> Trapecios
    }
}