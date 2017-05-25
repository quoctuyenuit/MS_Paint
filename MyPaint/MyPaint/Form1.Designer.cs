namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.lineShape = new DevExpress.XtraBars.BarCheckItem();
            this.rectangleShape = new DevExpress.XtraBars.BarCheckItem();
            this.ellipseShape = new DevExpress.XtraBars.BarCheckItem();
            this.btnPenColor = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.size1 = new DevExpress.XtraBars.BarButtonItem();
            this.size2 = new DevExpress.XtraBars.BarButtonItem();
            this.size3 = new DevExpress.XtraBars.BarButtonItem();
            this.size4 = new DevExpress.XtraBars.BarButtonItem();
            this.freePen = new DevExpress.XtraBars.BarCheckItem();
            this.eraser = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupShape = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.settingGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.penWitdhStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubItemUnFill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubItemSolidBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubItemLinearGradientBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubItemTextureBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSubItemHatchBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.FreeSpace = new System.Windows.Forms.Panel();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnOpen,
            this.btnSave,
            this.lineShape,
            this.rectangleShape,
            this.ellipseShape,
            this.btnPenColor,
            this.barSubItem1,
            this.size1,
            this.size2,
            this.size3,
            this.size4,
            this.freePen,
            this.eraser,
            this.btnUndo});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemColorPickEdit1});
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1388, 150);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "Open";
            this.btnOpen.Id = 1;
            this.btnOpen.LargeGlyph = global::MyPaint.Properties.Resources.open2_32x32;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpen_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 2;
            this.btnSave.LargeGlyph = global::MyPaint.Properties.Resources.saveall_32x32;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // lineShape
            // 
            this.lineShape.Caption = "Line";
            this.lineShape.Glyph = global::MyPaint.Properties.Resources.line_copy;
            this.lineShape.Id = 4;
            this.lineShape.Name = "lineShape";
            this.lineShape.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lineShape_ItemClick);
            // 
            // rectangleShape
            // 
            this.rectangleShape.Caption = "Rectangle";
            this.rectangleShape.Glyph = global::MyPaint.Properties.Resources.rectangle;
            this.rectangleShape.Id = 5;
            this.rectangleShape.Name = "rectangleShape";
            this.rectangleShape.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rectangleShape_ItemClick);
            // 
            // ellipseShape
            // 
            this.ellipseShape.Caption = "Ellipse";
            this.ellipseShape.Glyph = global::MyPaint.Properties.Resources.ellipse1;
            this.ellipseShape.Id = 6;
            this.ellipseShape.Name = "ellipseShape";
            this.ellipseShape.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ellipseShape_ItemClick);
            // 
            // btnPenColor
            // 
            this.btnPenColor.Caption = "Color";
            this.btnPenColor.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPenColor.Glyph")));
            this.btnPenColor.Id = 8;
            this.btnPenColor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPenColor.LargeGlyph")));
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPenColor_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Size";
            this.barSubItem1.Id = 9;
            this.barSubItem1.LargeGlyph = global::MyPaint.Properties.Resources.Editing_Line_Width_icon;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.size1),
            new DevExpress.XtraBars.LinkPersistInfo(this.size2),
            new DevExpress.XtraBars.LinkPersistInfo(this.size3),
            new DevExpress.XtraBars.LinkPersistInfo(this.size4)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // size1
            // 
            this.size1.Caption = "1 px";
            this.size1.Glyph = global::MyPaint.Properties.Resources.size1;
            this.size1.Id = 10;
            this.size1.Name = "size1";
            this.size1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.size1_ItemClick);
            // 
            // size2
            // 
            this.size2.Caption = "3 px";
            this.size2.Glyph = global::MyPaint.Properties.Resources.size2;
            this.size2.Id = 11;
            this.size2.Name = "size2";
            this.size2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.size2_ItemClick);
            // 
            // size3
            // 
            this.size3.Caption = "5 px";
            this.size3.Glyph = global::MyPaint.Properties.Resources.size3;
            this.size3.Id = 12;
            this.size3.Name = "size3";
            this.size3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.size3_ItemClick);
            // 
            // size4
            // 
            this.size4.Caption = "7 px";
            this.size4.Glyph = global::MyPaint.Properties.Resources.size4;
            this.size4.Id = 13;
            this.size4.Name = "size4";
            this.size4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.size4_ItemClick);
            // 
            // freePen
            // 
            this.freePen.BindableChecked = true;
            this.freePen.Caption = "Free Pen";
            this.freePen.Checked = true;
            this.freePen.Id = 14;
            this.freePen.LargeGlyph = global::MyPaint.Properties.Resources.Brushes_icon;
            this.freePen.Name = "freePen";
            this.freePen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.freePen_ItemClick);
            // 
            // eraser
            // 
            this.eraser.Caption = "Eraser";
            this.eraser.Id = 15;
            this.eraser.LargeGlyph = global::MyPaint.Properties.Resources.draw_eraser_icon;
            this.eraser.Name = "eraser";
            this.eraser.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.eraser_CheckedChanged);
            this.eraser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.eraser_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.groupShape,
            this.settingGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUndo);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnOpen);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // groupShape
            // 
            this.groupShape.ItemLinks.Add(this.lineShape);
            this.groupShape.ItemLinks.Add(this.rectangleShape);
            this.groupShape.ItemLinks.Add(this.ellipseShape);
            this.groupShape.ItemLinks.Add(this.freePen);
            this.groupShape.ItemLinks.Add(this.eraser);
            this.groupShape.Name = "groupShape";
            this.groupShape.Text = "Shape";
            // 
            // settingGroup
            // 
            this.settingGroup.ItemLinks.Add(this.btnPenColor);
            this.settingGroup.ItemLinks.Add(this.barSubItem1);
            this.settingGroup.Name = "settingGroup";
            this.settingGroup.Text = "Setting";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.colorStatus,
            this.toolStripStatusLabel2,
            this.penWitdhStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1388, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 20);
            this.toolStripStatusLabel1.Text = "Current Color:";
            // 
            // colorStatus
            // 
            this.colorStatus.BackColor = System.Drawing.Color.Black;
            this.colorStatus.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.colorStatus.Name = "colorStatus";
            this.colorStatus.Size = new System.Drawing.Size(37, 20);
            this.colorStatus.Text = "       ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(83, 20);
            this.toolStripStatusLabel2.Text = "Pen Width: ";
            // 
            // penWitdhStatus
            // 
            this.penWitdhStatus.Name = "penWitdhStatus";
            this.penWitdhStatus.Size = new System.Drawing.Size(37, 20);
            this.penWitdhStatus.Text = "1 px";
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenFile,
            this.menuItemSaveFile,
            this.menuItemFill,
            this.menuItemDelete});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(201, 108);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // menuItemOpenFile
            // 
            this.menuItemOpenFile.Image = global::MyPaint.Properties.Resources.open2_32x32;
            this.menuItemOpenFile.Name = "menuItemOpenFile";
            this.menuItemOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpenFile.Size = new System.Drawing.Size(200, 26);
            this.menuItemOpenFile.Text = "Open File";
            this.menuItemOpenFile.Click += new System.EventHandler(this.menuItemOpenFile_Click);
            // 
            // menuItemSaveFile
            // 
            this.menuItemSaveFile.Image = global::MyPaint.Properties.Resources.saveall_32x32;
            this.menuItemSaveFile.Name = "menuItemSaveFile";
            this.menuItemSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSaveFile.Size = new System.Drawing.Size(200, 26);
            this.menuItemSaveFile.Text = "Save File";
            this.menuItemSaveFile.Click += new System.EventHandler(this.menuItemSaveFile_Click);
            // 
            // menuItemFill
            // 
            this.menuItemFill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSubItemUnFill,
            this.menuSubItemSolidBrush,
            this.menuSubItemLinearGradientBrush,
            this.menuSubItemTextureBrush,
            this.menuSubItemHatchBrush});
            this.menuItemFill.Image = global::MyPaint.Properties.Resources.valuecolorizermap_32x32;
            this.menuItemFill.Name = "menuItemFill";
            this.menuItemFill.Size = new System.Drawing.Size(200, 26);
            this.menuItemFill.Text = "Fill";
            // 
            // menuSubItemUnFill
            // 
            this.menuSubItemUnFill.Name = "menuSubItemUnFill";
            this.menuSubItemUnFill.Size = new System.Drawing.Size(217, 26);
            this.menuSubItemUnFill.Text = "UnFill";
            this.menuSubItemUnFill.Click += new System.EventHandler(this.menuSubItemUnFill_Click);
            // 
            // menuSubItemSolidBrush
            // 
            this.menuSubItemSolidBrush.Image = global::MyPaint.Properties.Resources.solidBrushIcon;
            this.menuSubItemSolidBrush.Name = "menuSubItemSolidBrush";
            this.menuSubItemSolidBrush.Size = new System.Drawing.Size(217, 26);
            this.menuSubItemSolidBrush.Text = "SolidBrush";
            this.menuSubItemSolidBrush.Click += new System.EventHandler(this.menuSubItemSolidBrush_Click);
            // 
            // menuSubItemLinearGradientBrush
            // 
            this.menuSubItemLinearGradientBrush.Image = global::MyPaint.Properties.Resources.linearGradientBrushIcon;
            this.menuSubItemLinearGradientBrush.Name = "menuSubItemLinearGradientBrush";
            this.menuSubItemLinearGradientBrush.Size = new System.Drawing.Size(217, 26);
            this.menuSubItemLinearGradientBrush.Text = "LinearGradientBrush";
            this.menuSubItemLinearGradientBrush.Click += new System.EventHandler(this.menuSubItemLinearGradientBrush_Click);
            // 
            // menuSubItemTextureBrush
            // 
            this.menuSubItemTextureBrush.Image = global::MyPaint.Properties.Resources.textureBrushIcon;
            this.menuSubItemTextureBrush.Name = "menuSubItemTextureBrush";
            this.menuSubItemTextureBrush.Size = new System.Drawing.Size(217, 26);
            this.menuSubItemTextureBrush.Text = "TextureBrush";
            this.menuSubItemTextureBrush.Click += new System.EventHandler(this.menuSubItemTextureBrush_Click);
            // 
            // menuSubItemHatchBrush
            // 
            this.menuSubItemHatchBrush.Image = global::MyPaint.Properties.Resources.hatchBrushIcon;
            this.menuSubItemHatchBrush.Name = "menuSubItemHatchBrush";
            this.menuSubItemHatchBrush.Size = new System.Drawing.Size(217, 26);
            this.menuSubItemHatchBrush.Text = "HatchBrush";
            this.menuSubItemHatchBrush.Click += new System.EventHandler(this.menuSubItemHatchBrush_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Image = global::MyPaint.Properties.Resources.delete_32x32;
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItemDelete.Size = new System.Drawing.Size(200, 26);
            this.menuItemDelete.Text = "Delete";
            // 
            // FreeSpace
            // 
            this.FreeSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreeSpace.Location = new System.Drawing.Point(0, 150);
            this.FreeSpace.Name = "FreeSpace";
            this.FreeSpace.Size = new System.Drawing.Size(1388, 497);
            this.FreeSpace.TabIndex = 3;
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.Glyph")));
            this.btnUndo.Id = 16;
            this.btnUndo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.LargeGlyph")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 672);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.FreeSpace);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnOpen;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarCheckItem lineShape;
        private DevExpress.XtraBars.BarCheckItem rectangleShape;
        private DevExpress.XtraBars.BarCheckItem ellipseShape;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupShape;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup settingGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem btnPenColor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel colorStatus;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel penWitdhStatus;
        private DevExpress.XtraBars.BarButtonItem size1;
        private DevExpress.XtraBars.BarButtonItem size2;
        private DevExpress.XtraBars.BarButtonItem size3;
        private DevExpress.XtraBars.BarButtonItem size4;
        private DevExpress.XtraBars.BarCheckItem freePen;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemFill;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemUnFill;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemSolidBrush;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemLinearGradientBrush;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemTextureBrush;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemHatchBrush;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.Panel FreeSpace;
        private DevExpress.XtraBars.BarCheckItem eraser;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
    }
}