// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="White.cs" company="Zeroit Dev Technologies">
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

        
        Color whiteP1 = Color.FromArgb(225, 225, 225);
        Color whiteP2 = Color.FromArgb(150, 150, 150);
        Color whiteC1 = Color.FromArgb(225, 225, 225);
        Color whiteC2 = Color.FromArgb(185, 185, 185);

        

        private void WhitePaintHook()
        {
            G.Clear(BackColor);
            DrawBorders(new Pen(whiteP1), 1);

            switch (State)
            {

                case MouseState.Down:
                    DrawGradient(whiteC1, whiteC2, 0, 0, Width, Height);
                    break;
                case MouseState.None:
                    DrawGradient(whiteC2, whiteC1, 0, 0, Width, Height);
                    break;
                case MouseState.Over:
                    DrawGradient(whiteC2, whiteC1, 0, 0, Width, Height);
                    break;
            }

            HatchBrush DarkUp = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Transparent, Color.FromArgb(50, Color.Black));
            G.FillRectangle(DarkUp, new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

            DrawBorders(new Pen(whiteP2), 0);

            //G.DrawLine(whiteP2, 0, 20, Width, 20)
            //G.DrawLine(whiteP1, 0, 21, Width, 21)
            //G.DrawLine(whiteP1, 0, 22, Width, 22)
            //G.DrawLine(whiteP2, 0, 23, Width, 23)

            //DrawText(Brushes.DarkBlue, HorizontalAlignment.Center, 0, 0);
        }

    }

}

