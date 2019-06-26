using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    interface Ibreakable
    {
        int CurrDurability { get; set; }
        int MaxDurability { get; set; }
        bool IsUsable { get; set; }
    }
}
