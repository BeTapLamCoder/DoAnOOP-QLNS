using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWF
{
    [Serializable]
    public class SalaryManager: SalaryBase
    {
        public override double TotalSalary()
        {
            double sum;
            if (Dayoff <= 2)
            {
                return sum = (Salary + Salary * Increase + Bonus)*1.2;
            }
            else
            {
               return sum = (Salary + Salary * Increase + Bonus - Dayoff * 100)*1.2;
            }
        }
    }
}
