using System;
using Exercicios_refatorados_PGO;
using Exercicios_refatorados_PGO_.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercicios_refatorados_PGO_.Atividade01.Exercicio02
{

    /*
     
         2. Trabalhando com Checkbox
            URL para realizar o teste: http://the-internet.herokuapp.com/checkboxes
                1.1.Implementar um teste que marque o “checkbox 1”.
                1.2.Implementar um teste que desmarque o “checkbox 2”.
                1.3.Implementar um teste que valide se o checkbox está marcado 
                ou desmarcado (conforme o valor esperado)
         
         
         */
    [TestClass]
    public class ValidarCheckbox : BaseTeste
    {
        [TestMethod]
        public void CLicarComboBox01()
        {
            PGO_Atividade01_checkbox pgo_checkbox = new PGO_Atividade01_checkbox(Driver);

            pgo_checkbox.ClicaComboBox01();
            EsperaImplicita(4000);
        }


        [TestMethod]
        public void CLicarComboBox02()
        {
            PGO_Atividade01_checkbox pgo_checkbox = new PGO_Atividade01_checkbox(Driver);
            EsperaImplicita(2000);
            pgo_checkbox.ClicaComboBox02();
            EsperaImplicita(4000);

        }

    }
}
