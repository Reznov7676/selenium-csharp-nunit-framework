using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpFramework.Utility
{
	public class WindowsHelper :  BasePage
    {
        public WindowsHelper(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }


        public string GetWindowTitle()
        {
            return driver.Title;
        }

        public string GetWindowTitleByHandle(string windowhandle)
        {
          string Windowtitle=  driver.SwitchTo().Window(windowhandle).Title;
            return Windowtitle;
        }

        /// <summary>
        /// This method switches to tab if window Title is matching
        /// </summary>
        public void switchTowindowByTitle()
        {
             var a=driver.WindowHandles;
        
            for (int i=0;i<=a.Count-1;i++)
            {
                string Windowtitle= driver.SwitchTo().Window(a[i]).Title;
                string test = "Press Center - IN Press Center";
                if (Windowtitle.Equals(test))
                {
                    driver.SwitchTo().Window(a[i]);
                    break;
                }
                
            }
          
        }


        public string getWindowHandle()
        {
           return driver.CurrentWindowHandle;
          
        }

        public void getMultipleWindows()
        {
       
        }
        public void getMultipleTabs()
        {
           // driver.SwitchTo().Window();
        }

        public void test()
        {

            string a=driver.CurrentWindowHandle;
            //driver.CurrentWindowHandle.
        }




    }
}

