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
            label8 = new Label();
            tbFilasCol = new TextBox();
            tbTolerancia = new TextBox();
            tbIteraciones = new TextBox();
            label9 = new Label();
            cbMetodo = new ComboBox();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Ecuaciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 390);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Matriz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 300);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Iteraciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 300);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Tolerancia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 206);
            label5.Name = "label5";
            label5.Size = new Size(203, 20);
            label5.TabIndex = 4;
            label5.Text = "Cantidad de Filas y Columnas";
            // 
            // btnOptimizar
            // 
            btnOptimizar.Location = new Point(252, 244);
            btnOptimizar.Name = "btnOptimizar";
            btnOptimizar.Size = new Size(94, 29);
            btnOptimizar.TabIndex = 2;
            btnOptimizar.Text = "Optimizar";
            btnOptimizar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(180, 574);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(425, 29);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(469, 467);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 7;
            label6.Text = "=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 504);
            label7.Name = "label7";
            label7.Size = new Size(19, 20);
            label7.TabIndex = 8;
            label7.Text = "=";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(469, 538);
            label8.Name = "label8";
            label8.Size = new Size(19, 20);
            label8.TabIndex = 9;
            label8.Text = "=";
            label8.Click += label8_Click;
            // 
            // tbFilasCol
            // 
            tbFilasCol.Location = new Point(30, 244);
            tbFilasCol.Name = "tbFilasCol";
            tbFilasCol.Size = new Size(203, 27);
            tbFilasCol.TabIndex = 1;
            // 
            // tbTolerancia
            // 
            tbTolerancia.Location = new Point(30, 334);
            tbTolerancia.Name = "tbTolerancia";
            tbTolerancia.Size = new Size(203, 27);
            tbTolerancia.TabIndex = 3;
            // 
            // tbIteraciones
            // 
            tbIteraciones.Location = new Point(252, 334);
            tbIteraciones.Name = "tbIteraciones";
            tbIteraciones.Size = new Size(203, 27);
            tbIteraciones.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 124);
            label9.Name = "label9";
            label9.Size = new Size(160, 20);
            label9.TabIndex = 21;
            label9.Text = "Selecciona un metodo:";
            // 
            // cbMetodo
            // 
            cbMetodo.FormattingEnabled = true;
            cbMetodo.Location = new Point(30, 158);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(203, 28);
            cbMetodo.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, Column1, Column2 });
            dataGridView1.Location = new Point(26, 431);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(429, 128);
            dataGridView1.TabIndex = 23;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Y";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Z";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Matriz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 841);
            Controls.Add(dataGridView1);
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
            Name = "Matriz";
            Text = "Matriz";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label8;
        private TextBox tbFilasCol;
        private TextBox tbTolerancia;
        private TextBox tbIteraciones;
        private Label label9;
        private ComboBox cbMetodo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}