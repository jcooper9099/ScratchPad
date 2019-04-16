using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad.Patterns.Widgets
{
    public interface IWidget
    {

        WidgetDirection Direction { get; set; }

        decimal Speed { get; set; }

        void Spin();
    }
}
