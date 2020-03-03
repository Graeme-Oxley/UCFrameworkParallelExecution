namespace AutoFramework
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

    public class Driver
    {
        public IWebDriver driver { get; set; }

        public void WaitForElementUpTo(int seconds = 5)
        {
        }
    }
}
