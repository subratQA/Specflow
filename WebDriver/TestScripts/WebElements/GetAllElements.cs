using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriver.Settings;
using WebDriverWithCSharp.ComponentHelper;

namespace WebDriver_Specflow.TestScripts.WebElements
{
    [TestClass]
   public class GetAllElements
    {
        [TestMethod]
        public void GetAllElementsInWebPage()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.config.getUrl());
            TextBoxHelper.SetText(By.Id("Login_ContentBody_txtUsername"), ObjectRepository.config.getUserName());
            TextBoxHelper.SetText(By.Id("Login_ContentBody_txtPassword"), ObjectRepository.config.getPassword());
            ButtonHelper.ClickButton(By.Id("Login_ContentBody_btnLogin"));
            Thread.Sleep(5000);
            LinkHelper.ClickLink(By.XPath("//*[@id='ctl00_ContentBody_ctl00_grdHome_ctl00__0']/td[2]/a"));
            Thread.Sleep(3000);
            IReadOnlyList<IWebElement> iList =  ObjectRepository.driver.FindElements(By.XPath("//input"));
            Console.WriteLine("Total matching element: {0}", iList.Count);
            foreach(var ele in iList)
            {
                Console.WriteLine("Element Name: {0}", ele.GetAttribute("name"));
            }
        }
        [TestMethod]
        public void TestWebDriverWait()
        {
            ObjectRepository.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            //ObjectRepository.driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
            NavigationHelper.NavigateToURL(ObjectRepository.config.getUrl());
            Thread.Sleep(1000);
        }
        [TestMethod]
        public void TestDynamicWait()
        {
            DefaultWait<IWebElement> iWait = new DefaultWait<IWebElement>(ObjectRepository.driver.FindElement(By.Id("")));

        }
    }
}
