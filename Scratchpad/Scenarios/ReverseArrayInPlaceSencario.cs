using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Scenarios
{
    public class ReverseArrayInPlaceSencario : AbstractScenario
    {
        public override void Run()
        {

            Console.WriteLine("Starts with int array { 1, 2, 3, 4, 5 }");
            Console.WriteLine("Reverses array");
            var intArr = new int[] { 1, 2, 3, 4, 5 };

            for (var i = 0; i < intArr.Length / 2; i++)
            {
                int tmp = intArr[i];
                var pos = intArr.Length - i - 1;
                intArr[i] = intArr[pos];
                intArr[pos] = tmp;

            }

            

            for(var j = 0; j < intArr.Length; j++)
            {
                Console.WriteLine(intArr[j]);
            }

            base.EndSceanrio();
        }

    }
}
