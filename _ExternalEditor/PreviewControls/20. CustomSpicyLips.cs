// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="20. CustomSpicyLips.cs" company="Zeroit Dev Technologies">
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
    /// Class SpicyLipsPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class SpicyLipsPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom spicy background
        /// </summary>
        private Color customSpicyBackground = Color.FromArgb(1, 1, 1);

        /// <summary>
        /// The custom spicy none state colors
        /// </summary>
        private Color[] customSpicyNoneStateColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(28, 28, 28)
        };

        /// <summary>
        /// The custom spicy over state colors
        /// </summary>
        private Color[] customSpicyOverStateColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(28, 28, 28)
        };

        /// <summary>
        /// The custom spicy down state colors
        /// </summary>
        private Color[] customSpicyDownStateColors = new Color[]
        {
            Color.FromArgb(4, 4, 4),
            Color.FromArgb(20, 20, 20)
        };

        /// <summary>
        /// The custom spicy highlight
        /// </summary>
        private Color customSpicyHighlight = Color.White;

        /// <summary>
        /// The custom spicy border colors
        /// </summary>
        private Color[] customSpicyBorderColors = new Color[]
        {
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The custom spicy corner color
        /// </summary>
        private Color customSpicyCornerColor = Color.FromArgb(20, 20, 20);
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
        /// Gets or sets the custom spicy background.
        /// </summary>
        /// <value>The custom spicy background.</value>
        public Color CustomSpicyBackground
        {
            get { return customSpicyBackground; }
            set
            {
                customSpicyBackground = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom spicy none state colors.
        /// </summary>
        /// <value>The custom spicy none state colors.</value>
        public Color[] CustomSpicyNoneStateColors
        {
            get { return customSpicyNoneStateColors; }
            set { customSpicyNoneStateColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom spicy over state colors.
        /// </summary>
        /// <value>The custom spicy over state colors.</value>
        public Color[] CustomSpicyOverStateColors
        {
            get { return customSpicyOverStateColors; }
            set { customSpicyOverStateColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom spicy down state colors.
        /// </summary>
        /// <value>The custom spicy down state colors.</value>
        public Color[] CustomSpicyDownStateColors
        {
            get { return customSpicyDownStateColors; }
            set { customSpicyDownStateColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom spicy highlight.
        /// </summary>
        /// <value>The custom spicy highlight.</value>
        public Color CustomSpicyHighlight
        {
            get { return customSpicyHighlight; }
            set { customSpicyHighlight = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom spicy border colors.
        /// </summary>
        /// <value>The custom spicy border colors.</value>
        public Color[] CustomSpicyBorderColors
        {
            get { return customSpicyBorderColors; }
            set { customSpicyBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the custom spicy corner.
        /// </summary>
        /// <value>The color of the custom spicy corner.</value>
        public Color CustomSpicyCornerColor
        {
            get { return customSpicyCornerColor; }
            set
            {
                customSpicyCornerColor = value;
                Invalidate();
            }
        }


        #endregion

        #region Paint
        /// <summary>
        /// Customs the spicy lips paint hook.
        /// </summary>
        private void CustomSpicyLipsPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            G.Clear(CustomSpicyBackground);
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(CustomSpicyNoneStateColors[0], CustomSpicyNoneStateColors[1], 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(CustomSpicyOverStateColors[0], CustomSpicyOverStateColors[1], 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(CustomSpicyDownStateColors[0], CustomSpicyDownStateColors[1], 0, 0, Width, Height, 90);
                    break;
            }

            G.FillRectangle(new SolidBrush(Color.FromArgb(6, CustomSpicyHighlight)), 0, 0, Width, 12);

            DrawBorders(new Pen(CustomSpicyBorderColors[0]));
            DrawBorders(new Pen(CustomSpicyBorderColors[1]), 2);
            DrawCorners(CustomSpicyCornerColor, ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

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
            CustomSpicyLipsPaintHook();
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

