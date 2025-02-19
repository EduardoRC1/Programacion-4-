namespace P._05_DataGridView
{
    public partial class Form1 : Form
    {
        string selecion;
        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbboxPais.Items.Add("Mexico");
            cbboxPais.Items.Add("United States of America");
            cbboxPais.Items.Add("South Korea");
            cbboxPais.Items.Add("North Korea");
            cbboxPais.Items.Add("Canada");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selecion = Convert.ToString(cbboxPais.Text);

            int vindice = dgDatos.Rows.Add();
            dgDatos.Rows[vindice].Cells[0].Value = txtName.Text;
            dgDatos.Rows[vindice].Cells[1].Value = txtLastName.Text;
            dgDatos.Rows[vindice].Cells[2].Value = selecion;

            txtName.Text = " ";
            txtLastName.Text = " ";
            cbboxPais.Text = " ";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(indice >= 0)
            {
                dgDatos.Rows.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Selected Item Incorrect.");
            }
        }

        private void dgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }
    }
}