// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Qube.cs" company="Zeroit Dev Technologies">
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

        
        
        private void QubePaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Font btnfont = new Font("Verdana", 10, FontStyle.Regular);
            G.Clear(BackColor);
            LinearGradientBrush buttonrect = new LinearGradientBrush(rect, Color.FromArgb(68, 76, 99), Color.FromArgb(68, 76, 99), LinearGradientMode.Vertical);
            G.FillPath(buttonrect, Draw.RoundRect(rect, 3));
            G.DrawPath(new Pen(Brushes.Gray), Draw.RoundRect(rect, 3));
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush buttonrectnone = new LinearGradientBrush(rect, Color.FromArgb(68, 76, 99), Color.FromArgb(68, 76, 99), LinearGradientMode.Vertical);
                    G.FillPath(buttonrectnone, Draw.RoundRect(rect, 3));
                    G.DrawPath(new Pen(Color.FromArgb(68, 76, 99)), Draw.RoundRect(rect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    LinearGradientBrush buttonrectnone1 = new LinearGradientBrush(rect, Color.FromArgb(105, 120, 149), Color.FromArgb(105, 120, 149), LinearGradientMode.Vertical);
                    G.FillPath(buttonrectnone1, Draw.RoundRect(rect, 3));
                    G.DrawPath(new Pen(Color.FromArgb(105, 120, 149)), Draw.RoundRect(rect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    LinearGradientBrush buttonrectnone2 = new LinearGradientBrush(rect, Color.FromArgb(68, 76, 99), Color.FromArgb(68, 76, 99), LinearGradientMode.Vertical);
                    G.FillPath(buttonrectnone2, Draw.RoundRect(rect, 3));
                    G.DrawPath(new Pen(Color.FromArgb(68, 76, 99)), Draw.RoundRect(rect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }
            e.Graphics.DrawImage(B, new Point(0, 0));
            //G.Dispose();
            //B.Dispose();
        }

    }

}

