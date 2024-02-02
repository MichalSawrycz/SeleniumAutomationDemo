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
        private IWebElement FeaturedItemsList => Driver.FindElement(By.ClassName("features_items"));
        private IWebElement LogoutBtn => Driver.FindElement(By.CssSelector("a[href='/logout']"));

        #endregion Elements

        #region Public methods

        public bool VerifyIfHomepageIsDisplayed()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            bool IsElementVisible = FeaturedItemsList.Displayed;
            return IsElementVisible;
        }

        public void Logout()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            LogoutBtn.Click();
        }

        #endregion Public methods

    }
}
