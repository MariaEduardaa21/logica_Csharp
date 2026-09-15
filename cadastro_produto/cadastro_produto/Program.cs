using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_produto
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            int codigo, estoque;
            string fabricante, categoria;
            double preco, total;
            Console.WriteLine("digite o código: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o fabricante: ");
            fabricante = Console.ReadLine();
            Console.WriteLine(" digite  a categoria: ");
            categoria = Console.ReadLine();
            Console.WriteLine("digite on preço: ");
            preco = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o estoque: ");
            estoque = int.Parse(Console.ReadLine());
            total = preco * estoque;
            Console.WriteLine("o valor total em estoque é " + total);





        }
    }
}
