namespace Ej1TrasladoDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Significando que lo que esta adentro de el label lblTexto es igual a 
            lo que esta en el text box txtTexto */
     
            lblTexto.Text = "Hola " + txtTexto.Text;

            //Para borrar texto del Text Box
            txtTexto.Text = " ";
        }
    }
}
