using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Settings;
using WebDriverWithCSharp.ComponentHelper;

namespace WebDriver.TestScripts.PageNavigations
{
    [TestClass]
   public class Login
    {
        [TestMethod]
        public void LoginToDesigner()
        {
           //INavigation page= ObjectRepository.driver.Navigate();
            //page.GoToUrl(ObjectRepository.config.getUrl());
           // ObjectRepository.driver.Navigate().GoToUrl(ObjectRepository.config.getUrl());
            NavigationHelper.NavigateToURL(ObjectRepository.config.getUrl());
            Console.WriteLine("Title of page is : " + ObjectRepository.driver.Title);
            Console.WriteLine("Title of the page is : " + WindowHelper.GetTitle());            
        }
    }
}
