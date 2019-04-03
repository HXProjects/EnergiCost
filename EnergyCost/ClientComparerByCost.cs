using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCost
{
    class ClientComparerByCost : IComparer<Client>
    {
        public int Compare(Client x, Client y)
        {
            if (ReferenceEquals(x, y))
            {
                return 0;
            }

            if (ReferenceEquals(x, null)) return 1;
            if (ReferenceEquals(y, null)) return -1;

            if (x.EnergyCost > y.EnergyCost) return 1;
            if (x.EnergyCost < y.EnergyCost) return -1;
            return 0;
        }
    }
}
