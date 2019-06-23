using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    //let say this person works at sephora or kay Jewlers
    class Jewler:Employee,IEmployee, IRepair
    {
        Ring[] ringQueue;

        public void AppraiseRing(string ringType)
        {
            //appraise ring object
            //This should get a ring type, how big the ring is, and
            //if its a true ring or not? Though false ring should be its own type
        }

        public void Fix()
        {
            foreach(Ring broken in ringQueue)
            {

            }
            throw new NotImplementedException();
        }

        public double GetRepairValue()
        {
            double repairValue = 0;

            //implement something somewhere where we can get max durability of a ring
            //and the current durability and some equation to get a repair value

            return repairValue;
        }
    }
}
