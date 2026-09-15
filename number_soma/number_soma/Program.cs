using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, number2, soma;
            Console.WriteLine("digite o primeiro numero: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero:  ");
            number2 = int.Parse(Console.ReadLine());
            soma = number - number2;
            Console.WriteLine(" O RESULTADO DA SUBTRAÇÃO é; ", soma);



        }
    }
}
