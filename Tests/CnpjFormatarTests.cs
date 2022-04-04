namespace CnpjLibrary.Tests
{
    using CpfCnpjLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CnpjFormatarTests
    {
        [TestMethod]
        public void Valid()
        {
            Assert.AreEqual("67.419.649/0001-12", Cnpj.FormatarComPontuacao("67.419.649/0001-12"));
            Assert.AreEqual("67419649000112", Cnpj.FormatarSemPontuacao("67.419.649/0001-12"));
            Assert.AreEqual("02.287.987/0001-00", Cnpj.FormatarComPontuacao("2.287.987/0001-00"));
            Assert.AreEqual("02287987000100", Cnpj.FormatarSemPontuacao("2.287.987/0001-00"));
        }
    }
}
