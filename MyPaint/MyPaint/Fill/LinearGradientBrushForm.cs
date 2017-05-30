using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint.Fill
{
    public partial class LinearGradientBrushForm : Form
    {
        private Color _foreColor;

        public Color _ForeColor
        {
            get { return _foreColor; }
            set { _foreColor = value; }
        }

        private Color _backColor;

        public Color _BackColor
        {
            get { return _backColor; }
            set { _backColor = value; }
        }

        public LinearGradientBrushForm()
        {
            InitializeComponent();
            cbBackColor.Color = Tools.PaintTools.ColorBrush_1;
            cbForeColor.Color = Tools.PaintTools.ColorBrush_2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this._ForeColor = cbForeColor.Color;
            this._BackColor = cbBackColor.Color;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
