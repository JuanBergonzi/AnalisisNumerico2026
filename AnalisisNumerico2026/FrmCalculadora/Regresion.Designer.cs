namespace Front
{
    partial class Regresion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tbCantidadPuntos = new NumericUpDown();
            btnGenerar = new Button();
            panelPuntos = new Panel();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            tbTolerancia = new TextBox();
            tbDecimales = new TextBox();
            btnRedondear = new Button();

            label1 = new Label();
            label2 = new Label();

            labelFuncion = new Label();
            lblFuncion = new Label();

            labelR = new Label();
            lblR = new Label();

            labelAceptable = new Label();
            lblAceptable = new Label();

            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();

            ((System.ComponentModel.ISupportInitialize)tbCantidadPuntos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();

            SuspendLayout();

            // tbCantidadPuntos
            tbCantidadPuntos.Location = new Point(20, 35);
            tbCantidadPuntos.Minimum = 2;
            tbCantidadPuntos.Maximum = 100;
            tbCantidadPuntos.Name = "tbCantidadPuntos";
            tbCantidadPuntos.Size = new Size(120, 23);
            tbCantidadPuntos.Value = 5;

            // btnGenerar
            btnGenerar.Location = new Point(160, 35);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(100, 25);
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;

            // panelPuntos
            panelPuntos.AutoScroll = true;
            panelPuntos.BorderStyle = BorderStyle.FixedSingle;
            panelPuntos.Location = new Point(20, 80);
            panelPuntos.Name = "panelPuntos";
            panelPuntos.Size = new Size(260, 350);

            // btnCalcular
            btnCalcular.Location = new Point(310, 80);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 35);
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;

            // btnLimpiar
            btnLimpiar.Location = new Point(310, 130);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(310, 210);
            label1.Text = "Tolerancia";

            // tbTolerancia
            tbTolerancia.Location = new Point(310, 230);
            tbTolerancia.Name = "tbTolerancia";
            tbTolerancia.Size = new Size(120, 23);
            tbTolerancia.Text = "0.8";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(310, 280);
            label2.Text = "Decimales";

            // tbDecimales
            tbDecimales.Location = new Point(310, 300);
            tbDecimales.Name = "tbDecimales";
            tbDecimales.Size = new Size(120, 23);
            tbDecimales.Text = "2";

            // btnRedondear
            btnRedondear.Location = new Point(310, 340);
            btnRedondear.Name = "btnRedondear";
            btnRedondear.Size = new Size(120, 35);
            btnRedondear.Text = "Redondear";
            btnRedondear.UseVisualStyleBackColor = true;
            btnRedondear.Click += btnRedondear_Click;

            // labelFuncion
            labelFuncion.AutoSize = true;
            labelFuncion.Location = new Point(470, 25);
            labelFuncion.Text = "Función:";

            // lblFuncion
            lblFuncion.BorderStyle = BorderStyle.FixedSingle;
            lblFuncion.Location = new Point(550, 20);
            lblFuncion.Size = new Size(400, 25);

            // labelR
            labelR.AutoSize = true;
            labelR.Location = new Point(470, 65);
            labelR.Text = "Coeficiente r:";

            // lblR
            lblR.BorderStyle = BorderStyle.FixedSingle;
            lblR.Location = new Point(550, 60);
            lblR.Size = new Size(200, 25);

            // labelAceptable
            labelAceptable.AutoSize = true;
            labelAceptable.Location = new Point(470, 105);
            labelAceptable.Text = "Aceptable:";

            // lblAceptable
            lblAceptable.BorderStyle = BorderStyle.FixedSingle;
            lblAceptable.Location = new Point(550, 100);
            lblAceptable.Size = new Size(200, 25);

            // webView21
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(470, 150);
            webView21.Name = "webView21";
            webView21.Size = new Size(500, 350);
            webView21.ZoomFactor = 1D;

            // cbMetodo
            cbMetodo = new ComboBox();
            cbMetodo.Location = new Point(20, 460);
            cbMetodo.Size = new Size(180, 23);
            cbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;

            cbMetodo.Items.Add("Regresión Lineal");
            cbMetodo.Items.Add("Regresión Polinómica");
            cbMetodo.SelectedIndex = 0;

            // labelGrado
            labelGrado = new Label();
            labelGrado.Location = new Point(220, 463);
            labelGrado.Text = "Grado";
            labelGrado.AutoSize = true;

            // nudGrado
            nudGrado = new NumericUpDown();
            nudGrado.Location = new Point(270, 460);
            nudGrado.Minimum = 2;
            nudGrado.Maximum = 10;
            nudGrado.Value = 2;

            // Regresion
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1000, 550);

            Controls.Add(tbCantidadPuntos);
            Controls.Add(btnGenerar);
            Controls.Add(panelPuntos);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(tbTolerancia);
            Controls.Add(label2);
            Controls.Add(tbDecimales);
            Controls.Add(btnRedondear);

            Controls.Add(labelFuncion);
            Controls.Add(lblFuncion);

            Controls.Add(labelR);
            Controls.Add(lblR);

            Controls.Add(labelAceptable);
            Controls.Add(lblAceptable);

            Controls.Add(webView21);

            Controls.Add(cbMetodo);
            Controls.Add(labelGrado);
            Controls.Add(nudGrado);

            Name = "Regresion";
            Text = "Regresión Lineal";
            Load += Regresion_Load;

            ((System.ComponentModel.ISupportInitialize)tbCantidadPuntos).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown tbCantidadPuntos;
        private Button btnGenerar;
        private Panel panelPuntos;
        private Button btnCalcular;
        private Button btnLimpiar;
        private TextBox tbTolerancia;
        private TextBox tbDecimales;
        private Button btnRedondear;

        private Label label1;
        private Label label2;

        private Label labelFuncion;
        private Label lblFuncion;

        private Label labelR;
        private Label lblR;

        private Label labelAceptable;
        private Label lblAceptable;

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;

        private ComboBox cbMetodo;
        private NumericUpDown nudGrado;
        private Label labelGrado;
    }
}