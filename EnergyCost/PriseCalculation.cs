namespace EnergyCost
{
    public static class PriseCalculation
    {
        private static int _limitedLevel;
        private static decimal _commonCoefficent;
        private static decimal _limitedCoefficent;
        private static decimal _priviligedCoefficent;
        private static decimal _heatingPurposedCoefficent;
        private static decimal _costPlan;
        public static decimal CommonCoefficent
        {
            get { return _commonCoefficent; }
            set { _commonCoefficent = value; }
        }
        public static int LimitedLevel
        {
            get { return _limitedLevel; }
            set { _limitedLevel = value; }
        }
        public static decimal LimitedCoefficent
        {
            get { return _limitedCoefficent; }
            set { _limitedCoefficent = value; }
        }
        public static decimal PriviligedCoefficent
        {
            get { return _priviligedCoefficent; }
            set { _priviligedCoefficent = value; }
        }
        public static decimal HeatingPurposedCoefficent
        {
            get { return _heatingPurposedCoefficent; }
            set { _heatingPurposedCoefficent = value; }
        }
        public static decimal CostPlan
        {
            get { return _costPlan; }
            set { _costPlan = value; }
        }
        static PriseCalculation()
        {
            LimitedLevel = 250;
            CostPlan = 0.15M;
            CommonCoefficent = 1M;
            LimitedCoefficent = CostPlan+((decimal)1 / 3)*CostPlan;
            PriviligedCoefficent = ((decimal)2 / 3);
            HeatingPurposedCoefficent= ((decimal)1 / 15); 
        }
    }
}
