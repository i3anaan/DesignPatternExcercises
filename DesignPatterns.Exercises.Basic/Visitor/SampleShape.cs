using DesignPatterns.Exercises.Basic.Visitor.Shapes;
using System;

namespace DesignPatterns.Exercises.Basic.Visitor
{
    public class SampleShape : CompoundShape
    {
        public SampleShape()
        {
            this.XPosition = 0;
            this.XPosition = 0;

            this.SubShapes.Add(new Circle() { XPosition = 1, YPosition = 1, Radius = 3 });
            this.SubShapes.Add(new Square() { XPosition = 2, YPosition = 3, EdgeLength = 2 });
            this.SubShapes.Add(new Rectangle() { XPosition = 0, YPosition = 1, Width = 1, Height = 3 });


            this.SubShapes.Add(new CompoundShape()
            {
                XPosition = 2,
                YPosition = -1,
                SubShapes = new List<Shape> {
                    new Square() {  XPosition = 2, YPosition = 2, EdgeLength = 1},
                    new Circle() { XPosition = -1, YPosition = 4, Radius = 5},
                    new CompoundShape() {
                        XPosition = 1,
                        YPosition = 1,
                        SubShapes = new List<Shape>() {
                            new Rectangle(){ XPosition = 3, YPosition = 0, Height = 4, Width = 2},
                            new Rectangle(){ XPosition = 3, YPosition = 3, Height = 2, Width = 4},
                        }
                    }
                }
            });
        }
    }
}
