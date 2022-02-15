using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TestProject1
{
    public class TestProject1:Base
    {
        [Test]
        public void NoUser()
        {
            Base.Initialize();
            LogIn.Goto();
            LogIn.Login("", "secret_sauce");
            Assert.AreEqual("Epic sadface: Username is required", LogIn.msg1.Text);
            Base.Close();
        }
        [Test]
        public void NoPassword()
        {
            Base.Initialize();
            LogIn.Goto();
            LogIn.Login("standard_user", "");
            Assert.AreEqual("Epic sadface: Password is required", LogIn.msg2.Text);
            Base.Close();
        }
        [Test]
        public void WrongUserPass()
        {
            Base.Initialize();
            LogIn.Goto();
            LogIn.Login("asd", "asd");
            Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", LogIn.msg3.Text);
            Base.Close();
        }
        [Test]
        public void Title()
        {
            Base.Initialize();
            LogIn.Goto();
            LogIn.Login("standard_user", "secret_sauce");
            Assert.AreEqual("PRODUCTS",LogIn.title);
            Base.Close();
        }
        [Test]
        public void LogOut()
        {
            Base.Initialize();
            LogIn.Goto();
            LogIn.Login("standard_user", "secret_sauce");
            Logout.Menu();
            Thread.Sleep(3000);
            Logout.Quit();
            Base.Close();
        }
        [Test]
        public void BuyLoToHi()
        {
            Base.Initialize();
            LogIn.Goto();
            LogIn.Login("standard_user", "secret_sauce");
            Products.Price();
            Products.Buy();
            Products.Checkcart();
            Products.CheckOut();
            Info.YourInfo("rrr","ddd","11070");
            Info.End();
            Info.Order();
            Base.Close();
        }
    }
}