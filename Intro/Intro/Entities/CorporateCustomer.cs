using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

internal class CorporateCustomer : BaseCustomer
{
    public string Name { get; set; }
    public string TaxNumber { get; set; }
}
