using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCongressionalFoodChain
{
    abstract class DangerZoneFactory
    {
        public abstract BigWig CreateBigWig();
        public abstract LittlePerson CreateLittlePerson();
    }
}
