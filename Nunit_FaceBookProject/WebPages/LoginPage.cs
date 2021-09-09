using NUnit.Framework;
using OpenQA.Selenium;


namespace Nunit_FaceBookProject.WebPages
{
    public class LoginPage
    {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void LoginToFacebook(IWebDriver driver)
        {
            driver.FindElement(By.Name("email")).SendKeys("9843801062");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Id("pass")).SendKeys("vedha@1");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
