using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialProject
{
    partial class Employee : IEmployee
    {
        public string empname { get; set; }
        public int MyProperty { get; set; }

        public string Address()
        {
            return empname + " address 111";
        }

        public string Name()
        {
            return empname;
        }

        public string Description()
        {
            return empname + " descripton 111 ";

        }
        

    }
}
