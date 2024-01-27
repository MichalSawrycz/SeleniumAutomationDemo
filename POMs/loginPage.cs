using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestySelenium.POMs
{
    public class loginPage
    {
        #region Elements

        IWebDriver driver = new ChromeDriver();
        IWebElement usernameInput => driver.FindElement(By.Name("username"));
        IWebElement passwordInput => driver.FindElement(By.Name("password"));
        IWebElement submitLoginBtn => driver.FindElement(By.CssSelector("input[type='submit'][class='button']"));

        #endregion Elements

        #region Public methods

        public loginPage CompleteLogin(string username, string password)
        {
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm?ConnType=JDBC");
            usernameInput.SendKeys(username);
            passwordInput.SendKeys(password);
            submitLoginBtn.Click();
            return this;
        }

        #endregion Public methods

    }
}
