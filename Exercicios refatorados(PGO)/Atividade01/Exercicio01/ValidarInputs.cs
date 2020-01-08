using Exercicios_refatorados_PGO;
using Exercicios_refatorados_PGO_.PageObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Exercicios_refatorados_PGO_.Atividade01.Exercicio01
{
    [TestClass]
    public class ValidarInputs : BaseTeste
    {

        /*
         
            1. Trabalhando com Inputs
            URL para realizar o teste: http://the-internet.herokuapp.com/inputs
                1.1.Implementar um teste que insira um valor no input da tela.
                1.2.Implementar um teste que valide o texto contido no input da
                tela.

             
             */

        [TestMethod]
        public void InserirValor()
        {

            PGO_Atividade01_inputs pgo_input = new PGO_Atividade01_inputs(Driver);

            pgo_input.InserirNumero("2");

            pgo_input.AumentarValor();

            Assert.AreEqual("", pgo_input.RetornaValorInput());

        }

    }
}
