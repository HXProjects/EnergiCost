using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCost
{
    public class Priviliged:Client
    {
        public Priviliged()
        {
            Plan = 0.10;
            EnergiCost = Plan * EnergiAmount;
        }
    }
}
