using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Exercicios_refatorados_PGO
{
    [TestClass]
    public class BaseTeste
    {
        public IWebDriver Driver { get; set; }
        [TestInitialize]
        public void AbrirNavegador()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();

        }
        [TestCleanup]
        public void FecharNavegador()
        {
            Driver.Close();
            Driver.Quit();
            Driver = null;
        }

        public void EsperaImplicita(int tempo)
        {
            Thread.Sleep(tempo);
        }
        public void EsperaExplicita(int tempo, string elemento)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(tempo));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(elemento)));
        }

    }
}
