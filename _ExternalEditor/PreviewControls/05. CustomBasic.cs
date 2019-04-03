// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="05. CustomBasic.cs" company="Zeroit Dev Technologies">
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
    /// Class BasicPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class BasicPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom basic colors
        /// </summary>
        private Color[] customBasicColors = new Color[]
        {
            Color.FromArgb(255, 55, 55, 55),
            Color.FromArgb(255, 22, 22, 22),
            Color.FromArgb(255, 100, 0, 0),
            Color.FromArgb(255, 60, 0, 0)
        };

        /// <summary>
        /// The custom basic state colors
        /// </summary>
        private Color[] customBasicStateColors = new Color[]
        {
            Color.FromArgb(255, 60, 0, 0),
            Color.FromArgb(255, 100, 0, 0)
        };

        /// <summary>
        /// The custom basic highlights
        /// </summary>
        private Color[] customBasicHighlights = new Color[]
        {
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255)
        };

        /// <summary>
        /// The custom basic border colors
        /// </summary>
        private Color[] customBasicBorderColors = new Color[]
        {
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The custom basic disabled
        /// </summary>
        private Color[] customBasicDisabled = new Color[]
        {
            Color.FromArgb(255, 40, 40, 40),
            Color.FromArgb(255, 20, 20, 20),
            Color.FromArgb(13, 255, 255, 255)
        };


        /// <summary>
        /// The custom basic offset
        /// </summary>
        private int customBasicOffset = 3;
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
        /// Gets or sets the custom basic border colors.
        /// </summary>
        /// <value>The custom basic border colors.</value>
        public Color[] CustomBasicBorderColors
        {
            get { return customBasicBorderColors; }
            set
            {
                customBasicBorderColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic state colors.
        /// </summary>
        /// <value>The custom basic state colors.</value>
        public Color[] CustomBasicStateColors
        {
            get { return customBasicStateColors; }
            set
            {
                customBasicStateColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic colors.
        /// </summary>
        /// <value>The custom basic colors.</value>
        public Color[] CustomBasicColors
        {
            get { return customBasicColors; }
            set
            {
                customBasicColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic highlights.
        /// </summary>
        /// <value>The custom basic highlights.</value>
        public Color[] CustomBasicHighlights
        {
            get { return customBasicHighlights; }
            set
            {
                customBasicHighlights = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic disabled.
        /// </summary>
        /// <value>The custom basic disabled.</value>
        public Color[] CustomBasicDisabled
        {
            get { return customBasicDisabled; }
            set
            {
                customBasicDisabled = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic offset.
        /// </summary>
        /// <value>The custom basic offset.</value>
        public int CustomBasicOffset
        {
            get { return customBasicOffset; }
            set
            {
                customBasicOffset = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint

        /// <summary>
        /// Customs the basic paint.
        /// </summary>
        private void CustomBasicPaint()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            GraphicsPath customBasicBPath;
            GraphicsPath customBasicTPath;
            Point[] customBasicBITPoints;
            Rectangle customBasicBRect;
            Rectangle customBasicTRect;
            Rectangle customBasicBIRect;
            LinearGradientBrush customBasicBBrush;
            LinearGradientBrush customBasicBIBrush;

            customBasicBRect = new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            customBasicTRect = new Rectangle(0, 0, ClientRectangle.Width - 2, Convert.ToInt32(ClientRectangle.Height / 2));
            customBasicBITPoints = new Point[] {
                new Point(4, 4),
                new Point(ClientRectangle.Width - 4, 4),
                new Point(ClientRectangle.Width - 4, ClientRectangle.Height - 4),
                new Point(4, ClientRectangle.Height - 4),
                new Point(4, 4)
            };
            customBasicBIRect = new Rectangle(3, 3, ClientRectangle.Width - 4, ClientRectangle.Height - 4);
            customBasicBBrush = new LinearGradientBrush(ClientRectangle, CustomBasicColors[0], CustomBasicColors[1], LinearGradientMode.Vertical);
            customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicColors[2], CustomBasicColors[3], LinearGradientMode.Vertical);

            switch (State)
            {
                case MouseState.Over:
                    customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicStateColors[0], CustomBasicStateColors[1], LinearGradientMode.Vertical);
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[0]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[1]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[0]), customBasicTRect);
                    break;
                case MouseState.Down:
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[2]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[3]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[1]), customBasicTRect);
                    break;
                case MouseState.None:
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[4]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[5]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[2]), customBasicTRect);
                    break;
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

            if (Enabled == false)
            {
                customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicDisabled[0], CustomBasicDisabled[1], LinearGradientMode.Vertical);
                G.FillRectangle(customBasicBBrush, customBasicBRect);
                G.DrawRectangle(new Pen(CustomBasicBorderColors[6]), customBasicBRect);
                G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                DrawBorders(new Pen(CustomBasicBorderColors[7]), CustomBasicOffset);
                G.FillRectangle(new SolidBrush(CustomBasicDisabled[2]), customBasicTRect);
                //DrawText(Brushes.Gray, HorizontalAlignment.Center, 0, 0);
            }
            else
            {
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
            CustomBasicPaint();
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
