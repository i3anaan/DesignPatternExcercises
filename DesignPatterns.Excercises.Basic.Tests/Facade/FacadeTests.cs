using DesignPatterns.Exercises.Basic.Facade;

namespace DesignPatterns.Excercises.Basic.Tests.Facade
{
    [TestClass]
    public class FacadeTests
    {
        [TestMethod]
        public void TestFacade()
        {
            // TODO:
            // Create a Facade around the AESEncryptor that allows simple encryption and decryption without having to worry about secret management.
            // Ensure the below passes.

            var originalData = "Lorem ipsum dolor sit amet";

            string encryptedData = "TODO";
            Assert.AreNotEqual(originalData, encryptedData);

            string decryptedData = "TODO";
            Assert.AreEqual(originalData, decryptedData);
        }
    }
}
