using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Interfaces;

namespace WebDriver.Settings
{
   public class ObjectRepository
    {
        public static IConfig config { get; set; }
        public static IWebDriver driver { get; set; }
        public static IWebElement webelement { get; set; }
    }
}
