using DesignPatterns.Exercises.Basic.Decorator;

namespace DesignPatterns.Excercises.Basic.Tests.Decorator
{
    [TestClass]
    public class DecoratorTests
    {
        [TestMethod]
        public void TestDecorator()
        {
            // TODO:
            // Move the write/read logs below to a decorator by implementing the ConsoleLoggerDecorator
            // Verify that the assert passes.
            // Extend with additional decorators (inverse case, escape special characters, encode base64, remove whitespace, measure performance, etc)

            var dataSource = new DataSource();

            var dataToWrite = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

            Console.WriteLine($"Writing data:\n{dataToWrite}");
            dataSource.WriteData(dataToWrite);

            var dataRead = dataSource.ReadData();
            Console.WriteLine($"Read data:\n{dataRead}");

            Assert.AreEqual(dataToWrite, dataRead);
        }
    }
}