using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    interface IBuyer
    {
        void DisplayCart(StoreBasket basket);

        void AddToCart(StoreBasket basket);

        void PurchaseCart(StoreBasket basket);
    }
}
