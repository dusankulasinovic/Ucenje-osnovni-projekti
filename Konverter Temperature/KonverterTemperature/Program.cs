using System;

namespace KonverterTemperature
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sta zelite da konvertujete?\n" + "1. Celzijus u farenhajt\n" + "2. Farenhajt u celzijus\n" + 
                "3. Celzijus u kelvin");

            int odgovor = Convert.ToInt32((Console.ReadLine()));

            if (odgovor == 1)
            {
                Console.WriteLine("Unesite temperaturu u celzijusima");
                double temperaturaUc = Convert.ToDouble(Console.ReadLine());
                double temperaturaUf = temperaturaUc * 1.8 + 32;
                Console.WriteLine(temperaturaUc + " celzijusa" + " u farenhajtima iznosi " + temperaturaUf + " farenhajta");
            }

            else if (odgovor == 2)
            {
                Console.WriteLine("Unesite temperaturu u farenhajtima");
                double temperaturaUf = Convert.ToDouble(Console.ReadLine());
                double temperaturaUc = (temperaturaUf - 32) * 5 / 9;
                Console.WriteLine(temperaturaUf + " farenhajta" + " u celzijusima iznosi " + temperaturaUc + " celzijusa");
            }

            else if (odgovor == 3)
            {
                Console.WriteLine("Unesite temperaturu u celzijusima");
                double temperaturaUc = Convert.ToDouble(Console.ReadLine());
                double temperaturaUk = temperaturaUc + 273.15;
                Console.WriteLine(temperaturaUc + " celzijusa" + " u kelvinima iznosi " + temperaturaUk + " kelvina");
            }
        }
    }
}
