// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="15. CustomizedButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields

        //private int customizedBtnOffset = 3;

        ////private int customizedBtnRounding = 50;

        //private Color customizedBtnInactiveBorder = Color.FromArgb(20,20,20);

        //private Color[] customizedBtnInactive = new Color[]
        //{
        //    Color.FromArgb(25,25,25),
        //    Color.FromArgb(0,0,0)
        //};

        //private Color[] customizedBtnActive = new Color[]
        //{
        //    Color.FromArgb(0,0,0),
        //    Color.FromArgb(25,25,25)
        //};

        //private Color[] customizedBtnActiveBorder = new Color[]
        //{
        //    Color.FromArgb(60,60,60),
        //    Color.FromArgb(100,100,100)
        //};

        //private Color[] customizedBtnPressed = new Color[]
        //{
        //    Color.FromArgb(0,0,0),
        //    Color.FromArgb(25,25,25)
        //};

        //private Color[] customizedBtnPressedBorder = new Color[]
        //{
        //    Color.FromArgb(60, 60, 60),
        //    Color.FromArgb(100, 100, 100)
        //};

        //private Color[] customizedBtnOffsetGradient = new Color[]
        //{
        //    Color.FromArgb(25, 25, 25),
        //    Color.FromArgb(60, 60, 60)
        //};

        //private Color[] customizedBtnOffsetBorder = new Color[]
        //{
        //    Color.FromArgb(10,10,10),
        //    Color.FromArgb(100,100,100)
        //};

        #endregion

        #region Public Properties
        [Browsable(false)]
        public int CustomizedBtnOffset
        {
            get { return buttonInput.CustomizedBtnOffset; }
            set {
                buttonInput.CustomizedBtnOffset = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomizedBtnInactive
        {
            get { return buttonInput.CustomizedBtnInactive; }
            set { buttonInput.CustomizedBtnInactive = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomizedBtnActive
        {
            get { return buttonInput.CustomizedBtnActive; }
            set { buttonInput.CustomizedBtnActive = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomizedBtnActiveBorder
        {
            get { return buttonInput.CustomizedBtnActiveBorder; }
            set { buttonInput.CustomizedBtnActiveBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomizedBtnPressed
        {
            get { return buttonInput.CustomizedBtnPressed; }
            set { buttonInput.CustomizedBtnPressed = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomizedBtnPressedBorder
        {
            get { return buttonInput.CustomizedBtnPressedBorder; }
            set { buttonInput.CustomizedBtnPressedBorder = value; Invalidate(); }
        }

        //public int Curve
        //{
        //    get { return customizedBtnRounding; }
        //    set { customizedBtnRounding = value;
        //        Invalidate();
        //    }
        //}

        [Browsable(false)]
        public Color[] CustomizedBtnOffsetGradient
        {
            get { return buttonInput.CustomizedBtnOffsetGradient; }
            set { buttonInput.CustomizedBtnOffsetGradient = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomizedBtnOffsetBorder
        {
            get { return buttonInput.CustomizedBtnOffsetBorder; }
            set { buttonInput.CustomizedBtnOffsetBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomizedBtnInactiveBorder
        {
            get { return buttonInput.CustomizedBtnInactiveBorder; }
            set { buttonInput.CustomizedBtnInactiveBorder = value; Invalidate(); }
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


            Rectangle offsetRectangle = new Rectangle(0 + CustomizedBtnOffset, 0 + CustomizedBtnOffset, Width - 2 - (CustomizedBtnOffset * 2),
                Height - 2 - (CustomizedBtnOffset * 2));
            GraphicsPath BaWShape = Helper.RoundRect(new Rectangle(0, 0, Width - 2, Height - 2), Curve);
            GraphicsPath BaWShapeOffset = Helper.RoundRect(new Rectangle(0 + CustomizedBtnOffset, 0 + CustomizedBtnOffset, Width - 2 - (CustomizedBtnOffset * 2), Height - 2 - (CustomizedBtnOffset * 2)), Curve);


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
