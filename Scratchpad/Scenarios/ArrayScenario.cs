using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Scenarios
{
    public class ArrayScenario : AbstractScenario
    {
        public override void Run()
        {
            var stringArr = new string[] { "A", "B", "C", "D", "E" };
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();

            Console.WriteLine("start at 1, using i - 1");

            for (var i = 1; i < stringArr.Length; i++)
            {
                Console.WriteLine(stringArr[i - 1]);
                sb1.Append(stringArr[i - 1]);
            }

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("start at 0, uing i");
            for (var i = 0; i < stringArr.Length; i++)
            {
                Console.WriteLine(stringArr[i]);
                sb2.Append(stringArr[i]);
            }

            Console.WriteLine(Environment.NewLine);

            if (sb1.ToString() == sb2.ToString())
            {
                Console.WriteLine("Results match {0} : {1}", sb1.ToString(), sb2.ToString());
            }
            else
            {
                Console.WriteLine("Results DO NOT match {0} : {1}", sb1.ToString(), sb2.ToString());
            }

            base.EndSceanrio();
        }
    }
}
