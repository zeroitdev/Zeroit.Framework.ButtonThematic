// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="06. CustomBitDefender.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class BitDefenderPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class BitDefenderPreview : ThemeControl
    {

        #region Private Fields

        /// <summary>
        /// The custom bit defender c1
        /// </summary>
        private Color customBitDefenderC1 = Color.FromArgb(100, 41, 41, 41);
        /// <summary>
        /// The custom bit defender c2
        /// </summary>
        private Color customBitDefenderC2 = Color.White;
        /// <summary>
        /// The custom bit defender c3
        /// </summary>
        private Color customBitDefenderC3 = Color.FromArgb(101, 101, 101);
        /// <summary>
        /// The custom bit defender c4
        /// </summary>
        private Color customBitDefenderC4 = Color.FromArgb(60, 60, 60);
        /// <summary>
        /// The custom bit defender c5
        /// </summary>
        private Color customBitDefenderC5 = Color.FromArgb(28, 28, 28);
        /// <summary>
        /// The custom bit defender c6
        /// </summary>
        private Color customBitDefenderC6 = Color.FromArgb(45, 45, 45);
        /// <summary>
        /// The custom bit defender border
        /// </summary>
        private Color customBitDefenderBorder = Color.Black;


        /// <summary>
        /// The curve
        /// </summary>
        private int curve = 11;
        /// <summary>
        /// The custom bit defender fade color
        /// </summary>
        private Color customBitDefenderFadeColor = Color.White;


        //private Thread customOpenT;


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

        /// <summary>
        /// Gets or sets the custom bit defender c1.
        /// </summary>
        /// <value>The custom bit defender c1.</value>
        public Color CustomBitDefenderC1
        {
            get { return customBitDefenderC1; }
            set { customBitDefenderC1 = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c2.
        /// </summary>
        /// <value>The custom bit defender c2.</value>
        public Color CustomBitDefenderC2
        {
            get { return customBitDefenderC2; }
            set { customBitDefenderC2 = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c3.
        /// </summary>
        /// <value>The custom bit defender c3.</value>
        public Color CustomBitDefenderC3
        {
            get { return customBitDefenderC3; }
            set { customBitDefenderC3 = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c4.
        /// </summary>
        /// <value>The custom bit defender c4.</value>
        public Color CustomBitDefenderC4
        {
            get { return customBitDefenderC4; }
            set { customBitDefenderC4 = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c5.
        /// </summary>
        /// <value>The custom bit defender c5.</value>
        public Color CustomBitDefenderC5
        {
            get { return customBitDefenderC5; }
            set { customBitDefenderC5 = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c6.
        /// </summary>
        /// <value>The custom bit defender c6.</value>
        public Color CustomBitDefenderC6
        {
            get { return customBitDefenderC6; }
            set { customBitDefenderC6 = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom bit defender border.
        /// </summary>
        /// <value>The custom bit defender border.</value>
        public Color CustomBitDefenderBorder
        {
            get { return customBitDefenderBorder; }
            set { customBitDefenderBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the color of the custom bit defender fade.
        /// </summary>
        /// <value>The color of the custom bit defender fade.</value>
        public Color CustomBitDefenderFadeColor
        {
            get { return customBitDefenderFadeColor; }
            set
            {
                customBitDefenderFadeColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Mouse Events and Animation

        /// <summary>
        /// Customs the enter animation.
        /// </summary>
        private void CustomEnterAnimation()
        {
            Graphics G = this.CreateGraphics();
            Rectangle customBitDefenderR2 = new Rectangle(5, 5, Width - 10, Height - 10);
            GraphicsPath customBitDefenderGP2 = Helper.RoundRect(customBitDefenderR2, Curve);
            G.SetClip(customBitDefenderGP2);
            for (int fade = 0; fade <= 5; fade += Convert.ToInt32(0.85f))
            {
                Thread.Sleep(10);
                G.FillRectangle(new SolidBrush(Color.FromArgb(fade, CustomBitDefenderFadeColor)), ClientRectangle);
            }
        }

        #endregion

        #region Paint

        /// <summary>
        /// The custom bit defender lg b1
        /// </summary>
        private LinearGradientBrush customBitDefenderLGB1;


        /// <summary>
        /// Customs the bit defender paint.
        /// </summary>
        private void CustomBitDefenderPaint()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            Rectangle customBitDefenderR1 = new Rectangle(3, 3, Width - 6, Height - 6);
            Rectangle customBitDefenderR2 = new Rectangle(5, 5, Width - 10, Height - 10);
            Rectangle customBitDefenderR3 = new Rectangle(6, 6, Width - 12, Height - 12);
            GraphicsPath customBitDefenderGP1 = Helper.RoundRect(customBitDefenderR1, Curve);
            GraphicsPath customBitDefenderGP2 = Helper.RoundRect(customBitDefenderR2, Curve);
            GraphicsPath customBitDefenderGP3 = Helper.RoundRect(customBitDefenderR3, Curve);
            SolidBrush customBitDefenderB1 = new SolidBrush(customBitDefenderC1);
            SolidBrush customBitDefenderB2 = new SolidBrush(customBitDefenderC2);
            customBitDefenderLGB1 = new LinearGradientBrush(customBitDefenderR2, customBitDefenderC4, customBitDefenderC5, LinearGradientMode.Vertical);
            LinearGradientBrush customBitDefenderLGB2 = new LinearGradientBrush(customBitDefenderR3, customBitDefenderC3, customBitDefenderC6, LinearGradientMode.Vertical);
            Pen customBitDefenderP1 = new Pen(customBitDefenderBorder);
            Pen customBitDefenderP2 = new Pen(customBitDefenderLGB2);

            G.Clear(Parent.BackColor);
            
            G.FillPath(customBitDefenderB1, customBitDefenderGP1);
            G.FillPath(customBitDefenderLGB1, customBitDefenderGP2);
            G.DrawPath(customBitDefenderP1, customBitDefenderGP2);
            G.DrawPath(customBitDefenderP2, customBitDefenderGP3);

            if (State !=MouseState.Down)
            {
                //G.DrawString(Text, Font, customBitDefenderB2, customBitDefenderR3, BitDefenderSF1);
            }
            else
            {
                customBitDefenderR3.X += 1;
                customBitDefenderR3.Y += 1;
                //G.DrawString(Text, Font, customBitDefenderB2, customBitDefenderR3, BitDefenderSF1);
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
            CustomBitDefenderPaint();
        }


        /// <summary>
        /// Handles the <see cref="E:MouseEnter" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;

            Thread customOpenT = new Thread(CustomEnterAnimation);
            if (!customOpenT.IsAlive)
            {
                customOpenT.IsBackground = true;
                customOpenT.Start();
            }

        }

        /// <summary>
        /// Handles the <see cref="E:MouseUp" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            
        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            
        }

        /// <summary>
        /// Handles the <see cref="E:MouseLeave" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            
        }
                

        #endregion
    }

}
