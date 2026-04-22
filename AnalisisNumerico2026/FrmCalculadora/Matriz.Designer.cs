namespace Front
{
    partial class Matriz
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnOptimizar = new Button();
            btnCalcular = new Button();
            label6 = new Label();
            label7 = new Label();
            tbFilasCol = new TextBox();
            tbTolerancia = new TextBox();
            tbIteraciones = new TextBox();
            label9 = new Label();
            cbMetodo = new ComboBox();
            panelMatriz = new Panel();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Ecuaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 292);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Matriz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 225);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Iteraciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 225);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Tolerancia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 154);
            label5.Name = "label5";
            label5.Size = new Size(163, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad de Filas y Columnas";
            // 
            // btnOptimizar
            // 
            btnOptimizar.Location = new Point(220, 183);
            btnOptimizar.Margin = new Padding(3, 2, 3, 2);
            btnOptimizar.Name = "btnOptimizar";
            btnOptimizar.Size = new Size(82, 22);
            btnOptimizar.TabIndex = 2;
            btnOptimizar.Text = "Optimizar";
            btnOptimizar.UseVisualStyleBackColor = true;
            btnOptimizar.Click += btnOptimizar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(26, 440);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(372, 22);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 318);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 7;
            label6.Text = "=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 346);
            label7.Name = "label7";
            label7.Size = new Size(15, 15);
            label7.TabIndex = 8;
            label7.Text = "=";
            // 
            // tbFilasCol
            // 
            tbFilasCol.Location = new Point(26, 183);
            tbFilasCol.Margin = new Padding(3, 2, 3, 2);
            tbFilasCol.Name = "tbFilasCol";
            tbFilasCol.Size = new Size(178, 23);
            tbFilasCol.TabIndex = 1;
            // 
            // tbTolerancia
            // 
            tbTolerancia.Location = new Point(26, 250);
            tbTolerancia.Margin = new Padding(3, 2, 3, 2);
            tbTolerancia.Name = "tbTolerancia";
            tbTolerancia.Size = new Size(178, 23);
            tbTolerancia.TabIndex = 3;
            // 
            // tbIteraciones
            // 
            tbIteraciones.Location = new Point(220, 250);
            tbIteraciones.Margin = new Padding(3, 2, 3, 2);
            tbIteraciones.Name = "tbIteraciones";
            tbIteraciones.Size = new Size(178, 23);
            tbIteraciones.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 93);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 21;
            label9.Text = "Selecciona un metodo:";
            // 
            // cbMetodo
            // 
            cbMetodo.FormattingEnabled = true;
            cbMetodo.Location = new Point(26, 118);
            cbMetodo.Margin = new Padding(3, 2, 3, 2);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(178, 23);
            cbMetodo.TabIndex = 22;
            // 
            // panelMatriz
            // 
            panelMatriz.Location = new Point(26, 310);
            panelMatriz.Name = "panelMatriz";
            panelMatriz.Size = new Size(247, 100);
            panelMatriz.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 371);
            label8.Name = "label8";
            label8.Size = new Size(15, 15);
            label8.TabIndex = 9;
            label8.Text = "=";
            // 
            // Matriz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 473);
            Controls.Add(panelMatriz);
            Controls.Add(cbMetodo);
            Controls.Add(label9);
            Controls.Add(tbIteraciones);
            Controls.Add(tbTolerancia);
            Controls.Add(tbFilasCol);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnCalcular);
            Controls.Add(btnOptimizar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Matriz";
            Text = "Matriz";
            Load += Matriz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnOptimizar;
        private Button btnCalcular;
        private Label label6;
        private Label label7;
        private TextBox tbFilasCol;
        private TextBox tbTolerancia;
        private TextBox tbIteraciones;
        private Label label9;
        private ComboBox cbMetodo;
        private Panel panelMatriz;
        private Label label8;
    }
}