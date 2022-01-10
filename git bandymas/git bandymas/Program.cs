using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_bandymas
{
    class Program
    {
        static void Main(string[] args)
        {
            string limonadas = "limonadas";
            string arbata = "Arbata";
            string kakava = "Kakava";
            string kava = "Kava";
            string nieko = "Nieko";

            Console.WriteLine("1 - Limonadas");
            Console.WriteLine("2 - Arbata");
            Console.WriteLine("3 - Kakava");
            Console.WriteLine("4 - Kava");
            Console.WriteLine("5 - Nieko");



            Console.WriteLine("pasirinkite norima punkta:");
            int pasirinkimas = int.Parse(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine($"Jus pasirinkote: {limonadas}");
                    break;
                case 2:
                    Console.WriteLine($"Jus pasirinkote: {arbata}");
                    break;
                case 3:
                    Console.WriteLine($"Jus pasirinkote: {kakava}");
                    break;
                case 4:
                    Console.WriteLine($"Jus pasirinkote: {kava}");
                    break;
                case 5:
                    Console.WriteLine($"Jus pasirinkote: {nieko}");
                    break;
                default:
                    Console.WriteLine("blogai ivestas pasirinkimas");
                    break;



            }
            Console.ReadKey();
        }
    }
}
