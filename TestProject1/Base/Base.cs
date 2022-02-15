using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Base
    {
        public static IWebDriver driver;
        public static void Initialize()
        {
            driver = new ChromeDriver();
        }
        public static void Close()
        {
            driver.Close();
        }
    }
}
