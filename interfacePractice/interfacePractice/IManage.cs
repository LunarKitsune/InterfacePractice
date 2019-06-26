using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    interface IManage:IStocker
    {
        void CreateEmployee(int employType);
        void DestroyEmployee(int employeeID, Store StoreLocation);

    }
}
