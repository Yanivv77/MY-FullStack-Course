using Base.WinForms;
using ShapeLib;
using System.Drawing;
using System.Windows.Forms;
using static BaseLib.MathFunctions;
using Rectangle = ShapeLib.Rectangle;

namespace DrawWinApp
{
    public partial class Form1 : Form
    {


        Shape _triangle;
        Shape _diamond;
        Shape _circle;
        Shape _rectangle;


        public Form1()
        {

            //WinForms Size

            InitializeComponent();
            drawControl.MinX = -1;
            drawControl.MaxX = 1;
            drawControl.MinY = -1;
            drawControl.MaxY = 1;
            drawControl.DrawEvent += DrawControl_DrawEvent;
            ;


            //Shape Creation

            _circle = new Circle(0.8);
            _triangle = new Triangle(vec2(-0.3, 0), vec2(0, -0.6), vec2(0.3, 0));
            _diamond = new Diamond(vec2(-0.3, 0), vec2(0, -0.6), vec2(0.3, 0), vec2(0, 0.6));
            _rectangle = new Rectangle(0.8, 0.4);


        }

        void DrawControl_DrawEvent(object sender, Base.WinForms.DrawControl.DrawEventArgs e)
        {


            /*
           // Draw green circle
           DrawContext drawCircle = e.DrawContext;
           drawCircle.FillColor = Color.Green;
           drawCircle.LineWidth = 5;
           _circle.Draw(drawCircle);
           */


            /* 
            // Draw yellow triangle
            DrawContext drawTriangle = e.DrawContext;
            drawTriangle.FillColor = Color.Yellow;
            drawTriangle.LineWidth = 5;
            _triangle.Draw(drawTriangle);
            */


            /*    
           // Draw red diamond
           DrawContext drawDiamond = e.DrawContext;
           drawDiamond.FillColor = Color.Red;
           drawDiamond.LineWidth = 5;
          _diamond.Draw(drawDiamond);
           */

            // Draw blue rectangle
            DrawContext drawRec = e.DrawContext;
            drawRec.FillColor = Color.Blue;
            drawRec.LineWidth = 5;
            _rectangle.Draw(drawRec);


        }
    }
}
