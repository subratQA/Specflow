using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Interfaces;
using WebDriverWithCSharp.ComponentHelper;

namespace WebDriver_Specflow.Pages
{
    public class Page_Login
    {
        public static IWebElement UserNameTextbox { get { return GenericHelper.GetElement(By.Id("txtUsername")); } }

        public static IWebElement PasswordTextbox { get { return GenericHelper.GetElement(By.Id("txtPassword")); } }

        public static IWebElement LoginButton { get { return GenericHelper.GetElement(By.Id("btnLogin")); } }
    }
}
