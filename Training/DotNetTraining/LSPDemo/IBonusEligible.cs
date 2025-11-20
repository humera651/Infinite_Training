using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    public interface IBonusEligible
    {
        decimal GetBonus(decimal salary);
    }
}
