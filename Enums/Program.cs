using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // enum gebruiken
            Console.WriteLine(Season.Winter);
            // index waarde enum opvragen
            Console.WriteLine(Convert.ToInt32(Season.Spring));
            // enum gebruiken via index cijfer
            Console.WriteLine((Season)2);
            // index opvragen die niet bestaat
            // geen error
            Console.WriteLine((Season)10);

            // persoon aanmaken
            Person p = new Person(Guid.NewGuid(),
                "Karel Moestermans", Countries.BE);

            // enkele properties van de persoon tonen
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Country);
            // description van country opvragen met aparte methode
            Console.WriteLine(p.Country.GetEnumDescription());
        }
    }
}
