using MyPaint.Shape.Frame;
using MyPaint.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint.Shape
{
    class ImageShape : FrameSpace
    {
        private Bitmap currentImage;

        public ImageShape(Size size, Point p, Bitmap _image)
            : base(size, p)
        {
            this.currentImage = _image.Clone(new Rectangle(0, 0, _image.Size.Width, _image.Size.Height), _image.PixelFormat);

            this.pivotMove = p;
            this.leftBound = p.X;
            this.upperBound  = p.Y;
            this.rightBound = _image.Size.Width + p.X;
            this.lowerBound = _image.Size.Height + p.Y;

            this.doneStatus = false;
            this.drawingStatus = DrawingSetting.DrawingStatus.Free;
            this.drawingMode = DrawingSetting.DrawingMode.Move;
        }


        #region Override

        public override Bitmap CurrentShape
        {
            get { return generateImage(); }
        }

        #endregion

        protected override Bitmap generateImage()
        {
            Bitmap bmp = new Bitmap(surfaceSize.Width, surfaceSize.Height);

            if (drawingStatus == DrawingSetting.DrawingStatus.PreDraw)
                return bmp;
            else
            {
                using (Graphics gr = Graphics.FromImage(bmp))
                {
                    gr.DrawImage(currentImage, leftBound, upperBound, rightBound - leftBound, lowerBound - upperBound);
                }
            }

            drawFrame(bmp);

            return bmp;
        }

    }
}
