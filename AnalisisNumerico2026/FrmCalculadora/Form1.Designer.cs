namespace FrmCalculadora
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            txbFuncion = new TextBox();
            comboBox1 = new ComboBox();
            txbIteraciones = new TextBox();
            txbTolerancia = new TextBox();
            txbXi = new TextBox();
            txbXd = new TextBox();
            btnCalcular = new Button();
            txbFuncionU = new TextBox();
            txbMetodoU = new TextBox();
            txbIteracionesU = new TextBox();
            txbToleranciaU = new TextBox();
            txbIntervaloU = new TextBox();
            txbConverge = new TextBox();
            txbRaiz = new TextBox();
            txbError = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 72);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 0;
            label1.Text = "UNIDAD 1 - RAICES DE FUNCIONES";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(807, 142);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 142);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Grafico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 142);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 3;
            label4.Text = "Ingreso de Datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 202);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 4;
            label5.Text = "Ingresar Funcion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(786, 401);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 5;
            label6.Text = "Tolerancia Utilizada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(770, 335);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 6;
            label7.Text = "Iteraciones Realizadas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(786, 266);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 7;
            label8.Text = "Metodo Utilizado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(793, 202);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 8;
            label9.Text = "Funcion Utilizada";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(218, 525);
            label10.Name = "label10";
            label10.Size = new Size(25, 20);
            label10.TabIndex = 9;
            label10.Text = "xd";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 525);
            label11.Name = "label11";
            label11.Size = new Size(51, 20);
            label11.TabIndex = 10;
            label11.Text = "xi | xin";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(110, 472);
            label12.Name = "label12";
            label12.Size = new Size(124, 20);
            label12.TabIndex = 11;
            label12.Text = "Ingresar Intervalo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(101, 335);
            label13.Name = "label13";
            label13.Size = new Size(138, 20);
            label13.TabIndex = 12;
            label13.Text = "Ingresar Iteraciones";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(93, 401);
            label14.Name = "label14";
            label14.Size = new Size(134, 20);
            label14.TabIndex = 13;
            label14.Text = "Ingresar Tolerancia";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(101, 265);
            label15.Name = "label15";
            label15.Size = new Size(142, 20);
            label15.TabIndex = 14;
            label15.Text = "Seleccionar Metodo";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(911, 539);
            label16.Name = "label16";
            label16.Size = new Size(44, 20);
            label16.TabIndex = 15;
            label16.Text = "Raiz?";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(734, 539);
            label17.Name = "label17";
            label17.Size = new Size(79, 20);
            label17.TabIndex = 16;
            label17.Text = "Converge?";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(760, 472);
            label18.Name = "label18";
            label18.Size = new Size(184, 20);
            label18.TabIndex = 17;
            label18.Text = "Intervalo Utilizado (xi | xd)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(830, 615);
            label19.Name = "label19";
            label19.Size = new Size(41, 20);
            label19.TabIndex = 18;
            label19.Text = "Error";
            // 
            // txbFuncion
            // 
            txbFuncion.Location = new Point(107, 225);
            txbFuncion.Name = "txbFuncion";
            txbFuncion.Size = new Size(125, 27);
            txbFuncion.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(97, 288);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 20;
            // 
            // txbIteraciones
            // 
            txbIteraciones.Location = new Point(107, 358);
            txbIteraciones.Name = "txbIteraciones";
            txbIteraciones.Size = new Size(125, 27);
            txbIteraciones.TabIndex = 21;
            // 
            // txbTolerancia
            // 
            txbTolerancia.Location = new Point(107, 424);
            txbTolerancia.Name = "txbTolerancia";
            txbTolerancia.Size = new Size(125, 27);
            txbTolerancia.TabIndex = 22;
            // 
            // txbXi
            // 
            txbXi.Location = new Point(12, 495);
            txbXi.Name = "txbXi";
            txbXi.Size = new Size(125, 27);
            txbXi.TabIndex = 23;
            // 
            // txbXd
            // 
            txbXd.Location = new Point(172, 495);
            txbXd.Name = "txbXd";
            txbXd.Size = new Size(125, 27);
            txbXd.TabIndex = 24;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(120, 574);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 25;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txbFuncionU
            // 
            txbFuncionU.Location = new Point(790, 225);
            txbFuncionU.Name = "txbFuncionU";
            txbFuncionU.Size = new Size(125, 27);
            txbFuncionU.TabIndex = 26;
            // 
            // txbMetodoU
            // 
            txbMetodoU.Location = new Point(790, 289);
            txbMetodoU.Name = "txbMetodoU";
            txbMetodoU.Size = new Size(125, 27);
            txbMetodoU.TabIndex = 27;
            // 
            // txbIteracionesU
            // 
            txbIteracionesU.Location = new Point(790, 358);
            txbIteracionesU.Name = "txbIteracionesU";
            txbIteracionesU.Size = new Size(125, 27);
            txbIteracionesU.TabIndex = 28;
            // 
            // txbToleranciaU
            // 
            txbToleranciaU.Location = new Point(790, 424);
            txbToleranciaU.Name = "txbToleranciaU";
            txbToleranciaU.Size = new Size(125, 27);
            txbToleranciaU.TabIndex = 29;
            // 
            // txbIntervaloU
            // 
            txbIntervaloU.Location = new Point(790, 495);
            txbIntervaloU.Name = "txbIntervaloU";
            txbIntervaloU.Size = new Size(125, 27);
            txbIntervaloU.TabIndex = 30;
            // 
            // txbConverge
            // 
            txbConverge.Location = new Point(711, 562);
            txbConverge.Name = "txbConverge";
            txbConverge.Size = new Size(125, 27);
            txbConverge.TabIndex = 31;
            // 
            // txbRaiz
            // 
            txbRaiz.Location = new Point(873, 562);
            txbRaiz.Name = "txbRaiz";
            txbRaiz.Size = new Size(125, 27);
            txbRaiz.TabIndex = 32;
            // 
            // txbError
            // 
            txbError.Location = new Point(790, 638);
            txbError.Name = "txbError";
            txbError.Size = new Size(125, 27);
            txbError.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(351, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 302);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 708);
            Controls.Add(pictureBox1);
            Controls.Add(txbError);
            Controls.Add(txbRaiz);
            Controls.Add(txbConverge);
            Controls.Add(txbIntervaloU);
            Controls.Add(txbToleranciaU);
            Controls.Add(txbIteracionesU);
            Controls.Add(txbMetodoU);
            Controls.Add(txbFuncionU);
            Controls.Add(btnCalcular);
            Controls.Add(txbXd);
            Controls.Add(txbXi);
            Controls.Add(txbTolerancia);
            Controls.Add(txbIteraciones);
            Controls.Add(comboBox1);
            Controls.Add(txbFuncion);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txbFuncion;
        private ComboBox comboBox1;
        private TextBox txbIteraciones;
        private TextBox txbTolerancia;
        private TextBox txbXi;
        private TextBox txbXd;
        private Button btnCalcular;
        private TextBox txbFuncionU;
        private TextBox txbMetodoU;
        private TextBox txbIteracionesU;
        private TextBox txbToleranciaU;
        private TextBox txbIntervaloU;
        private TextBox txbConverge;
        private TextBox txbRaiz;
        private TextBox txbError;
        private PictureBox pictureBox1;
    }
}
