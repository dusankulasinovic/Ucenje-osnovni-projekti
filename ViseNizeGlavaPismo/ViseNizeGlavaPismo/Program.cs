using System;
using System.Collections.Generic;

namespace ViseNizeGlavaPismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Da li zelite da igrate igru Vise-Nize ili Glave-Pismo\n"+ "1.Vise-Nize\n" + "2. Glava-pismo\n");
            int odabirIgre = Convert.ToInt32(Console.ReadLine());



            //Vise nize
            if (odabirIgre == 1)
            {
                Random rnd = new Random();
                int zadatiBroj = rnd.Next(1, 100);
                int pokusaniBroj = 0;
                Console.WriteLine("Pogodite broj od 1 do 100");
                while (pokusaniBroj != zadatiBroj)
                {
                    pokusaniBroj = Convert.ToInt32(Console.ReadLine());

                    if (pokusaniBroj < zadatiBroj)
                    {
                        Console.WriteLine("Vise\n");
                    }

                    else if (pokusaniBroj > zadatiBroj)
                    {
                        Console.Write("Nize\n");
                    }
                }
                Console.WriteLine("Pogodili ste trazeni broj " + zadatiBroj);
                Console.Read();

            }

            //Glava Pismo
            else if (odabirIgre == 2)
            {
                while (true) {
                
                    Random rnd = new Random();
                    List<string> glavaPismo = new List<string> { "Glava", "Pismo" };
                    var random = new Random();
                    int indexGlavaPismo = random.Next(glavaPismo.Count);
                    Console.WriteLine(glavaPismo[indexGlavaPismo] + "\n Pritisnite enter za ponovni pokusaj");
                    Console.ReadLine();
                }

            }
            
        }
    }
}
