using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchLogo
{
    public partial class Form1 : Form
    {

        private Graphics graphics = null;
        private int centralHorizontalLine;
        private int centralVerticalLine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centralHorizontalLine = (this.Width / 2) - 8;
            centralVerticalLine = (this.Height / 2) - 7;
            //
            graphics = this.CreateGraphics();
            //
            GraphicsPath graphicsPath01 = new GraphicsPath();
            GraphicsPath graphicsPath02 = new GraphicsPath();
            graphicsPath01.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine + 270, centralVerticalLine - 333),
                new PointF(centralHorizontalLine - 176,  centralVerticalLine - 333),
                new PointF(centralHorizontalLine - 295,  centralVerticalLine - 214),
                new PointF(centralHorizontalLine - 295,  centralVerticalLine + 210),
                new PointF(centralHorizontalLine - 152,  centralVerticalLine + 210),
                new PointF(centralHorizontalLine - 152,  centralVerticalLine + 327),
                new PointF(centralHorizontalLine - 35,  centralVerticalLine + 210),
                new PointF(centralHorizontalLine + 60,  centralVerticalLine + 210),
                new PointF(centralHorizontalLine + 270,  centralVerticalLine),
            });
            graphicsPath02.AddPolygon(new PointF[] {
                new PointF(centralHorizontalLine + 224, centralVerticalLine - 285),
                new PointF(centralHorizontalLine - 152,  centralVerticalLine - 285),
                new PointF(centralHorizontalLine - 152,  centralVerticalLine + 68),
                new PointF(centralHorizontalLine - 47,  centralVerticalLine + 68),
                new PointF(centralHorizontalLine - 47,  centralVerticalLine + 150),
                new PointF(centralHorizontalLine + 35,  centralVerticalLine + 68),
                new PointF(centralHorizontalLine + 130,  centralVerticalLine + 68),
                new PointF(centralHorizontalLine + 224,  centralVerticalLine - 25),
            });
            //
            graphics.FillPath(Brushes.Black, graphicsPath01);
            graphics.FillPath(Brushes.White, graphicsPath02);
            //
            DrawVerticalLine(Color.Black, centralHorizontalLine, centralVerticalLine - 202, centralVerticalLine - 61, 45);
            DrawVerticalLine(Color.Black, centralHorizontalLine + 129, centralVerticalLine - 202, centralVerticalLine - 61, 45);
        }

        private void DrawHorizontalLine(Color color, int x1, int x2, int y, int size = 1)
        {
            graphics.DrawLine(new Pen(new SolidBrush(color), size), x1, y, x2, y);
        }

        private void DrawVerticalLine(Color color, int x, int y1, int y2, int size = 1)
        {
            graphics.DrawLine(new Pen(new SolidBrush(color), size), x, y1, x, y2);
        }
    }
}
