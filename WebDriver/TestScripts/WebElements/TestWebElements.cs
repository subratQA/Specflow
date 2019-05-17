using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Settings;

namespace WebDriverWithCSharp.TestScripts.WebElements
{
    [TestClass]
    public class TestWebElements
    {
        [TestMethod]
        public void GetElement()
        {
            IReadOnlyCollection<IWebElement> iList =  ObjectRepository.driver.FindElements(By.TagName("input"));
            iList.Count();

        }

    }
}
