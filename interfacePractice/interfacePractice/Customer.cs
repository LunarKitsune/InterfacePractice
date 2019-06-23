using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class Customer:IBuy
    {
        //holds a ring, and a value oduble
        Dictionary<Ring, double> ProductBasket = new Dictionary<Ring, double>();
        double MoneyAmt;

        
        public Customer()
        {

        }

        public void Buy()
        {
            //here we would get the chosen product with ChooseProduct and then
            //Have the result subtract the customers money amount, and clear the product basket
        }

        public void ChooseProduct(Dictionary<Ring, double> ProductBasket)
        {
            //here we would have the customer choose product, maybe there should be a
            //random number that sites how much the customer wants, and then they choose
            //said items? 
        }
    }
}
