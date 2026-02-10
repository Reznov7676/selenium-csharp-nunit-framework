using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using SeleniumCSharpFramework.Utility;

namespace SeleniumCSharpFramework.TestAreas.HomePage.PageObjects
{
	public class HomePageMethods : BasePage
	{
        private MouseActions mouseActions;
        private BrowserActions browseractions;
        public HomePageMethods(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
            mouseActions = new MouseActions(driver, wait);
            browseractions = new BrowserActions(driver, wait);
        }
         
        /// <summary>
        /// Locators related to Homepage
        /// </summary>
        By searchButton = By.XPath("//*[@id='nav-search-submit-button']");
        private readonly By baseFooter = By.XPath("//div[@class='navFooterVerticalRow navAccessibility']/div[1]/ul/li/a");
        By footerUrls = By.XPath("//li[@class='nav_first']/a");


        public void verifysearchButton_HomePage()
		{
            WaitForElementVisible(searchButton, 10);
        }


        /// <summary>
        /// This method verifies the text of botton footer links
        /// </summary>
        /// <param name="bottom_footerLinks"></param>
        /// <exception cref="Exception"></exception>
        public void verify_footerLinkNames(string[] bottom_footerLinks)
        {
            waitFordocumentReady(10);
            IWebElement scrollDown = driver.FindElement(baseFooter);
            mouseActions.scroll(scrollDown);

            List<IWebElement> footerLink = driver.FindElements(baseFooter).ToList();
            for (int i = 0; i <= footerLink.Count - 1; i++)
            {
                WaitForElementVisible(baseFooter, 10);
                string Single_footerlink = footerLink[i].Text;
                string footerLinkfromTestData = bottom_footerLinks[i].ToString();

                if (Single_footerlink == footerLinkfromTestData)
                {
                    Console.WriteLine("matching");
                }
                else
                {
                    throw new Exception($"Not matching : {Single_footerlink}");
                }
            }
        }

        public void openMultiple_bottomFooterLinks()
        {
            mouseActions.MultipleControlclick();
        }

        public void verifyFooterLinks_working()
        {
            List<IWebElement> ABC = driver.FindElements(footerUrls).ToList();

            for(int i=0;i<= ABC.Count - 1; i++)
            {
              string url =  ABC[i].GetAttribute("href");
                if (string.IsNullOrEmpty(url))
                {
                    throw new Exception("Footer link has empty href attribute");
                }

                browseractions.VerifyLinkIsWorking(url);

                Console.WriteLine($"✔ Link working: {url}");
            }

        }
            


        }
    }


