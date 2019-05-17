using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverWithCSharp.ComponentHelper
{
   public class CheckBoxHelper
    {
        private static IWebElement checkboxElement;

        public static void CheckedCheckbox(By locator)
        {
            checkboxElement = GenericHelper.GetElement(locator);
            checkboxElement.Click();
        }
        public static bool IsCheckBoxChecked(By locator)
        {
            checkboxElement = GenericHelper.GetElement(locator);
            string flag = checkboxElement.GetAttribute("checked");
            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
             
    }
}
