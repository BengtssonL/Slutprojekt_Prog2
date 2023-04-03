using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt_Prog2
{
    class Kund
    {
        int antalpersoner;
        int tid;
        int datum;
       
        
        public Kund()
        {
            Console.WriteLine("Hur stort sällskap är ni?");
            this.antalpersoner = int.Parse(Console.ReadLine());
            Console.WriteLine("Vilken tid tänkte ni komma?");

        }
    }
}
