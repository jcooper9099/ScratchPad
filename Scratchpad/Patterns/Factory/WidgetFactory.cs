using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scratchpad.Patterns.Widgets;

namespace Scratchpad.Patterns.Factory
{
    /// <summary>
    ///  A factory for producing "Widgets".
    ///  Implements simple factory pattern
    ///  Implements simple singleton pattern
    /// </summary>
    public class WidgetFactory
    {
        private static WidgetFactory _instance;

        public static WidgetFactory Instance { get
            {
                if(_instance == null)
                {
                    _instance = new WidgetFactory();
                }

                return _instance;

            } }

        private WidgetFactory()
        {
            

        }

        public IWidget Generate(WidgetType type)
        {
            IWidget widget;
            switch (type)
            {
                case WidgetType.Fast:
                    widget = new FastWidget();
                    break;
                case WidgetType.Slow:
                    widget = new SlowWidget();
                    break;
                default:
                    widget = null;
                    break;                    
            }

            return widget;

        }
    }
}
