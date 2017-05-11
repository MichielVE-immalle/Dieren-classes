using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Koe k1 = new Koe();
            Slang s1 = new Slang();
            Varken v1 = new Varken();

            List<Dier> groep = new List<Dier>();
            groep.Add(k1);
            groep.Add(s1);
            groep.Add(v1);

            foreach(Dier dier in groep)
            {
                dier.Zegt();
            }
        }
    }
}
