namespace Front
{
    partial class Integracion
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
            txtFuncion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtXi = new TextBox();
            TxtXd = new TextBox();
            label5 = new Label();
            TxtN = new TextBox();
            label6 = new Label();
            cbMetodos = new ComboBox();
            btnCalcular = new Button();
            label7 = new Label();
            txtResultado = new TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 67);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "F(x):";
            // 
            // txtFuncion
            // 
            txtFuncion.Location = new Point(100, 64);
            txtFuncion.Margin = new Padding(3, 2, 3, 2);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(193, 23);
            txtFuncion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 29);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Datos de Entrada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 108);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 3;
            label3.Text = "Xi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 105);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 4;
            label4.Text = "Xd:";
            // 
            // txtXi
            // 
            txtXi.Location = new Point(100, 103);
            txtXi.Margin = new Padding(3, 2, 3, 2);
            txtXi.Name = "txtXi";
            txtXi.Size = new Size(67, 23);
            txtXi.TabIndex = 5;
            // 
            // TxtXd
            // 
            TxtXd.Location = new Point(226, 103);
            TxtXd.Margin = new Padding(3, 2, 3, 2);
            TxtXd.Name = "TxtXd";
            TxtXd.Size = new Size(67, 23);
            TxtXd.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 140);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 7;
            label5.Text = "Cantidad de Subintervalos (n):";
            // 
            // TxtN
            // 
            TxtN.Location = new Point(229, 137);
            TxtN.Margin = new Padding(3, 2, 3, 2);
            TxtN.Name = "TxtN";
            TxtN.Size = new Size(64, 23);
            TxtN.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 178);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 9;
            label6.Text = "Metodo:";
            // 
            // cbMetodos
            // 
            cbMetodos.FormattingEnabled = true;
            cbMetodos.Location = new Point(100, 176);
            cbMetodos.Margin = new Padding(3, 2, 3, 2);
            cbMetodos.Name = "cbMetodos";
            cbMetodos.Size = new Size(193, 23);
            cbMetodos.TabIndex = 10;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(42, 220);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(250, 22);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 67);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 12;
            label7.Text = "Area:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(425, 64);
            txtResultado.Margin = new Padding(3, 2, 3, 2);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(193, 23);
            txtResultado.TabIndex = 13;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(393, 108);
            webView21.Name = "webView21";
            webView21.Size = new Size(248, 218);
            webView21.TabIndex = 14;
            webView21.ZoomFactor = 1D;
            // 
            // Integracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(webView21);
            Controls.Add(txtResultado);
            Controls.Add(label7);
            Controls.Add(btnCalcular);
            Controls.Add(cbMetodos);
            Controls.Add(label6);
            Controls.Add(TxtN);
            Controls.Add(label5);
            Controls.Add(TxtXd);
            Controls.Add(txtXi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFuncion);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Integracion";
            Text = "Trapecios";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFuncion;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtXi;
        private TextBox TxtXd;
        private Label label5;
        private TextBox TxtN;
        private Label label6;
        private ComboBox cbMetodos;
        private Button btnCalcular;
        private Label label7;
        private TextBox txtResultado;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}