using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_Coding_Tutorial
{

    using Microsoft.VisualStudio.TestTools.UITesting;

    class Launch
    {
        public static UITestControl calciwindow;

        public static UITestControl Control()
        {
            calciwindow = new UITestControl();
            calciwindow.TechnologyName = "MSAA";
            calciwindow.SearchProperties[UITestControl.PropertyNames.Name] = "Calculator";
            calciwindow.SearchProperties[UITestControl.PropertyNames.ClassName] = "CalcFrame";
            return calciwindow;
        }

    }
}
