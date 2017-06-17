using MyPaint.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Shape
{
    class Eraser:FreePen
    {
        public Eraser(Size surfaceSize, Point p)
            : base(surfaceSize, p)
        { }

        public override System.Drawing.Bitmap CurrentShape
        {
            get { return generateImage(); }
        }


        private Bitmap generateImage()
        {
            Bitmap bmp = new Bitmap(surfaceSize.Width, surfaceSize.Height);

            if (drawingStatus == DrawingSetting.DrawingStatus.PreDraw)
                return bmp;
            else
            {
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    Pen pen = new Pen(Color.White);
                    pen.Width = Tools.PaintTools.EraserWidth;
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                    gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    if (listPrePoint.Count > 1)
                        gr.DrawLines(pen, listPrePoint.ToArray());
                    else
                        gr.DrawLine(pen, listPrePoint.First(), new Point(listPrePoint.First().X + 1, listPrePoint.First().Y));
                }
            }

            return bmp;
        }

    }
}
