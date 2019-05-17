using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Interfaces;
using WebDriver.Settings;
using WebDriver_Specflow.Pages;
using WebDriverWithCSharp.ComponentHelper;

namespace WebDriver_Specflow.ActionUtilities
{
   public class LoginUtil
    {
        public static bool Login(string username, string password)
        {
            try
            {
                ObjectRepository.config.GetBrowserType();
                TextBoxHelper.SetText(Page_Login.UserNameTextbox, username, "Unable to set user name in LoginPage");
                TextBoxHelper.SetText(Page_Login.PasswordTextbox, password, "Unable to set user name in LoginPage");
                ButtonHelper.ClickButton(Page_Login.LoginButton);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static void ScrollIntoView(IWebElement webElement)
        {
            ((OpenQA.Selenium.IJavaScriptExecutor)ObjectRepository.driver).ExecuteScript("arguments[0].scrollIntoView(false);", webElement);
        }
    }
}
