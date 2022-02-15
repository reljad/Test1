using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Logout:Base
    {
        public static IWebElement mBtn => driver.FindElement(By.Id("react-burger-menu-btn"));
        public static void Menu()
        {
            mBtn.Click();
        }
        public static IWebElement lBtn => driver.FindElement(By.Id("logout_sidebar_link"));
        public static void Quit()
        {
            lBtn.Click();
        }
    }
}
