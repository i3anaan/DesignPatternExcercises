namespace DesignPatterns.Exercises.Basic.Visitor.Shapes
{
    public class CompoundShape : Shape
    {
        public List<Shape> SubShapes { get; set; } = new List<Shape>();
    }
}
