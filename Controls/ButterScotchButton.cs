// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ButterScotchButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        private void ButterScotchOnPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle innerrect = new Rectangle(3, 3, Width - 7, Height - 7);
            Font btnfont = new Font("Verdana", 10, FontStyle.Regular);
            G.SmoothingMode = Smoothing;
            G.InterpolationMode = InterpolationMode;
            G.TextRenderingHint = TextRendering;
            G.Clear(BackColor);
            LinearGradientBrush buttonrect = new LinearGradientBrush(rect, Color.FromArgb(100, 90, 80), Color.FromArgb(48, 43, 39), LinearGradientMode.Vertical);
            G.FillPath(new SolidBrush(Color.FromArgb(26, 25, 21)), Draw.RoundRect(rect, 3));
            G.FillPath(buttonrect, Draw.RoundRect(innerrect, 3));
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush buttonrectnone = new LinearGradientBrush(innerrect, Color.FromArgb(100, 90, 80), Color.FromArgb(48, 43, 39), LinearGradientMode.Vertical);
                    G.FillPath(new SolidBrush(Color.FromArgb(26, 25, 21)), Draw.RoundRect(rect, 3));
                    G.FillPath(buttonrectnone, Draw.RoundRect(innerrect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, innerrect, new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    LinearGradientBrush buttonrectdown = new LinearGradientBrush(innerrect, Color.FromArgb(48, 43, 39), Color.FromArgb(100, 90, 80), LinearGradientMode.Vertical);
                    G.FillPath(new SolidBrush(Color.FromArgb(26, 25, 21)), Draw.RoundRect(rect, 3));
                    G.FillPath(buttonrectdown, Draw.RoundRect(innerrect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, innerrect, new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    LinearGradientBrush buttonrectover = new LinearGradientBrush(innerrect, Color.FromArgb(48, 43, 39), Color.FromArgb(100, 90, 80), LinearGradientMode.Vertical);
                    G.FillPath(new SolidBrush(Color.FromArgb(26, 25, 21)), Draw.RoundRect(rect, 3));
                    G.FillPath(buttonrectover, Draw.RoundRect(innerrect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, innerrect, new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }
            e.Graphics.DrawImage(B, new Point(0, 0));
            
        }

    }
}

