/*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/


using System;

namespace cond01
{
    class Hora
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a hora inicial:");
            int HoraI = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora inicial:");
            int HoraF = int.Parse(Console.ReadLine());
            int duracao;

             if (HoraI < HoraF) {
                duracao = HoraF - HoraI;
            }
            else {
                duracao = 24 - HoraI + HoraF;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
  

            
           
