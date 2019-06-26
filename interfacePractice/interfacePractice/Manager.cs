using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class Manager : Employee,IManage,IStocker
    {
        private enum jobCode { manager = 1, jewler = 2, clerk = 3}

        public void CreateEmployee(int EmployType)
        {
            switch(EmployType)
            {
                case 1:
                    Manager newManager = new Manager();
                    break;
                case 2:
                    Jewler newJewler = new Jewler();
                    break;
            }
        }

        public void DestroyEmployee(int numID, Store storeID)
        {
            
        }

        public void AddStock()
        {
            throw new NotImplementedException();
        }

        public void DeleteStockItem(int stockID)
        {
            throw new NotImplementedException();
        }

        public void GetStockInfo(int stockID)
        {
            throw new NotImplementedException();
        }

        public void UpdateStock(int stockID)
        {
            throw new NotImplementedException();
        }

    }
}
