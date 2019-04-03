// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="22. CustomRoaster.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
    /// Class RoasterPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class RoasterPreview : ThemeControl
    {
        #region Private Fields
        /// <summary>
        /// The custom roaster gradient colors
        /// </summary>
        private Color[] customRoasterGradientColors = new Color[]
        {
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(95, 0, 0),
            Color.FromArgb(73, 73, 73),
            Color.FromArgb(93, 93, 93)
        };

        /// <summary>
        /// The custom roaster border color
        /// </summary>
        private Color customRoasterBorderColor = Color.Black;

        /// <summary>
        /// The custom roaster background state colors
        /// </summary>
        private Color[] customRoasterBackgroundStateColors = new Color[]
        {
            Color.White,
            Color.Black
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
        /// Gets or sets the custom roaster gradient colors.
        /// </summary>
        /// <value>The custom roaster gradient colors.</value>
        public Color[] CustomRoasterGradientColors
        {
            get { return customRoasterGradientColors; }
            set
            {
                customRoasterGradientColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom roaster border.
        /// </summary>
        /// <value>The color of the custom roaster border.</value>
        public Color CustomRoasterBorderColor
        {
            get { return customRoasterBorderColor; }
            set
            {
                customRoasterBorderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom roaster background state colors.
        /// </summary>
        /// <value>The custom roaster background state colors.</value>
        public Color[] CustomRoasterBackgroundStateColors
        {
            get { return customRoasterBackgroundStateColors; }
            set
            {
                customRoasterBackgroundStateColors = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        /// <summary>
        /// Customs the roaster paint hook.
        /// </summary>
        private void CustomRoasterPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            G.Clear(Parent.BackColor);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
            DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
            DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);

            DrawBorders(new Pen(CustomRoasterBorderColor), 0);
            DrawBorders(new Pen(CustomRoasterBorderColor), 1);
            DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
            G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
            G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);

            if (State == MouseState.Over)
            {
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);
                G.FillRectangle(new SolidBrush(Color.FromArgb(13, CustomRoasterBackgroundStateColors[0])), 0, 0, Width, (Height / 2) - 7);
                DrawBorders(new Pen(CustomRoasterBorderColor), 0);
                DrawBorders(new Pen(CustomRoasterBorderColor), 1);
                DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);
                G.FillRectangle(new SolidBrush(Color.FromArgb(20, CustomRoasterBackgroundStateColors[1])), 0, 0, Width, (Height / 2) - 7);
                DrawBorders(new Pen(CustomRoasterBorderColor), 0);
                DrawBorders(new Pen(CustomRoasterBorderColor), 1);
                DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);
            }
            else
            {
            }

            DrawCorners(BackColor);
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
            CustomRoasterPaintHook();
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
