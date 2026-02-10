using System;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpFramework.Utility
{
	public class BrowserActions : BasePage
	{
        public BrowserActions(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void openUrl(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                driver.Navigate().GoToUrl(url);
            }
            else
            {
                throw new Exception($"URL is not present : {url}");
            }
            
        }

        public void refreshPage()
        {
            driver.Navigate().Refresh();
        }

        public void CloseBrowser()
        {
            driver.Close();
        }

        public void VerifyLinkIsWorking(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD"; // lightweight request
            request.Timeout = 10000;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if ((int)response.StatusCode >= 400)
            {
                throw new Exception($"Broken link: {url} - Status: {response.StatusCode}");
            }

            response.Close();
        }
    }
}

