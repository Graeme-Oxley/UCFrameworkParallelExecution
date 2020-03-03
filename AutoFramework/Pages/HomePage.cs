namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > header > div.mh-container.mh-container-inner.mh-row.clearfix > div > a > div > div > h1")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > header > div.mh-container.mh-container-inner.mh-row.clearfix > div > a > div > div > h2")]
        public IWebElement SubHeader { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(1) > a > img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }
    }
}
