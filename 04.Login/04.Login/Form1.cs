namespace _04.Login
{
    public partial class FrmIndex1 : Form
    {
        public FrmIndex1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*Se declara un if statement para comprobar que el Username
             y el Password ingresados son exactamente igual a lo que 
            declaramos en el codigo*/
            if (txtUsername.Text == "Admin" && txtPassword.Text == "1234")
            {
                /*Si son iguales los dos nos abre una nueva form
                 donde ira lo que es nuestro home page y se abre un
                message box indicando que el login fue successful*/
                FrmIndex2 index2 = new FrmIndex2();
                index2.Show();
                this.Hide();
                MessageBox.Show("Login Successful!");
            }
            else
            {
                /*Declaramos un else statement para abrir un 
                 Message Box con la indicacion que el login no se iso 
                correctamente */
                MessageBox.Show("Login Failed");
            }
        }
    }
}
