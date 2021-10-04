using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit_FaceBookProject.Pages
{
    public class HomePageData
    {
        //Used to intialize elements of a page class
        public HomePageData(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='bcvklqu9 nzypyw8j']")]
        [CacheLookup]
        public IWebElement dashboard;

        [FindsBy(How = How.XPath, Using = "//span[@class='l9j0dhe7']")]
        [CacheLookup]
        public IWebElement home;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/span[1]")]
        [CacheLookup]
        public IWebElement createpost;

        [FindsBy(How = How.XPath, Using = "//*[@class='_1mf _1mj']")]
        [CacheLookup]
        public IWebElement message;

        [FindsBy(How = How.XPath, Using = "//*[@class='dwxx2s2f dicw6rsg kady6ibp rs0gx3tq'][1]")]
        [CacheLookup]
        public IWebElement photo;

        [FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn rt8b4zig n8ej3o3l agehan2d sk4xxmp2 rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
        [CacheLookup]
        public IWebElement addphoto;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]")]
        [CacheLookup]
        public IWebElement post;

        [FindsBy(How = How.XPath, Using = "//*[text()='Vacation Begins!!']")]
        [CacheLookup]
        public IWebElement successfulpost;

    }
}
