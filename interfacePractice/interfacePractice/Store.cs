using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class Store
    {
        //set some sort of inventory model here
        double VaultAmt;
        Dictionary<Merchandise, double> availableRingInv;
        Dictionary<Employee, int> AvailableEmployees; 

        public Store()
        {

        }

        public void LoadStoreState()
        {
            //assume this function will load some database of inventory
            //(I don't have/done database practice coding yet)
        }

        public void SerializeStoreState()
        {
            //Assume this function will save 
        }

        public void CreateCustomer()
        {

        }
    }

    
}
