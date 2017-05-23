namespace MyPaint
{
    partial class MyPaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPaintForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupShape = new System.Windows.Forms.GroupBox();
            this.cbPenColor = new DevExpress.XtraEditors.ColorPickEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.btnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveFile = new DevExpress.XtraEditors.SimpleButton();
            this.ellipseShape = new DevExpress.XtraEditors.CheckButton();
            this.rectangleShape = new DevExpress.XtraEditors.CheckButton();
            this.lineShape = new DevExpress.XtraEditors.CheckButton();
            this.pen = new DevExpress.XtraEditors.CheckButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPenColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSize.Properties)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnSaveFile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 129);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupShape);
            this.panel2.Controls.Add(this.cbPenColor);
            this.panel2.Controls.Add(this.pen);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.cbSize);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Location = new System.Drawing.Point(136, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 105);
            this.panel2.TabIndex = 9;
            // 
            // groupShape
            // 
            this.groupShape.Controls.Add(this.ellipseShape);
            this.groupShape.Controls.Add(this.rectangleShape);
            this.groupShape.Controls.Add(this.lineShape);
            this.groupShape.Location = new System.Drawing.Point(10, 6);
            this.groupShape.Name = "groupShape";
            this.groupShape.Size = new System.Drawing.Size(149, 85);
            this.groupShape.TabIndex = 1;
            this.groupShape.TabStop = false;
            this.groupShape.Text = "Shape";
            // 
            // cbPenColor
            // 
            this.cbPenColor.EditValue = System.Drawing.Color.Black;
            this.cbPenColor.Location = new System.Drawing.Point(339, 27);
            this.cbPenColor.Name = "cbPenColor";
            this.cbPenColor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbPenColor.Properties.Appearance.Options.UseFont = true;
            this.cbPenColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPenColor.Size = new System.Drawing.Size(154, 28);
            this.cbPenColor.TabIndex = 3;
            this.cbPenColor.EditValueChanged += new System.EventHandler(this.Color_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(290, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Size:";
            // 
            // cbSize
            // 
            this.cbSize.EditValue = "1";
            this.cbSize.Location = new System.Drawing.Point(339, 61);
            this.cbSize.Name = "cbSize";
            this.cbSize.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbSize.Properties.Appearance.Options.UseFont = true;
            this.cbSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSize.Properties.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "7"});
            this.cbSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbSize.Size = new System.Drawing.Size(154, 28);
            this.cbSize.TabIndex = 4;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(254, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Pen Color:";
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
            this.menuItemOpenFile.Name = "menuItemOpenFile";
            this.menuItemOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpenFile.Size = new System.Drawing.Size(200, 26);
            this.menuItemOpenFile.Text = "Open File";
            // 
            // menuItemSaveFile
            // 
            this.menuItemSaveFile.Name = "menuItemSaveFile";
            this.menuItemSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSaveFile.Size = new System.Drawing.Size(200, 26);
            this.menuItemSaveFile.Text = "Save File";
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
            // btnOpenFile
            // 
            this.btnOpenFile.Image = global::MyPaint.Properties.Resources.open2_32x32;
            this.btnOpenFile.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnOpenFile.Location = new System.Drawing.Point(65, 55);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(49, 48);
            this.btnOpenFile.TabIndex = 10;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Image = global::MyPaint.Properties.Resources.saveall_32x32;
            this.btnSaveFile.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSaveFile.Location = new System.Drawing.Point(10, 56);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(49, 48);
            this.btnSaveFile.TabIndex = 10;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // ellipseShape
            // 
            this.ellipseShape.Image = global::MyPaint.Properties.Resources.ellipse1;
            this.ellipseShape.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ellipseShape.Location = new System.Drawing.Point(88, 21);
            this.ellipseShape.Name = "ellipseShape";
            this.ellipseShape.Size = new System.Drawing.Size(35, 30);
            this.ellipseShape.TabIndex = 0;
            this.ellipseShape.Text = "checkButton1";
            this.ellipseShape.Click += new System.EventHandler(this.ellipseShape_Click);
            // 
            // rectangleShape
            // 
            this.rectangleShape.Image = ((System.Drawing.Image)(resources.GetObject("rectangleShape.Image")));
            this.rectangleShape.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.rectangleShape.Location = new System.Drawing.Point(47, 21);
            this.rectangleShape.Name = "rectangleShape";
            this.rectangleShape.Size = new System.Drawing.Size(35, 30);
            this.rectangleShape.TabIndex = 0;
            this.rectangleShape.Text = "checkButton1";
            this.rectangleShape.Click += new System.EventHandler(this.rectangleShape_Click);
            // 
            // lineShape
            // 
            this.lineShape.Image = global::MyPaint.Properties.Resources.line_copy;
            this.lineShape.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.lineShape.Location = new System.Drawing.Point(6, 21);
            this.lineShape.Name = "lineShape";
            this.lineShape.Size = new System.Drawing.Size(35, 30);
            this.lineShape.TabIndex = 0;
            this.lineShape.Text = "checkButton1";
            this.lineShape.Click += new System.EventHandler(this.lineShape_Click);
            // 
            // pen
            // 
            this.pen.Checked = true;
            this.pen.Image = global::MyPaint.Properties.Resources.Brushes_icon;
            this.pen.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.pen.Location = new System.Drawing.Point(165, 17);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(83, 72);
            this.pen.TabIndex = 2;
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(10, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 38);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MyPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 702);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.panel1);
            this.Name = "MyPaintForm";
            this.Text = "MyPaintForm";
            this.Load += new System.EventHandler(this.MyPaintForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupShape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPenColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSize.Properties)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupShape;
        private DevExpress.XtraEditors.CheckButton lineShape;
        private DevExpress.XtraEditors.CheckButton ellipseShape;
        private DevExpress.XtraEditors.CheckButton rectangleShape;
        private DevExpress.XtraEditors.CheckButton pen;
        private DevExpress.XtraEditors.ColorPickEdit cbPenColor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbSize;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnOpenFile;
        private DevExpress.XtraEditors.SimpleButton btnSaveFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemFill;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemSolidBrush;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemLinearGradientBrush;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemTextureBrush;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemHatchBrush;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveFile;
        private System.Windows.Forms.ToolStripMenuItem menuSubItemUnFill;

    }
}