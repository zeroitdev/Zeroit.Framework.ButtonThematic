// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="19. CustomRecon.cs" company="Zeroit Dev Technologies">
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
    /// Class ReconPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class ReconPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom recon background
        /// </summary>
        private Color customReconBackground = Color.FromArgb(49, 49, 49);

        /// <summary>
        /// The custom recon none state colors
        /// </summary>
        private Color[] customReconNoneStateColors = new Color[]
        {
            Color.FromArgb(22, 22, 22),
            Color.FromArgb(34, 34, 34)
        };

        /// <summary>
        /// The custom recon down state colors
        /// </summary>
        private Color[] customReconDownStateColors = new Color[]
        {
            Color.FromArgb(28, 28, 28),
            Color.FromArgb(38, 38, 38),
            Color.FromArgb(100, 0, 0, 0),
            Color.Transparent
        };

        /// <summary>
        /// The custom recon over state colors
        /// </summary>
        private Color[] customReconOverStateColors = new Color[]
        {
            Color.FromArgb(28, 28, 28),
            Color.FromArgb(38, 38, 38),
            Color.FromArgb(100, 50, 50, 50),
            Color.Transparent
        };

        /// <summary>
        /// The custom recon border
        /// </summary>
        private Color[] customReconBorder = new Color[]
        {
            Color.Black,
            Color.FromArgb(52, 52, 52)
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
        /// Gets or sets the custom recon background.
        /// </summary>
        /// <value>The custom recon background.</value>
        public Color CustomReconBackground
        {
            get { return customReconBackground; }
            set
            {
                customReconBackground = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom recon none state colors.
        /// </summary>
        /// <value>The custom recon none state colors.</value>
        public Color[] CustomReconNoneStateColors
        {
            get { return customReconNoneStateColors; }
            set { customReconNoneStateColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom recon down state colors.
        /// </summary>
        /// <value>The custom recon down state colors.</value>
        public Color[] CustomReconDownStateColors
        {
            get { return customReconDownStateColors; }
            set { customReconDownStateColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom recon over state colors.
        /// </summary>
        /// <value>The custom recon over state colors.</value>
        public Color[] CustomReconOverStateColors
        {
            get { return customReconOverStateColors; }
            set { customReconOverStateColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom recon border.
        /// </summary>
        /// <value>The custom recon border.</value>
        public Color[] CustomReconBorder
        {
            get { return customReconBorder; }
            set
            {
                customReconBorder = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        /// <summary>
        /// Customs the recon paint hook.
        /// </summary>
        private void CustomReconPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            switch (State)
            {
                case MouseState.None:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconNoneStateColors[0], CustomReconNoneStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
                case MouseState.Down:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconDownStateColors[0], CustomReconDownStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawGradient(CustomReconDownStateColors[2], CustomReconDownStateColors[3], 1, 1, ClientRectangle.Width, ClientRectangle.Height / 2, 90);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 1);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
                case MouseState.Over:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconOverStateColors[0], CustomReconOverStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawGradient(CustomReconOverStateColors[2], CustomReconOverStateColors[3], 1, 1, ClientRectangle.Width, ClientRectangle.Height / 2, 90);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, -1);
                    DrawCorners(this.BackColor, ClientRectangle);
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
            CustomReconPaintHook();
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

