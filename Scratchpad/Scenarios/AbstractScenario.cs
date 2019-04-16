using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad
{
    public class AbstractScenario
    {
        public virtual void Run()
        {

        }

        public virtual void EndSceanrio()
        {
            Console.WriteLine("Hit any key to exit");
            Console.ReadKey();
        }


    }
}
