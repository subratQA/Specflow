using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Settings;

namespace WebDriverWithCSharp.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToURL(string url)
        {
            ObjectRepository.driver.Navigate().GoToUrl(url);
        }
    }
}
