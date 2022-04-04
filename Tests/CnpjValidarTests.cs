namespace CnpjLibrary.Test
{
    using CpfCnpjLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CnpjValidarTests
    {
        [TestMethod]
        public void ValidWithMask()
        {
            Assert.IsTrue(Cnpj.Validar("67.419.649/0001-12"));
            Assert.IsTrue(Cnpj.Validar("67419649000112"));
            Assert.IsTrue(Cnpj.Validar("02.944.203/0001-61"));
            Assert.IsTrue(Cnpj.Validar("2.944.203/0001-61"));
            Assert.IsTrue(Cnpj.Validar("02089275000179"));
            Assert.IsTrue(Cnpj.Validar("2089275000179"));
        }
    }
}
