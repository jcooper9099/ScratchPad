using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Scenarios
{
    class MinDateValueScenario : AbstractScenario
    {

        public override void Run()
        {
            Console.WriteLine(DateTime.MinValue.ToString("MM/dd/yyyy"));

            base.EndSceanrio();
        }


    }
}
