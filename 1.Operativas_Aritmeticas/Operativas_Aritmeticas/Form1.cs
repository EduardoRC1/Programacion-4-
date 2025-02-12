namespace Operativas_Aritmeticas
{
    public partial class Form1 : Form
    {
        /* la propiedad que se llamara para el resultado de las operaciones
         que se realizaran, publica para poder usar la en cualquier punto de
        el programa */
        public decimal Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            /*La propiedad Resultado se hace igual a txtNum1 y txtNum2 usando 
             Convert.ToDecimal para poder convertir lo de la caja de texto a Numerico*/
            Resultado = Convert.ToDecimal(txtNum1.Text) + Convert.ToDecimal(txtNum2.Text);
            //En el label Result saldra lo que es igual a Resultado despues de convertir lo en String
            lblResult.Text = Resultado.ToString();
            //Agrega un simbolo de suma
            lblSigno.Text = "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            /*La propiedad Resultado se hace igual a txtNum1 y txtNum2 usando 
             Convert.ToDecimal para poder convertir lo de la caja de texto a Numerico*/
            Resultado = Convert.ToDecimal(txtNum1.Text) - Convert.ToDecimal(txtNum2.Text);
            //En el label Result saldra lo que es igual a Resultado despues de convertir lo en String
            lblResult.Text = Resultado.ToString();
            //Agrega un simbolo de resta
            lblSigno.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            /*La propiedad Resultado se hace igual a txtNum1 y txtNum2 usando 
             Convert.ToDecimal para poder convertir lo de la caja de texto a Numerico*/
            Resultado = Convert.ToDecimal(txtNum1.Text) * Convert.ToDecimal(txtNum2.Text);
            //En el label Result saldra lo que es igual a Resultado despues de convertir lo en String
            lblResult.Text = Resultado.ToString();
            //Agrega un simbolo de multiplicacion
            lblSigno.Text = "*";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            /*La propiedad Resultado se hace igual a txtNum1 y txtNum2 usando 
              Convert.ToDecimal para poder convertir lo de la caja de texto a Numerico*/
            Resultado = Convert.ToDecimal(txtNum1.Text) / Convert.ToDecimal(txtNum2.Text);
            //En el label Result saldra lo que es igual al Resultado despues de convertir lo a String
            lblResult.Text = Resultado.ToString();
            //Agrega un simbolo de Division
            lblSigno.Text = "/";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //el boton Limpiar en hacer click limpiara cada uno de los cuadros anotados abajo
            txtNum1.Text = " ";
            txtNum2.Text = " ";
            lblResult.Text = "|";
            lblSigno.Text = "|";


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //El boton Cerrar cerrara el programa en hacer click
            this.Close();
        }
    }

}
