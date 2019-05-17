using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriver.Interfaces;
using WebDriver.Settings;
using WebDriver_Specflow.ActionUtilities;

namespace WebDriverWithCSharp.ComponentHelper
{
   public class TextBoxHelper
    {
        private static IWebElement element;

        public static bool IsClickable { get; private set; }
        public static object DebugException { get; private set; }

        public static bool SetText(IWebElement Locator, string text, string logMessageOnException)
        {
            // element = GenericHelper.GetElement(Locator);
            // element.SendKeys(text);
            bool isTextEntered = false;
            try
            {
                if (Locator != null && Locator.Displayed)
                {
                    LoginUtil.ScrollIntoView(Locator);
                    ObjectRepository.webelement = GenericHelper.GetElement(Locator);
                    ObjectRepository.webelement.SendKeys(text);
                    isTextEntered = true;
                }
                if (!isTextEntered)
                {
                    //LogException("Object does not exist and failed to set text to textbox", String.Empty, logMessageOnException);
                }
            }
            catch (Exception e)
            {
               // LogException("Failed to set text to textbox", e.ToString(), logMessageOnException);
            }
            return isTextEntered;

        }
                  
        

        public static void ClearTextFromTextBox(By Locator)
        {
            //element = GenericHelper.GetElement(Locator);
            //element.Clear();
            ObjectRepository.webelement = GenericHelper.GetElement(Locator);
            ObjectRepository.webelement.Clear();
        }
    }
}
