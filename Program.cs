using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PruebaSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://twitter.com/?lang=es");
            driver.Manage().Window.Maximize();//**
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            System.Threading.Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,250)");
            //**1.-Boton login //*[@id="react-root"]/div/div/div[2]/main/div/div/div[1]/div[1]/div/div[3]/div[5]/a //*[@id="react-root"]/div/div/div[2]/main/div/div/div[1]/div[1]/div/div[3]/div[5]/a
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='react-root']/div/div/div[2]/main/div/div/div[1]/div[1]/div/div[3]/div[5]/a"));
            loginButton.Click();
            //**2.-Ingreso de correo
            IWebElement input = driver.FindElement(By.XPath("//*[@id='react - root']/div/div/div/main/div/div/div/div[2]/div[2]/div/div[5]/label/div/div[2]/div/input"));
            input.SendKeys("perezaleyda251@gmail.com");
            //**3.-Boton siguiente
            IWebElement nextButton = driver.FindElement(By.XPath("//*[@id='layers']/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div[2]/div[2]/div/div/div/div[6]/div"));
            nextButton.Click();
            //**4.-Ingreso de contraseña
            IWebElement contraseña = driver.FindElement(By.XPath("//*[@id='layers']/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div[2]/div[2]/div[1]/div/div/div[3]/div/label/div/div[2]/div[1]/input"));
            contraseña.SendKeys("Sniper110");
            //**5.-Boton inicar sesion 
            IWebElement ISButton = driver.FindElement(By.XPath("//*[@id='layers']/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div//*[@id='layers']/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div[2]/div[2]/div[2]/div/div[1]/div/div/div/div"));
            ISButton.Click();
            //**6.-caja de twits
            IWebElement twitbox = driver.FindElement(By.XPath("//*[@id='layers']/div[2]/div/div/div/div/div/div[2]/div[2]/div/div/div[2]/div[2]/div/div/div/div[5]/label/div/div[2]/div/input"));
            twitbox.SendKeys("Buenas tardes, ten un lindo dia");
            //*





        }
    }
}
