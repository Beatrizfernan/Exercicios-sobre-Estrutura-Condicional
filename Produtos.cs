/*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
seguir, calcule e mostre o valor da conta a pagar.*/


using System;

namespace cond01
{
    class Produtos
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o codigo do item:");
            int codigo= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quantidade do item:");
            int quantidade= int.Parse(Console.ReadLine());

            double total;
           
            if (codigo == 1) {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) {
                total = quantidade * 2.0;
            }
            else if (codigo == 5){
                total = quantidade * 1.5;
            }else{
                total = 0;
            }

            Console.WriteLine("Total: R$ " + total);

            
        }
    }
}

            