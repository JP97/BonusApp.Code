using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public delegate double BonusProvider(double amount);

    public class Bonuses
    {
		public static BonusProvider TenPercent = amount => amount / 10;

		public static BonusProvider FlatTwoIfAmountMoreThanFive = amount => amount > 5.0 ? 2.0 : 0.0;
    }
}
