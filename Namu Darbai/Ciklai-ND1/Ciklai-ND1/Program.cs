using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai_ND1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool veikia = true;
            while (veikia)
            {
                Console.Write("Iveskite pirma skaiciu: ");
                double pirmasSkaicius = Convert.ToDouble(Console.ReadLine());
                Console.Write("Iveskite norima veiksma:(+, -, /, *) ");
                char veiksmas = Convert.ToChar(Console.ReadLine());
                Console.Write("Iveskite antra skaiciu: ");
                double antraSkaicius = Convert.ToDouble(Console.ReadLine());
                
                AtliktiVeiksma(pirmasSkaicius, antraSkaicius, veiksmas);

                Console.WriteLine("Ar norite kartoti skaiciavima?");
                string taip = Console.ReadLine();

                if(taip != "taip")
                {
                    veikia = false;
                }

            }
            Console.ReadKey();
        }
        public static void AtliktiVeiksma(double pirmasSkaicius, double antrasSkaicius, char veiksmas)
        {


            if (veiksmas == '+')
            {
                Console.WriteLine($"{pirmasSkaicius} + {antrasSkaicius} = {pirmasSkaicius + antrasSkaicius}");
            }
            else if (veiksmas == '-')
            {
                Console.WriteLine($"{pirmasSkaicius} - {antrasSkaicius} = {pirmasSkaicius - antrasSkaicius}");
            }
            else if (veiksmas == '/')
            {
                Console.WriteLine($"{pirmasSkaicius} / {antrasSkaicius} = {pirmasSkaicius / antrasSkaicius}");
            }
            else if (veiksmas == '*')
            {
                Console.WriteLine($"{pirmasSkaicius} * {antrasSkaicius} = {pirmasSkaicius * antrasSkaicius}");
            }
            else
            {
                Console.WriteLine("Neteisingai pasirinkote");
            }
                
            
            
        } 
    }
}
