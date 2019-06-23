using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    interface IStock
    {
        void AddStock();
        void UpdateStock(int stockID);
        void DeleteStockItem(int stockID);
        void GetStockInfo(int stockID);
    }
}
