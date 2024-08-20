using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Oppg 1
namespace Beslutninger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oppg 2
            Console.WriteLine("Vil du ha en brus?");
            string svar = Console.ReadLine().ToLower(); //Jeg bruker .ToLower() for å slippe å måtte lage et alternativ for hver kombinasjon av store og små bokstaver

            //Oppg 3
            if (svar == "ja") //sjekker om svaret er ja, siden jeg gjorde .ToLower() tidligere så trenger jeg bare sjekke små bokstaver
            {
                Console.WriteLine("Her har du en brus");
            } else if (svar == "nei") //sjekker om svaret er nei
            {
                Console.WriteLine("Den er grei");
            } else //kjører om svaret er noe annet enn "ja" eller "nei"
            {
                Console.WriteLine("Det var desverre ikke et gyldig svar");
            }

            //Man kunne også ha brukt en while-loop til å kjøre programmet om igjen til brukeren gir et gyldig svar.

            Console.ReadLine(); //For å hidnre at programmet lukker seg
        }
    }
}
