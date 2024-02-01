using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestySelenium.POMs
{
    public class homePage : PageObjectBase
    {
        public homePage() : base()
        {
        }
        #region Elements
        private IWebElement homePageAccountTable => Driver.FindElement(By.Id("accountTable"));

        #endregion Elements

        #region Public methods

        public bool VerifyIfHomepageIsDisplayed()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            bool IsElementVisible = homePageAccountTable.Displayed;
            return IsElementVisible;
        }

        #endregion Public methods

    }
}
