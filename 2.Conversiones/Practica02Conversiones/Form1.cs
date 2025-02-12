namespace Practica02Conversiones
{
    public partial class Form1 : Form
    {
        public decimal Resultado;
        public decimal Resultado2;
        //decimal numero = 1.8M;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            Resultado = Convert.ToDecimal(txtCelsius.Text) * 9 / 5 + 32;
            lblResultado.Text = Resultado.ToString() + "°F";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir2_Click(object sender, EventArgs e)
        {
            Resultado2 = (Convert.ToDecimal(txtFahrenheit.Text) - 32)*5/9;
            lblResultado2.Text = Resultado2.ToString() + "°C";
        }
    }
}
