using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TestProject1

{
    public class LogIn:Base
    {
         public static IWebElement username=>driver.FindElement(By.Id("user-name"));
         public static IWebElement password=>driver.FindElement(By.Id("password"));
        public static IWebElement btn => driver.FindElement(By.Id("login-button"));
        public static IWebElement msg1 => driver.FindElement(By.XPath("//h3[text() ='Epic sadface: Username is required']"));
        public static IWebElement msg2 => driver.FindElement(By.XPath("//h3[text() ='Epic sadface: Password is required']"));
        public static IWebElement msg3 => driver.FindElement(By.XPath("//h3[text() ='Epic sadface: Username and password do not match any user in this service']"));
        public static string title => driver.FindElement(By.XPath("//span[@class='title']")).Text;

        public static void Goto()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
        public static void Login(string a,string b)
        {
            username.SendKeys(a);
            password.SendKeys(b);
            btn.Click();
        }
    }   
}