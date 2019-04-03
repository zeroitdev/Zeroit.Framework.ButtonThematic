// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="18. CustomOrains.cs" company="Zeroit Dev Technologies">
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
    /// Class OrainsPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class OrainsPreview : ThemeControl
    {


        #region Private Fields
        /// <summary>
        /// The custom orains inner border
        /// </summary>
        Color customOrainsInnerBorder = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// The custom orains header
        /// </summary>
        Color customOrainsHeader = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// The custom orains outer border
        /// </summary>
        Color customOrainsOuterBorder = Color.Black;

        /// <summary>
        /// The custom orains button
        /// </summary>
        private Color[] customOrainsButton = new Color[]
        {
            Color.FromArgb(35, 35, 35),
            Color.FromArgb(20, 20, 20)
        };

        /// <summary>
        /// The custom orains hatch
        /// </summary>
        private Color[] customOrainsHatch = new Color[]
        {
            Color.Black,
            Color.Transparent
        };

        /// <summary>
        /// The hatch style
        /// </summary>
        private HatchStyle hatchStyle = HatchStyle.LightDownwardDiagonal;
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
        /// Gets or sets the custom orains hatch.
        /// </summary>
        /// <value>The custom orains hatch.</value>
        public Color[] CustomOrainsHatch
        {
            get { return customOrainsHatch; }
            set
            {
                customOrainsHatch = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom orains button.
        /// </summary>
        /// <value>The custom orains button.</value>
        public Color[] CustomOrainsButton
        {
            get { return customOrainsButton; }
            set { customOrainsButton = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom orains inner border.
        /// </summary>
        /// <value>The custom orains inner border.</value>
        public Color CustomOrainsInnerBorder
        {
            get { return customOrainsInnerBorder; }
            set { customOrainsInnerBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom orains header.
        /// </summary>
        /// <value>The custom orains header.</value>
        public Color CustomOrainsHeader
        {
            get { return customOrainsHeader; }
            set { customOrainsHeader = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom orains outer border.
        /// </summary>
        /// <value>The custom orains outer border.</value>
        public Color CustomOrainsOuterBorder
        {
            get { return customOrainsOuterBorder; }
            set { customOrainsOuterBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the hatch style.
        /// </summary>
        /// <value>The hatch style.</value>
        public HatchStyle HatchStyle
        {
            get { return hatchStyle; }
            set { hatchStyle = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint
        /// <summary>
        /// Customs the orains paint hook.
        /// </summary>
        private void CustomOrainsPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            //G.Clear(BackColor)


            switch (State)
            {
                case MouseState.None:

                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[0], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 0, 0);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(CustomOrainsInnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Over:

                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[0], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB1, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch1 = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch1, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -1, -1);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(45, CustomOrainsInnerBorder /*45, 45, 45*/)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Down:
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[1], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB2, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch2 = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch2, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 1, 1);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(32, CustomOrainsInnerBorder /*32, 32, 32*/)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
            }




            //Dim BodyHatch As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent)
            // G.FillRectangle(BodyHatch, New Rectangle(0, 0, Width - 1, Height - 1))
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
            CustomOrainsPaintHook();
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

