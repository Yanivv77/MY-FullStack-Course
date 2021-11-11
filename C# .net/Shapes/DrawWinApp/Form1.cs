using System.Drawing;
using System.Windows.Forms;
using Base.WinForms;
using BaseLib;
using ShapeLib;
using static BaseLib.MathFunctions;



namespace DrawWinApp
{
    public partial class Form1 : Form
    {
        Shape _diamond;
        Shape _circle;
        Shape _rectangle;


        public Form1()
        {
            InitializeComponent();

            drawControl.MinX = -1;
            drawControl.MaxX = 1;
            drawControl.MinY = -1;
            drawControl.MaxY = 1;

            drawControl.DrawEvent += DrawControl_DrawEvent;

            //             _circle = new Circle
            //             {
            //                 Center = vec2(0,0),
            //                 Radius = 0.25
            //             };
            // 
            //             _diamond = new Diamond(vec2(-0.3, 0), vec2(0, -0.6), vec2(0.3, 0),vec2(0, 0.6))
            //             {
            //                 Center = vec2(0, 0),
            //             };

            _rectangle = new Rectangle(0.5, 0.6);
           



        }

        void DrawControl_DrawEvent(object sender, Base.WinForms.DrawControl.DrawEventArgs e)
        {
            DrawContext dc = e.DrawContext;

            //dc.PointSize = 37;
            //dc.FillColor = Color.Red;

            //dc.DrawPoints(vec2(0,0), vec2(0.5, -0.5));

            //dc.LineWidth = 5;
            //dc.LineColor = Color.Blue;


            //dc.DrawLines(vec2(0, 0), vec2(0.5, -0.5));

            dc.LineColor = Color.BlueViolet;
            dc.FillColor = Color.Red;
            dc.LineWidth = 5;
            _rectangle.Draw(dc);

           
        }
    }
}
