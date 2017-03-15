using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCongressionalFoodChain
{
    class GoverningBody
    {
        private BigWig _bigwig;
        private LittlePerson _littlePerson;

        public GoverningBody(DangerZoneFactory factory)
        {
            _bigwig = factory.CreateBigWig();
            _littlePerson = factory.CreateLittlePerson();
        }

        public void Run()
        {
            _bigwig.Eat(_littlePerson);
        }
    }
}
