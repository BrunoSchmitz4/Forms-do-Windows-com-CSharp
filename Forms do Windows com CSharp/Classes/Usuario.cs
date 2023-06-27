using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Forms_do_Windows_com_CSharp.Classes
{
    // Versão beta. A versão final terá outputs e inputs visíveis no form
    class Usuario
    {
        // Propriedades do Usuário
        public int Id { get; set; }
        public string Name { get; set; }
        // Balance: Saldo :)
        public double Balance { get; set; }
        public string Cpf { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        // Vph: Valuer P/Hour
        public double Vph { get; set; }
        public DateTime SingnedUpDate { get; set; }


        public Usuario() { }
        public Usuario(int id, string name, double balance, string cpf, int age, double salary, double vph)
        {
            Id = id;
            Name = name;
            Balance = balance;
            Cpf = cpf;
            Age = age;
            Salary = salary;
            Vph = vph;
        }

        public void CreateUser()
        {
            Console.Clear();
            Console.WriteLine("|-----Adicionando dados do usuário-----|");
            Id = Id + 1;
            Console.Write("Nome: ");
            Name = Console.ReadLine();
            Console.Write($"Saldo atual de {Name}");
            Balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("CPF:");
            Cpf = Console.ReadLine();
            Console.Write($"Idade de {Name}");
            Age = int.Parse(Console.ReadLine());
            Console.Write($"Salário de {Name} (em reais): R$");
            Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write($"Valor p/hora de {Name}: ");
            Vph = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            SingnedUpDate = DateTime.Now;
        }

        public string ReadUser() 
        {
            return $"Dados do usuário:\n{ToString()}";
            //Console.WriteLine("|-----Dados do usuário:-----|\n" + ToString());
        }

        public void UpdateUser()
        {
            string option = "";
            option.ToUpper();
            while (option != "N" || option != "C" || option != "I" || option != "V")
            {
                Console.Clear();
                Console.WriteLine("|-----Atualizando dados do usuário-----|\nO que desejas mudar?\n| (N) - Nome | (C) - CPF | (I) - Idade | (V) - Voltar\n" + ToString());
                option = Console.ReadLine().ToUpper();
                option = option.ToUpper();
                switch (option)
                {

                    case "N": 
                        Console.WriteLine($"|Nome atual: {Name} | Novo nome: ");
                        Name = Console.ReadLine();
                        break;
                    case "C":
                        Console.Clear();
                        Console.WriteLine($"|CPF atual: {Cpf} | Novo CPF: ");
                        Cpf = Console.ReadLine();
                        break;
                    case "I":
                        Console.Clear();
                        Console.WriteLine($"|Idade atual: {Age} | Novo Idade: ");
                        Age = int.Parse(Console.ReadLine());
                        break;
                    case "V": break;
                    default: Console.WriteLine("..."); break;

                }
            }
        }

        public void DeleteUser()
        {
            string option = "";
            option.ToUpper();
            while (option != "S" || option != "N")
            {
                Console.WriteLine($"Tem certeza que deseja deletar os dados de {Name}?(S/N)");
                option = Console.ReadLine();
                if (option == "N")
                {
                    break;
                }else if (option == "S")
                {
                    Id = 0;
                    Name = "No info";
                    Balance = 0.0f;
                    Cpf = "No info";
                    Age = 0;
                    Salary = 0.0f;
                    Vph = 0.0f;
                    break;
                }
                break;
            }
        }
        public override string ToString()
        {
            return $"|Id: {Id} |Nome: {Name} |Idade: {Age} |CPF: {Cpf}\n|Saldo: {Balance} |Salário: {Salary} |Valor p/ hora: {Vph} |Data de criação: {SingnedUpDate}";
        }
    }
}
