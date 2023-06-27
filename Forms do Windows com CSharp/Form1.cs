using Forms_do_Windows_com_CSharp.Classes;

namespace Forms_do_Windows_com_CSharp
{
    /*
    Objetivo: desenvolver um CRUD de usuários com Windows forms.
    Abandonando assim, a dependência do uso de console

     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo!\nVamos fazer seu cadastro?");
            Usuario u = new Usuario();
            u.Id = 1;
            u.Salary = 1;
            u.Vph = 10;
            u.Cpf = "1";
            u.Name = "Name";
            u.Balance = 100;
            u.Age = 30;
            MessageBox.Show(u.ReadUser()).ToString();
        }
    }
}