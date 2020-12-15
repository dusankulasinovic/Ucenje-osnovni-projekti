using System;

namespace KolikoSiStarUsekundama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dan, mesec i godinu rodjenja");

            Console.WriteLine("Dan rodjenja?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mesec rodjenja?");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Godina rodjenja?");
            int year = Convert.ToInt32(Console.ReadLine());
            
            
            DateTime godinaRodjenja = new DateTime(year, month, day);
            DateTime trenutnoVreme = DateTime.Now;
            TimeSpan ts = trenutnoVreme - godinaRodjenja;
            Console.WriteLine("Stari ste tacno " + ts.TotalSeconds + " sekundi");

        }
    }
}
