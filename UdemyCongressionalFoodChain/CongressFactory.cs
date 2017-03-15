using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCongressionalFoodChain
{
    class CongressFactory : DangerZoneFactory
    {
        public override BigWig CreateBigWig()
        {
            return new CongressMan();
        }

        public override LittlePerson CreateLittlePerson()
        {
            return new Citizen();
        }

        public override 
    }
}
