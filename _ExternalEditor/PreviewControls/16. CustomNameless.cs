// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="16. CustomNameless.cs" company="Zeroit Dev Technologies">
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
    /// Class NamelessPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class NamelessPreview : ThemeControl
    {

        #region Private Fields
        /// <summary>
        /// The custom nameless border colors
        /// </summary>
        private Color[] customNamelessBorderColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The custom nameless corners
        /// </summary>
        private Color customNamelessCorners = Color.Black;

        /// <summary>
        /// The custom nameless none highlight
        /// </summary>
        private Color[] customNamelessNoneHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(130, 130, 130),
            Color.FromArgb(40, 40, 40)

        };

        /// <summary>
        /// The custom nameless over highlight
        /// </summary>
        private Color[] customNamelessOverHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(150, 150, 150),
            Color.FromArgb(50, 50, 50)

        };

        /// <summary>
        /// The custom nameless down highlight
        /// </summary>
        private Color[] customNamelessDownHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(60, 60, 60),
            Color.FromArgb(22, 22, 22)

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
        /// Gets or sets the custom nameless corners.
        /// </summary>
        /// <value>The custom nameless corners.</value>
        public Color CustomNamelessCorners
        {
            get { return customNamelessCorners; }
            set
            {
                customNamelessCorners = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom nameless border colors.
        /// </summary>
        /// <value>The custom nameless border colors.</value>
        public Color[] CustomNamelessBorderColors
        {
            get { return customNamelessBorderColors; }
            set { customNamelessBorderColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom nameless none highlight.
        /// </summary>
        /// <value>The custom nameless none highlight.</value>
        public Color[] CustomNamelessNoneHighlight
        {
            get { return customNamelessNoneHighlight; }
            set { customNamelessNoneHighlight = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom nameless over highlight.
        /// </summary>
        /// <value>The custom nameless over highlight.</value>
        public Color[] CustomNamelessOverHighlight
        {
            get { return customNamelessOverHighlight; }
            set
            {
                customNamelessOverHighlight = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom nameless down highlight.
        /// </summary>
        /// <value>The custom nameless down highlight.</value>
        public Color[] CustomNamelessDownHighlight
        {
            get { return customNamelessDownHighlight; }
            set
            {
                customNamelessDownHighlight = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        /// <summary>
        /// Customs the name less paint hook.
        /// </summary>
        private void CustomNameLessPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            if (State == MouseState.None)
            {
                G.Clear(Color.FromArgb(20, CustomNamelessNoneHighlight[0]));
                Rectangle GrdRect = new Rectangle(0, 0, Width, this.Height / 2);
                LinearGradientBrush HeaderLGB = new LinearGradientBrush(GrdRect, CustomNamelessNoneHighlight[1], CustomNamelessNoneHighlight[2], 90);
                G.FillRectangle(HeaderLGB, GrdRect);
                //DrawGradient(Color.FromArgb(70, 70, 70), Color.FromArgb(30, 30, 30), 0, 0, Width, Me.Height \ 2)
                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(180, 180, 180)), HorizontalAlignment.Center, 0, 0);

            }

            else if (State == MouseState.Over)
            {
                G.Clear(Color.FromArgb(35, CustomNamelessOverHighlight[0]));
                //DrawGradient(Color.FromArgb(80, 80, 80), Color.FromArgb(40, 40, 40), 0, 0, Width, Me.Height \ 2)

                Rectangle GrdRect1 = new Rectangle(0, 0, Width, this.Height / 2);
                LinearGradientBrush HeaderLGB1 = new LinearGradientBrush(GrdRect1, CustomNamelessOverHighlight[1], CustomNamelessOverHighlight[2], 90);
                G.FillRectangle(HeaderLGB1, GrdRect1);
                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(222, 222, 222)), HorizontalAlignment.Center, 0, 0);


            }

            else if (State == MouseState.Down)
            {
                G.Clear(Color.FromArgb(10, CustomNamelessDownHighlight[0]));
                DrawGradient(CustomNamelessDownHighlight[1], CustomNamelessDownHighlight[2], 0, 0, Width, this.Height / 2);

                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(170, 170, 170)), HorizontalAlignment.Center, 1, 1);

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
            CustomNameLessPaintHook();
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

