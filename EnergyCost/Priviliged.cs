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
        }

        protected override decimal Сoefficient => PlanCost * ((decimal)2 / 3);
    }
}
