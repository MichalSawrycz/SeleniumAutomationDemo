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
        private IWebElement usernameInput => Driver.FindElement(By.CssSelector("input[data-qa='login-email']"));
        private IWebElement passwordInput => Driver.FindElement(By.CssSelector("input[data-qa='login-password']"));
        private IWebElement submitLoginBtn => Driver.FindElement(By.CssSelector("button[data-qa='login-button']"));

        #endregion Elements

        #region Public methods

        public loginPage CompleteLogin(string username, string password)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://automationexercise.com/login");
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            submitLoginBtn.Click();
            return this;
        }

        #endregion Public methods

    }
}
