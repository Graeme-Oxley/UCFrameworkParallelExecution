namespace AutoFramework
{
    using AutoFramework.Pages;
    using OpenQA.Selenium;

    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughTestCases(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameCasePost ucPost = new UsernameCasePost(driver);

            menu.TestCases.Click();
            tcPage.UsernameCase.Click();
            ucPost.LoginFormLink.Click();
        }

        public static void LoginFormScenarioThroughMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenariosPage tsPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            tsPage.LoginFormScenario.Click();
        }
    }
}
