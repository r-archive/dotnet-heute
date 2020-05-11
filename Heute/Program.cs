using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woche
{
    class Heute
    {
        static void Main(string[] args)
        {
            Laune soGehtEsMir = new Laune() { zustand = LaunenZustand.langeweile };
            Console.Write(soGehtEsMir.ToString());
        }
    }

    class Laune
    {
        public LaunenZustand zustand = new LaunenZustand();
    }

    enum LaunenZustand
    {
        gut,
        langeweile
    }
}
