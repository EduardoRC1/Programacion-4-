namespace Sistema_De_Calificaciones
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
            lblCalificaciones = new Label();
            txtCalif1 = new TextBox();
            lblIngresar1 = new Label();
            lblIngresar2 = new Label();
            txtCalif2 = new TextBox();
            lblIngresar3 = new Label();
            txtCalif3 = new TextBox();
            btnCalificaciones = new Button();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblCalificaciones
            // 
            lblCalificaciones.AutoSize = true;
            lblCalificaciones.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalificaciones.Location = new Point(160, 30);
            lblCalificaciones.Name = "lblCalificaciones";
            lblCalificaciones.Size = new Size(486, 41);
            lblCalificaciones.TabIndex = 0;
            lblCalificaciones.Text = "Sistema De Calificaciones de Parcial";
            // 
            // txtCalif1
            // 
            txtCalif1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalif1.Location = new Point(250, 135);
            txtCalif1.Name = "txtCalif1";
            txtCalif1.Size = new Size(257, 34);
            txtCalif1.TabIndex = 1;
            // 
            // lblIngresar1
            // 
            lblIngresar1.AutoSize = true;
            lblIngresar1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresar1.Location = new Point(250, 90);
            lblIngresar1.Name = "lblIngresar1";
            lblIngresar1.Size = new Size(257, 25);
            lblIngresar1.TabIndex = 2;
            lblIngresar1.Text = "Ingresar Calificacion 1er Parcial:";
            // 
            // lblIngresar2
            // 
            lblIngresar2.AutoSize = true;
            lblIngresar2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresar2.Location = new Point(250, 172);
            lblIngresar2.Name = "lblIngresar2";
            lblIngresar2.Size = new Size(264, 25);
            lblIngresar2.TabIndex = 3;
            lblIngresar2.Text = "Ingresar Calificacion 2do Parcial:";
            // 
            // txtCalif2
            // 
            txtCalif2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalif2.Location = new Point(250, 212);
            txtCalif2.Name = "txtCalif2";
            txtCalif2.Size = new Size(257, 34);
            txtCalif2.TabIndex = 4;
            // 
            // lblIngresar3
            // 
            lblIngresar3.AutoSize = true;
            lblIngresar3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresar3.Location = new Point(250, 249);
            lblIngresar3.Name = "lblIngresar3";
            lblIngresar3.Size = new Size(257, 25);
            lblIngresar3.TabIndex = 5;
            lblIngresar3.Text = "Ingresar Calificacion 3er Parcial:";
            // 
            // txtCalif3
            // 
            txtCalif3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalif3.Location = new Point(250, 292);
            txtCalif3.Name = "txtCalif3";
            txtCalif3.Size = new Size(257, 34);
            txtCalif3.TabIndex = 6;
            // 
            // btnCalificaciones
            // 
            btnCalificaciones.Location = new Point(61, 351);
            btnCalificaciones.Name = "btnCalificaciones";
            btnCalificaciones.Size = new Size(257, 44);
            btnCalificaciones.TabIndex = 7;
            btnCalificaciones.Text = "Enter Calificaciones";
            btnCalificaciones.UseVisualStyleBackColor = true;
            btnCalificaciones.Click += btnCalificaciones_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(466, 351);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(267, 44);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(528, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(205, 203);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(btnCalificaciones);
            Controls.Add(txtCalif3);
            Controls.Add(lblIngresar3);
            Controls.Add(txtCalif2);
            Controls.Add(lblIngresar2);
            Controls.Add(lblIngresar1);
            Controls.Add(txtCalif1);
            Controls.Add(lblCalificaciones);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCalificaciones;
        private TextBox txtCalif1;
        private Label lblIngresar1;
        private Label lblIngresar2;
        private TextBox txtCalif2;
        private Label lblIngresar3;
        private TextBox txtCalif3;
        private Button btnCalificaciones;
        private Button btnClear;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
