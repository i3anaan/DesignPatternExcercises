using DesignPatterns.Exercises.Basic.Visitor;

namespace DesignPatterns.Excercises.Basic.Tests.Visitor
{
    [TestClass]
    public class VisitorTests
    {
        [TestMethod]
        public void TestVisitor()
        {
            // TODO:
            // Implement the XMLVisitor and validate the output generated by this test.
            // Optional: Create a second Visitor that calculates the total area of a shape (including potential overlap)

            var visitor = new XMLVisitor();
            var shapeToVisit = new SampleShape();

            var result = visitor.Visit(shapeToVisit);

            Console.WriteLine(result);

            Assert.AreNotEqual(string.Empty, result);
        }
    }
}
