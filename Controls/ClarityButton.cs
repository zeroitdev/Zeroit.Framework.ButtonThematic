// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ClarityButton.cs" company="Zeroit Dev Technologies">
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
        
        Color clarityC1 = Color.FromArgb(51, 49, 47);
        Color clarityC2 = Color.FromArgb(90, 91, 90);
        Color clarityC3 = Color.FromArgb(0, 0, 0);
        Color clarityC4 = Color.FromArgb(41, 39, 35);

        private void ClarityOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            LinearGradientBrush G1 = new LinearGradientBrush(new Point(0, 0), new Point(0, Height), clarityC3, clarityC4);
            G.FillRectangle(G1, 0, 0, Width, Height);
            G1.Dispose();

            if (Enabled)
            {
                switch (State)
                {
                    case MouseState.Over:
                        G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(0, 0, Width, Height));
                        break;
                    case MouseState.Down:
                        G.FillRectangle(new SolidBrush(Color.FromArgb(10, Color.White)), new Rectangle(0, 0, Width, Height));
                        break;
                }
            }

            StringFormat S1 = new StringFormat();
            S1.LineAlignment = StringAlignment.Center;
            S1.Alignment = StringAlignment.Center;

            switch (Enabled)
            {
                case true:
                    //G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), S1);
                    break;
                case false:
                    //G.DrawString(Text, Font, Brushes.Black, new Rectangle(0, 0, Width - 1, Height - 1), S1);
                    break;
            }

            S1.Dispose();

            G.DrawRectangle(new Pen(clarityC1), 0, 0, Width - 1, Height - 1);
            G.DrawRectangle(new Pen(clarityC2), 1, 1, Width - 3, Height - 3);

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            
        }
        

    }

}

