using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestySelenium.POMs
{
    public class loginPage : PageObjectBase
    {
        public loginPage() : base()
        {
        }
        #region Elements
        private IWebElement usernameInput => Driver.FindElement(By.Name("username"));
        private IWebElement passwordInput => Driver.FindElement(By.Name("password"));
        private IWebElement submitLoginBtn => Driver.FindElement(By.CssSelector("input[type='submit'][class='button']"));

        #endregion Elements

        #region Public methods

        public loginPage CompleteLogin(string username, string password)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm?ConnType=JDBC");
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            submitLoginBtn.Click();
            return this;
        }

        #endregion Public methods

    }
}
