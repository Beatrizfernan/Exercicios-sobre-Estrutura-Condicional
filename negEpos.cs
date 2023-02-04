/* Fazer um programa para ler um número inteiro, 
e depois dizer se este número é negativo ou não. */



using System;

namespace cond01
{
    class negEpos
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor para saber se é negativou ou positivo:");
            int N = int.Parse(Console.ReadLine());



            if (N < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}
