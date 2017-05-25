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
        Drawing.MainPanel DrawingSpace;

        void init()
        {
            this.DrawingSpace = new Drawing.MainPanel(this.Size);
            this.DrawingSpace.BackColor = System.Drawing.Color.White;
            this.DrawingSpace.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DrawingSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingSpace.Location = new System.Drawing.Point(0, 150);
            this.DrawingSpace.Name = "mainPanel1";
            this.DrawingSpace.TabIndex = 1;
            this.DrawingSpace.ContextMenuStrip = contextMenu;
            this.FreeSpace.Controls.Add(this.DrawingSpace);
        }
        public Form1()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.FreePen;
            Tools.PaintTools.DrawingColor = Color.Black;
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
            if (this.DrawingSpace.ListBack.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Do you want to save change to Untitled?", "Paint", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                btnSave_ItemClick(null, null);

                this.DrawingSpace.embed();

                Bitmap bmp = this.DrawingSpace.ListBack.Last();

                this.DrawingSpace.ContentPanel.Content = bmp;
                this.DrawingSpace.DrawingPanel.Content = new Bitmap(bmp.Size.Width, bmp.Size.Height);
                this.DrawingSpace.Refresh();
                this.DrawingSpace.ListBack.Clear();
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                this.DrawingSpace.embed();

                Bitmap bmp = this.DrawingSpace.ListBack.Last();

                this.DrawingSpace.ContentPanel.Content = bmp;
                this.DrawingSpace.DrawingPanel.Content = new Bitmap(bmp.Size.Width, bmp.Size.Height);
                this.DrawingSpace.Refresh();
                this.DrawingSpace.ListBack.Clear();
            }
            else
                return;
        }

        private void btnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" +
                    "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                    "Windows Bitmap (*.bmp)|*.bmp|" +
                    "All Files (*.*)|*.*";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(dlg.FileName);

                    this.DrawingSpace.DrawingPanel.ActiveShape = new Shape.ImageShape(this.DrawingSpace.Size, new Point(0, 0), bmp);

                    this.DrawingSpace.DrawingPanel.updateContent();

                    this.DrawingSpace.Refresh();
                }
            }
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DrawingSpace.embed();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "JPEG(.jpg)|*.jpg|PNG(.png)|*.png|Bitmap(.bmp)|*.bmp";
            dlg.FileName = "Untitled";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(this.DrawingSpace.Image);
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

        private void btnPenColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.colorStatus.BackColor = dlg.Color;
                    Tools.PaintTools.DrawingColor = dlg.Color;
                }
            }
        }

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
            foreach (ToolStripMenuItem item in contextMenu.Items)
                item.Enabled = true;

            if (this.DrawingSpace.Cursor != Cursors.SizeAll)
            {
                foreach (ToolStripMenuItem item in contextMenu.Items)
                    item.Enabled = (item.Name != menuItemSaveFile.Name && item.Name != menuItemOpenFile.Name) ? false : true;
            }
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
            using (FillEvent.HatchBrush dlg = new FillEvent.HatchBrush())
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    LinearGradientBrush _brush = new LinearGradientBrush(new Point(0, 10), new Point(200, 10), dlg._ForeColor, dlg._BackColor);
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
            using (FillEvent.HatchBrush dlg = new FillEvent.HatchBrush())
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    HatchStyle style = HatchStyle.BackwardDiagonal;
                    HatchBrush _brush = new HatchBrush(style, dlg._ForeColor, dlg._BackColor);
                    Tools.PaintTools.DrawingBrush = _brush;
                }
            }
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.Fill;
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            btnUndo_ItemClick(null, null);
        }

        #endregion

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DrawingSpace.embed();
            if (this.DrawingSpace.ListBack.Count == 0)
                return;
            Bitmap bmp = this.DrawingSpace.ListBack.Pop();
            
            this.DrawingSpace.ContentPanel.Content = bmp;
            this.DrawingSpace.DrawingPanel.Content = new Bitmap(bmp.Size.Width, bmp.Size.Height);
            this.DrawingSpace.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control|Keys.Z))
                btnUndo_ItemClick(null, null);
            else if(e.KeyData == (Keys.Control|Keys.O))
                btnOpen_ItemClick(null, null);
            else if(e.KeyData ==(Keys.Control|Keys.S))
                btnSave_ItemClick(null, null);
        }

        private void ribbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            switch(e.Item.Caption)
            {
                case "pencil":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.FreePen;
                        break;
                    }
                case "line":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Line;
                        break;
                    }
                case "rectangle":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Rectangle;
                        break;
                    }
                case "ellipse":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Ellipse;
                        break;
                    }
                case "triangle":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Triangle;
                        break;
                    }
                case "diamond":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Diamond;
                        break;
                    }
                case "pentagon":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Pentagon;
                        break;
                    }
                case "downArrow":
                    {
                        Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.DownArrow;
                        break;
                    }
            }
        }

        private void btnEraser3px_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tools.PaintTools.EraserWidth = 3;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Eraser;

            btnEraser5px.Checked = false;
            btnEraser10px.Checked = false;
            btnEraser20px.Checked = false;

            if(!btnEraser3px.Checked)
            {
                btnEraser3px.Checked = true;
            }
        }

        private void btnEraser5px_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tools.PaintTools.EraserWidth = 5;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Eraser;

            btnEraser3px.Checked = false;
            btnEraser10px.Checked = false;
            btnEraser20px.Checked = false;

            if (!btnEraser5px.Checked)
            {
                btnEraser5px.Checked = true;
            }
        }

        private void btnEraser10px_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tools.PaintTools.EraserWidth = 10;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Eraser;

            btnEraser3px.Checked = false;
            btnEraser5px.Checked = false;
            btnEraser20px.Checked = false;

            if (!btnEraser10px.Checked)
            {
                btnEraser10px.Checked = true;
            }

        }

        private void btnEraser20px_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Tools.PaintTools.EraserWidth = 20;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Eraser;

            btnEraser3px.Checked = false;
            btnEraser5px.Checked = false;
            btnEraser10px.Checked = false;

            if (!btnEraser20px.Checked)
            {
                btnEraser20px.Checked = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DrawingSpace.ListBack.Count == 0)
                return;

            DialogResult result = MessageBox.Show("Do you want to save change to Untitled?", "Paint", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                btnSave_ItemClick(null, null);
                Application.Exit();
                this.Close();
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                Application.Exit();
                this.Close();
            }
            else
                e.Cancel = true;
        }

        

        

       




    }
}
