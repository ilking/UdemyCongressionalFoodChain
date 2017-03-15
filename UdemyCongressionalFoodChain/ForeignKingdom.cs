using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCongressionalFoodChain
{
    class ForeignKingdom : DangerZoneFactory
    {
        public override BigWig CreateBigWig()
        {
            return new ForeignDictator();
        }

        public override LittlePerson CreateLittlePerson()
        {
            return new Baby();
        }
    }
}
