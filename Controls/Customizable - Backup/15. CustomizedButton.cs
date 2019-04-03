using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields

        private int customizedBtnOffset = 3;

        //private int customizedBtnRounding = 50;

        private Color customizedBtnInactiveBorder = Color.FromArgb(20,20,20);
        
        private Color[] customizedBtnInactive = new Color[]
        {
            Color.FromArgb(25,25,25),
            Color.FromArgb(0,0,0)
        };

        private Color[] customizedBtnActive = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(25,25,25)
        };

        private Color[] customizedBtnActiveBorder = new Color[]
        {
            Color.FromArgb(60,60,60),
            Color.FromArgb(100,100,100)
        };

        private Color[] customizedBtnPressed = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(25,25,25)
        };

        private Color[] customizedBtnPressedBorder = new Color[]
        {
            Color.FromArgb(60, 60, 60),
            Color.FromArgb(100, 100, 100)
        };

        private Color[] customizedBtnOffsetGradient = new Color[]
        {
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(60, 60, 60)
        };

        private Color[] customizedBtnOffsetBorder = new Color[]
        {
            Color.FromArgb(10,10,10),
            Color.FromArgb(100,100,100)
        };

        #endregion
        
        #region Public Properties

        public int CustomizedBtnOffset
        {
            get { return customizedBtnOffset; }
            set { customizedBtnOffset = value;
                Invalidate();
            }
        }

        public Color[] CustomizedBtnInactive
        {
            get { return customizedBtnInactive; }
            set { customizedBtnInactive = value; Invalidate(); }
        }

        public Color[] CustomizedBtnActive
        {
            get { return customizedBtnActive; }
            set { customizedBtnActive = value; Invalidate(); }
        }

        public Color[] CustomizedBtnActiveBorder
        {
            get { return customizedBtnActiveBorder; }
            set { customizedBtnActiveBorder = value; Invalidate(); }
        }

        public Color[] CustomizedBtnPressed
        {
            get { return customizedBtnPressed; }
            set { customizedBtnPressed = value; Invalidate(); }
        }

        public Color[] CustomizedBtnPressedBorder
        {
            get { return customizedBtnPressedBorder; }
            set { customizedBtnPressedBorder = value; Invalidate(); }
        }

        //public int Curve
        //{
        //    get { return customizedBtnRounding; }
        //    set { customizedBtnRounding = value;
        //        Invalidate();
        //    }
        //}

        public Color[] CustomizedBtnOffsetGradient
        {
            get { return customizedBtnOffsetGradient; }
            set { customizedBtnOffsetGradient = value; }
        }

        public Color[] CustomizedBtnOffsetBorder
        {
            get { return customizedBtnOffsetBorder; }
            set { customizedBtnOffsetBorder = value; }
        }

        public Color CustomizedBtnInactiveBorder
        {
            get { return customizedBtnInactiveBorder; }
            set { customizedBtnInactiveBorder = value; }
        }

        #endregion

        #region Paint

        private void CustomizedButtonPaint(PaintEventArgs e)
        {
            //B = new Bitmap(Width, Height);
            //G = Graphics.FromImage(B);
            //G.SmoothingMode = Smoothing;
            //e.Graphics.SmoothingMode = Smoothing;
            G.Clear(Parent.BackColor);

            LinearGradientBrush BaWInactiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), CustomizedBtnInactive[0], CustomizedBtnInactive[1], 90);
            LinearGradientBrush BaWActiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), CustomizedBtnActive[0], CustomizedBtnActive[1], 90);
            LinearGradientBrush BaWActiveContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), CustomizedBtnActiveBorder[0], CustomizedBtnActiveBorder[1], 90);
            LinearGradientBrush BaWPressedGB = new LinearGradientBrush(new Rectangle(0, 1, Width, Height), CustomizedBtnPressed[0], CustomizedBtnPressed[1], 90);
            LinearGradientBrush BaWPressedContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), CustomizedBtnPressedBorder[0], CustomizedBtnPressedBorder[1], 90);
            Pen BaWP2 = new Pen(BaWActiveContourGB);
            Pen BaWP3 = new Pen(BaWPressedContourGB);


            Rectangle offsetRectangle = new Rectangle(0 + customizedBtnOffset, 0 + customizedBtnOffset, Width - 2 - (customizedBtnOffset * 2),
                Height - 2 - (customizedBtnOffset * 2));
            GraphicsPath BaWShape = Helper.RoundRect(new Rectangle(0, 0, Width - 2, Height - 2), 50);
            GraphicsPath BaWShapeOffset = Helper.RoundRect(new Rectangle(0 + customizedBtnOffset, 0 + customizedBtnOffset, Width - 2 - (customizedBtnOffset * 2), Height - 2 - (customizedBtnOffset * 2)), Curve);


            switch (State)
            {
                case MouseState.None:
                    //Inactive
                    G.FillPath(BaWInactiveGB, BaWShape);
                    G.DrawPath(new Pen(CustomizedBtnInactiveBorder), BaWShape);
                    G.DrawPath(new Pen(CustomizedBtnInactiveBorder), BaWShapeOffset);
                    break;
                case MouseState.Over:
                    //Active
                    G.FillPath(BaWActiveGB, BaWShape);
                    G.DrawPath(BaWP2, BaWShape);
                    G.FillPath(new LinearGradientBrush(offsetRectangle, CustomizedBtnOffsetGradient[0], CustomizedBtnOffsetGradient[1], 90f), BaWShapeOffset);
                    G.DrawPath(new Pen(new LinearGradientBrush(offsetRectangle, CustomizedBtnOffsetBorder[0], CustomizedBtnOffsetBorder[1], 90f)), BaWShapeOffset);
                    break;
                case MouseState.Down:
                    //Pressed
                    G.FillPath(BaWPressedGB, BaWShape);
                    G.DrawPath(BaWP3, BaWShape);
                    G.FillPath(new LinearGradientBrush(offsetRectangle, CustomizedBtnOffsetGradient[1], CustomizedBtnOffsetGradient[0], 90f), BaWShapeOffset);
                    G.DrawPath(new Pen(new LinearGradientBrush(offsetRectangle, Color.FromArgb(50, CustomizedBtnOffsetBorder[0]), Color.FromArgb(175, CustomizedBtnOffsetBorder[1]), 90f)), BaWShapeOffset);
                    break;
            }

            //e.Graphics.DrawImage((Bitmap) B.Clone(), 0, 0);

        }

        #endregion


    }


}
