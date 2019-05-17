using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriver.Settings;
using WebDriver_Specflow.ActionUtilities;
using WebDriverWithCSharp.ComponentHelper;

namespace WebDriver_Specflow.StepDefinations
{
    [Binding]
    class StepDef_CreateNewStudy
    {
        [Given(@"I Logged into Designer application")]
        public void GivenILoggedIntoDesignerApplication()
        {
            if(!LoginUtil.Login(ObjectRepository.config.getUserName(), ObjectRepository.config.getPassword()))
            {
                ScenarioContext.Current["ActResult"] = "Failed";
            }
            
        }



    }
}
