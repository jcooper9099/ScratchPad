using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Scenarios
{
    public class BoxingScenario : AbstractScenario
    {
        public override void Run()
        {
            var plainInt = 128;
            Console.WriteLine(plainInt);
            object oInt = plainInt;
            Console.WriteLine(plainInt);
            base.EndSceanrio();
        }
    }
}
