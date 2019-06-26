using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class Customer:IBuyer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double getMoneyAmount { get; set; }

        //I think this should be private. lol. Having this public would be like
        //the customer shopping around and anyone can take from their basket while
        //they shop
        public StoreBasket customerCart = new StoreBasket();

        //just for simplicity that they have an inventory
        public List<Merchandise> Inventory = new List<Merchandise>();

        public Customer()
        {

        }

        public void DisplayCart(StoreBasket basket)
        {
            Console.WriteLine($"{"Item",-20}{"Cost"}");
            foreach(KeyValuePair<Merchandise, double> Item in customerCart.BasketItems)
            {
                Console.WriteLine($"{Item.Key,-20}: {Item.Value:C}");
            }
        }

        public void AddToCart(StoreBasket basket)
        {
            //I think I should have an enumerator list for the type
            //case it out in a switch statement to which item it gets converted to
            //with what qualities?

            //this should also access the store quantity and change store system
            //inventory of x product by - x number of product taken

        }

        public void PurchaseCart(StoreBasket basket)
        {
            foreach (KeyValuePair<Merchandise, double> BasketItem in customerCart.BasketItems)
            {
                getMoneyAmount -= BasketItem.Value;
                Inventory.Add(BasketItem.Key);
            }

            customerCart.BasketItems.Clear();
        }
    }

}
