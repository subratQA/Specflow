using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Settings;

namespace WebDriver_Specflow.ComponentHelper
{
   public class BrowserHelper
    {
        public static void MaximizeBrowser()
        {
            ObjectRepository.driver.Manage().Window.Maximize();
        }
        public static void MoveForward()
        {
            ObjectRepository.driver.Navigate().Forward();
        }
        public static void MoveBack()
        {
            ObjectRepository.driver.Navigate().Back();
        }
    }
}
