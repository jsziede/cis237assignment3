using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    interface IDroid                        //droid interface
    {
        decimal CalculateTotalCost();       //I changed this from a void to a decimal. I am not sure if that is something you wanted us to do,
                                            //but for me it seemed easier to work with this method if it was a decimal type.

        decimal TotalCost { get; set; }
    }
}
