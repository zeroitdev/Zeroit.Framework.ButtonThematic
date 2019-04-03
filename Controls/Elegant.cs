// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Elegant.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region "Declarations"
        private Color elegantBaseColour = Color.FromArgb(245, 245, 245);
        private Color elegantPressedTextColour = Color.FromArgb(42, 42, 42);
        #endregion
        private Color elegantBorderColour = Color.FromArgb(163, 190, 146);

        #region "Properties"

        [Browsable(false)]
        [Category("Colours")]
        public Color ElegantBaseColor
        {
            get { return elegantBaseColour; }
            set { elegantBaseColour = value; }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color ElegantPressedTextColor
        {
            get { return elegantPressedTextColour; }
            set { elegantPressedTextColour = value; }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color ElegantBorderColor
        {
            get { return elegantBorderColour; }
            set { elegantBorderColour = value; }
        }
        

        #endregion

        #region "Mouse States"

        

        #endregion

        #region "Draw Control"

        

        private void ElegantOnPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            GraphicsPath GP = default(GraphicsPath);
            GraphicsPath GP1 = new GraphicsPath();
            //var G = G;
            G.TextRenderingHint = TextRendering;
            G.SmoothingMode = Smoothing;
            G.PixelOffsetMode = PixelOffsetMode.HighQuality;
            G.Clear(Parent.BackColor);
            switch (State)
            {
                case MouseState.None:
                    G.FillRectangle(new SolidBrush(elegantBaseColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(elegantBorderColour, 1), new Rectangle(0, 0, Width, Height));
                    //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(0, 0, Width, Height), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(elegantBaseColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(elegantBorderColour, 2), new Rectangle(0, 0, Width, Height));
                    //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(0, 0, Width, Height), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(elegantBaseColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(elegantBorderColour, 2), new Rectangle(0, 0, Width, Height));
                    //G.DrawString(Text, Font, new SolidBrush(elegantPressedTextColour), new Rectangle(0, 0, Width, Height), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }
            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            
        }

        #endregion

    }

}

