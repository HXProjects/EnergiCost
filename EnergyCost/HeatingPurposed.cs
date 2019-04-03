namespace EnergyCost
{
    public class HeatingPurposed : Client
    {
        public HeatingPurposed()
        {
        }

        protected override decimal Сoefficient => PlanCost * ((decimal)1 / 15);
       
    }
}
