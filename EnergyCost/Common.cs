using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCost
{
    public class Common:Client
    {
        public Common()
        {
            Plan = 0.15;
            EnergiCost = Plan * EnergiAmount;
        }
    }
}
