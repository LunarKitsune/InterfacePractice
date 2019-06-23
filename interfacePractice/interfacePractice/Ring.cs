using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class Ring
    {
        string ringType;
        int ringSize;
        double ringPrice;

        string GetRingType { set { ringType = value; } }
        int getRingSize { set { ringSize = value; } }
        double getRingPrice { set { ringPrice = value; } }


    }
}
