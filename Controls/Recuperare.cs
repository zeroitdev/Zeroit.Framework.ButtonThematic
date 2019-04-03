// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Recuperare.cs" company="Zeroit Dev Technologies">
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

        private void RecupararePaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            dynamic ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.Clear(BackColor);

            switch (State)
            {
                case MouseState.None:
                    //Mouse None
                    LinearGradientBrush bodyGrad = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 2), Color.FromArgb(245, 245, 245), Color.FromArgb(230, 230, 230), 90);
                    G.FillRectangle(bodyGrad, bodyGrad.Rectangle);
                    LinearGradientBrush bodyInBorder = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 4), Color.FromArgb(252, 252, 252), Color.FromArgb(249, 249, 249), 90);
                    G.DrawRectangle(new Pen(bodyInBorder), new Rectangle(1, 1, Width - 3, Height - 4));
                    G.DrawRectangle(new Pen(Color.FromArgb(189, 189, 189)), new Rectangle(0, 0, Width - 1, Height - 2));
                    G.DrawLine(new Pen(Color.FromArgb(200, 168, 168, 168)), new Point(1, Height - 1), new Point(Width - 2, Height - 1));
                    ForeColor = Color.FromArgb(27, 94, 137);
                    //G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(200, Color.White)), new Rectangle(-1, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    LineAlignment = StringAlignment.Center,
                    //    Alignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    //Mouse Hover
                    LinearGradientBrush bodyGrad1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 2), Color.FromArgb(70, 153, 205), Color.FromArgb(53, 124, 170), 90);
                    G.FillRectangle(bodyGrad1, bodyGrad1.Rectangle);
                    LinearGradientBrush bodyInBorder1 = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 4), Color.FromArgb(88, 168, 221), Color.FromArgb(76, 149, 194), 90);
                    G.DrawRectangle(new Pen(bodyInBorder1), new Rectangle(1, 1, Width - 3, Height - 4));
                    G.DrawRectangle(new Pen(Color.FromArgb(38, 93, 131)), new Rectangle(0, 0, Width - 1, Height - 2));
                    G.DrawLine(new Pen(Color.FromArgb(200, 25, 73, 109)), new Point(1, Height - 1), new Point(Width - 2, Height - 1));
                    ForeColor = Color.White;
                    G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(200, Color.Black)), new Rectangle(-1, -2, Width - 1, Height - 1), new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    });
                    break;
                case MouseState.Down:
                    //Mouse Down
                    LinearGradientBrush bodyGrad2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 2), Color.FromArgb(70, 153, 205), Color.FromArgb(53, 124, 170), 270);
                    G.FillRectangle(bodyGrad2, bodyGrad2.Rectangle);
                    LinearGradientBrush bodyInBorder2 = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 4), Color.FromArgb(88, 168, 221), Color.FromArgb(76, 149, 194), 270);
                    G.DrawRectangle(new Pen(bodyInBorder2), new Rectangle(1, 1, Width - 3, Height - 4));
                    G.DrawRectangle(new Pen(Color.FromArgb(38, 93, 131)), new Rectangle(0, 0, Width - 1, Height - 2));
                    G.DrawLine(new Pen(Color.FromArgb(200, 25, 73, 109)), new Point(1, Height - 1), new Point(Width - 2, Height - 1));
                    ForeColor = Color.White;
                    //G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(200, Color.Black)), new Rectangle(-1, -2, Width - 1, Height - 1), new StringFormat
                    //{
                    //    LineAlignment = StringAlignment.Center,
                    //    Alignment = StringAlignment.Center
                    //});
                    break;
            }
            //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(-1, -1, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = StringAlignment.Center
            //});

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

    }

}

