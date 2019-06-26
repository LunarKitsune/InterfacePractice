using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePractice
{
    abstract class Merchandise
    {
        /*I was originally taught by my professor for intro to c#
         *That public properties should be made to get values while having private data
         *inaccessable from the user. Is it more reliable to have it just properties
         *or should I have these with their private field counterparts?
         */

        public string SetItemType { get; set; }
        public double SetItemPrice { get; set; }
        public float SetTaxAmount { get; set; }

        public Merchandise()
        {

        }
    }

    //Merchendise Model Types
    class Ring:Merchandise, Ibreakable
    {
        //going to keep this as one socket type rings for simplicity sake
        public bool HasGemSocket { get; set; }

        //should this be set to null if there is no sockets available, or no gem is
        //chosen to be socketed?
        public Gem GetGem { get; set; } = null;
        public double GetRingBandWidth { get; set; }

        public int CurrDurability { get; set; }
        public int MaxDurability { get; set; }
        public bool IsUsable { get; set; }

        public Ring()
        { }

    }

    class Necklace : Merchandise,Ibreakable
    {
        public float GetKarats { get; set; }
        public bool HasGemSocket { get; set; }
        public Gem GemType { get; set; } = null;

        public int CurrDurability { get; set; }
        public int MaxDurability { get; set; }
        public bool IsUsable { get; set; }


    }

    //related to ring,but seperate item
    class Gem
    {
        public float GetKarats { get; set; }
        public string GetGemType { get; set; }
        public double Value { get; set; }
        public Gem()
        { }

    }
}
