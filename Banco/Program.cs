using System;
using System.Globalization;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROCESSO INTERAÇÃO COM O USUARIO

            Conta conta; // classe para chamar o construtor
            Console.WriteLine("Digite o número da sua conta");
            int numero = int.Parse(Console.ReadLine()); //variável temporaria
            Console.WriteLine("Digite o nome do titular");
            string titular = Console.ReadLine();// variavel auxiliar
            Console.WriteLine("Haverá depósito inicial?(s/n)");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S')//a tecla || significa OU
            {
                Console.WriteLine("Digite o valor do depósito:");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//variavel auxiliar
                conta = new Conta(numero, titular, depositoInicial); // atribuir e utilizar o construtor
                
            }

            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine("dados da conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("valor do deposito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);//chama a operação da classe
            Console.WriteLine("Dados atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Valor do saque:");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("dados atualizados");
            Console.WriteLine(conta);


















        }
    }
}
