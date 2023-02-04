/*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.*/


using System;

namespace cond01
{
    class Multiplos
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor inteiro A:");
            
            int A = int.Parse(Console.ReadLine());
           
           
            Console.WriteLine("Digite o valor inteiro B:");
            int B = int.Parse(Console.ReadLine());


            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
