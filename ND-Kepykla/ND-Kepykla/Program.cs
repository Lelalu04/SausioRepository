using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Kepykla
{
    class Program
    {
        static void Main(string[] args)
        {
            int darboValanduPerDiena = 8;

            Console.Write("iveskite kiek iskepa per valanda duonos kepalu: ");
            int iskepaKepaluPerValanda = int.Parse(Console.ReadLine());
            Console.Write("iveskite darbuotoju skaiciu: ");
            int darbuotojuSkaicius = int.Parse(Console.ReadLine());
            Console.Write("iveskite vieno kepalo kaina: ");
            double vienoKepaloPardavimoKaina = double.Parse(Console.ReadLine());
            Console.Write("iveskite vieno kepalo savikaina: ");
            double vienoKepaloSavikaina = double.Parse(Console.ReadLine());

            int darbuotojasIskepaPerDienaKepalu = iskepaKepaluPerValanda * darboValanduPerDiena;
            int kepyklaPerDienaIskepaDuonosKepalu = darbuotojasIskepaPerDienaKepalu * darbuotojuSkaicius;

            double visuKepaluKaina = kepyklaPerDienaIskepaDuonosKepalu * vienoKepaloPardavimoKaina;
            double visuKepaluSavikaina = kepyklaPerDienaIskepaDuonosKepalu * vienoKepaloSavikaina;

            double pelnas = visuKepaluKaina - visuKepaluSavikaina;
            Console.WriteLine($"Kepykla per vieną darbo dieną spės iškepti duonos kepalų: {kepyklaPerDienaIskepaDuonosKepalu} ");
            Console.WriteLine($"Visų kepalų savikainą: {visuKepaluSavikaina}");
            Console.WriteLine($"Visų kepalų kainą: {visuKepaluKaina}");
            Console.WriteLine($"Pardavus visus duonos kepalus gryno pelno liko: {pelnas}");
            Console.ReadKey();
        }
    }
}
