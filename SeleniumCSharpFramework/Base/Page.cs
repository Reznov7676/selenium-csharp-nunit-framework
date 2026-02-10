using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public class Page
{
    protected IWebDriver driver;
    protected WebDriverWait wait;

    public Page(IWebDriver driver, WebDriverWait wait)
    {
        this.driver = driver;
        this.wait = wait;
    }

    public TPage GetInstance<TPage>() where TPage : BasePage
    {
        return (TPage)Activator.CreateInstance(
            typeof(TPage),
            driver,
            wait
        );
    }
}
