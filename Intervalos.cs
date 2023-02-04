/*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/


using System;

namespace cond01
{
    class intervalos
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite UM VALOR QUALQUER:");
            int N = int.Parse(Console.ReadLine());



            if (N >= 0 && N <= 25)
            {
                Console.WriteLine("[0,25]");
            }
            else if (N > 25 && N <= 50)
            {
                Console.WriteLine("(25,50]");
            }
            else if(N > 50 && N <= 75){
                Console.WriteLine("(50,75]");
            }
            else if(N >75 && N <= 100){
                Console.WriteLine("(75,100]");
            }
            else{
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
