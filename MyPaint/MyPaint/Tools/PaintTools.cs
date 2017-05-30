using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Tools
{
    class PaintTools
    {
        public enum EnumDrawingTool { FreePen, Line, Eraser, Select, RectangleShape, EllipseShape, ImageShape, TriangleShape, SquareTriangleShape, DiamondShape, PentagonShape, DownArrowShape, UpArrowShape, RightArrowShape, LeftArrowShape, Bezier, Polygon};
        public static EnumDrawingTool DrawingTool;
        public static Color DrawingColor;
        public static Brush DrawingBrush;
        //Save the Color Brush in HatchBruhs Style Fill
        public static Color ColorBrush_1;
        public static Color ColorBrush_2;
        public static System.Drawing.Drawing2D.HatchStyle HatchStyleBrush;
        public enum EnumBrushStatus { Fill, UnFill };
        public static EnumBrushStatus BrushStatus;
        public static int PenWidth;
        public static int EraserWidth;
    }
}
