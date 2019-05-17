using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Settings;
using WebDriverWithCSharp.ComponentHelper;

namespace WebDriverWithCSharp.TestScripts.WebElements
{
    [TestClass]
  public  class TestTextBox
    {
        [TestMethod]
        public void TextBoxTesting()
        {
            NavigationHelper.NavigateToURL(ObjectRepository.config.getUrl());
            TextBoxHelper.SetText(By.Id("Login_ContentBody_txtUsername"), ObjectRepository.config.getUserName());
            TextBoxHelper.SetText(By.Id("Login_ContentBody_txtPassword"), ObjectRepository.config.getPassword());
            ButtonHelper.ClickButton(By.Id("Login_ContentBody_btnLogin"));
        }
    }
}
