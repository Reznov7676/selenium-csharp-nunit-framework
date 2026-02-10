using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public abstract class BasePage
{
    protected IWebDriver driver;
    protected WebDriverWait wait;

    protected BasePage(IWebDriver driver, WebDriverWait wait)
    {
        this.driver = driver;
        this.wait = wait;
    }

   
    
    protected void WaitForElementVisible(By locator , int Time)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Time));
        wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));

    }


    protected void WaitForElementClickable(By locator)
    {

         wait.Until(ExpectedConditions.ElementToBeClickable(locator));
    }

    protected void WaitForElementVisible(IWebElement element, int time)
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
        wait.Until(ExpectedConditions.ElementToBeClickable(element));
    }

    public void waitFordocumentReady(int t)
    {
         driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(t);
    }


}
