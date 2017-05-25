using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Shape
{
    class DownArowShape:RectangleShape
    {
        public DownArowShape(Size surfaceSize, Point p)
            : base(surfaceSize, p)
        { }

        public override Bitmap CurrentShape
        {
            get { return this.generateImage(); }
        }

        private Bitmap generateImage()
        {
            Bitmap bmp = new Bitmap(surfaceSize.Width, surfaceSize.Height);

            if (leftBound == rightBound && upperBound == lowerBound)
                return bmp;

            switch (drawingStatus)
            {
                case DrawingSetting.DrawingStatus.PreDraw:
                    {
                        break;
                    }
                case DrawingSetting.DrawingStatus.Draw:
                    {
                        using (Graphics gr = Graphics.FromImage(bmp))
                        {
                            gr.SmoothingMode = SmoothingMode.AntiAlias;

                            Pen pen = genratePen(this.drawingProperties);
                            pen.StartCap = LineCap.Round;
                            pen.EndCap = LineCap.Round;
                            int halfHorizontal = (rightBound - leftBound) / 4;
                            int halfVertical = (lowerBound - upperBound) / 4;

                            Point p1 = new Point(halfHorizontal+leftBound, upperBound);
                            Point p2 = new Point(halfHorizontal*3 +leftBound, upperBound);
                            Point p3 = new Point(halfHorizontal * 3 + leftBound, halfVertical*2 +upperBound);
                            Point p4 = new Point(rightBound, halfVertical * 2 + upperBound);
                            Point p5 = new Point(halfHorizontal * 2 + leftBound, lowerBound);
                            Point p6 = new Point(leftBound, halfVertical * 2 + upperBound);
                            Point p7 = new Point(halfHorizontal + leftBound, halfVertical * 2 + upperBound);

                            GraphicsPath path = new GraphicsPath();
                             path.AddLine(p1, p2);
                            path.AddLine(p2, p3);
                            path.AddLine(p3, p4);
                            path.AddLine(p4, p5);
                            path.AddLine(p5, p6);
                            path.AddLine(p6, p7);
                            path.AddLine(p7, p1);

                            gr.DrawPath(pen, path);
                            if (Tools.PaintTools.BrushStatus == Tools.PaintTools.EnumBrushStatus.Fill)
                            {
                                gr.FillPath(drawingProperties.ActiveBrush, path);
                            }
                        }
                        break;
                    }
                case DrawingSetting.DrawingStatus.Free:
                case DrawingSetting.DrawingStatus.Adjust:
                    {
                        using (Graphics gr = Graphics.FromImage(bmp))
                        {
                            gr.SmoothingMode = SmoothingMode.AntiAlias;

                            Pen pen = genratePen(this.drawingProperties);
                            pen.StartCap = LineCap.Round;
                            pen.EndCap = LineCap.Round;
                            int halfHorizontal = (rightBound - leftBound) / 4;
                            int halfVertical = (lowerBound - upperBound) / 4;


                            Point p1 = new Point(halfHorizontal + leftBound, upperBound);
                            Point p2 = new Point(halfHorizontal * 3 + leftBound, upperBound);
                            Point p3 = new Point(halfHorizontal * 3 + leftBound, halfVertical * 2 + upperBound);
                            Point p4 = new Point(rightBound, halfVertical * 2 + upperBound);
                            Point p5 = new Point(halfHorizontal * 2 + leftBound, lowerBound);
                            Point p6 = new Point(leftBound, halfVertical * 2 + upperBound);
                            Point p7 = new Point(halfHorizontal + leftBound, halfVertical * 2 + upperBound);

                            GraphicsPath path = new GraphicsPath();
                            path.AddLine(p1, p2);
                            path.AddLine(p2, p3);
                            path.AddLine(p3, p4);
                            path.AddLine(p4, p5);
                            path.AddLine(p5, p6);
                            path.AddLine(p6, p7);
                            path.AddLine(p7, p1);

                            gr.DrawPath(pen, path);
                            if (Tools.PaintTools.BrushStatus == Tools.PaintTools.EnumBrushStatus.Fill)
                            {
                                gr.FillPath(drawingProperties.ActiveBrush, path);
                            }
                        }
                        break;
                    }
            }

            if (!doneStatus)
            {
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    Pen pen = new Pen(Color.Gray);
                    pen.Width = 0.1f;
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    gr.DrawRectangle(pen, new System.Drawing.Rectangle(leftBound, upperBound, rightBound - leftBound + 1, lowerBound - upperBound + 1));

                    int[] xArr = new int[3];
                    int[] yArr = new int[3];

                    xArr[0] = leftBound;
                    xArr[1] = (leftBound + rightBound) / 2;
                    xArr[2] = rightBound;

                    yArr[0] = upperBound;
                    yArr[1] = (upperBound + lowerBound) / 2;
                    yArr[2] = lowerBound;

                    for (int i = 0; i < xArr.Length; i++)
                        for (int j = 0; j < yArr.Length; j++)
                        {
                            if (i == 1 && j == 1)
                                continue;
                            drawEditPoint(xArr[i], yArr[j], gr);
                        }
                }
            }
            return bmp;
        }
    }
}
