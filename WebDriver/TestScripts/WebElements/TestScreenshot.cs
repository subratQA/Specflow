using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriver.Settings;
using WebDriver_Specflow.ComponentHelper;
using WebDriverWithCSharp.ComponentHelper;

namespace WebDriver_Specflow.TestScripts.WebElements
{
    [TestClass]
   public class TestScreenshot
    {

        [TestMethod]
        public void TestScreenShot()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.config.getUrl());
            TextBoxHelper.SetText(By.Id("Login_ContentBody_txtUsername"), ObjectRepository.config.getUserName());
            TextBoxHelper.SetText(By.Id("Login_ContentBody_txtPassword"), ObjectRepository.config.getPassword());
            ButtonHelper.ClickButton(By.Id("Login_ContentBody_btnLogin"));
            Thread.Sleep(5000);
            LinkHelper.ClickLink(By.XPath("//*[@id='ctl00_ContentBody_ctl00_grdHome_ctl00__0']/td[2]/a"));
            Thread.Sleep(3000);
            // DropDownListHelper.SelectListItemByname(By.Id("ctl00_ctl00_ContentBody_ContentBody_ddlTherapeuticArea"), "Oncology");
            GenericHelper.TakeScreenshotForMePlease();
        }
    }
}
