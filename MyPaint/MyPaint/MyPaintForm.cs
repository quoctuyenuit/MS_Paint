using DevExpress.XtraEditors;
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
    public partial class MyPaintForm : Form
    {
        Drawing.MainPanel mainPanel1;
        private Stack<Bitmap> listBack;
        public MyPaintForm()
        {
            InitializeComponent();
            init();
            this.listBack = new Stack<Bitmap>();
        }

        void init()
        {
            WindowState = FormWindowState.Maximized;
            Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.FreePen;
            Tools.PaintTools.DrawingColor = Color.Black;
            Tools.PaintTools.PenWidth = 1;
            Tools.PaintTools.DrawingBrush = Brushes.Yellow;
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.UnFill;

            this.mainPanel1 = new Drawing.MainPanel(new Size(1600,1000));
            this.mainPanel1.BackColor = System.Drawing.Color.White;
            this.mainPanel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel1.Location = new System.Drawing.Point(0, 179);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.TabIndex = 1;
            this.mainPanel1.MouseDown += mainPanel1_MouseDown;
            this.mainPanel1.MouseUp += mainPanel1_MouseUp;
            this.Controls.Add(this.mainPanel1);


        }

        void mainPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        void mainPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.mainPanel1.Size.Width, this.mainPanel1.Size.Height);
            bmp = this.mainPanel1.Image.Clone(new Rectangle(0, 0, this.mainPanel1.Image.Size.Width, this.mainPanel1.Image.Size.Height), this.mainPanel1.Image.PixelFormat);
            this.listBack.Push(bmp);
        }

        private void MyPaintForm_Load(object sender, EventArgs e)
        {

        }

        private void Color_EditValueChanged(object sender, EventArgs e)
        {
            Tools.PaintTools.DrawingColor = cbPenColor.Color;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tools.PaintTools.PenWidth = int.Parse(cbSize.Text.ToString());
        }

        private void lineShape_Click(object sender, EventArgs e)
        {
            if (!lineShape.Checked)
            {
                Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Line;
                lineShape.Checked = true;
            }
            
            foreach (Control ctrl in groupShape.Controls)
            {
                CheckButton item = ctrl as CheckButton;
                item.Checked = false;
            }
        }

        private void rectangleShape_Click(object sender, EventArgs e)
        {
            if (!rectangleShape.Checked)
            {
                Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Rectangle;
                rectangleShape.Checked = true;
            }

            foreach (Control ctrl in groupShape.Controls)
            {
                CheckButton item = ctrl as CheckButton;
                item.Checked = false;
            }
        }

        private void ellipseShape_Click(object sender, EventArgs e)
        {
            if (!ellipseShape.Checked)
            {
                Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.Ellipse;
                ellipseShape.Checked = true;
            }

            foreach (Control ctrl in groupShape.Controls)
            {
                CheckButton item = ctrl as CheckButton;
                item.Checked = false;
            }
        }

        private void pen_Click(object sender, EventArgs e)
        {
            if (!pen.Checked)
            {
                Tools.PaintTools.DrawingTool = Tools.PaintTools.EnumDrawingTool.FreePen;
                pen.Checked = true;
            }

            foreach (Control ctrl in groupShape.Controls)
            {
                CheckButton item = ctrl as CheckButton;
                item.Checked = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.listBack.Count <= 0)
                return;


            this.mainPanel1.ContentPanel.embedImage(this.listBack.Pop());
            
            this.mainPanel1.DrawingPanel.Content = new Bitmap(this.Size.Width, this.Size.Height);
            
            Graphics g = this.mainPanel1.CreateGraphics();
            g.DrawImage(this.mainPanel1.ContentPanel.Content, 0, 0);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" +
                    "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                    "Windows Bitmap (*.bmp)|*.bmp|" +
                    "All Files (*.*)|*.*";
                if(dlg.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(dlg.FileName);
                    this.mainPanel1.Image = bmp;
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            this.mainPanel1.embed();
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "JPEG(.jpg)|*.jpg|PNG(.png)|*.png|Bitmap(.bmp)|*.bmp";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(this.mainPanel1.Image);
                string ext = dlg.FileName.Substring(dlg.FileName.LastIndexOf('.')+1);
                switch(ext)
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

        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            foreach (ToolStripMenuItem item in contextMenu.Items)
                item.Enabled = true;

            if (this.mainPanel1.Cursor != Cursors.SizeAll)
            {
                foreach (ToolStripMenuItem item in contextMenu.Items)
                    item.Enabled = (item.Name != menuItemSaveFile.Name && item.Name != menuItemOpenFile.Name) ? false : true;
            }
           
        }

        private void menuSubItemSolidBrush_Click(object sender, EventArgs e)
        {
            using(ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    SolidBrush _brush = new SolidBrush(dlg.Color);
                    Tools.PaintTools.DrawingBrush = _brush;
                }
            }
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.Fill;
        }

        private void menuSubItemUnFill_Click(object sender, EventArgs e)
        {
            Tools.PaintTools.BrushStatus = Tools.PaintTools.EnumBrushStatus.UnFill;
        }

        private void menuSubItemTextureBrush_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;" +
                    "*.jfif;*.png;*.tif;*.tiff;*.wmf;*.emf|" +
                    "Windows Bitmap (*.bmp)|*.bmp|" +
                    "All Files (*.*)|*.*";
                if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
            using(FillEvent.HatchBrush dlg = new FillEvent.HatchBrush())
            {
                if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    HatchStyle style = HatchStyle.BackwardDiagonal;
                    HatchBrush _brush = new HatchBrush(style, dlg._ForeColor, dlg._BackColor);
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


    }
}
