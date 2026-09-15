using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("digite seu nome: ");
            nome = Console.ReadLine(); //
            Console.WriteLine("digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine(" parabéns " + nome + "voce acabou de ganhar uma coca-cola");
            Console.WriteLine("\n voce possui" + idade + "anos, beba mais água");
        }
    }
}
