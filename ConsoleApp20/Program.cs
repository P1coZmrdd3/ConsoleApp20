using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace polasek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> slovnik = new Dictionary<string, string>();
            Console.WriteLine("kolik lidi chces zadat?");
            string input = Console.ReadLine();
            int inputCislo = Convert.ToInt32(input); for (int pocitadlo = 0; pocitadlo < inputCislo; pocitadlo++)
            {
                Console.WriteLine("zadej jmeno jednoho cloveka:");
                string jmeno = Console.ReadLine();
                Console.WriteLine("zadej kolik gramu pika vyjede za noc:");
                string hodnota = Console.ReadLine();
                slovnik.Add(jmeno, hodnota);
            }
            foreach (var radekSlovniku in slovnik)
            {
                Console.WriteLine($"Jmeno: {radekSlovniku.Key}, gramu pika: {radekSlovniku.Value}");
                Console.ReadLine();
            }
            Console.WriteLine("Ksicht jak bobova draha STYL KAMO");
            Console.ReadLine();

;


        }
    }
}