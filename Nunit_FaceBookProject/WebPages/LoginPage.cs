using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Nunit_FaceBookProject.WebPages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginbutton;

        [FindsBy(How = How.XPath, Using = "//span[contains(@class,'l9j0dhe7')]")]
        [CacheLookup]
        public IWebElement home;

        //[FindsBy(How = How.XPath, Using = "//*[contains(@class,'n00je7tq arfg74bv qs9ysxi8 k77z8yql i09qtzwb n7fi1qx3 b5wmifdl hzruof5a pmk7jnqg j9ispegn kr520xx4 c5ndavph art1omkt ot9fgl3s rnr61an3')]")]
        //[CacheLookup]
        //public IWebElement photo;
    }
}
