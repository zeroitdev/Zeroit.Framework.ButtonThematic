// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="14. CustomIntel.cs" company="Zeroit Dev Technologies">
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
    /// Class IntelPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class IntelPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom intel glow
        /// </summary>
        private int customIntelGlow = 180;
        /// <summary>
        /// The custom intel background color
        /// </summary>
        private Color customIntelBackgroundColor = Color.SteelBlue;
        /// <summary>
        /// The custom intel border color
        /// </summary>
        private Color customIntelBorderColor = Color.DeepSkyBlue;
        /// <summary>
        /// The custom intel shade
        /// </summary>
        private Color customIntelShade = Color.Black;
        /// <summary>
        /// The custom intel curve
        /// </summary>
        private int customIntelCurve = 8;
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
        /// Gets or sets the custom intel glow.
        /// </summary>
        /// <value>The custom intel glow.</value>
        public int CustomIntelGlow
        {
            get { return customIntelGlow; }
            set
            {
                customIntelGlow = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom intel background.
        /// </summary>
        /// <value>The color of the custom intel background.</value>
        public Color CustomIntelBackgroundColor
        {
            get { return customIntelBackgroundColor; }
            set { customIntelBackgroundColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the custom intel border.
        /// </summary>
        /// <value>The color of the custom intel border.</value>
        public Color CustomIntelBorderColor
        {
            get { return customIntelBorderColor; }
            set { customIntelBorderColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom intel shade.
        /// </summary>
        /// <value>The custom intel shade.</value>
        public Color CustomIntelShade
        {
            get { return customIntelShade; }
            set { customIntelShade = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom intel curve.
        /// </summary>
        /// <value>The custom intel curve.</value>
        public int CustomIntelCurve
        {
            get { return customIntelCurve; }
            set
            {
                customIntelCurve = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint and Private Methods
        /// <summary>
        /// Customis the button.
        /// </summary>
        public void CustomiButton()
        {
            IsAnimated = true;

        }

        /// <summary>
        /// Customs the intel paint hook.
        /// </summary>
        private void CustomIntelPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            //G.Clear(Color.FromArgb(45, 45, 45));

            G.Clear(Parent.BackColor);

            GraphicsPath gp = CreateRound(new Rectangle(0, 0, Width - 1, Height - 1), CustomIntelCurve);
            PathGradientBrush pgb = new PathGradientBrush(gp);

            G.FillPath(new SolidBrush(customIntelShade), gp);

            pgb.CenterColor = Color.FromArgb(200, CustomIntelBackgroundColor);
            pgb.SurroundColors = new Color[] { Color.FromArgb(customIntelGlow, CustomIntelBackgroundColor) };
            pgb.CenterPoint = new Point((this.Width - 1) / 2, (this.Height - 1) / 2);

            G.FillPath(pgb, gp);
            G.DrawPath(new Pen(CustomIntelBorderColor), gp);

            int textWidth = (int)this.CreateGraphics().MeasureString(Text, Font).Width;
            int textHeight = (int)this.CreateGraphics().MeasureString(Text, Font).Height;
            SolidBrush textShadow = new SolidBrush(Color.FromArgb(30, 15, 0));
            Rectangle textRect = new Rectangle(3, 3, textWidth + 10, textHeight);
            Point textPoint = new Point((Width / 2) - (textWidth / 2), (Height / 2) - (textHeight / 2));
            Point textShadowPoint = new Point((Width / 2) - (textWidth / 2) + 1, (Height / 2) - (textHeight / 2) + 1);

            //G.DrawString(Text, Font, textShadow, textShadowPoint);
            //G.DrawString(Text, Font, Brushes.WhiteSmoke, textPoint);

        }

        /// <summary>
        /// Customs the intel on animation.
        /// </summary>
        private void CustomIntelOnAnimation()
        {
            if (State == MouseState.Over)
            {
                if (customIntelGlow < 230)
                    customIntelGlow += 1;
            }
            else
            {
                if (customIntelGlow > 182)
                {
                    customIntelGlow -= 2;
                }
                else if (customIntelGlow > 180 & customIntelGlow < 182)
                {
                    customIntelGlow = 180;
                }
            }
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
            CustomIntelPaintHook();
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
            CustomIntelOnAnimation();
        }


        #endregion

    }

}

