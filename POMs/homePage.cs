using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestySelenium.POMs
{
    public class homePage
    {
        #region Elements

        IWebDriver driver = new ChromeDriver();

        private IWebElement homePageAccountTable => driver.FindElement(By.Id("accountTable"));


        #endregion Elements

        #region Public methods

        public bool VerifyIfHomepageIsDisplayed()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            bool IsElementVisible = homePageAccountTable.Displayed;
            return IsElementVisible;
        }

        #endregion Public methods

    }
}
