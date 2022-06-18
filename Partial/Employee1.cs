using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialProject
{
    partial class Employee : IEmployee
    {
        public string DOJ()
        {
            return empname + " doj";
        }
        public string empcode()
        {
            return empname + " doj";
        }

        public string salary()
        {
            return  empname +" salary";
        }

        public string taxacc()
        {
            return empname + " taxacc";
        }

        public string pfacc()
        {
            //some logic
            return empname + " pfacc";
        }

    }
}
