using System;
using System.Collections.Generic;
using System.Text;

namespace CaspianCafe.Interfaces
{
    interface IBillCalculator
    {
        double CalculateBill(string[] menuItems);
    }
}
