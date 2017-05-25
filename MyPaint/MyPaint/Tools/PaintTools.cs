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
        public enum EnumDrawingTool { FreePen, Rectangle, Ellipse, Line, Image, Triangle, Diamond, Pentagon, DownArrow, Eraser};
        public static EnumDrawingTool DrawingTool;
        public static Color DrawingColor;
        public static Brush DrawingBrush;
        public enum EnumBrushStatus { Fill, UnFill };
        public static EnumBrushStatus BrushStatus;
        public static int PenWidth;
        public static int EraserWidth;
    }
}
