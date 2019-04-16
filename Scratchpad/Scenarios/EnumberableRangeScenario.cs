using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Scenarios
{
    public class EnumberableRangeScenario: AbstractScenario
    {
        public override void Run()
        {
            Console.WriteLine("Test if the Enumerable.Range(1,100) function includes 1 and 100");
            

            if (Enumerable.Range(1, 100).Contains(1))
            {
                Console.WriteLine("1 is included");
            }
            else
            {
                Console.WriteLine("1 is NOT  included");
            }

            if (Enumerable.Range(1, 100).Contains(100))
            {
                Console.WriteLine("100 is included");
            }
            else
            {
                Console.WriteLine("100 is NOT included");
            }

            base.EndSceanrio();

        }
    }
}
