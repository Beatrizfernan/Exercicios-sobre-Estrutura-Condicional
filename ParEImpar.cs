/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.*/



using System;

namespace cond01
{
    class ParEImpar
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor para saber se é negativou ou positivo:");
            int N = int.Parse(Console.ReadLine());



            if (N % 2==0 )
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("ímpar");
            }
        }
    }
}

