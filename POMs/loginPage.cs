using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestySelenium.POMs
{
    public class loginPage
    {
        #region Elements

        private IWebDriver driver = new ChromeDriver();
        private IWebElement usernameInput => driver.FindElement(By.Name("username"));
        private IWebElement passwordInput => driver.FindElement(By.Name("password"));
        private IWebElement submitLoginBtn => driver.FindElement(By.CssSelector("input[type='submit'][class='button']"));

        #endregion Elements

        #region Public methods

        public loginPage CompleteLogin(string username, string password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm?ConnType=JDBC");
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            submitLoginBtn.Click();
            return this;
        }

        #endregion Public methods

    }
}
