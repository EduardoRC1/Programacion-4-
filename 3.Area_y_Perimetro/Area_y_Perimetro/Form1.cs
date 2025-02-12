namespace Area_y_Perimetro
{
    public partial class Form1 : Form
    {
        public double Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txtRadio.Text);
            double area = (Math.PI * radio);
            lblResultado.Text = "Area: " + area;

        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txtRadio.Text);
            double perimetro = (2 * Math.PI * radio);
            lblResultado.Text = "Perimetro: " + perimetro;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
