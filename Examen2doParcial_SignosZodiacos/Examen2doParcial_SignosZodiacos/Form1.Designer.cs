namespace Examen2doParcial_SignosZodiacos
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
            lblFecha = new Label();
            btnSigno = new Button();
            cmbBoxDate = new ComboBox();
            label1 = new Label();
            cmbBoxMes = new ComboBox();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = SystemColors.Desktop;
            lblFecha.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(381, 112);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(206, 31);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Dia De Nacimiento";
            // 
            // btnSigno
            // 
            btnSigno.BackColor = Color.Red;
            btnSigno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSigno.ForeColor = SystemColors.MenuText;
            btnSigno.Location = new Point(261, 454);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new Size(206, 92);
            btnSigno.TabIndex = 3;
            btnSigno.Text = "Obtener Signo";
            btnSigno.UseVisualStyleBackColor = false;
            btnSigno.Click += button1_Click;
            // 
            // cmbBoxDate
            // 
            cmbBoxDate.BackColor = SystemColors.GrayText;
            cmbBoxDate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxDate.FormattingEnabled = true;
            cmbBoxDate.Location = new Point(381, 163);
            cmbBoxDate.Name = "cmbBoxDate";
            cmbBoxDate.Size = new Size(206, 28);
            cmbBoxDate.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Desktop;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 112);
            label1.Name = "label1";
            label1.Size = new Size(215, 31);
            label1.TabIndex = 5;
            label1.Text = "Mes De Nacimiento";
            // 
            // cmbBoxMes
            // 
            cmbBoxMes.BackColor = SystemColors.GrayText;
            cmbBoxMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxMes.FormattingEnabled = true;
            cmbBoxMes.Location = new Point(142, 163);
            cmbBoxMes.Name = "cmbBoxMes";
            cmbBoxMes.Size = new Size(215, 28);
            cmbBoxMes.TabIndex = 6;
            cmbBoxMes.SelectedIndexChanged += cmbBoxMes_SelectedIndexChanged;
            cmbBoxMes.MouseClick += cmbBoxMes_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 607);
            Controls.Add(cmbBoxMes);
            Controls.Add(label1);
            Controls.Add(cmbBoxDate);
            Controls.Add(btnSigno);
            Controls.Add(lblFecha);
            Name = "Form1";
            Text = "Signo Zodiacal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFecha;
        private Button btnSigno;
        private ComboBox cmbBoxDate;
        private Label label1;
        private ComboBox cmbBoxMes;
    }
}
