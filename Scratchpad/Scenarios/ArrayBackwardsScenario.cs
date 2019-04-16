using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Scenarios
{
    public class ArrayBackwardsScenario : AbstractScenario
    {

        public override void Run()
        {
            var arr = new int[] { 1, 2, 3, 4, 5 };

            for (var i = arr.Length; i --> 0;)
            {
                Console.WriteLine(arr[i]);
            }

            base.EndSceanrio();
        }
    }
}
