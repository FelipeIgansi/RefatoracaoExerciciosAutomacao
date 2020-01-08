using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_refatorados_PGO_.PageObject
{
    class PGO_Atividade01_checkbox
    {
        private readonly IWebDriver Driver;
        //public string Ambiente = "";

        private readonly string link = "http://the-internet.herokuapp.com/checkboxes";

         
        public PGO_Atividade01_checkbox(IWebDriver driver)
        {
            Driver = driver;
            Driver.Url = link;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[type='checkbox']:nth-child(1)")]
        private IWebElement ComboBox01 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type='checkbox']:nth-child(3)")]
        private IWebElement ComboBox02 { get; set; }


        public void ClicaComboBox01() {
            ComboBox01.Click();
        }

        public void ClicaComboBox02()
        {
            ComboBox02.Click();
        }
    }
}
