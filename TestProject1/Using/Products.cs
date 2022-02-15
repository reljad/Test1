using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Products:Base
    {
        public static IWebElement loHi => driver.FindElement(By.XPath("//select[@class='product_sort_container']//option[@value='lohi']"));

        public static void Price()
        {
            loHi.Click();
        }
        public static IWebElement addCart => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public static void Buy()
        {
            addCart.Click();
        }
        public static IWebElement cart => driver.FindElement(By.ClassName("shopping_cart_badge"));
        public static void Checkcart()
        {
            cart.Click();
        }
        public static IWebElement check => driver.FindElement(By.Id("checkout"));
        public static void CheckOut()
        {
            check.Click();
        }
    }
}
