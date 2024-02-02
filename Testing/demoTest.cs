using TestySelenium.POMs;

namespace TestySelenium.Testing
{
    public class Test
    {
        [Test]
        public void VisitingAndLoginIntoTestWebsite()
        {
            //Test data
            string username = "michaelsawrycz@gmail.com";
            string password = "Test123!";
            var loginPage = new loginPage();

            loginPage.CompleteLogin(username, password);

            var homePage = new homePage();

            bool isHomePageDisplayed = homePage.VerifyIfHomepageIsDisplayed();
            Assert.IsTrue(isHomePageDisplayed);

            homePage.Logout();
         }
    }
}