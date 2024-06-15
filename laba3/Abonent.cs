using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    public class Abonent
    {
        public string Name;
        public int Number;
        public bool Debt;
        public bool Contract;
        public double Service;
        public double Extra;
        public double CostT;

        public double GetYearIncome()
        {
            return Service * CostT + Extra;
        }

    }
}
