namespace P._05_DataGridView
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
            cbboxPais = new ComboBox();
            btnAdd = new Button();
            btnRemove = new Button();
            dgDatos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtName = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // cbboxPais
            // 
            cbboxPais.FormattingEnabled = true;
            cbboxPais.Location = new Point(495, 96);
            cbboxPais.Name = "cbboxPais";
            cbboxPais.Size = new Size(178, 28);
            cbboxPais.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Desktop;
            btnAdd.Location = new Point(50, 159);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 51);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Desktop;
            btnRemove.Location = new Point(504, 161);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(169, 47);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgDatos.Location = new Point(172, 263);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 51;
            dgDatos.Size = new Size(429, 145);
            dgDatos.TabIndex = 5;
            dgDatos.CellClick += dgDatos_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Last Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Pais";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HighlightText;
            txtName.Location = new Point(50, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(172, 27);
            txtName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(269, 97);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(177, 27);
            txtLastName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(81, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 38);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(302, 43);
            label2.Name = "label2";
            label2.Size = new Size(119, 38);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(538, 23);
            label3.Name = "label3";
            label3.Size = new Size(106, 62);
            label3.TabIndex = 10;
            label3.Text = "Pais";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(dgDatos);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(cbboxPais);
            Name = "Form1";
            Text = "DataGridView";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbboxPais;
        private Button btnAdd;
        private Button btnRemove;
        private DataGridView dgDatos;
        private TextBox txtName;
        private TextBox txtLastName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
