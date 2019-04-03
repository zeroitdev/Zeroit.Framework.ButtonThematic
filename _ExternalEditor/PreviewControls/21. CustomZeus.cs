// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="21. CustomZeus.cs" company="Zeroit Dev Technologies">
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
    /// Class ZeusPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class ZeusPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom zeus background
        /// </summary>
        Color customZeusBackground = Color.FromArgb(38, 38, 38);

        /// <summary>
        /// The custom zeus gradient colors
        /// </summary>
        private Color[] customZeusGradientColors = new Color[]
        {
            Color.AliceBlue,
            Color.FromArgb(150, 255, 255)
        };

        /// <summary>
        /// The custom zeus border colors
        /// </summary>
        private Color[] customZeusBorderColors = new Color[]
        {
            Color.Black,
            Color.AliceBlue
        };

        /// <summary>
        /// The custom zeus click reduce
        /// </summary>
        private int customZeusClickReduce = 5;

        /// <summary>
        /// The custom zeus click locate
        /// </summary>
        private int customZeusClickLocate = 2;
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
        /// Gets or sets the custom zeus background.
        /// </summary>
        /// <value>The custom zeus background.</value>
        public Color CustomZeusBackground
        {
            get { return customZeusBackground; }
            set
            {
                customZeusBackground = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom zeus gradient colors.
        /// </summary>
        /// <value>The custom zeus gradient colors.</value>
        public Color[] CustomZeusGradientColors
        {
            get { return customZeusGradientColors; }
            set
            {
                customZeusGradientColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom zeus border colors.
        /// </summary>
        /// <value>The custom zeus border colors.</value>
        public Color[] CustomZeusBorderColors
        {
            get { return customZeusBorderColors; }
            set
            {
                customZeusBorderColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom zeus click reduce.
        /// </summary>
        /// <value>The custom zeus click reduce.</value>
        public int CustomZeusClickReduce
        {
            get { return customZeusClickReduce; }
            set { customZeusClickReduce = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom zeus click locate.
        /// </summary>
        /// <value>The custom zeus click locate.</value>
        public int CustomZeusClickLocate
        {
            get { return customZeusClickLocate; }
            set { customZeusClickLocate = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        /// <summary>
        /// Customs the zeus paint hook.
        /// </summary>
        private void CustomZeusPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            switch (State)
            {

                case MouseState.None:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width, Height, 90);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
                case MouseState.Over:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width, Height, 90);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
                case MouseState.Down:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width - (CustomZeusClickLocate / 2), Height - (CustomZeusClickLocate / 2), 90);
                    G.DrawRectangle(new Pen(CustomZeusBorderColors[0]), CustomZeusClickLocate, CustomZeusClickLocate, Width - CustomZeusClickReduce, Height - CustomZeusClickReduce);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
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
            CustomZeusPaintHook();
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

