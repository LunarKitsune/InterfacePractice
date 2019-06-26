using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    //this oddly makes me think the basket is the "Buyer" somehow
    class StoreBasket
    {
        public Dictionary<Merchandise, double> BasketItems = new Dictionary<Merchandise, double>();

        int ItemAmount;

        double MaxWeight { get; set; }
        double MaxItems { get; set; }

        public StoreBasket()
        {

        }
    }
}
