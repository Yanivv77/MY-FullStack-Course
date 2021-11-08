using Base.WinForms;
using BaseLib;


namespace ShapeLib
{
    public class Star : Shape

{
        public Star(Vector2d p0, Vector2d p1, Vector2d p2)
        {
            Points = new Vector2d[6];
            Points[0] = p0;
            Points[1] = p1;
            Points[2] = p2;
    

        }

        public Vector2d[] Points { get; set; }

        public override void Draw(DrawContext dc)
        {
            dc.DrawPolygon(Points);
        }
    }
}
