using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCost
{
    public class HeatingPurposed:Client
    {
        public HeatingPurposed()
        {
            Plan = 0.01;
            EnergiCost = Plan * EnergiAmount;
        }
    }
}
