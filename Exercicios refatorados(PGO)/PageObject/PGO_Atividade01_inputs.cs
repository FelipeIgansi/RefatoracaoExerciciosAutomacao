using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Exercicios_refatorados_PGO_.PageObject
{
    class PGO_Atividade01_inputs
    {
        private readonly IWebDriver Driver;
        //public string Ambiente = "";

        private readonly string link = "http://the-internet.herokuapp.com/inputs";


        public PGO_Atividade01_inputs(IWebDriver driver)
        {
            Driver = driver;
            Driver.Url = link;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > div > div > input[type=number]")]
        private IWebElement ImputNumero { get; set; }


        public void InserirNumero(string valor) { ImputNumero.SendKeys(valor); }

        public void AumentarValor() {
            ImputNumero.SendKeys(Keys.ArrowUp);
        }

        public void DiminuirValor()
        {
            ImputNumero.SendKeys(Keys.ArrowDown);
        }

        public string RetornaValorInput()
        {
            return ImputNumero.Text.ToString();
        }

    }
}
