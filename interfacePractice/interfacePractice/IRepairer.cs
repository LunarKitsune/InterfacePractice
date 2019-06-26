using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    interface IRepairer
    {
        double GetRepairValue(Merchandise merchandise, bool addingGem, Gem gem);
        void Fix(Merchandise merch);
        

    }
}
