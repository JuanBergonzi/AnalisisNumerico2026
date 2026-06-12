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
            cbMetodo = new ComboBox();
            labelGrado = new Label();
            nudGrado = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)tbCantidadPuntos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGrado).BeginInit();
            SuspendLayout();
            // 
            // tbCantidadPuntos
            // 
            tbCantidadPuntos.Location = new Point(20, 35);
            tbCantidadPuntos.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            tbCantidadPuntos.Name = "tbCantidadPuntos";
            tbCantidadPuntos.Size = new Size(120, 23);
            tbCantidadPuntos.TabIndex = 0;
            tbCantidadPuntos.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(160, 35);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(100, 25);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // panelPuntos
            // 
            panelPuntos.AutoScroll = true;
            panelPuntos.BorderStyle = BorderStyle.FixedSingle;
            panelPuntos.Location = new Point(20, 80);
            panelPuntos.Name = "panelPuntos";
            panelPuntos.Size = new Size(260, 350);
            panelPuntos.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(310, 80);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 35);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(310, 130);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // tbTolerancia
            // 
            tbTolerancia.Location = new Point(310, 230);
            tbTolerancia.Name = "tbTolerancia";
            tbTolerancia.Size = new Size(120, 23);
            tbTolerancia.TabIndex = 6;
            tbTolerancia.Text = "0,8";
            // 
            // tbDecimales
            // 
            tbDecimales.Location = new Point(310, 300);
            tbDecimales.Name = "tbDecimales";
            tbDecimales.Size = new Size(120, 23);
            tbDecimales.TabIndex = 8;
            tbDecimales.Text = "2";
            // 
            // btnRedondear
            // 
            btnRedondear.Location = new Point(310, 340);
            btnRedondear.Name = "btnRedondear";
            btnRedondear.Size = new Size(120, 35);
            btnRedondear.TabIndex = 9;
            btnRedondear.Text = "Redondear";
            btnRedondear.UseVisualStyleBackColor = true;
            btnRedondear.Click += btnRedondear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 210);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Tolerancia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 280);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Decimales";
            // 
            // labelFuncion
            // 
            labelFuncion.AutoSize = true;
            labelFuncion.Location = new Point(470, 25);
            labelFuncion.Name = "labelFuncion";
            labelFuncion.Size = new Size(53, 15);
            labelFuncion.TabIndex = 10;
            labelFuncion.Text = "Función:";
            // 
            // lblFuncion
            // 
            lblFuncion.BorderStyle = BorderStyle.FixedSingle;
            lblFuncion.Location = new Point(550, 20);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(400, 25);
            lblFuncion.TabIndex = 11;
            // 
            // labelR
            // 
            labelR.AutoSize = true;
            labelR.Location = new Point(470, 65);
            labelR.Name = "labelR";
            labelR.Size = new Size(77, 15);
            labelR.TabIndex = 12;
            labelR.Text = "Coeficiente r:";
            // 
            // lblR
            // 
            lblR.BorderStyle = BorderStyle.FixedSingle;
            lblR.Location = new Point(550, 60);
            lblR.Name = "lblR";
            lblR.Size = new Size(200, 25);
            lblR.TabIndex = 13;
            // 
            // labelAceptable
            // 
            labelAceptable.AutoSize = true;
            labelAceptable.Location = new Point(470, 105);
            labelAceptable.Name = "labelAceptable";
            labelAceptable.Size = new Size(63, 15);
            labelAceptable.TabIndex = 14;
            labelAceptable.Text = "Aceptable:";
            // 
            // lblAceptable
            // 
            lblAceptable.BorderStyle = BorderStyle.FixedSingle;
            lblAceptable.Location = new Point(550, 100);
            lblAceptable.Name = "lblAceptable";
            lblAceptable.Size = new Size(200, 25);
            lblAceptable.TabIndex = 15;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(470, 150);
            webView21.Name = "webView21";
            webView21.Size = new Size(500, 350);
            webView21.TabIndex = 16;
            webView21.ZoomFactor = 1D;
            // 
            // cbMetodo
            // 
            cbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMetodo.Items.AddRange(new object[] { "Regresión Lineal", "Regresión Polinómica" });
            cbMetodo.Location = new Point(20, 460);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(180, 23);
            cbMetodo.TabIndex = 17;
            // 
            // labelGrado
            // 
            labelGrado.AutoSize = true;
            labelGrado.Location = new Point(220, 463);
            labelGrado.Name = "labelGrado";
            labelGrado.Size = new Size(39, 15);
            labelGrado.TabIndex = 18;
            labelGrado.Text = "Grado";
            // 
            // nudGrado
            // 
            nudGrado.Location = new Point(270, 460);
            nudGrado.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudGrado.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudGrado.Name = "nudGrado";
            nudGrado.Size = new Size(120, 23);
            nudGrado.TabIndex = 19;
            nudGrado.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // Regresion
            // 
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
            ((System.ComponentModel.ISupportInitialize)nudGrado).EndInit();
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