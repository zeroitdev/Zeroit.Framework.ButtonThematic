// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="12. CustomFuture.cs" company="Zeroit Dev Technologies">
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
    /// Class FuturePreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class FuturePreview : ThemeControl
    {


        #region Private Fields
        /// <summary>
        /// The custom fusion blend
        /// </summary>
        private ColorBlend customFusionBlend = new ColorBlend
        {
            Colors = new Color[]
            {
                Color.FromArgb(28, 28, 28),
                Color.FromArgb(32, 32, 32),
                Color.FromArgb(24, 24, 24),
            },
            Positions = new float[] {
                0f,
                0.5f,
                1f
            }
        };

        /// <summary>
        /// The custom fusion grad colors
        /// </summary>
        private Color[] customFusionGradColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(48, 48, 48)
        };

        /// <summary>
        /// The custom fusion corner color
        /// </summary>
        private Color customFusionCornerColor = Color.FromArgb(40, 40, 40);

        /// <summary>
        /// The custom fusion none border color
        /// </summary>
        private Color customFusionNoneBorderColor = Color.Black;
        /// <summary>
        /// The custom fusion down border color
        /// </summary>
        private Color customFusionDownBorderColor = Color.FromArgb(24, 24, 24);
        /// <summary>
        /// The custom fusion over border color
        /// </summary>
        private Color customFusionOverBorderColor = Color.FromArgb(44, 44, 44);
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
        /// Gets or sets the custom fusion blend.
        /// </summary>
        /// <value>The custom fusion blend.</value>
        public ColorBlend CustomFusionBlend
        {
            get { return customFusionBlend; }
            set
            {
                customFusionBlend = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom fusion grad colors.
        /// </summary>
        /// <value>The custom fusion grad colors.</value>
        public Color[] CustomFusionGradColors
        {
            get { return customFusionGradColors; }
            set
            {
                customFusionGradColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom fusion corner.
        /// </summary>
        /// <value>The color of the custom fusion corner.</value>
        public Color CustomFusionCornerColor
        {
            get { return customFusionCornerColor; }
            set { customFusionCornerColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the custom fusion none border.
        /// </summary>
        /// <value>The color of the custom fusion none border.</value>
        public Color CustomFusionNoneBorderColor
        {
            get { return customFusionNoneBorderColor; }
            set { customFusionNoneBorderColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the custom fusion down border.
        /// </summary>
        /// <value>The color of the custom fusion down border.</value>
        public Color CustomFusionDownBorderColor
        {
            get { return customFusionDownBorderColor; }
            set { customFusionDownBorderColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the custom fusion over border.
        /// </summary>
        /// <value>The color of the custom fusion over border.</value>
        public Color CustomFusionOverBorderColor
        {
            get { return customFusionOverBorderColor; }
            set { customFusionOverBorderColor = value; Invalidate(); }
        }
        #endregion

        #region Paint
        /// <summary>
        /// Customs the future paint hook.
        /// </summary>
        private void CustomFuturePaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            DrawGradient(CustomFusionBlend, ClientRectangle, 90f);

            LinearGradientBrush GB1 = new LinearGradientBrush(ClientRectangle, CustomFusionGradColors[0], CustomFusionGradColors[1], 90f);
            Pen P1 = new Pen(GB1);

            DrawBorders(new Pen(CustomFusionNoneBorderColor), 1);
            DrawBorders(P1);

            if (State == MouseState.Down)
            {
                DrawBorders(new Pen(CustomFusionDownBorderColor), 2);

            }
            else
            {
                G.DrawLine(new Pen(CustomFusionOverBorderColor), 2, 2, Width - 3, 2);

            }

            DrawCorners(CustomFusionCornerColor, 1, 1, Width - 2, Height - 2);
            DrawCorners(Parent.BackColor);
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
            CustomFuturePaintHook();
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

