using Base.WinForms;
using BaseLib;
using System;

namespace ShapeLib
{
    public class Diamond : Shape
    {

        public Vector2d[] Points { get; set; }


        public Diamond()
        {
            Points = new Vector2d[4];
        }

        public Diamond(Vector2d p0, Vector2d p1, Vector2d p2, Vector2d p3)
        {
            Points = new Vector2d[4];
            Points[0] = p0;
            Points[1] = p1;
            Points[2] = p2;
            Points[3] = p3;


        }

        

        public override void Draw(DrawContext dc)
        {
            dc.DrawPolygon(Points);
        }
    }
}
