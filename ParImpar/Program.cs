using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Olá ^_^");
            Thread.Sleep(3600);
            Console.Clear();

            Console.WriteLine("Digite um número por favor: ");
            numero = double.Parse(Console.ReadLine());

            Console.WriteLine(numero % 2 == 0 ? "Seu número é Par" : "Seu número é Impar");
            Console.WriteLine("Digite qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
