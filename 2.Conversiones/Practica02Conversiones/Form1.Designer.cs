namespace Practica02Conversiones
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
            txtText1 = new TextBox();
            txtCelsius = new TextBox();
            txtText2 = new TextBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            txtText3 = new TextBox();
            btnConvertir2 = new Button();
            lblResultado2 = new Label();
            txtFahrenheit = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtText1
            // 
            txtText1.BackColor = SystemColors.Highlight;
            txtText1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtText1.Location = new Point(5, 7);
            txtText1.Name = "txtText1";
            txtText1.Size = new Size(297, 43);
            txtText1.TabIndex = 0;
            txtText1.Text = "CELSUIS A FAHRENHEIT";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(5, 101);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(293, 27);
            txtCelsius.TabIndex = 1;
            // 
            // txtText2
            // 
            txtText2.Location = new Point(6, 63);
            txtText2.Name = "txtText2";
            txtText2.Size = new Size(296, 27);
            txtText2.TabIndex = 2;
            txtText2.Text = "Ingrese Celsius";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(360, 77);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(120, 61);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(580, 86);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(25, 41);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "|";
            // 
            // txtText3
            // 
            txtText3.Location = new Point(6, 213);
            txtText3.Name = "txtText3";
            txtText3.Size = new Size(296, 27);
            txtText3.TabIndex = 5;
            txtText3.Text = "Ingrese Fahrenheit";
            // 
            // btnConvertir2
            // 
            btnConvertir2.Location = new Point(360, 213);
            btnConvertir2.Name = "btnConvertir2";
            btnConvertir2.Size = new Size(120, 61);
            btnConvertir2.TabIndex = 6;
            btnConvertir2.Text = "Convertir";
            btnConvertir2.UseVisualStyleBackColor = true;
            btnConvertir2.Click += btnConvertir2_Click;
            // 
            // lblResultado2
            // 
            lblResultado2.AutoSize = true;
            lblResultado2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado2.ForeColor = Color.Black;
            lblResultado2.Location = new Point(580, 233);
            lblResultado2.Name = "lblResultado2";
            lblResultado2.Size = new Size(25, 41);
            lblResultado2.TabIndex = 7;
            lblResultado2.Text = "|";
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(5, 247);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(293, 27);
            txtFahrenheit.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Highlight;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(6, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 43);
            textBox1.TabIndex = 9;
            textBox1.Text = "FAHRENHEIT A CELSIUS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(931, 486);
            Controls.Add(textBox1);
            Controls.Add(txtFahrenheit);
            Controls.Add(lblResultado2);
            Controls.Add(btnConvertir2);
            Controls.Add(txtText3);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(txtText2);
            Controls.Add(txtCelsius);
            Controls.Add(txtText1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtText1;
        private TextBox txtCelsius;
        private TextBox txtText2;
        private Button btnConvertir;
        private Label lblResultado;
        private TextBox txtText3;
        private Button btnConvertir2;
        private Label lblResultado2;
        private TextBox txtFahrenheit;
        private TextBox textBox1;
    }
}
