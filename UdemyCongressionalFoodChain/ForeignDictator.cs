using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCongressionalFoodChain
{
    class ForeignDictator : BigWig
    {
        public override void Eat(LittlePerson littlun)
        {
            Console.WriteLine("{0} ate a friggin {1}!!", this.GetType().Name, littlun.GetType().Name);
        }
    }
}
