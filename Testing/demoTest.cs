using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestySelenium.POMs;

namespace TestySelenium.Testing
{
    public class Test
    {
        [Test]
        public void VisitingAndLoginIntoTestWebsite()
        {
            string username = "test";
            string password = "test";
            var loginPage = new loginPage();

            loginPage.CompleteLogin(username, password);
         }
    }
}