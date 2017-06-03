using MyPaint.Properties;
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

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Drawing.DrawingSpace DrawingFrames;

        private Stack<Bitmap> listRedo;

        private Bitmap copyBitmap;

        public Bitmap CopyBitmap
        {
            get { return copyBitmap; }
            set { copyBitmap = value; }
        }

        void init()
        {
            this.DrawingFrames = new Drawing.DrawingSpace(this.Size);
            this.DrawingFrames.BackColor = System.Drawing.Color.White;
            this.DrawingFrames.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DrawingFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingFrames.Location = new System.Drawing.Point(0, 150);
            this.DrawingFrames.Name = "mainPanel1";
            this.DrawingFrames.TabIndex = 1;
            this.DrawingFrames.ContextMenuStrip = contextMenuStrip;
            this.FreeSpace.Controls.Add(this.DrawingFrames);
            this.listRedo = new Stack<Bitmap>();
        }
        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.FreePen;
            Tools.PaintTools.DrawingColor = Color.Black;
            Tools.PaintTools.ColorBrush_1 = Color.White;
            Tools.PaintTools.ColorBrush_2 = Color.White;
            Tools.PaintTools.HatchStyleBrush = HatchStyle.BackwardDiagonal;
            Tools.PaintTools.PenWidth = 1;
            Tools.PaintTools.DrawingBrush = Brushes.Yellow;
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.UnFill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        #region File

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.DrawingFrames.ListBack.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Do you want to save change to Untitled?", "Paint", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                btnSave_ItemClick(null, null);

                this.DrawingFrames.embed();

                Bitmap bmp = this.DrawingFrames.ListBack.Last();

                this.DrawingFrames.ContentPanel.Content = bmp;
                this.DrawingFrames.DrawingPanel.Content = new Bitmap(bmp.Size.Width, bmp.Size.Height);
                this.DrawingFrames.Refresh();
                this.DrawingFrames.ListBack.Clear();
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                this.DrawingFrames.embed();

                Bitmap bmp = this.DrawingFrames.ListBack.Last();

                this.DrawingFrames.ContentPanel.Content = bmp;
                this.DrawingFrames.DrawingPanel.Content = new Bitmap(bmp.Size.Width, bmp.Size.Height);
                this.DrawingFrames.Refresh();
                this.DrawingFrames.ListBack.Clear();
            }
            else
                return;
        }

        private void btnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DrawingFrames.embed();
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" +
                    "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                    "Windows Bitmap (*.bmp)|*.bmp|" +
                    "All Files (*.*)|*.*";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(dlg.FileName);

                    this.DrawingFrames.DrawingPanel.ActiveShape = new Shape.ImageShape(this.DrawingFrames.Size, new Point(0, 0), bmp);

                    this.DrawingFrames.DrawingPanel.updateContent();

                    this.DrawingFrames.Refresh();
                }
            }
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DrawingFrames.embed();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "JPEG(.jpg)|*.jpg|PNG(.png)|*.png|Bitmap(.bmp)|*.bmp";
            dlg.FileName = "Untitled";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(this.DrawingFrames.Image);
                string ext = dlg.FileName.Substring(dlg.FileName.LastIndexOf('.') + 1);
                switch (ext)
                {
                    case "png": bmp.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case "jpg": bmp.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "bmp": bmp.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
            }
        }

        #endregion

        #region Setting Color and Pen width

        private void size1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tools.PaintTools.PenWidth = 1;
            this.penWitdhStatus.Text = "1 px";
        }

        private void size2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tools.PaintTools.PenWidth = 3;
            this.penWitdhStatus.Text = "3 px";
        }

        private void size3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tools.PaintTools.PenWidth = 5;
            this.penWitdhStatus.Text = "5 px";
        }

        private void size4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tools.PaintTools.PenWidth = 7;
            this.penWitdhStatus.Text = "7 px";
        }

        #endregion

        #region ContextMenuStrip Event

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            foreach (ToolStripItem item in contextMenuStrip.Items)
                item.Enabled = false;

            if (this.DrawingFrames.Cursor == Cursors.SizeAll)
            {
                foreach (ToolStripItem item in contextMenuStrip.Items)
                    item.Enabled = true;

                if (!selectStyle.Checked)
                {
                    menuItemCopy.Enabled = false;
                    menuItemCut.Enabled = false;
                }

            }

            if (copyBitmap != null)
                menuItemPaste.Enabled = true;
            else
                menuItemPaste.Enabled = false;
        }

        private void menuItemOpenFile_Click(object sender, EventArgs e)
        {
            btnOpen_ItemClick(null, null);
        }

        private void menuItemSaveFile_Click(object sender, EventArgs e)
        {
            btnSave_ItemClick(null, null);
        }

        private void menuSubItemUnFill_Click(object sender, EventArgs e)
        {
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.UnFill;
        }

        private void menuSubItemSolidBrush_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SolidBrush _brush = new SolidBrush(dlg.Color);
                    Tools.PaintTools.DrawingBrush = _brush;
                }
            }
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.Fill;
        }

        private void menuSubItemLinearGradientBrush_Click(object sender, EventArgs e)
        {
            using (Fill.LinearGradientBrushForm dlg = new Fill.LinearGradientBrushForm())
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LinearGradientBrush _brush = new LinearGradientBrush(new Point(0, 10), new Point(200, 10), dlg._ForeColor, dlg._BackColor);
                    Tools.PaintTools.ColorBrush_1 = dlg._BackColor;
                    Tools.PaintTools.ColorBrush_2 = dlg._ForeColor;
                    Tools.PaintTools.DrawingBrush = _brush;
                }
            }
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.Fill;
        }

        private void menuSubItemTextureBrush_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" +
                    "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                    "Windows Bitmap (*.bmp)|*.bmp|" +
                    "All Files (*.*)|*.*";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Image img = new Bitmap(dlg.FileName);
                    TextureBrush _brush = new TextureBrush(img);
                    Tools.PaintTools.DrawingBrush = _brush;
                }
            }
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.Fill;
        }

        private void menuSubItemHatchBrush_Click(object sender, EventArgs e)
        {
            using (Fill.HatchBrushForm dlg = new Fill.HatchBrushForm())
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    HatchStyle style = dlg.HatchStyle;
                    HatchBrush _brush = new HatchBrush(style, dlg._ForeColor, dlg._BackColor);
                    Tools.PaintTools.ColorBrush_1 = dlg._BackColor;
                    Tools.PaintTools.ColorBrush_2 = dlg._ForeColor;
                    Tools.PaintTools.HatchStyleBrush = dlg.HatchStyle;
                    Tools.PaintTools.DrawingBrush = _brush;
                }
            }
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.Fill;
        }

        private void menuItemCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = this.DrawingFrames.DrawingPanel.ActiveShape.CurrentImage;
                if (bmp != null)
                {
                    this.copyBitmap = bmp.Clone(new Rectangle(0, 0, bmp.Size.Width, bmp.Size.Height), bmp.PixelFormat);
                }
            }
            catch (Exception ex) { }
            btnPaste.Enabled = true;
        }

        private void menuItemCut_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bmp = this.DrawingFrames.DrawingPanel.ActiveShape.CurrentImage;
                if (bmp != null)
                {
                    this.copyBitmap = bmp.Clone(new Rectangle(0, 0, bmp.Size.Width, bmp.Size.Height), bmp.PixelFormat);
                }
                btnUndo_ItemClick(null, null);
            }
            catch (Exception ex) { }
            btnPaste.Enabled = true;
        }

        private void menuItemPaste_Click(object sender, EventArgs e)
        {
            this.DrawingFrames.embed();
            if (this.copyBitmap != null)
            {
                this.DrawingFrames.DrawingPanel.ActiveShape = new Shape.ImageShape(this.DrawingFrames.Size, new Point(0, 0), this.copyBitmap);

                this.DrawingFrames.DrawingPanel.updateContent();

                this.DrawingFrames.Refresh();
            }

        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            btnUndo_ItemClick(null, null);
        }

        #endregion

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DrawingFrames.embed();
            if (this.DrawingFrames.ListBack.Count == 0)
                return;
            Bitmap redoBitmap = this.DrawingFrames.ContentPanel.Content.Clone(new Rectangle(0, 0, this.DrawingFrames.ContentPanel.Content.Size.Width, this.DrawingFrames.ContentPanel.Content.Size.Height), this.DrawingFrames.ContentPanel.Content.PixelFormat);

            this.listRedo.Push(redoBitmap);

            Bitmap bmp = this.DrawingFrames.ListBack.Pop();

            this.DrawingFrames.ContentPanel.Content = bmp;
            this.DrawingFrames.DrawingPanel.Content = new Bitmap(bmp.Size.Width, bmp.Size.Height);
            this.DrawingFrames.Refresh();
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DrawingFrames.embed();
            if (this.listRedo.Count == 0)
                return;
            Bitmap undoBitmap = this.DrawingFrames.ContentPanel.Content.Clone(new Rectangle(0, 0, this.DrawingFrames.ContentPanel.Content.Size.Width, this.DrawingFrames.ContentPanel.Content.Size.Height), this.DrawingFrames.ContentPanel.Content.PixelFormat);

            this.DrawingFrames.ListBack.Push(undoBitmap);

            Bitmap bmp = this.listRedo.Pop();

            this.DrawingFrames.ContentPanel.Content = bmp;
            this.DrawingFrames.DrawingPanel.Content = new Bitmap(bmp.Size.Width, bmp.Size.Height);
            this.DrawingFrames.Refresh();
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DrawingFrames.embed();
            btnCopy.Enabled = true;
            btnCut.Enabled = true;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Select;
            this.currentShape.Image = Resources.selectIcon;
            if (!selectStyle.Checked)
                selectStyle.Checked = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Z))
                btnUndo_ItemClick(null, null);
            else if (e.KeyData == (Keys.Control | Keys.Y))
                btnRedo_ItemClick(null, null);
            else if (e.KeyData == (Keys.Control | Keys.N))
                btnNew_ItemClick(null, null);
            else if (e.KeyData == (Keys.Control | Keys.O))
                btnOpen_ItemClick(null, null);
            else if (e.KeyData == (Keys.Control | Keys.S))
                btnSave_ItemClick(null, null);
            else if (e.KeyData == (Keys.Control | Keys.C))
                menuItemCopy_Click(null, null);
            else if (e.KeyData == (Keys.Control | Keys.X))
                menuItemCut_Click(null, null);
            else if (e.KeyData == (Keys.Control | Keys.V))
                menuItemPaste_Click(null, null);
            else if (e.KeyData == Keys.Delete) 
                menuItemDelete_Click(null, null);
        }

        private void ribbonControl1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ribbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            this.DrawingFrames.embed();
            selectStyle.Checked = false;
            eraserStyle.Checked = false;
            this.btnCopy.Enabled = this.btnCut.Enabled = false;
            switch(e.Item.Caption)
            {
                case "pencil":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.FreePen;
                        this.currentShape.Image = Resources.pencil_icon;
                        break;
                    }
                case "line":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Line;
                        this.currentShape.Image = Resources.Line_icon;
                        break;
                    }
                case "bezier":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Bezier;
                        this.currentShape.Image = Resources.bezierShapeIcon;
                        break;
                    }
                case "rectangle":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.RectangleShape;
                        this.currentShape.Image = Resources.rectangle_icon;
                        break;
                    }
                case "ellipse":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.EllipseShape;
                        this.currentShape.Image = Resources.ellipse_icon;
                        break;
                    }
                case "triangle":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.TriangleShape;
                        this.currentShape.Image = Resources.Triangle_icon;
                        break;
                    }
                case "squareTriangle":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.SquareTriangleShape;
                        this.currentShape.Image = Resources.squareTriangleIcon;
                        break;
                    }
                case "diamond":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.DiamondShape;
                        this.currentShape.Image = Resources.diamondIcon;
                        break;
                    }
                case "pentagon":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.PentagonShape;
                        this.currentShape.Image = Resources.pentagon_icon;
                        break;
                    }
                case "downArrow":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.DownArrowShape;
                        this.currentShape.Image = Resources.down_icon;
                        break;
                    }
                case "upArrow":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.UpArrowShape;
                        this.currentShape.Image = Resources.down_icon;
                        break;
                    }
                case "rightArrow":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.RightArrowShape;
                        this.currentShape.Image = Resources.down_icon;
                        break;
                    }
                case "leftArrow":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.LeftArrowShape;
                        this.currentShape.Image = Resources.down_icon;
                        break;
                    }
                case "polygon":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Polygon;
                        this.currentShape.Image = Resources.polygonShapeIcon;
                        break;
                    }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DrawingFrames.embed();
            if (this.DrawingFrames.ListBack.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Do you want to save change to Untitled?", "Paint", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                btnSave_ItemClick(null, null);
                return;
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            else
                e.Cancel = true;
        }

        private void btnCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuItemCopy_Click(null, null);
        }

        private void btnCut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuItemCut_Click(null, null);
        }

        private void btnPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            menuItemPaste_Click(null, null);
        }

        private void btnEditColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using(ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = this.colorStatus.BackColor;
                if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.colorStatus.BackColor = dlg.Color;
                    Tools.PaintTools.DrawingColor = dlg.Color;
                }
            }
        }

        private void eraserStyle_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void eraserStyle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            selectStyle.Checked = false;
            this.DrawingFrames.embed();
            Tools.PaintTools.EraserWidth = Tools.PaintTools.PenWidth * 10;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Eraser;

            if (!eraserStyle.Checked)
            {
                eraserStyle.Checked = true;
            }
            this.currentShape.Image = Resources.eraserIcon;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

       

        
    }
}
