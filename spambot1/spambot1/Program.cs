using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace spambot1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a frase1?");
            string frase1 = Console.ReadLine();

            Console.WriteLine("Qual a frase2?");
            string frase2 = Console.ReadLine();

            Console.WriteLine("Qual a frase3?");
            string frase3 = Console.ReadLine();

            Console.WriteLine("Qual a frase4?");
            string frase4 = Console.ReadLine();

            string[] frases = { frase1, frase2, frase3, frase4 };

            Console.WriteLine("Qual é o tempo em milisegundos entre frases?");
            int tempo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Quantas repeticoes queres?");
            int repeticoes = Convert.ToInt16(Console.ReadLine());

            Random rng = new Random();

            for (int i = 0; i < repeticoes; i++)
            {
                int pos = rng.Next(0, 4);
                Console.WriteLine(frases[pos]);
                Thread.Sleep(tempo);
            }
            Console.ReadKey();
        }
    }
}
