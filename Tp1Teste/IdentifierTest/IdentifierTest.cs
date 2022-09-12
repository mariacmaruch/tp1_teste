using NUnit.Framework;
using Tp1Teste;

namespace IdentifierTest
{
    public class IdentifierTest
    {
        private Identifier id;

        [SetUp]
        public void Setup()
        {
            id = new Identifier();
        }

        [Test]
        public void Test_True_Validar_Id()
        {
            Assert.AreEqual(true, id.ValidarIdentificador("abc12"));
        }

        [Test]
        public void Test_False_Validar_Id()
        {

            Assert.AreEqual(false, id.ValidarIdentificador("cont*1"));
        }

        [Test]
        public void Test_True_Validar_Primeiro()
        {
            Assert.AreEqual(true, id.ValidarPrimeira('a'));
        }

        [Test]
        public void Test_False_Validar_Primeiro1()
        {
            Assert.AreEqual(false, id.ValidarPrimeira('1'));
        }

        [Test]
        public void Test_False_Validar_Primeiro2()
        {
            Assert.AreEqual(false, id.ValidarPrimeira('?'));
        }

        [Test]
        public void Test_True_Validar_Caracter1()
        {
            Assert.AreEqual(true, id.ValidarCaracteres('A'));
        }

        [Test]
        public void Test_True_Validar_Caracter2()
        {
            Assert.AreEqual(true, id.ValidarCaracteres('4'));
        }

        [Test]
        public void Test_False_Validar_Caracter()
        {
            Assert.AreEqual(false, id.ValidarPrimeira('!'));
        }
    }
}