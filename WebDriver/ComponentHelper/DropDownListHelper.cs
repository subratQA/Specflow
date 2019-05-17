using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverWithCSharp.ComponentHelper;

namespace WebDriver_Specflow.ComponentHelper
{
    public class DropDownListHelper
    {
        private static IWebElement element;
        public static void SelectListItemByname(By Locator, string item)
        {
            element = GenericHelper.GetElement(Locator);
            SelectElement select = new SelectElement(element);
            select.SelectByValue(item);
        }
        public static void SelectListByIndex(By Locator, int index)
        {
            element = GenericHelper.GetElement(Locator);
            SelectElement select = new SelectElement(element);
            select.SelectByIndex(index);
        }
        public static IList<string> GetAllItem(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            SelectElement select = new SelectElement(element);
            return select.Options.Select((x) => x.Text).ToList();//Linq expression        }
        }
    }
}
