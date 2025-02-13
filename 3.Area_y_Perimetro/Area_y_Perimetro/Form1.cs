namespace Area_y_Perimetro
{
    public partial class Form1 : Form
    {
        /*utilizamos una declaracion publica para poder llamar el
        variable Resulado en cualquier momento*/
        public double Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            /*declaramos como variable el radio y el area del circulo y 
            ingresamos la libreria Math.PI para utilizar 3.14*/

            double radio = Convert.ToDouble(txtRadio.Text);
            double area = (Math.PI * radio);
            lblResultado.Text = "Area: " + area;

        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            /*declaramos como variable el radio y el perimetro del circulo y 
            ingresamos la libreria Math.PI para utilizar 3.14*/
            double radio = Convert.ToDouble(txtRadio.Text);
            double perimetro = (2 * Math.PI * radio);
            lblResultado.Text = "Perimetro: " + perimetro;
        }

       //una foto usando la harramienta de picturebox
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
