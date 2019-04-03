// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Hacker.cs" company="Zeroit Dev Technologies">
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

        Color hackerBorder = Color.Black;
        
        private void HackerPaint()
        {
            G.Clear(Color.Black);
            G.DrawRectangle(new Pen(hackerBorder), new Rectangle(0, 0, Width - 1, Height - 1));
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height - 2), Color.FromArgb(255, 32, 32, 32), Color.Black, 75f);
                    G.FillRectangle(LGB, new Rectangle(1, 1, Width - 2, Height - 2));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Over:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height - 2), Color.FromArgb(255, 20, 20, 20), Color.Black, 75f);
                    G.FillRectangle(LGB1, new Rectangle(1, 1, Width - 2, Height - 2));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Down:
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height - 2), Color.FromArgb(255, 12, 12, 12), Color.Black, 75f);
                    G.FillRectangle(LGB2, new Rectangle(1, 1, Width - 2, Height - 2));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
            }
            DrawCorners(Color.Transparent, 0);
        }

    }

}

