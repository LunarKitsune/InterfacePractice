using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class Program
    {
        public static Employee[] existingEmployees;

        static void Main(string[] args)
        {
            Jewler rob = new Jewler();

            rob.GetNumID = 123456;
            rob.GetFirstName = "Robert";
            rob.GetLastName = "Jr";
            rob.GetMerchandisePermission = true;

            Jewler stacy = new Jewler();
            stacy.GetNumID = 654321;
            stacy.GetFirstName = "Stacy";
            stacy.GetLastName = "IsYourMom";
            stacy.GetMerchandisePermission = false;
            
        }

        public void DisplayCart()
        {

        }

        public void AddToCart()
        {

        }

        public void PurchaseCart()
        {

        }
    }
}
