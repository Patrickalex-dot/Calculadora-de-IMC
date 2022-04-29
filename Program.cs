using System;

namespace Aplicação_teste
{
    class Program
    {


        static void Main(string[] args)
        {
            decimal peso;
            decimal altura;
            decimal IMC;

            Console.WriteLine("Insira seu peso: ");
            peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira sua altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(IMC = peso / (altura * altura));

        }
    }
}