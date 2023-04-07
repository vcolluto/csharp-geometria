using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    internal class Rettangolo
    {
        public int baseRettangolo, altezzaRettangolo;

        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        public int calcolaArea()
        {
            return baseRettangolo * altezzaRettangolo;
        }


        public int calcolaPerimetro()
        {
            return 2*(baseRettangolo + altezzaRettangolo);
        }

        public void stampaRettangolo()
        {
            Console.WriteLine($"base: {baseRettangolo} cm");
            Console.WriteLine($"altezza: {altezzaRettangolo} cm");
            Console.WriteLine($"perimetro: {calcolaPerimetro()} cm");
            Console.WriteLine($"area: {calcolaArea()} cm2");
        }
    }
}
