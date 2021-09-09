using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Nunit_FaceBookProject.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
        }
        [TearDown]
        public void TearDown()
        {

            driver.Quit();
        }
    }
}
