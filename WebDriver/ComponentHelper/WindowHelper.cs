using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Settings;

namespace WebDriverWithCSharp.ComponentHelper
{
   public class WindowHelper
    {
        public static string GetTitle()
        {
            return ObjectRepository.driver.Title;
        }
    }
}
