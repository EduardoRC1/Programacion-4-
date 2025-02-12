namespace Operativas_Aritmeticas
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
            btnSuma = new Button();
            btnResta = new Button();
            btnMulti = new Button();
            btnDivi = new Button();
            txtNum1 = new TextBox();
            lblSigno = new Label();
            txtNum2 = new TextBox();
            lblResult = new Label();
            txtEquals = new TextBox();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(-2, 0);
            btnSuma.Margin = new Padding(4);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(236, 127);
            btnSuma.TabIndex = 0;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(-4, 125);
            btnResta.Margin = new Padding(4);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(236, 120);
            btnResta.TabIndex = 1;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(-2, 240);
            btnMulti.Margin = new Padding(4);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(234, 135);
            btnMulti.TabIndex = 2;
            btnMulti.Text = "Multiplicacion";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivi
            // 
            btnDivi.Location = new Point(-2, 374);
            btnDivi.Margin = new Padding(4);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(234, 123);
            btnDivi.TabIndex = 3;
            btnDivi.Text = "Division";
            btnDivi.UseVisualStyleBackColor = true;
            btnDivi.Click += btnDivi_Click;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Kristen ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(301, 175);
            txtNum1.Margin = new Padding(4);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(156, 48);
            txtNum1.TabIndex = 4;
            txtNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSigno
            // 
            lblSigno.AutoSize = true;
            lblSigno.Font = new Font("Kristen ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSigno.Location = new Point(509, 181);
            lblSigno.Margin = new Padding(4, 0, 4, 0);
            lblSigno.Name = "lblSigno";
            lblSigno.Size = new Size(33, 42);
            lblSigno.TabIndex = 5;
            lblSigno.Text = "|";
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Kristen ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(608, 175);
            txtNum2.Margin = new Padding(4);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(156, 48);
            txtNum2.TabIndex = 6;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Kristen ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(913, 175);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(33, 42);
            lblResult.TabIndex = 7;
            lblResult.Text = "|";
            // 
            // txtEquals
            // 
            txtEquals.BackColor = SystemColors.MenuHighlight;
            txtEquals.BorderStyle = BorderStyle.None;
            txtEquals.Font = new Font("Kristen ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEquals.Location = new Point(792, 165);
            txtEquals.Name = "txtEquals";
            txtEquals.Size = new Size(80, 64);
            txtEquals.TabIndex = 8;
            txtEquals.Text = "=";
            txtEquals.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(229, 374);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(404, 115);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(630, 375);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(316, 112);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1000, 495);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtEquals);
            Controls.Add(lblResult);
            Controls.Add(txtNum2);
            Controls.Add(lblSigno);
            Controls.Add(txtNum1);
            Controls.Add(btnDivi);
            Controls.Add(btnMulti);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Font = new Font("Kristen ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuma;
        private Button btnResta;
        private Button btnMulti;
        private Button btnDivi;
        private TextBox txtNum1;
        private Label lblSigno;
        private TextBox txtNum2;
        private Label lblResult;
        private TextBox txtEquals;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}
