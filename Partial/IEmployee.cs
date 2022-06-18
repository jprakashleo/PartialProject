using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialProject
{
    partial interface IEmployee
    {
        string empcode();
        string DOJ();
        string salary();
        string pfacc();
        string taxacc();

    }
}
