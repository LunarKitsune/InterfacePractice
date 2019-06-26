using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    //let say this person works at sephora or kay Jewlers
    class Jewler:Employee,IRepairer, IStocker
    {
        Merchandise[] ItemQueue;

        public void AppraiseRing(Ring Ring)
        {
            //appraise ring object
            //This should get a ring type, how big the ring is, and
            //if its a true ring or not? Though false ring should be its own type
        }

        public void Fix(Merchandise merch)
        {
            throw new NotImplementedException();
        }

        public double GetRepairValue(Merchandise merchandise)
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
