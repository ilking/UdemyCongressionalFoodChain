using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCongressionalFoodChain
{
    class Program
    {
        static void Main(string[] args)
        {
            DangerZoneFactory fact1 = new CongressFactory();
            GoverningBody gb = new GoverningBody(fact1);
            gb.Run();

            DangerZoneFactory fact2 = new ForeignKingdomFactory();
            GoverningBody gb2 = new GoverningBody(fact2);
            gb2.Run();
        }
    }
}
