// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="03. CustomAdvantium.cs" company="Zeroit Dev Technologies">
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
    /// Class AdvantiumPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class AdvantiumPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom advantium back
        /// </summary>
        Color customAdvantiumBack = Color.FromArgb(40, 40, 40);

        /// <summary>
        /// The custom advantium none colors
        /// </summary>
        private Color[] customAdvantiumNoneColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(42, 42, 42)
        };

        /// <summary>
        /// The custom advantium down colors
        /// </summary>
        private Color[] customAdvantiumDownColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(42, 42, 42)
        };

        /// <summary>
        /// The custom advantium over colors
        /// </summary>
        private Color[] customAdvantiumOverColors = new Color[]
        {
            Color.FromArgb(42, 42, 42),
            Color.FromArgb(50, 50, 50)

        };

        /// <summary>
        /// The custom advantium border colors
        /// </summary>
        private Color[] customAdvantiumBorderColors = new Color[]
        {
            Color.FromArgb(59, 59, 59),
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(35, 35, 35)

        };

        /// <summary>
        /// The custom advantium offsets
        /// </summary>
        private int[] customAdvantiumOffsets = new int[]
        {
            1,
            0,
            0
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
        /// Gets or sets the custom advantium offsets.
        /// </summary>
        /// <value>The custom advantium offsets.</value>
        public int[] CustomAdvantiumOffsets
        {
            get { return customAdvantiumOffsets; }
            set { customAdvantiumOffsets = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium background.
        /// </summary>
        /// <value>The custom advantium background.</value>
        public Color CustomAdvantiumBackground
        {
            get { return customAdvantiumBack; }
            set { customAdvantiumBack = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium none colors.
        /// </summary>
        /// <value>The custom advantium none colors.</value>
        public Color[] CustomAdvantiumNoneColors
        {
            get { return customAdvantiumNoneColors; }
            set { customAdvantiumNoneColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium down colors.
        /// </summary>
        /// <value>The custom advantium down colors.</value>
        public Color[] CustomAdvantiumDownColors
        {
            get { return customAdvantiumDownColors; }
            set { customAdvantiumDownColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium over colors.
        /// </summary>
        /// <value>The custom advantium over colors.</value>
        public Color[] CustomAdvantiumOverColors
        {
            get { return customAdvantiumOverColors; }
            set { customAdvantiumOverColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium border colors.
        /// </summary>
        /// <value>The custom advantium border colors.</value>
        public Color[] CustomAdvantiumBorderColors
        {
            get { return customAdvantiumBorderColors; }
            set { customAdvantiumBorderColors = value; Invalidate(); }
        }
        #endregion

        #region Paint
        /// <summary>
        /// Customs the advantium paint hook.
        /// </summary>
        private void CustomAdvantiumPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            G.Clear(Color.Red);
            switch (State)
            {
                case MouseState.None:
                    //None
                    DrawGradient(CustomAdvantiumNoneColors[0], CustomAdvantiumNoneColors[1], ClientRectangle, 90);
                    break;
                case MouseState.Down:
                    //Down
                    DrawGradient(CustomAdvantiumDownColors[0], CustomAdvantiumDownColors[1], ClientRectangle, 90);
                    break;
                case MouseState.Over:
                    //Over
                    DrawGradient(CustomAdvantiumOverColors[0], CustomAdvantiumOverColors[1], ClientRectangle, 90);
                    break;
            }
            DrawBorders(new Pen(new SolidBrush(CustomAdvantiumBorderColors[0])), CustomAdvantiumOffsets[0]);
            DrawBorders(new Pen(new SolidBrush(CustomAdvantiumBorderColors[1])), CustomAdvantiumOffsets[1]);
            DrawCorners(CustomAdvantiumBorderColors[2], CustomAdvantiumOffsets[2]);
            //DrawText(new SolidBrush(CustomadvantiumT1), HorizontalAlignment.Center, 0, 0);
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
            CustomAdvantiumPaintHook();
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
