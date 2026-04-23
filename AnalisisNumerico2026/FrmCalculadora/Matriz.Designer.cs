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
            tbTolerancia = new TextBox();
            tbIteraciones = new TextBox();
            label9 = new Label();
            cbMetodo = new ComboBox();
            panelMatriz = new Panel();
            btnLimpiar = new Button();
            tbFilasCol = new NumericUpDown();
            btnRedondearMatriz = new Button();
            btnRedondearResultados = new Button();
            tbDecimalesMatriz = new NumericUpDown();
            tbDecimalesResultados = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)tbFilasCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDecimalesMatriz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDecimalesResultados).BeginInit();
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
            label2.Location = new Point(26, 251);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Matriz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(843, 93);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Iteraciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(692, 93);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Tolerancia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 93);
            label5.Name = "label5";
            label5.Size = new Size(163, 15);
            label5.TabIndex = 4;
            label5.Text = "Cantidad de Filas y Columnas";
            // 
            // btnOptimizar
            // 
            btnOptimizar.Location = new Point(536, 118);
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
            btnCalcular.Location = new Point(26, 578);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(372, 22);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tbTolerancia
            // 
            tbTolerancia.Location = new Point(692, 119);
            tbTolerancia.Margin = new Padding(3, 2, 3, 2);
            tbTolerancia.Name = "tbTolerancia";
            tbTolerancia.Size = new Size(61, 23);
            tbTolerancia.TabIndex = 3;
            tbTolerancia.Text = "0,0001";
            // 
            // tbIteraciones
            // 
            tbIteraciones.Location = new Point(843, 119);
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
            panelMatriz.Location = new Point(26, 269);
            panelMatriz.Name = "panelMatriz";
            panelMatriz.Size = new Size(1069, 285);
            panelMatriz.TabIndex = 23;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(938, 578);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tbFilasCol
            // 
            tbFilasCol.Location = new Point(352, 118);
            tbFilasCol.Name = "tbFilasCol";
            tbFilasCol.Size = new Size(163, 23);
            tbFilasCol.TabIndex = 25;
            // 
            // btnRedondearMatriz
            // 
            btnRedondearMatriz.Location = new Point(497, 578);
            btnRedondearMatriz.Name = "btnRedondearMatriz";
            btnRedondearMatriz.Size = new Size(165, 23);
            btnRedondearMatriz.TabIndex = 26;
            btnRedondearMatriz.Text = "Redondear Matriz";
            btnRedondearMatriz.UseVisualStyleBackColor = true;
            btnRedondearMatriz.Click += btnRedondearMatriz_Click;
            // 
            // btnRedondearResultados
            // 
            btnRedondearResultados.Location = new Point(730, 578);
            btnRedondearResultados.Name = "btnRedondearResultados";
            btnRedondearResultados.Size = new Size(166, 23);
            btnRedondearResultados.TabIndex = 27;
            btnRedondearResultados.Text = "Redondear Resultados";
            btnRedondearResultados.UseVisualStyleBackColor = true;
            btnRedondearResultados.Click += btnRedondearResultados_Click;
            // 
            // tbDecimalesMatriz
            // 
            tbDecimalesMatriz.Location = new Point(455, 577);
            tbDecimalesMatriz.Name = "tbDecimalesMatriz";
            tbDecimalesMatriz.Size = new Size(36, 23);
            tbDecimalesMatriz.TabIndex = 28;
            // 
            // tbDecimalesResultados
            // 
            tbDecimalesResultados.Location = new Point(690, 577);
            tbDecimalesResultados.Name = "tbDecimalesResultados";
            tbDecimalesResultados.Size = new Size(34, 23);
            tbDecimalesResultados.TabIndex = 29;
            // 
            // Matriz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(tbDecimalesResultados);
            Controls.Add(tbDecimalesMatriz);
            Controls.Add(btnRedondearResultados);
            Controls.Add(btnRedondearMatriz);
            Controls.Add(tbFilasCol);
            Controls.Add(btnLimpiar);
            Controls.Add(panelMatriz);
            Controls.Add(cbMetodo);
            Controls.Add(label9);
            Controls.Add(tbIteraciones);
            Controls.Add(tbTolerancia);
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
            ((System.ComponentModel.ISupportInitialize)tbFilasCol).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDecimalesMatriz).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDecimalesResultados).EndInit();
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
        private TextBox tbTolerancia;
        private TextBox tbIteraciones;
        private Label label9;
        private ComboBox cbMetodo;
        private Panel panelMatriz;
        private Button btnLimpiar;
        private NumericUpDown tbFilasCol;
        private Button btnRedondearMatriz;
        private Button btnRedondearResultados;
        private NumericUpDown tbDecimalesMatriz;
        private NumericUpDown tbDecimalesResultados;
    }
}