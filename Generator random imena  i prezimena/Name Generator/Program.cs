using System;
using System.Collections.Generic;

namespace Name_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Rucno unesene liste muskih i zenskih imena
                var listaMuskihImena = new List<string>
            { "Dusan", "Marko", "Zarko", "Darko", "Milos", "Mitar","Avra","Srecko","Misko","Pisko","Drazen","Adam","Adrijan","Nikola", "Azarije"};

                var listaZenskihImena = new List<string>
            { "Milica", "Nina", "Sanja", "Vanja", "Dragica", "Ivana","Petra","Gordana","Milana","Jovana","Dragana","Olivera","Ceca","Ana", "Ivona"};

                //Rucno unesena lista prezimena
                List<string> listaPrezimena = new List<string> { "Jovanovic", "Davidovic", "Kulasinovic", "Ilijin", "Petrovic", "Mitrovic", "Kitic", "Dacic", "Vucic", "Vojvodic" };

                var random = new Random();
                int indexMuskihImena = random.Next(listaMuskihImena.Count);
                int indexPrezimena = random.Next(listaPrezimena.Count);
                int indexZenskihImena = random.Next(listaZenskihImena.Count);

                //Pokazuje korisniku opciju i trazi da unese parametar
                Console.WriteLine("Da li zelite da generisete random musko ili zensko ime?");
                Console.Write("1. Musko\n");
                Console.Write("2. Zensko\n");
                var odgovor = Console.ReadLine();


                //Printa musko ime + prezime
                if (odgovor == "1")
                {
                    Console.WriteLine(listaMuskihImena[indexMuskihImena] + " " + listaPrezimena[indexPrezimena]);
                }
                //Printa zensko ime + prezime
                else if (odgovor == "2")
                {

                    Console.WriteLine(listaZenskihImena[indexZenskihImena] + " " + listaPrezimena[indexPrezimena]);
                }

                else
                {
                    Console.WriteLine("Niste uneli broj 1 ili 2 da odaberete opciju");
                }

                Console.WriteLine("\nPritisnite enter da ponovite radnju");
                Console.ReadLine();
            }
        }
    }
}
