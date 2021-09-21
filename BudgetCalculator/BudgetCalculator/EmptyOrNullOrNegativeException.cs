using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetCalculator
{
    class EmptyOrNullOrNegativeException : Exception
    {
        public EmptyOrNullOrNegativeException(string message) : base(message)
        {
        }
    }
}