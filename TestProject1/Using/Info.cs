using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Info:Base
    {
        public static IWebElement name => driver.FindElement(By.Id("first-name"));
        public static IWebElement lastname => driver.FindElement(By.Id("last-name"));
        public static IWebElement code => driver.FindElement(By.Id("postal-code"));
        public static IWebElement btn => driver.FindElement(By.Id("continue"));
        public static IWebElement finish => driver.FindElement(By.Id("finish"));

        public static string complete = driver.FindElement(By.ClassName("complete-header")).Text;
        public static void YourInfo(string c,string d ,string e)
        {
            name.SendKeys(c);
            lastname.SendKeys(d);
            code.SendKeys(e);
            btn.Click();
        }
        public static void End()
        {
            finish.Click();
        }
        public static void Order()
        {
            complete.Contains("THANK YOU FOR YOUR ORDER");
        }
    }
}
