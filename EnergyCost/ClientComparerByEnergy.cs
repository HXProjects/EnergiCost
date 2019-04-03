using System;
using System.Collections.Generic;

namespace EnergyCost
{
    class ClientComparerByEnergy : IComparer<Client>
    {
        static readonly Type[] priority = { typeof(Common), typeof(Limited), typeof(Priviliged), typeof(HeatingPurposed) };
        public int Compare(Client x, Client y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(x, null)) return 1;
            if (ReferenceEquals(y, null)) return -1;

            int xOrder = Array.IndexOf(priority, x.GetType());
            int yOrder = Array.IndexOf(priority, y.GetType());

            if (xOrder == yOrder) return 0;
            if (xOrder == -1) return 1;
            if (yOrder == -1) return -1;

            return xOrder.CompareTo(yOrder);

        }
    }

}
