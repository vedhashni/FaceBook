using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Nunit_FaceBookProject.Pages
{
    public class SignUpPage
    {
        //Used to intialize elements of a page class
        public SignUpPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='fb_logo _8ilh img']")]
        [CacheLookup]
        public IWebElement logo;

        [FindsBy(How = How.XPath, Using = "//*[@class='_6ltg'][2]")]
        [CacheLookup]
        public IWebElement createnewaccountbtn;

        [FindsBy(How = How.Name, Using = "firstname")]
        [CacheLookup]
        public IWebElement FirstName;

        [FindsBy(How = How.Name, Using = "lastname")]
        [CacheLookup]
        public IWebElement SurName;

        [FindsBy(How = How.Name, Using = "reg_email__")]
        [CacheLookup]
        public IWebElement Email;

        [FindsBy(How = How.Name, Using = "reg_email_confirmation__")]
        [CacheLookup]
        public IWebElement ReConfirmEmail;

        [FindsBy(How = How.Name, Using = "reg_passwd__")]
        [CacheLookup]
        public IWebElement Password;

        [FindsBy(How = How.Name, Using = "birthday_day")]
        [CacheLookup]
        public IWebElement Date;

        [FindsBy(How = How.Id, Using = "month")]
        [CacheLookup]
        public IWebElement Month;

        [FindsBy(How = How.Id, Using = "year")]
        [CacheLookup]
        public IWebElement Year;

        [FindsBy(How = How.Name, Using = "sex")]
        [CacheLookup]
        public IWebElement Gender;

        [FindsBy(How = How.Name, Using = "websubmit")]
        [CacheLookup]
        public IWebElement SignUp;
    }
}
