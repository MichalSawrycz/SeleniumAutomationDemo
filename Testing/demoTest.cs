using TestySelenium.POMs;

namespace TestySelenium.Testing
{
    public class Test
    {
        [Test]
        public void VisitingAndLoginIntoTestWebsite()
        {
            //Test data
            string username = "TestLogin";
            string password = "TestPassword";
            var loginPage = new loginPage();

            loginPage.CompleteLogin(username, password);

            var homePage = new homePage();

            bool isHomePageDisplayed = homePage.VerifyIfHomepageIsDisplayed();
            Assert.IsTrue(isHomePageDisplayed);
         }
    }
}