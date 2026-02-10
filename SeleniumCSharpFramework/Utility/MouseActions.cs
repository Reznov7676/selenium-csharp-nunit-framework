using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumCSharpFramework.Utility
{
	public class MouseActions : BasePage
	{
        private Actions actions;
        public MouseActions(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            actions = new Actions(driver);
        }

        private readonly By baseFooter = By.XPath("//div[@class='navFooterVerticalRow navAccessibility']/div[1]/ul/li/a");
        By scrollBottonFotter = By.XPath("//*[@id='navFooter']/div[1]/div/div[1]/ul/li[4]/a");
        By wholeFooterSection = By.XPath("//*[@id='navFooter']");

        // Actions actions = new Actions(driver);

        public void CommandClickElement(IWebElement element)
        {
            actions.KeyDown(Keys.Command)   // 1. Press and hold Command
                   .Click(element)          // 2. Click the element
                   .KeyUp(Keys.Command)     // 3. Release Command
                   .Perform();              // 4. Execute the sequence
        }

        public void scroll(IWebElement element)
        {
            actions.ScrollToElement(element).Perform();
        }


        public void MultipleControlclick()
        {
            IWebElement scrollDown = driver.FindElement(scrollBottonFotter);
         
            List<IWebElement> footerCount = driver.FindElements(baseFooter).ToList();
            scroll(scrollDown);
            for (int i = 0; i <= footerCount.Count - 1; i++)
            {
                IWebElement footerLink = footerCount[i];

                waitFordocumentReady(10);
                
                WaitForElementVisible(baseFooter, 10);
            
                CommandClickElement(footerCount[i]);  
            }
        }

    }


}

