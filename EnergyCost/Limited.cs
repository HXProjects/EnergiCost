namespace EnergyCost
{
    public class Limited : Client
    {
        private const int LimitLevel = 250;

        public override decimal EnergyCost => GetCost(LimitLevel, _afterLimitCost, EnergiAmount);

        protected override decimal Сoefficient => 1 / 3;

        private decimal _afterLimitCost => PlanCost + (PlanCost * Сoefficient);

        public Limited()
        {
        }

        private decimal GetCost(int limit, decimal prise, int amount)
        {
            if (amount > 250)
            {
                decimal discountCost = PlanCost * limit;
                int overLimitLevel = amount - limit;
                return discountCost + (overLimitLevel * _afterLimitCost);
            }

            return amount * PlanCost;
        }
    }
}
