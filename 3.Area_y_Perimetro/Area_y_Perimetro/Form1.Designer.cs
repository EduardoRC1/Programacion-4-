namespace Area_y_Perimetro
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
            txtRadio = new TextBox();
            lbl1 = new Label();
            btnArea = new Button();
            btnPerimetro = new Button();
            lblResultado = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(12, 136);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(267, 27);
            txtRadio.TabIndex = 0;
            txtRadio.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(54, 80);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(191, 20);
            lbl1.TabIndex = 1;
            lbl1.Text = "Ingresa el Radio del Circulo";
            // 
            // btnArea
            // 
            btnArea.Location = new Point(315, 79);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(183, 51);
            btnArea.TabIndex = 2;
            btnArea.Text = "Calcular Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnPerimetro
            // 
            btnPerimetro.Location = new Point(315, 136);
            btnPerimetro.Name = "btnPerimetro";
            btnPerimetro.Size = new Size(183, 57);
            btnPerimetro.TabIndex = 3;
            btnPerimetro.Text = "Calcular Perimetro";
            btnPerimetro.UseVisualStyleBackColor = true;
            btnPerimetro.Click += btnPerimetro_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(597, 122);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(25, 41);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "|";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(700, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(988, 518);
            Controls.Add(pictureBox1);
            Controls.Add(lblResultado);
            Controls.Add(btnPerimetro);
            Controls.Add(btnArea);
            Controls.Add(lbl1);
            Controls.Add(txtRadio);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRadio;
        private Label lbl1;
        private Button btnArea;
        private Button btnPerimetro;
        private Label lblResultado;
        private PictureBox pictureBox1;
    }
}
