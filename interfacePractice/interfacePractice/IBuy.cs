using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    interface IBuy
    {
        void ChooseProduct(Dictionary<Ring,double> ProductBasket);
        void Buy();
    }
}
