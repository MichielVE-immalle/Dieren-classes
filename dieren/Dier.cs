using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dieren
{
    public abstract class Dier
    {

        public int weight
        {
            get; set;
        }

        public abstract void Zegt();

        public Dier()
        {
            
        }
    }
}
