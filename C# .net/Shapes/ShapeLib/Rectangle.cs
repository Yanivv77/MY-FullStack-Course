using Base.WinForms;
using BaseLib;

namespace ShapeLib
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        Vector2d[] Points = new Vector2d[4];


        public Rectangle(double Width , double Height)
        {
            Points[0] = new Vector2d(Center.X - (Width / 2), Center.Y + (Height / 2));
            Points[1] = new Vector2d(Center.X - (Width / 2), Center.Y - (Height /2));
            Points[2] = new Vector2d(Center.X + (Width / 2), Center.Y - (Height / 2));
            Points[3] = new Vector2d(Center.X + (Width / 2), Center.Y + (Height / 2));
        }



        public override void Draw(DrawContext dc)
        {
            dc.DrawPolygon(Points);
        }
    }
}