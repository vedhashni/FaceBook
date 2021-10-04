using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Nunit_FaceBookProject.Pages
{
    public class LogoutPage
    {
        //Used to intialize elements of a page class
        public LogoutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='j83agx80 l9j0dhe7']")]
        [CacheLookup]
        public IWebElement accountbtn;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Log Out')]")]
        [CacheLookup]
        public IWebElement logout;

        [FindsBy(How = How.XPath, Using = "//*[text()='Recent logins']")]
        [CacheLookup]
        public IWebElement logoutsuccessful;
    }
}
