using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCost
{
    public class Limited : Client
    {
        private int limit;
        private double unlimitedCost;
        public int Limit {get; set;}
        public double UnlimitedCost { get; set; }

        public Limited()
        {
            UnlimitedCost = 0.15;
            Limit = 250;
            Plan = 0.20;
            EnergiCost = GetCost(Limit, Plan, EnergiAmount);
        }
        public double GetCost(int limit, double prise, int amount)
        {
            double result=0;
            int usedEnergi = amount;
            
            if (amount > 250)
            {
                result = UnlimitedCost * Limit;
                usedEnergi = usedEnergi - Limit;
                result = result + usedEnergi * Plan;
                return result;
            }
            else
            {
                result= Plan * EnergiAmount;

            }
            return result;
        }
    }
}
