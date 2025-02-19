namespace Sistema_De_Calificaciones
{
    public partial class Form1 : Form
    {
        //declaramos un variable global indicado por Resultado que sera nuestro resultado de las 3 calificaciones
        public Decimal Resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalificaciones_Click(object sender, EventArgs e)
        {
            //nuestro resultado es calculado agregando las 3 calificaciones y dividiendo entre 3
            //recordamos de seguir la orden de operaciones y indicar que se agregue lo que esta entre perentesis primero
            Resultado = (Convert.ToDecimal(txtCalif1.Text) + Convert.ToDecimal(txtCalif2.Text) + Convert.ToDecimal(txtCalif3.Text)) / 3;

            //introducimos nuestro if para declarar los rangos de aprobacion
            if (Resultado >= 94)
            {
                //introducemos un message box en cada if para declarar la calificacion y si aprobo, reprobo o tiene que tomar cierto examen
                MessageBox.Show("Tienes " + Resultado + " estas exempto!");
            }
            else if (Resultado >= 70 && Resultado < 94)
            {
                MessageBox.Show("Tienes " + Resultado + ". Tienes que ir a Ordinario!");
            }
            else if (Resultado >= 50 && Resultado < 70)
            {
                MessageBox.Show("Tienes 1" + Resultado + ". Tienes que ir a Extra!");
            }
            else
            {
                MessageBox.Show(Resultado + " Tienes que ir a Especial!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Limpieza de pantalla en cada text box
            txtCalif1.Text = " ";
            txtCalif2.Text = " ";
            txtCalif3.Text = " ";
        }
    }
}
