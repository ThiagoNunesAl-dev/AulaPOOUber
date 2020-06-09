using System;

namespace AulaPOOUber
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro thiago = new Passageiro();

            Console.WriteLine("Digite o seu login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Digite a sua senha: ");
            string senha = Console.ReadLine();

            thiago.Login(login, senha);

            if (thiago.TokenLogin != "" && thiago.TokenLogin != null) {
                Console.WriteLine("Login autorizado!");
                Console.WriteLine(thiago.TokenLogin);
            }

            else {
                Console.WriteLine("Não é possível utilizar o app.");
            }

            thiago.ChamarMotorista();

            System.Console.WriteLine("Completando a viagem...");

            string statusCorrida = "Finalizada.";

            Console.WriteLine(thiago.Pagar(statusCorrida));


        }
    }
}
