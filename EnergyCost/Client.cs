using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCost
{
    public class Client: IComparable
    {
        private string clientName;
        private double clientPlan;
        private int energiAmount;
        private double energiCost;

        public string Name
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public double Plan
        {
            get { return clientPlan; }
            set { clientPlan = value; }//to think about condtion
        }
        public int EnergiAmount
        {
            get { return energiAmount; }
            set { energiAmount = value; }
        }
        public double EnergiCost
        {
            get { return energiCost; }
            set { energiCost = value; }
        }
        public Client()
        {
            Name = null;
            Plan = 0;
            EnergiAmount = 0;
            EnergiCost = 0;

        }
        

        public override string ToString()
        {
            string output = null;
            output = string.Format( " Name: {0}; Energi {1}, cost:{2}", Name, EnergiAmount, EnergiCost);
            return output;
        }

        public int CompareTo(object obj)
        {
            Client c = obj as Client;
            if (c != null)
                return this.EnergiAmount.CompareTo(c.EnergiAmount);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
      

    

       
    }
}
