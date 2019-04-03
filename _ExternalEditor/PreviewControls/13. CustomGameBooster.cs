// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="13. CustomGameBooster.cs" company="Zeroit Dev Technologies">
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
    /// Class GameBoosterPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class GameBoosterPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom game booster top gradient
        /// </summary>
        private Color customGameBoosterTopGradient = Color.FromArgb(55, 55, 55);
        /// <summary>
        /// The custom game booster bot gradient
        /// </summary>
        private Color customGameBoosterBotGradient = Color.FromArgb(32, 32, 32);
        /// <summary>
        /// The custom game booster top gradient click
        /// </summary>
        private Color customGameBoosterTopGradientClick = Color.FromArgb(60, 60, 60);
        /// <summary>
        /// The custom game booster bot gradient click
        /// </summary>
        private Color customGameBoosterBotGradientClick = Color.FromArgb(37, 37, 37);
        /// <summary>
        /// The custom game booster top gradient hover
        /// </summary>
        private Color customGameBoosterTopGradientHover = Color.FromArgb(66, 66, 66);
        /// <summary>
        /// The custom game booster bot gradient hover
        /// </summary>
        private Color customGameBoosterBotGradientHover = Color.FromArgb(41, 41, 41);
        /// <summary>
        /// The custom game booster corner color
        /// </summary>
        private Color customGameBoosterCornerColor = Color.FromArgb(51, 51, 51);
        /// <summary>
        /// The custom game booster inner border
        /// </summary>
        private Color customGameBoosterInnerBorder = Color.FromArgb(76, 76, 76);
        /// <summary>
        /// The custom game booster outer border
        /// </summary>
        private Color customGameBoosterOuterBorder = Color.Black;
        /// <summary>
        /// The custom game booster inner border hover
        /// </summary>
        private Color customGameBoosterInnerBorderHover = Color.FromArgb(87, 87, 87);
        /// <summary>
        /// The custom game booster outer border hover
        /// </summary>
        private Color customGameBoosterOuterBorderHover = Color.Black;
        /// <summary>
        /// The custom game booster inner border click
        /// </summary>
        private Color customGameBoosterInnerBorderClick = Color.FromArgb(71, 71, 71);
        /// <summary>
        /// The custom game booster outer border click
        /// </summary>
        private Color customGameBoosterOuterBorderClick = Color.Black;

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
        /// Gets or sets the custom game booster top gradient.
        /// </summary>
        /// <value>The custom game booster top gradient.</value>
        public Color CustomGameBoosterTopGradient
        {
            get { return customGameBoosterTopGradient; }
            set
            {
                customGameBoosterTopGradient = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom game booster bot gradient.
        /// </summary>
        /// <value>The custom game booster bot gradient.</value>
        public Color CustomGameBoosterBotGradient
        {
            get { return customGameBoosterBotGradient; }
            set { customGameBoosterBotGradient = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster top gradient click.
        /// </summary>
        /// <value>The custom game booster top gradient click.</value>
        public Color CustomGameBoosterTopGradientClick
        {
            get { return customGameBoosterTopGradientClick; }
            set { customGameBoosterTopGradientClick = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster bot gradient click.
        /// </summary>
        /// <value>The custom game booster bot gradient click.</value>
        public Color CustomGameBoosterBotGradientClick
        {
            get { return customGameBoosterBotGradientClick; }
            set { customGameBoosterBotGradientClick = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster top gradient hover.
        /// </summary>
        /// <value>The custom game booster top gradient hover.</value>
        public Color CustomGameBoosterTopGradientHover
        {
            get { return customGameBoosterTopGradientHover; }
            set { customGameBoosterTopGradientHover = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster bot gradient hover.
        /// </summary>
        /// <value>The custom game booster bot gradient hover.</value>
        public Color CustomGameBoosterBotGradientHover
        {
            get { return customGameBoosterBotGradientHover; }
            set { customGameBoosterBotGradientHover = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the custom game booster corner.
        /// </summary>
        /// <value>The color of the custom game booster corner.</value>
        public Color CustomGameBoosterCornerColor
        {
            get { return customGameBoosterCornerColor; }
            set { customGameBoosterCornerColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster inner border.
        /// </summary>
        /// <value>The custom game booster inner border.</value>
        public Color CustomGameBoosterInnerBorder
        {
            get { return customGameBoosterInnerBorder; }
            set { customGameBoosterInnerBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster outer border.
        /// </summary>
        /// <value>The custom game booster outer border.</value>
        public Color CustomGameBoosterOuterBorder
        {
            get { return customGameBoosterOuterBorder; }
            set { customGameBoosterOuterBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster inner border hover.
        /// </summary>
        /// <value>The custom game booster inner border hover.</value>
        public Color CustomGameBoosterInnerBorderHover
        {
            get { return customGameBoosterInnerBorderHover; }
            set { customGameBoosterInnerBorderHover = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster outer border hover.
        /// </summary>
        /// <value>The custom game booster outer border hover.</value>
        public Color CustomGameBoosterOuterBorderHover
        {
            get { return customGameBoosterOuterBorderHover; }
            set { customGameBoosterOuterBorderHover = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster inner border click.
        /// </summary>
        /// <value>The custom game booster inner border click.</value>
        public Color CustomGameBoosterInnerBorderClick
        {
            get { return customGameBoosterInnerBorderClick; }
            set { customGameBoosterInnerBorderClick = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom game booster outer border click.
        /// </summary>
        /// <value>The custom game booster outer border click.</value>
        public Color CustomGameBoosterOuterBorderClick
        {
            get { return customGameBoosterOuterBorderClick; }
            set { customGameBoosterOuterBorderClick = value; Invalidate(); }
        }
        #endregion

        #region Paint
        /// <summary>
        /// Customs the game booster paint hook.
        /// </summary>
        private void CustomGameBoosterPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            if (State == MouseState.Down)
            {
                DrawGradient(CustomGameBoosterTopGradientClick, CustomGameBoosterBotGradientClick, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(CustomGameBoosterInnerBorderClick), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(CustomGameBoosterOuterBorderClick, 1, 1);
                DrawPixel(CustomGameBoosterInnerBorderClick, 2, 2);
                //TOPRIGHT
                DrawPixel(CustomGameBoosterOuterBorderClick, Width - 2, 1);
                DrawPixel(CustomGameBoosterInnerBorderClick, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(CustomGameBoosterOuterBorderClick, 1, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorderClick, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(CustomGameBoosterOuterBorderClick, Width - 2, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorderClick, Width - 3, Height - 3);
                DrawBorders(new Pen(CustomGameBoosterOuterBorderClick));
            }
            else
            {
                DrawGradient(CustomGameBoosterTopGradient, CustomGameBoosterBotGradient, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(CustomGameBoosterInnerBorder), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(CustomGameBoosterOuterBorder, 1, 1);
                DrawPixel(CustomGameBoosterInnerBorder, 2, 2);
                //TOPRIGHT
                DrawPixel(CustomGameBoosterOuterBorder, Width - 2, 1);
                DrawPixel(CustomGameBoosterInnerBorder, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(CustomGameBoosterOuterBorder, 1, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorder, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(CustomGameBoosterOuterBorder, Width - 2, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorder, Width - 3, Height - 3);
                DrawBorders(new Pen(CustomGameBoosterOuterBorder));
            }

            if (State == MouseState.Over)
            {
                DrawGradient(CustomGameBoosterTopGradientHover, CustomGameBoosterBotGradientHover, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(CustomGameBoosterInnerBorderHover), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(CustomGameBoosterOuterBorderHover, 1, 1);
                DrawPixel(CustomGameBoosterInnerBorderHover, 2, 2);
                //TOPRIGHT
                DrawPixel(CustomGameBoosterOuterBorderHover, Width - 2, 1);
                DrawPixel(CustomGameBoosterInnerBorderHover, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(CustomGameBoosterOuterBorderHover, 1, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorderHover, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(CustomGameBoosterOuterBorderHover, Width - 2, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorderHover, Width - 3, Height - 3);
                DrawBorders(new Pen(CustomGameBoosterOuterBorderHover));
            }

            //DrawText(CustomGameBoosterTextCol, HorizontalAlignment.Center, 0, 0);

            DrawCorners(CustomGameBoosterCornerColor);
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
            CustomGameBoosterPaintHook();
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

