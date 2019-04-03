// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Evolve.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        
        private void EvolvePaintHook()
        {
            G.Clear(Parent.BackColor);

            //G.Clear(BackColor);

            if (State == MouseState.None)
            {
                LinearGradientBrush Gradientbrush1 = new LinearGradientBrush(new Rectangle(new Point(3, 2), new Size(Width - 6, (Height / 5) * 2)), Color.FromArgb(88, 88, 88), Color.FromArgb(47, 47, 47), 90f);
                G.FillRectangle(Gradientbrush1, new Rectangle(new Point(4, 2), new Size(Width - 7, (Height / 5) * 2)));
                G.DrawLine(new Pen(Color.FromArgb(121, 121, 121)), new Point(4, 2), new Point(Width - 5, 2));
                Gradientbrush1 = new LinearGradientBrush(new Rectangle(new Point(3, (Height / 5) * 2), new Size(Width - 6, Height - 16)), Color.FromArgb(43, 43, 43), Color.FromArgb(21, 21, 21), 90f);
                G.FillRectangle(Gradientbrush1, new Rectangle(new Point(3, (Height / 5) * 2 + 1), new Size(Width - 6, Height - 16)));
                G.DrawLine(new Pen(Color.FromArgb(21, 21, 21)), new Point(6, Height - 2), new Point(Width - 5, Height - 2));
                G.DrawLine(new Pen(Color.FromArgb(21, 21, 21)), new Point(5, Height - 3), new Point(Width - 5, Height - 3));
                G.DrawLine(new Pen(Color.FromArgb(21, 21, 21)), new Point(4, Height - 4), new Point(Width - 4, Height - 4));
            }
            else if (State == MouseState.Over)
            {
                LinearGradientBrush Gradientbrush1 = new LinearGradientBrush(new Rectangle(new Point(3, 2), new Size(Width - 6, (Height / 5) * 2)), Color.FromArgb(162, 72, 72), Color.FromArgb(134, 38, 38), 90f);
                G.FillRectangle(Gradientbrush1, new Rectangle(new Point(4, 2), new Size(Width - 7, (Height / 5) * 2)));
                G.DrawLine(new Pen(Color.FromArgb(179, 105, 105)), new Point(4, 2), new Point(Width - 5, 2));
                Gradientbrush1 = new LinearGradientBrush(new Rectangle(new Point(3, (Height / 5) * 2), new Size(Width - 6, Height - 16)), Color.FromArgb(126, 26, 26), Color.FromArgb(88, 12, 12), 90f);
                G.FillRectangle(Gradientbrush1, new Rectangle(new Point(3, (Height / 5) * 2 + 1), new Size(Width - 6, Height - 16)));
                G.DrawLine(new Pen(Color.FromArgb(88, 12, 12)), new Point(6, Height - 2), new Point(Width - 5, Height - 2));
                G.DrawLine(new Pen(Color.FromArgb(88, 12, 12)), new Point(5, Height - 3), new Point(Width - 5, Height - 3));
                G.DrawLine(new Pen(Color.FromArgb(88, 12, 12)), new Point(4, Height - 4), new Point(Width - 4, Height - 4));
            }
            else if (State == MouseState.Down)
            {
                LinearGradientBrush Gradientbrush1 = new LinearGradientBrush(new Rectangle(new Point(3, 2), new Size(Width - 6, (Height / 5) * 2)), Color.FromArgb(86, 21, 21), Color.FromArgb(136, 38, 38), 90f);
                G.FillRectangle(Gradientbrush1, new Rectangle(new Point(4, 2), new Size(Width - 7, (Height / 5) * 2)));
                Gradientbrush1 = new LinearGradientBrush(new Rectangle(new Point(3, (Height / 5) * 2), new Size(Width - 6, Height - 16)), Color.FromArgb(114, 30, 30), Color.FromArgb(149, 64, 64), 90f);
                G.FillRectangle(Gradientbrush1, new Rectangle(new Point(3, (Height / 5) * 2 + 1), new Size(Width - 6, Height - 16)));
                G.DrawLine(new Pen(Color.FromArgb(149, 64, 64)), new Point(6, Height - 2), new Point(Width - 5, Height - 2));
                G.DrawLine(new Pen(Color.FromArgb(149, 64, 64)), new Point(5, Height - 3), new Point(Width - 5, Height - 3));
                G.DrawLine(new Pen(Color.FromArgb(149, 64, 64)), new Point(4, Height - 4), new Point(Width - 4, Height - 4));
            }

            G.DrawLine(Pens.Black, new Point(3, 3), new Point(3, this.Height - 4));
            G.DrawLine(Pens.Black, new Point(5, 1), new Point(this.Width - 5, 1));
            G.DrawLine(Pens.Black, new Point(this.Width - 3, 3), new Point(this.Width - 3, this.Height - 4));
            G.DrawLine(Pens.Black, new Point(5, this.Height - 2), new Point(this.Width - 5, this.Height - 2));
            DrawPixel(Color.Black, 4, 2);
            DrawPixel(Color.Black, this.Width - 4, 2);
            DrawPixel(Color.Black, 4, this.Height - 3);
            DrawPixel(Color.Black, this.Width - 4, this.Height - 3);

            SizeF textSize = this.CreateGraphics().MeasureString(Text, Font, Width - 4);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            //G.DrawString(Text, Font, Brushes.Black, new RectangleF(1, 3, this.Width - 5, this.Height - 4), sf);
            //G.DrawString(Text, Font, Brushes.Black, new RectangleF(3, 3, this.Width - 5, this.Height - 4), sf);
            //G.DrawString(Text, Font, Brushes.White, new RectangleF(2, 2, this.Width - 5, this.Height - 4), sf);

        }

    }

}

