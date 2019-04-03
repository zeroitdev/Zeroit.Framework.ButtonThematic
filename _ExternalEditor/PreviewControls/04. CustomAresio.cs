// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="04. CustomAresio.cs" company="Zeroit Dev Technologies">
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
    /// Class AresioButton.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    /// <seealso cref="System.Windows.Forms.Control" />
    [ToolboxItem(false)]
    public class AresioPreview : ThemeControl
    {

        #region Private Fields

        /// <summary>
        /// The custom aresio border colors
        /// </summary>
        private Color[] customAresioBorderColors = new Color[]
        {
            Color.FromArgb(50,Color.White),
            Color.FromArgb(150, 100, 70)
        };


        /// <summary>
        /// The custom aresio none colors
        /// </summary>
        private Color[] customAresioNoneColors = new Color[]
        {
            Color.FromArgb(250, 200, 70),
            Color.FromArgb(250, 160, 40)
        };

        /// <summary>
        /// The custom aresio over colors
        /// </summary>
        private Color[] customAresioOverColors = new Color[]
        {
            Color.FromArgb(50, Color.White),
            Color.Transparent
        };

        /// <summary>
        /// The custom aresio down colors
        /// </summary>
        private Color[] customAresioDownColors = new Color[]
        {
            Color.FromArgb(50, Color.Black),
            Color.Transparent
        };

        /// <summary>
        /// The curve
        /// </summary>
        private int curve = 5;
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
        /// Gets or sets the custom aresio border colors.
        /// </summary>
        /// <value>The custom aresio border colors.</value>
        public Color[] CustomAresioBorderColors
        {
            get { return customAresioBorderColors; }
            set
            {
                customAresioBorderColors = value;
                Invalidate();
            }
        }

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
        /// Gets or sets the custom aresio none colors.
        /// </summary>
        /// <value>The custom aresio none colors.</value>
        public Color[] CustomAresioNoneColors
        {
            get { return customAresioNoneColors; }
            set { customAresioNoneColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom aresio over colors.
        /// </summary>
        /// <value>The custom aresio over colors.</value>
        public Color[] CustomAresioOverColors
        {
            get { return customAresioOverColors; }
            set { customAresioOverColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom aresio down colors.
        /// </summary>
        /// <value>The custom aresio down colors.</value>
        public Color[] CustomAresioDownColors
        {
            get { return customAresioDownColors; }
            set
            {
                customAresioDownColors = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        /// <summary>
        /// Customs the aresio paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void CustomAresioPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            G.Clear(Parent.BackColor);

            G.DrawPath(DesignFunctions.ToPen(CustomAresioBorderColors[0]), DesignFunctions.RoundRect(0, 1, Width - 1, Height - 2, Curve));
            G.DrawPath(DesignFunctions.ToPen(CustomAresioBorderColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
            switch (Enabled)
            {
                case true:
                    switch (State)
                    {
                        case MouseState.None:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioNoneColors[0], CustomAresioNoneColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                        case MouseState.Over:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioOverColors[0], CustomAresioOverColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                        case MouseState.Down:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioDownColors[0], CustomAresioDownColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                    }

                    break;
                case false:
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.White, new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)) + 1, Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2)) + 1));
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.Gray, new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2))));
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
            CustomAresioPaint(e);
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
