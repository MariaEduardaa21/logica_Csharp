using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.WriteLine(" digite o tempo da entrega: ");
            time = int.Parse(Console.ReadLine());
            if (time <= 15)
            {
                Console.WriteLine(" Entrega perfeita! bonus garantido. ");
            }
             if (time >15 && time < 30) {
                Console.WriteLine(" ´pizza entregue a tempo, sem bonus.");
            }
             if (time >= 30) {
                Console.WriteLine("A pizza esfriou! peter foi demitido!");
            }
           
     




        }
    }
}
