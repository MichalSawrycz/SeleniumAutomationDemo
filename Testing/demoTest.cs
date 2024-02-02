using TestySelenium.POMs;

namespace TestySelenium.Testing
{
    public class Test
    {
        [Test]
        public void VisitingAndLoginIntoTestWebsite()
        {
            //Test data
            string username = Environment.GetEnvironmentVariable("SELENIUM_USERNAME");
            string password = Environment.GetEnvironmentVariable("SELENIUM_PASSWORD");

            var loginPage = new loginPage();

            loginPage.CompleteLogin(username, password);

            var homePage = new homePage();

            bool isHomePageDisplayed = homePage.VerifyIfHomepageIsDisplayed();
            Assert.IsTrue(isHomePageDisplayed);

            homePage.Logout();
         }
    }
}