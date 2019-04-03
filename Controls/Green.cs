// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Green.cs" company="Zeroit Dev Technologies">
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
        
        Color greenC1 = Color.FromArgb(41, 57, 34);
        Color greenC2 = Color.FromArgb(49, 49, 49);
        Color greenC3 = Color.FromArgb(39, 39, 39);
        Color greenC4 = Color.FromArgb(60, Color.Black);
        Pen greenP1 = new Pen(Color.FromArgb(22, 22, 22));
        Pen greenP2 = new Pen(Color.FromArgb(20, Color.White));
        Pen greenP3 = new Pen(Color.FromArgb(10, Color.White));
        Pen P4 = new Pen(Color.FromArgb(30, Color.Black));
        Brush B1;
        Brush B2;
        Brush B5 = new SolidBrush(Color.FromArgb(201, 205, 37));
        LinearGradientBrush B3;

        LinearGradientBrush B4;
        
        private void GreenPaint(PaintEventArgs e)
        {
            Rectangle R1 = new Rectangle(2, 2, Width - 4, 4);
            B1 = new SolidBrush(greenC1);
            B2 = new SolidBrush(greenC3);
            B3 = new LinearGradientBrush(ClientRectangle, greenC3, greenC2, 90f);
            B4 = new LinearGradientBrush(R1, greenC4, Color.Transparent, 90f);

            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            G.FillRectangle(B3, ClientRectangle);

            switch (State)
            {
                case MouseState.None:
                    //Up
                    G.FillRectangle(B1, 1, 1, Width - 2, Height - 2);
                    G.DrawLine(greenP2, 2, 2, Width - 3, 2);
                    G.DrawLine(greenP3, 2, Height - 3, Width - 3, Height - 3);
                    break;
                case MouseState.Over:
                    //Over
                    G.FillRectangle(B2, 1, 1, Width - 2, Height - 2);
                    G.DrawLine(greenP2, 2, 2, Width - 3, 2);
                    G.DrawLine(greenP3, 2, Height - 3, Width - 3, Height - 3);
                    break;
                case MouseState.Down:
                    //Down
                    G.FillRectangle(B2, 1, 1, Width - 2, Height - 2);
                    G.FillRectangle(B4, R1);
                    G.DrawLine(P4, 2, 2, 2, Height - 3);
                    break;
            }

            SizeF S = G.MeasureString(Text, Font);
            //G.DrawString(Text, Font, B5, Convert.ToInt32(Width / 2 - S.Width / 2), Convert.ToInt32(Height / 2 - S.Height / 2));

            G.DrawRectangle(greenP1, 1, 1, Width - 3, Height - 3);

            e.Graphics.DrawImage(B, 0, 0);
            //G.Dispose();
            //B.Dispose();
        }


    }

}

