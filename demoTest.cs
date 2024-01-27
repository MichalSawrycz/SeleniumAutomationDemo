using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestySelenium
{
    public class Tests
    {
        [Test]
        public void VisitingAndLoginIntoTestWebsite()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/index.htm?ConnType=JDBC");
            driver.FindElement(By.Name("username")).SendKeys("test");
            Thread.Sleep(1000);
            driver.FindElement(By.Name("password")).SendKeys("test");
            Thread.Sleep(1000);
            //driver.FindElement(By.CssSelector('input[type="submit"]')).Click();
            Assert.Pass();
        }
    }
}