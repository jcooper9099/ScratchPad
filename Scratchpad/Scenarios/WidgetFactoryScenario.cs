using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scratchpad.Patterns.Factory;
using Scratchpad.Patterns.Widgets;

namespace Scratchpad.Scenarios
{
    public class WidgetFactoryScenario: AbstractScenario
    {
        public override void Run()
        {

            Console.WriteLine("Ask factory to produce a FastWidget. Hit any key");
            Console.ReadKey();

            var fastWidget = WidgetFactory.Instance.Generate(WidgetType.Fast);

            Console.WriteLine("FastWidget Produced. Hit any key to spin the FastWidget");
            Console.ReadKey();           
            fastWidget.Spin();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Ask factory to produce a SlowWidget. Hit any key");
            Console.ReadKey();

            var slowWidget = WidgetFactory.Instance.Generate(WidgetType.Slow);

            Console.WriteLine("SlowWidget Produced. Hit any key to spin the SlowWidget");
            Console.ReadKey();
            slowWidget.Spin();

            base.EndSceanrio();
        }
    }
}
