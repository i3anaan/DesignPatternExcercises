using DesignPatterns.Exercises.Basic.Singleton;

namespace DesignPatterns.Excercises.Basic.Tests.Singleton
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("input", true)]
        [DataRow("some other input!", false)]
        public void TestDecorator(string input, bool expected)
        {
            // TODO:
            // First extend these tests to cover both flows of the regex validator (do not alter RegexValidator)
            // Then rewrite the RegexValidator to use the singleton pattern while keeping the tests functional
            // Optional: Introduce a locking mechanism that ensures all tests pass even when running in parallel

            var validator = new RegexValidator(true);

            Assert.AreEqual(expected, validator.ValidateString(input));
        }
    }
}
