using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    class Manager : Employee, IEmployee, IManage
    {
        public void CreateEmployee(int EmployType)
        {
            switch(EmployType)
            {

            }
        }

        public void DestroyEmployee()
        {
            throw new NotImplementedException();
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
