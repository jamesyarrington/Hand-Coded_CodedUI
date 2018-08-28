using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_Coding_Tutorial
{

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class CalciFun
    {
        static UITestControl control = Launch.Control();

        [TestMethod]
        public void CallFun()
        {
            ApplicationUnderTest app = ApplicationUnderTest.Launch("C:\\Windows\\System32\\calc.exe");
            Mouse.Click(btnmethod8());
            Mouse.Click(btnmethodAdd());
            Mouse.Click(btnmethod7());
            Mouse.Click(btnmethodEqual());
            Assert.AreEqual("10", txtmethodResult().GetProperty(WinText.PropertyNames.DisplayText));
        }

        #region Buttons
        public static UITestControl btnmethod8()
        {
            UITestControl btn8 = new WinButton(control);
            btn8.SearchProperties[UITestControl.PropertyNames.Name] = "8";
            return btn8;
        }

        public static UITestControl btnmethod7()
        {
            UITestControl btn8 = new WinButton(control);
            btn8.SearchProperties[UITestControl.PropertyNames.Name] = "7";
            return btn8;
        }

        public static UITestControl btnmethodAdd()
        {
            UITestControl btn8 = new WinButton(control);
            btn8.SearchProperties[UITestControl.PropertyNames.Name] = "Add";
            return btn8;
        }

        public static UITestControl btnmethodEqual()
        {
            UITestControl btn8 = new WinButton(control);
            btn8.SearchProperties[UITestControl.PropertyNames.Name] = "Equals";
            return btn8;
        }
        #endregion

        #region Text Box
        public static UITestControl txtmethodResult()
        {
            UITestControl txtResult = new WinText(control);
            txtResult.SearchProperties[UITestControl.PropertyNames.Name] = "Result";
            return txtResult;
        }
        #endregion
    }
}
