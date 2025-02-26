using System.CodeDom;

namespace Examen2doParcial_SignosZodiacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //para que este limpio el combo box cuando el usuario ingrese el mes
            cmbBoxDate.Items.Clear();
            //para que este limpio el combo box cuando el usuario ingrese el dia
            cmbBoxDate.Items.Clear();

            //agregar los meses en un nuevo array en forma string que se usaran despues para llamar cada mes
            cmbBoxMes.Items.AddRange(new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });

            //un for para poder eliger entre el dia 1 asta el dia 31 de cualquier mes
            //se usara como variable i = 1 como inicio y mientras que sea menor o igual a 31 el i incrementara
            //Febrero solo tiene 28 dias, algo para investigar
            for (int i = 1; i <= 31; i++)
            {
                //para cuando se haga click en el comboBox de Date se vean los numeros 1 a 31 al eligir
                cmbBoxDate.Items.Add(i);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creamos el variable dia para agarrar los datos del ComboBox de Dia para poder utilizar lo en nuestro switch
            //SelectedIndex especifica lo que en verdad esta selecionado sea 1 o 10, etc.
            int dia = cmbBoxDate.SelectedIndex;
            //creamos el variable mes para poder utilizar lo que fue eligido en el ComboBox del Mes para poder utilizar lo en nuestro Switch
            //funciona el programa pero dudas por que se hace en .Text cuando es un comboBox igual que al Date? Sera por que es un string?
            string mes = cmbBoxMes.Text;

            // un placeholder para cuando el usuario hace click sin eligir ningun dato
            string Zodiaco = "Desconocido";

            //iniciamos el switch
            /* en cada caso se dara conocer que si lo 
               capturado por el variable (dia) es menor o igual a X fecha 
               el usuario es X Signo y si es mayor a X fecha es X Signo*/
            switch (mes)
            {
                // el operador ? es utilzado como si fuera un if-else
                //solo es utilizado para compresar el codigo pero en si sirve como un if-else statement
                //el operador : es utilizado para separar lo que es true y lo que es false
                case "Enero":
                    Zodiaco = (dia <= 19) ? "Capricornio" : "Acuario";
                    break;
                case "Febrero":
                    Zodiaco = (dia <= 18) ? "Acuario" : "Piscis";
                    break;
                case "Marzo":
                    Zodiaco = (dia <= 20) ? "Piscis" : "Aries";
                    break;
                case "Abril":
                    Zodiaco = (dia <= 19) ? "Aries" : "Tauro";
                    break;
                case "Mayo":
                    Zodiaco = (dia <= 20) ? "Tauro" : "Gemenis";
                    break;
                case "Junio":
                    Zodiaco = (dia <= 20) ? "Gemenis" : "Cancer";
                    break;
                case "Julio":
                    Zodiaco = (dia <= 22) ? "Cancer" : "Leo";
                    break;
                case "Agosto":
                    Zodiaco = (dia <= 22) ? "Leo" : "Virgo";
                    break;
                case "Septiembre":
                    Zodiaco = (dia <= 22) ? "Virgo" : "Libra";
                    break;
                case "Octubre":
                    Zodiaco = (dia <= 22) ? "Libra" : "Escorpio";
                    break;
                case "Noviembre":
                    Zodiaco = (dia <= 21) ? "Escorpio" : "Sagitario";
                    break;
                case "Diciembre":
                    Zodiaco = (dia <= 21) ? "Sagitario" : "Capricornio";
                    break;

            }
            // Un messageBox para demostrar le al usuario que signo es
            MessageBox.Show("Eres: " + Zodiaco + "!");

           


        }

        private void cmbBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxMes_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
