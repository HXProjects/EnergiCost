using System;

namespace EnergyCost
{
    public abstract class Client : IComparable
    {
        protected const decimal PlanCost = 0.15M;
        public virtual decimal EnergyCost => EnergiAmount * Сoefficient * PlanCost;
        protected abstract decimal Сoefficient { get; }
        private string _clientName;
        private double _clientPlan;
        private int _energiAmount;
        private double _energiCost;

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
        

        public override string ToString()
        {
            string output = null;
            output = string.Format( " Name: {0}; Energi {1}, cost:{2} typePlan{3}", Name, EnergiAmount, EnergyCost, GetType());
            return output;
        }

        public int CompareTo(object obj)
        {
            Client c = obj as Client;
            if (c != null)
                return this.EnergiAmount.CompareTo(c.EnergiAmount);
            else
                throw new Exception("Невозможно сравнить два клиента");
        }
    }
}
