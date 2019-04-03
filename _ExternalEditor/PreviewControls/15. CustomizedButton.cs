// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="15. CustomizedButton.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class CustomizedButton.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class CustomizedButton : ThemeControl
    {

        #region Private Fields

        /// <summary>
        /// The customized BTN offset
        /// </summary>
        private int customizedBtnOffset = 3;

        //private int customizedBtnRounding = 50;

        /// <summary>
        /// The customized BTN inactive border
        /// </summary>
        private Color customizedBtnInactiveBorder = Color.FromArgb(20,20,20);

        /// <summary>
        /// The customized BTN inactive
        /// </summary>
        private Color[] customizedBtnInactive = new Color[]
        {
            Color.FromArgb(25,25,25),
            Color.FromArgb(0,0,0)
        };

        /// <summary>
        /// The customized BTN active
        /// </summary>
        private Color[] customizedBtnActive = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(25,25,25)
        };

        /// <summary>
        /// The customized BTN active border
        /// </summary>
        private Color[] customizedBtnActiveBorder = new Color[]
        {
            Color.FromArgb(60,60,60),
            Color.FromArgb(100,100,100)
        };

        /// <summary>
        /// The customized BTN pressed
        /// </summary>
        private Color[] customizedBtnPressed = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(25,25,25)
        };

        /// <summary>
        /// The customized BTN pressed border
        /// </summary>
        private Color[] customizedBtnPressedBorder = new Color[]
        {
            Color.FromArgb(60, 60, 60),
            Color.FromArgb(100, 100, 100)
        };

        /// <summary>
        /// The customized BTN offset gradient
        /// </summary>
        private Color[] customizedBtnOffsetGradient = new Color[]
        {
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(60, 60, 60)
        };

        /// <summary>
        /// The customized BTN offset border
        /// </summary>
        private Color[] customizedBtnOffsetBorder = new Color[]
        {
            Color.FromArgb(10,10,10),
            Color.FromArgb(100,100,100)
        };

        /// <summary>
        /// The curve
        /// </summary>
        private int curve = 20;

        #endregion

        #region Public Properties

        #region Smoothing Mode

        /// <summary>
        /// The smoothing
        /// </summary>
        private SmoothingMode smoothing = SmoothingMode.AntiAlias;

        /// <summary>
        /// Gets or sets the smoothing.
        /// </summary>
        /// <value>The smoothing.</value>
        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                if (value == SmoothingMode.Invalid)
                {
                    value = SmoothingMode.HighQuality;
                    Invalidate();
                }
                smoothing = value;
                Invalidate();
            }
        }

        #endregion

        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        /// <summary>
        /// The textrendering
        /// </summary>
        TextRenderingHint textrendering = TextRenderingHint.SystemDefault;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }



        #endregion

        #region Interpolation Mode

        /// <summary>
        /// The interpolation mode
        /// </summary>
        private InterpolationMode interpolationMode = InterpolationMode.HighQualityBicubic;

        /// <summary>
        /// Gets or sets the interpolation mode.
        /// </summary>
        /// <value>The interpolation mode.</value>
        public InterpolationMode InterpolationMode
        {
            get { return interpolationMode; }
            set
            {
                interpolationMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Pixel Offset
        /// <summary>
        /// The pixel offset mode
        /// </summary>
        private PixelOffsetMode pixelOffsetMode = PixelOffsetMode.None;

        /// <summary>
        /// Gets or sets the pixel offset mode.
        /// </summary>
        /// <value>The pixel offset mode.</value>
        public PixelOffsetMode PixelOffsetMode
        {
            get { return pixelOffsetMode; }
            set
            {
                pixelOffsetMode = value;
                Invalidate();
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the customized BTN offset.
        /// </summary>
        /// <value>The customized BTN offset.</value>
        public int CustomizedBtnOffset
        {
            get { return customizedBtnOffset; }
            set { customizedBtnOffset = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the customized BTN inactive.
        /// </summary>
        /// <value>The customized BTN inactive.</value>
        public Color[] CustomizedBtnInactive
        {
            get { return customizedBtnInactive; }
            set { customizedBtnInactive = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the customized BTN active.
        /// </summary>
        /// <value>The customized BTN active.</value>
        public Color[] CustomizedBtnActive
        {
            get { return customizedBtnActive; }
            set { customizedBtnActive = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the customized BTN active border.
        /// </summary>
        /// <value>The customized BTN active border.</value>
        public Color[] CustomizedBtnActiveBorder
        {
            get { return customizedBtnActiveBorder; }
            set { customizedBtnActiveBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the customized BTN pressed.
        /// </summary>
        /// <value>The customized BTN pressed.</value>
        public Color[] CustomizedBtnPressed
        {
            get { return customizedBtnPressed; }
            set { customizedBtnPressed = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the customized BTN pressed border.
        /// </summary>
        /// <value>The customized BTN pressed border.</value>
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

        /// <summary>
        /// Gets or sets the customized BTN offset gradient.
        /// </summary>
        /// <value>The customized BTN offset gradient.</value>
        public Color[] CustomizedBtnOffsetGradient
        {
            get { return customizedBtnOffsetGradient; }
            set { customizedBtnOffsetGradient = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the customized BTN offset border.
        /// </summary>
        /// <value>The customized BTN offset border.</value>
        public Color[] CustomizedBtnOffsetBorder
        {
            get { return customizedBtnOffsetBorder; }
            set { customizedBtnOffsetBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the customized BTN inactive border.
        /// </summary>
        /// <value>The customized BTN inactive border.</value>
        public Color CustomizedBtnInactiveBorder
        {
            get { return customizedBtnInactiveBorder; }
            set { customizedBtnInactiveBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the curve.
        /// </summary>
        /// <value>The curve.</value>
        public int Curve
        {
            get { return curve; }
            set { curve = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        /// <summary>
        /// Customizeds the button paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void CustomizedButtonPaint(PaintEventArgs e)
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

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
            GraphicsPath BaWShape = Helper.RoundRect(new Rectangle(0, 0, Width - 2, Height - 2), Curve);
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

        #region Addition

        /// <summary>
        /// The state
        /// </summary>
        MouseState State = MouseState.None;


        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {

        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected override void PaintHook(PaintEventArgs e)
        {
            CustomizedButtonPaint(e);
        }


        /// <summary>
        /// Handles the <see cref="E:MouseEnter" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseUp" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();

        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();

        }

        /// <summary>
        /// Handles the <see cref="E:MouseLeave" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;

            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:EnabledChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {

        }

        /// <summary>
        /// Paints the background of the control.
        /// </summary>
        /// <param name="pevent">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains information about the control to paint.</param>
        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
        {
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {

        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected override void OnAnimation()
        {

        }


        #endregion

    }


}
