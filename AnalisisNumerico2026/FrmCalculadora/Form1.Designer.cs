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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gbDatos = new GroupBox();
            btnCalcular = new Button();
            txbXd = new TextBox();
            label6 = new Label();
            txbXi = new TextBox();
            label5 = new Label();
            txbTolerancia = new TextBox();
            Tolerancia = new Label();
            txbIteraciones = new TextBox();
            label4 = new Label();
            cbMetodo = new ComboBox();
            label3 = new Label();
            cmMet = new ComboBox();
            label2 = new Label();
            txbFuncion = new TextBox();
            label1 = new Label();
            gbGrafico = new GroupBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            gbResultado = new GroupBox();
            pictureBox1 = new PictureBox();
            txbError = new TextBox();
            Error = new Label();
            txbRaiz = new TextBox();
            label8 = new Label();
            txbConverge = new TextBox();
            txbIntervaloU = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txbIteracionesU = new TextBox();
            label13 = new Label();
            gbDatos.SuspendLayout();
            gbGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            gbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbDatos
            // 
            gbDatos.BackColor = Color.Transparent;
            gbDatos.Controls.Add(btnCalcular);
            gbDatos.Controls.Add(txbXd);
            gbDatos.Controls.Add(label6);
            gbDatos.Controls.Add(txbXi);
            gbDatos.Controls.Add(label5);
            gbDatos.Controls.Add(txbTolerancia);
            gbDatos.Controls.Add(Tolerancia);
            gbDatos.Controls.Add(txbIteraciones);
            gbDatos.Controls.Add(label4);
            gbDatos.Controls.Add(cbMetodo);
            gbDatos.Controls.Add(label3);
            gbDatos.Controls.Add(cmMet);
            gbDatos.Controls.Add(label2);
            gbDatos.Controls.Add(txbFuncion);
            gbDatos.Controls.Add(label1);
            gbDatos.Location = new Point(12, 20);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(280, 600);
            gbDatos.TabIndex = 0;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos";
            // 
            // btnCalcular
            // 
            btnCalcular.ForeColor = SystemColors.ControlText;
            btnCalcular.Location = new Point(40, 470);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(200, 40);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txbXd
            // 
            txbXd.Location = new Point(20, 410);
            txbXd.Name = "txbXd";
            txbXd.Size = new Size(240, 23);
            txbXd.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 390);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 12;
            label6.Text = "Xd";
            // 
            // txbXi
            // 
            txbXi.Location = new Point(20, 350);
            txbXi.Name = "txbXi";
            txbXi.Size = new Size(240, 23);
            txbXi.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 330);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 10;
            label5.Text = "Xi";
            // 
            // txbTolerancia
            // 
            txbTolerancia.Location = new Point(20, 290);
            txbTolerancia.Name = "txbTolerancia";
            txbTolerancia.Size = new Size(240, 23);
            txbTolerancia.TabIndex = 9;
            txbTolerancia.Text = "0,0001";
            // 
            // Tolerancia
            // 
            Tolerancia.AutoSize = true;
            Tolerancia.Location = new Point(20, 270);
            Tolerancia.Name = "Tolerancia";
            Tolerancia.Size = new Size(60, 15);
            Tolerancia.TabIndex = 8;
            Tolerancia.Text = "Tolerancia";
            // 
            // txbIteraciones
            // 
            txbIteraciones.Location = new Point(20, 230);
            txbIteraciones.Name = "txbIteraciones";
            txbIteraciones.Size = new Size(240, 23);
            txbIteraciones.TabIndex = 7;
            txbIteraciones.Text = "100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 210);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Iteraciones";
            // 
            // cbMetodo
            // 
            cbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodo.FormattingEnabled = true;
            cbMetodo.Location = new Point(20, 170);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(240, 23);
            cbMetodo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 150);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Método";
            // 
            // cmMet
            // 
            cmMet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmMet.FormattingEnabled = true;
            cmMet.Items.AddRange(new object[] { "Abierto", "Cerrado" });
            cmMet.Location = new Point(20, 110);
            cmMet.Name = "cmMet";
            cmMet.Size = new Size(240, 23);
            cmMet.TabIndex = 3;
            cmMet.SelectedIndexChanged += cmMet_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo Método";
            // 
            // txbFuncion
            // 
            txbFuncion.Location = new Point(20, 51);
            txbFuncion.Name = "txbFuncion";
            txbFuncion.Size = new Size(240, 23);
            txbFuncion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Función";
            // 
            // gbGrafico
            // 
            gbGrafico.BackColor = Color.Transparent;
            gbGrafico.Controls.Add(webView21);
            gbGrafico.Location = new Point(320, 20);
            gbGrafico.Name = "gbGrafico";
            gbGrafico.Size = new Size(540, 600);
            gbGrafico.TabIndex = 1;
            gbGrafico.TabStop = false;
            gbGrafico.Text = "Grafico";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(20, 30);
            webView21.Name = "webView21";
            webView21.Size = new Size(500, 500);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // gbResultado
            // 
            gbResultado.BackColor = Color.Transparent;
            gbResultado.Controls.Add(pictureBox1);
            gbResultado.Controls.Add(txbError);
            gbResultado.Controls.Add(Error);
            gbResultado.Controls.Add(txbRaiz);
            gbResultado.Controls.Add(label8);
            gbResultado.Controls.Add(txbConverge);
            gbResultado.Controls.Add(txbIntervaloU);
            gbResultado.Controls.Add(label11);
            gbResultado.Controls.Add(label12);
            gbResultado.Controls.Add(txbIteracionesU);
            gbResultado.Controls.Add(label13);
            gbResultado.Location = new Point(880, 20);
            gbResultado.Name = "gbResultado";
            gbResultado.Size = new Size(280, 600);
            gbResultado.TabIndex = 2;
            gbResultado.TabStop = false;
            gbResultado.Text = "Resultado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 229);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txbError
            // 
            txbError.Location = new Point(20, 290);
            txbError.Name = "txbError";
            txbError.ReadOnly = true;
            txbError.Size = new Size(240, 23);
            txbError.TabIndex = 27;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Location = new Point(20, 270);
            Error.Name = "Error";
            Error.Size = new Size(32, 15);
            Error.TabIndex = 26;
            Error.Text = "Error";
            // 
            // txbRaiz
            // 
            txbRaiz.Location = new Point(20, 230);
            txbRaiz.Name = "txbRaiz";
            txbRaiz.ReadOnly = true;
            txbRaiz.Size = new Size(240, 23);
            txbRaiz.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 210);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 24;
            label8.Text = "Raíz";
            // 
            // txbConverge
            // 
            txbConverge.Location = new Point(20, 170);
            txbConverge.Name = "txbConverge";
            txbConverge.ReadOnly = true;
            txbConverge.Size = new Size(240, 23);
            txbConverge.TabIndex = 23;
            // 
            // txbIntervaloU
            // 
            txbIntervaloU.Location = new Point(20, 110);
            txbIntervaloU.Name = "txbIntervaloU";
            txbIntervaloU.ReadOnly = true;
            txbIntervaloU.Size = new Size(240, 23);
            txbIntervaloU.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 150);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 18;
            label11.Text = "Converge";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 90);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 16;
            label12.Text = "Intervalo";
            // 
            // txbIteracionesU
            // 
            txbIteracionesU.Location = new Point(20, 50);
            txbIteracionesU.Name = "txbIteracionesU";
            txbIteracionesU.ReadOnly = true;
            txbIteracionesU.Size = new Size(240, 23);
            txbIteracionesU.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 30);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 14;
            label13.Text = "Iteraciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 611);
            Controls.Add(gbResultado);
            Controls.Add(gbGrafico);
            Controls.Add(gbDatos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calculadora de Raices";
            Load += Form1_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            gbResultado.ResumeLayout(false);
            gbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatos;
        private GroupBox gbGrafico;
        private GroupBox gbResultado;
        private ComboBox cbMetodo;
        private Label label3;
        private ComboBox cmMet;
        private Label label2;
        private TextBox txbFuncion;
        private Label label1;
        private Button btnCalcular;
        private TextBox txbXd;
        private Label label6;
        private TextBox txbXi;
        private Label label5;
        private TextBox txbTolerancia;
        private Label Tolerancia;
        private TextBox txbIteraciones;
        private Label label4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox txbError;
        private Label Error;
        private TextBox txbRaiz;
        private Label label8;
        private TextBox txbConverge;
        private TextBox txbIntervaloU;
        private Label label11;
        private Label label12;
        private TextBox txbIteracionesU;
        private Label label13;
        private PictureBox pictureBox1;
    }
}
