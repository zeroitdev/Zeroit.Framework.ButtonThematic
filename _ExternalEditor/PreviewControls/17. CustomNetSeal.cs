// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="17. CustomNetSeal.cs" company="Zeroit Dev Technologies">
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
    /// Class NetSealPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class NetSealPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom net seal path borders
        /// </summary>
        private Color[] customNetSealPathBorders = new Color[]
        {
            Color.FromArgb(24, 24, 24),
            Color.FromArgb(65, 65, 65)
        };

        /// <summary>
        /// The custom net seal center color
        /// </summary>
        private Color customNetSealCenterColor = Color.FromArgb(60, 60, 60);

        /// <summary>
        /// The custom net seal surround color
        /// </summary>
        private Color customNetSealSurroundColor = Color.FromArgb(55, 55, 55);

        /// <summary>
        /// The custom focus scales
        /// </summary>
        private PointF customFocusScales = new PointF(0.8f, 0.5f);

        /// <summary>
        /// The curve
        /// </summary>
        private int curve = 50;

        /// <summary>
        /// The gradient angle
        /// </summary>
        private LinearGradientMode gradientAngle = LinearGradientMode.Vertical;
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
        /// Gets or sets the custom net seal path borders.
        /// </summary>
        /// <value>The custom net seal path borders.</value>
        public Color[] CustomNetSealPathBorders
        {
            get { return customNetSealPathBorders; }
            set
            {
                customNetSealPathBorders = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom net seal center.
        /// </summary>
        /// <value>The color of the custom net seal center.</value>
        public Color CustomNetSealCenterColor
        {
            get { return customNetSealCenterColor; }
            set
            {
                customNetSealCenterColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom net seal surround.
        /// </summary>
        /// <value>The color of the custom net seal surround.</value>
        public Color CustomNetSealSurroundColor
        {
            get { return customNetSealSurroundColor; }
            set { customNetSealSurroundColor = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom focus scales.
        /// </summary>
        /// <value>The custom focus scales.</value>
        public PointF CustomFocusScales
        {
            get { return customFocusScales; }
            set { customFocusScales = value; Invalidate(); }
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

        /// <summary>
        /// Gets or sets the gradient angle.
        /// </summary>
        /// <value>The gradient angle.</value>
        public LinearGradientMode GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint
        /// <summary>
        /// Customs the net seal paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void CustomNetSealPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            G.Clear(Parent.BackColor);
            GraphicsPath GP1 = Draw.CreateRound(0, 0, Width - 1, Height - 1, Curve);
            GraphicsPath GP2 = Draw.CreateRound(1, 1, Width - 3, Height - 3, Curve);

            if (State == MouseState.Down)
            {
                PathGradientBrush PB1 = new PathGradientBrush(GP1);
                PB1.CenterColor = CustomNetSealCenterColor;
                PB1.SurroundColors = new Color[] { CustomNetSealSurroundColor };
                PB1.FocusScales = CustomFocusScales;

                G.FillPath(PB1, GP1);
            }
            else
            {
                LinearGradientBrush GB1 = new LinearGradientBrush(ClientRectangle, CustomNetSealCenterColor, CustomNetSealSurroundColor, GradientAngle);
                G.FillPath(GB1, GP1);
            }

            G.DrawPath(new Pen(CustomNetSealPathBorders[0]), GP1);
            G.DrawPath(new Pen(CustomNetSealPathBorders[1]), GP2);

            SizeF SZ1 = G.MeasureString(Text, Font);
            PointF PT1 = new PointF(5, Height / 2 - SZ1.Height / 2);

            if (State == MouseState.Down)
            {
                PT1.X += 1f;
                PT1.Y += 1f;
            }

            //G.DrawString(Text, Font, Brushes.Black, PT1.X + 1, PT1.Y + 1);
            //G.DrawString(Text, Font, Brushes.WhiteSmoke, PT1);
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
            CustomNetSealPaint(e);
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

