using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Actions actionProvider = new Actions(Driver);

            Driver.Manage().Window.Maximize();
            
            // REGISTER

            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            /*
            Driver.FindElement(By.XPath("//input[@id='email_create']")).SendKeys("zeusalmighty398@gmail.com");
            Driver.FindElement(By.XPath("//button[@id='SubmitCreate']")).Click();
            Thread.Sleep(2000);

            
            //Driver.FindElement(By.XPath("//span//input[@id='id_gender1']")).Click();

            IWebElement YesBtn = Driver.FindElement(By.XPath("//span//input[@id='id_gender1']"));

            Thread.Sleep(2000);

            js.ExecuteScript("arguments[1].click()", YesBtn);

            Thread.Sleep(2000);

            js.ExecuteScript("arguments[0].click()", YesBtn);

            Thread.Sleep(2000);;
            

            Driver.FindElement(By.XPath("//div//input[@id='customer_firstname']")).SendKeys("Zeus");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div//input[@id='customer_lastname']")).SendKeys("Almighty");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div//input[@id='passwd']")).SendKeys("Qwertyuiop@12345");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div//select[@id='days']")).Click();
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//div//select[@id='days']")).SendKeys(Keys.ArrowDown);
            Driver.FindElement(By.XPath("//div//select[@id='days']")).SendKeys(Keys.Enter);
            Driver.FindElement(By.XPath("//div//select[@id='months']")).SendKeys(Keys.ArrowDown);
            Driver.FindElement(By.XPath("//div//select[@id='months']")).SendKeys(Keys.Enter);
            Driver.FindElement(By.XPath("//div//select[@id='years']")).SendKeys(Keys.ArrowDown);
            Driver.FindElement(By.XPath("//div//select[@id='years']")).SendKeys(Keys.Enter);

            Driver.FindElement(By.XPath("//p//input[@id='firstname']")).SendKeys("Zeus");
            Driver.FindElement(By.XPath("//p//input[@id='lastname']")).SendKeys("Almighty");
            Driver.FindElement(By.XPath("//p//input[@id='company']")).SendKeys("ABCD");
            Driver.FindElement(By.XPath("//p//input[@id='address1']")).SendKeys("Kolkata,toyyugdydg, 3rd floor , 6th lane ");
            Driver.FindElement(By.XPath("//p//input[@id='address2']")).SendKeys("howrah");
            Driver.FindElement(By.XPath("//p//input[@id='city']")).SendKeys("howrah");


            Driver.FindElement(By.XPath("//div//select[@id='id_state']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div//select[@id='id_state']")).SendKeys(Keys.ArrowDown);
            Driver.FindElement(By.XPath("//div//select[@id='id_state']")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            Driver.FindElement(By.XPath("//p//input[@id='postcode']")).SendKeys("00000");

            Driver.FindElement(By.XPath("//div//select[@id='id_country']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div//select[@id='id_country']")).SendKeys(Keys.ArrowDown);
            Driver.FindElement(By.XPath("//div//select[@id='id_country']")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//p//textarea[@id='other']")).SendKeys("Nothing to write.");
            Driver.FindElement(By.XPath("//p//input[@id='phone_mobile']")).SendKeys("123456789");
            Driver.FindElement(By.XPath("//p//input[@id='alias']")).SendKeys("India");

            Driver.FindElement(By.XPath("//div//button[@id='submitAccount']")).Click();
            Thread.Sleep(2000);
            */


            // Sign IN    

            Driver.FindElement(By.XPath("//div//input[@id='email']")).SendKeys("zeusalmighty398@gmail.com");
            Driver.FindElement(By.XPath("//span//input[@id='passwd']")).SendKeys("Qwertyuiop@12345");
            Driver.FindElement(By.XPath("//p//button[@id='SubmitLogin']")).Click();



            // HOVER T-shirt

            //Driver.FindElement(By.XPath("//div//a[@href='http://automationpractice.com/index.php?id_category=3&controller=category']")).Click();
            //Driver.FindElement(By.XPath("//div//a[@title='T-shirts']")).Click();

            //Driver.FindElement(By.XPath("//div//form[@id='searchbox']")).Click();
            //Driver.FindElement(By.XPath("//div//form[@id='searchbox']")).SendKeys("top


            //Actions builder = new Actions(Driver);
            //builder.MoveToElement(Driver.FindElement(By.XPath("//div//a[@title='Women']"))).Click().Build().Perform();
            //Thread.Sleep(4000);


            // SEARCH   

            Driver.FindElement(By.XPath("//div//input[@id='search_query_top']")).SendKeys("Top");
            Driver.FindElement(By.XPath("//div//button[@name='submit_search']")).Click();
            Thread.Sleep(2000);

            // Sort Option on page

            Driver.FindElement(By.XPath("//div//select[@id='selectProductSort']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("//div//select[@id='selectProductSort']")).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);

            js.ExecuteScript("window.scrollTo(0, 400)");

            // HOVER   

            //Actions Actions = new Actions(Driver);
            //WebElement target = (WebElement)Driver.FindElement(By.XPath("//div//a[@class='quick-view-mobile']"));
            //Actions.MoveToElement(target).Perform();
            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollTo(0, 300)");

            Driver.FindElement(By.XPath("//div//a[@title='Printed Dress']")).Click();
            Thread.Sleep(2000);
            
            Actions actions = new Actions(Driver);
            WebElement target = (WebElement)Driver.FindElement(By.XPath("//div//li[@id='thumbnail_9']"));
            actions.MoveToElement(target).Perform();
            Thread.Sleep(2000);


        }

        public void hoverOnto(IWebElement webElement)
        {
            getAction().MoveToElement(webElement).Perform();
        }

    }
}
