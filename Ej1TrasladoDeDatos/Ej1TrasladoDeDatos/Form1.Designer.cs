namespace Ej1TrasladoDeDatos
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
            lblTexto = new Label();
            txtTexto = new TextBox();
            btnCambiar = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(369, 66);
            lblTexto.Margin = new Padding(4, 0, 4, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(171, 38);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Hola Mundo";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(275, 144);
            txtTexto.Margin = new Padding(4, 3, 4, 3);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(406, 26);
            txtTexto.TabIndex = 1;
            // 
            // btnCambiar
            // 
            btnCambiar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiar.Location = new Point(275, 205);
            btnCambiar.Margin = new Padding(4, 3, 4, 3);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(408, 90);
            btnCambiar.TabIndex = 2;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1000, 405);
            Controls.Add(btnCambiar);
            Controls.Add(txtTexto);
            Controls.Add(lblTexto);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private TextBox txtTexto;
        private Button btnCambiar;
    }
}
