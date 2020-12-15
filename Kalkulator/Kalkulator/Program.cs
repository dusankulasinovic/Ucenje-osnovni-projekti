using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true) {

                Console.WriteLine("Sta zelis da uradis:");
                Console.WriteLine("1: Saberi dva broja");
                Console.WriteLine("2: Oduzmi dva broja");
                Console.WriteLine("3: Ocisti konzolu");

                double odgovor = Convert.ToDouble(Console.ReadLine());


                if (odgovor == 1)
                {
                    Console.WriteLine("Unesi dva broja");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Unesi drugi broj:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double rezultat = num1 + num2;
                    Console.WriteLine("Tvoje resenje je " + rezultat);
                }
                else if (odgovor == 2)
                {

                    Console.Write("Unesi dva broja:");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Unesi drugi broj:");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double rezultat = num1 - num2;
                    Console.WriteLine("Tvoje resenje je " + rezultat);
                }

                else if (odgovor == 3)
                {
                    Console.Clear();
                }
            }
        }
    }
}
