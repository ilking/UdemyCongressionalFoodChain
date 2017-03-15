using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCongressionalFoodChain
{
    class CongressMan : BigWig
    {
        public override void Eat(LittlePerson littlun)
        {
            Console.WriteLine("{0} eats {1}!", this.GetType().Name, littlun.GetType().Name);
        }
    }
}
