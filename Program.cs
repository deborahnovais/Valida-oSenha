using System;

namespace ValidaçãoSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de senha");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            string senha = Console.ReadLine();

            while(nome == senha) {
                Console.WriteLine("Senha inválida. Digite uma senha que não contenha o seu nome.");
                senha = Console.ReadLine();
            }  

            Console.WriteLine("Senha cadastrada com sucesso.");     
        }
    }
}
