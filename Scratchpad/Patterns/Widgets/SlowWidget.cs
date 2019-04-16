using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Patterns.Widgets
{
    public class SlowWidget : IWidget
    {

        private decimal _maxSpeed { get; } = 45M;

        public decimal Speed { get; set; } = 30M;
        public WidgetDirection Direction { get; set; } = WidgetDirection.Left;

        public SlowWidget()
        {

        }

        public void Spin()
        {
            if (Speed > _maxSpeed)
            {
                Console.WriteLine("Speed of {0} greater than max speed of {1}. Widget does not spin for safety reasons", Speed, _maxSpeed);
            }
            else
            {
                Console.WriteLine("Widget Spins {0}  at {1} parsecs per light year", Direction.ToString(), Speed);
            }
        }
    }
}
