using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai_ND2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programosSustabdimas = true;
                Random randomGenerator = new Random();
                int randomSkaicius = randomGenerator.Next(1, 10);

            while (programosSustabdimas)
            {

                

                Console.WriteLine("Bandykite atspeti slapta skaiciu \nNuo 1 iki 10.");
                int ivestasSkaicius = Convert.ToInt32(Console.ReadLine());

                programosSustabdimas = BandytiSurastiSkaiciu(ivestasSkaicius, randomSkaicius);
               
                
            }
            Console.ReadLine();
        }
        public static bool BandytiSurastiSkaiciu(int ivestasSkaicius, int randomSkaicius)
        {
            if (ivestasSkaicius == randomSkaicius)
            {
                Console.WriteLine("SVEIKINAME ATSPEJOTE!");
                return false;

            }
            else if (ivestasSkaicius <= randomSkaicius)
            {
                Console.WriteLine("Slaptas skaicius yra didesnis");
            }
            else if (ivestasSkaicius >= randomSkaicius)
            {
                Console.WriteLine("Slaptas skaicius yra mazesnis");
            }
            return true;
        }
    }
}
