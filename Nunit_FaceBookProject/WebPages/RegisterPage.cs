using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;


namespace Nunit_FaceBookProject.WebPages
{
    public class RegisterPage
    {
        public static Actions notify1;
        public static void SignUpintoFacebookWithClass(IWebDriver driver)
        {
            IWebElement button = driver.FindElement(By.XPath("//*[@class='_6ltg'][2]"));
            button.Click();

            //notify1 = new Actions(driver);
            //notify1.MoveByOffset((int)164.688,48).Click().Build().Perform();

            System.Threading.Thread.Sleep(5000);
            driver.FindElement(By.Name("firstname")).SendKeys("pritheesh");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("lastname")).SendKeys("k");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("reg_email__")).SendKeys("testprogrammer80@gmail.com");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("testprogrammer80@gmail.com");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("test@123");
            System.Threading.Thread.Sleep(1000);
            SelectElement element = new SelectElement(driver.FindElement(By.Name("birthday_day")));
            //Here we select the day by using text
            element.SelectByText("12");
            System.Threading.Thread.Sleep(1000);
            SelectElement element1 = new SelectElement(driver.FindElement(By.Id("month")));
            //Here we select the month by using value
            element1.SelectByValue("1");
            System.Threading.Thread.Sleep(1000);
            SelectElement element2 = new SelectElement(driver.FindElement(By.Id("year")));
            //Here we select the year by using value
            element2.SelectByValue("1999");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("sex")).Click();
            System.Threading.Thread.Sleep(1000);
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("websubmit")).Click();
            System.Threading.Thread.Sleep(1000);
            
        }

        
    }
}
