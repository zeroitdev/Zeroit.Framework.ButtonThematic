// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="07. CustomBlackShades.cs" company="Zeroit Dev Technologies">
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
    /// Class BlackShadesPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class BlackShadesPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The curve
        /// </summary>
        int curve = 3;

        /// <summary>
        /// The custom black shades none colors
        /// </summary>
        private Color[] customBlackShadesNoneColors = new Color[]
        {
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(70, Color.White),
            Color.Transparent,
            Color.FromArgb(36, 31, 43),
            Color.FromArgb(61, 65, 68),
            Color.FromArgb(99, 103, 105),
            Color.FromArgb(27, 31, 33)
        };

        /// <summary>
        /// The custom black shades over colors
        /// </summary>
        private Color[] customBlackShadesOverColors = new Color[]
        {
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(70, Color.White),
            Color.Transparent,
            Color.FromArgb(36, 31, 43),
            Color.FromArgb(61, 65, 68),
            Color.FromArgb(99, 103, 105),
            Color.FromArgb(100, 99, 103, 105),
            Color.FromArgb(27, 31, 33),
            Color.FromArgb(0, 186, 255)
        };

        /// <summary>
        /// The custom black shades down colors
        /// </summary>
        private Color[] customBlackShadesDownColors = new Color[]
        {
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(57, 57, 57),
            Color.FromArgb(57, 57, 57),
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(57, 57, 57),
            Color.FromArgb(36, 31, 43),
            Color.FromArgb(61, 65, 68),
            Color.FromArgb(27, 31, 33)

        };
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
        /// Gets or sets the custom black shades none colors.
        /// </summary>
        /// <value>The custom black shades none colors.</value>
        public Color[] CustomBlackShadesNoneColors
        {
            get { return customBlackShadesNoneColors; }
            set
            {
                customBlackShadesNoneColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom black shades over colors.
        /// </summary>
        /// <value>The custom black shades over colors.</value>
        public Color[] CustomBlackShadesOverColors
        {
            get { return customBlackShadesOverColors; }
            set { customBlackShadesOverColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom black shades down colors.
        /// </summary>
        /// <value>The custom black shades down colors.</value>
        public Color[] CustomBlackShadesDownColors
        {
            get { return customBlackShadesDownColors; }
            set { customBlackShadesDownColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the curve.
        /// </summary>
        /// <value>The curve.</value>
        public int Curve
        {
            get { return curve; }
            set
            {
                curve = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        /// <summary>
        /// Customs the black shades paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void CustomBlackShadesPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            dynamic ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            G.Clear(Parent.BackColor);
            //Dim bg As Color = Parent.FindForm.BackColor

            //G.Clear(Color.FromArgb(42, 47, 49));

            switch (State)
            {
                case MouseState.None:
                    //Mouse None
                    G.FillPath(new SolidBrush(CustomBlackShadesNoneColors[0]), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    LinearGradientBrush gloss = new LinearGradientBrush(new Rectangle(1, 1, Width - 5, Height / 2 - 3), CustomBlackShadesNoneColors[1], CustomBlackShadesNoneColors[2], 90);
                    G.FillPath(gloss, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 - 3), Curve));
                    LinearGradientBrush borderRect = new LinearGradientBrush(ClientRectangle, CustomBlackShadesNoneColors[3], CustomBlackShadesNoneColors[4], 90);
                    G.DrawPath(new Pen(CustomBlackShadesNoneColors[5]), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 3), Curve));
                    G.DrawPath(new Pen(borderRect), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesNoneColors[6]), Draw.RoundRect(new Rectangle(1, 0, Width - 3, Height - 3), Curve));
                    break;
                case MouseState.Over:
                    //Mouse Hover
                    G.FillPath(new SolidBrush(CustomBlackShadesOverColors[0]), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    LinearGradientBrush gloss1 = new LinearGradientBrush(new Rectangle(1, 1, Width - 5, Height / 2 - 3), CustomBlackShadesOverColors[1], CustomBlackShadesOverColors[2], 90);
                    G.FillPath(gloss1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 - 3), Curve));
                    LinearGradientBrush borderRect1 = new LinearGradientBrush(ClientRectangle, CustomBlackShadesOverColors[3], CustomBlackShadesOverColors[4], 90);
                    G.DrawPath(new Pen(CustomBlackShadesOverColors[5]), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 3), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesOverColors[6]), Draw.RoundRect(new Rectangle(2, 2, Width - 5, Height - 6), Curve));
                    G.DrawPath(new Pen(borderRect1), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesOverColors[7]), Draw.RoundRect(new Rectangle(1, 0, Width - 3, Height - 3), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesOverColors[8]), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 4), Curve));
                    break;
                case MouseState.Down:
                    //Mouse Down
                    G.FillPath(new SolidBrush(CustomBlackShadesDownColors[0]), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    LinearGradientBrush topGrad = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2 - 1), CustomBlackShadesDownColors[1], CustomBlackShadesDownColors[2], 90);
                    G.FillPath(topGrad, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 + 1), Curve));
                    LinearGradientBrush botGrad = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2 - 1), CustomBlackShadesDownColors[3], CustomBlackShadesDownColors[4], 90);
                    G.FillPath(botGrad, Draw.RoundRect(new Rectangle(0, Height / 2 - 1, Width - 1, Height / 2 + 2), Curve));
                    G.DrawLine(new Pen(CustomBlackShadesDownColors[5]), 0, Convert.ToInt32(Height / 2 - 1), Width - 1, Convert.ToInt32(Height / 2 - 1));

                    LinearGradientBrush borderRect2 = new LinearGradientBrush(ClientRectangle, CustomBlackShadesDownColors[6], CustomBlackShadesDownColors[7], 90);
                    G.DrawPath(new Pen(borderRect2), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesDownColors[8]), Draw.RoundRect(new Rectangle(1, 0, Width - 3, Height - 3), Curve));

                    break;
            }

            //G.DrawRectangle(Pens.Black, ClientRectangle)

            //G.DrawString(Text, Font, Brushes.Black, New Rectangle(-1, -2, Width - 1, Height - 1), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
            //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(-1, -1, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = StringAlignment.Center
            //});

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);

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
            CustomBlackShadesPaint(e);
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
