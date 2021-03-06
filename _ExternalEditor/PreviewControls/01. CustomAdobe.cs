﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="01. CustomAdobe.cs" company="Zeroit Dev Technologies">
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
    /// Class AdobePreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class AdobePreview : ThemeControl
    {

        #region Private Fields

        /// <summary>
        /// The customizable adobe background
        /// </summary>
        private Color customizableAdobeBackground = Color.FromArgb(102, 102, 102);

        /// <summary>
        /// The customizable adobe coefficient
        /// </summary>
        int customizableAdobeCoefficient = 15;

        /// <summary>
        /// The customizable adobe border offset
        /// </summary>
        private int customizableAdobeBorderOffset = 2;

        /// <summary>
        /// The customizable adobe colors
        /// </summary>
        private Color[] customizableAdobeColors = new Color[]
        {
            Color.FromArgb(105, 105, 105),
            Color.FromArgb(56, 56, 56),
            Color.FromArgb(73, 73, 73),
            Color.FromArgb(48, 48, 48),
            Color.White,
            Color.Black
        };

        #endregion

        #region Properties


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
        /// Gets or sets the customizable adobe colors.
        /// </summary>
        /// <value>The customizable adobe colors.</value>
        public Color[] CustomizableAdobeColors
        {
            get { return customizableAdobeColors; }
            set
            {
                customizableAdobeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the customizable adobe background.
        /// </summary>
        /// <value>The customizable adobe background.</value>
        public Color CustomizableAdobeBackground
        {
            get { return customizableAdobeBackground; }
            set { customizableAdobeBackground = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the customizable adobe coefficient.
        /// </summary>
        /// <value>The customizable adobe coefficient.</value>
        public int CustomizableAdobeCoefficient
        {
            get { return customizableAdobeCoefficient; }
            set
            {
                customizableAdobeCoefficient = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the customizable adobe border offset.
        /// </summary>
        /// <value>The customizable adobe border offset.</value>
        public int CustomizableAdobeBorderOffset
        {
            get { return customizableAdobeBorderOffset; }
            set
            {
                customizableAdobeBorderOffset = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        /// <summary>
        /// Customizables the adobe paint hook.
        /// </summary>
        private void CustomizableAdobePaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            G.Clear(CustomizableAdobeBackground);

            DrawGradient(CustomizableAdobeColors[0], CustomizableAdobeColors[1], 0, 0, Width, Height, 90);
            DrawGradient(CustomizableAdobeColors[2], CustomizableAdobeColors[3], 1, 1, Width - 2, Height - 2, 90);

            switch (State)
            {
                case MouseState.None:
                    break;
                //NULL
                case MouseState.Over:

                    CustomizableAdobeCoefficient = 5;
                    break;
                case MouseState.Down:

                    CustomizableAdobeCoefficient = 10;
                    break;
            }

            for (int i = 1; i <= 5; i++)
            {
                G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(Convert.ToInt32(255 / (i * CustomizableAdobeCoefficient)), CustomizableAdobeColors[4]))), new Rectangle(i, i, Width - 2 - (i * 2), Height - 2 - (i * 2)));
            }

            DrawBorders(new Pen(CustomizableAdobeColors[5]), CustomizableAdobeBorderOffset);


        }


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
            CustomizableAdobePaintHook();
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

        #endregion

    }
}
