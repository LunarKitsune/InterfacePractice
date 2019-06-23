using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    public abstract class Employee:IEmployee
    {
        private string firstName;
        private string lastName;
        private int numID;
        private int storeID;
        private bool canMerchandise;

        public string GetFirstName { set { firstName = value; } }
        public string GetLastName { set { lastName = value; } }
        public int GetNumID { set { numID = value; } }
        public int GetStoreID { set { storeID = value; } }
        public bool GetMerchandisePermission { set { canMerchandise = value; } }

        public Employee()
        {

        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {firstName} {lastName}\nID:{numID}\n{storeID}");
        }

        public void Sell()
        {

        }
    }
}
