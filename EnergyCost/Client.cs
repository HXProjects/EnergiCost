using System;

namespace EnergyCost
{
    public abstract class Client : IComparable
    {       
        private string _clientName;     
        private int _energiAmount;      
        private decimal _costOfEnergy;
        private decimal _manualCostOfEnergy;        

        public string Name
        {
            get { return _clientName; }
            set { _clientName = value; }
        }        
        public int EnergiAmount
        {
            get { return _energiAmount; }
            set { _energiAmount = value; }
        }
        public decimal CostOfEnergy
        {
            get { return _costOfEnergy; }
            set { _costOfEnergy = value; }
        }
        public decimal ManualCostOfEnergy
        {
            get { return _manualCostOfEnergy; }
            set { _manualCostOfEnergy = value; }
        }

        public override string ToString()
        {
            string output = null;
            output = string.Format("Name: {0} | Plan type: {2} | Energi amount: {1} | paid: {3}", Name, EnergiAmount, GetType().Name, String.Format("{0:0.0000}", CostOfEnergy));
            return output;
        }

        /// <summary>
        /// compare data by amount of energy
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Client c = obj as Client;
            if (c != null)
                return this.EnergiAmount.CompareTo(c.EnergiAmount);
            else
                throw new Exception("Невозможно сравнить данные клиентов");
        }
    }
}
