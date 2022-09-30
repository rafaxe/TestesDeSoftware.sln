using NerdStore.BDD.Tests.Config;
using NerdStore.BDD.Tests.Usuario;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace NerdStore.BDD.Tests.Pedido
{
    [Binding, Scope(Feature = "FeatureTeste")]
    public class FeatureTesteSteps
    {
        public FeatureTesteSteps()
        {
        }

        [Given(@"O usuario esteja logado")]
        public void DadoOUsuarioEstejaLogado()
        {
            Assert.True(true);
        }

        [When(@"O usuario adicionar uma unidade ao carrinho")]
        public void QuandoOUsuarioAdicionarUmaUnidadeAoCarrinho()
        {
            Console.WriteLine("teste");
        }

        [Then(@"O usuario será redirecionado ao resumo da compra")]
        public void EntaoOUsuarioSeraRedirecionadoAoResumoDaCompra()
        {
            Assert.True(true);
        }
    }
}
