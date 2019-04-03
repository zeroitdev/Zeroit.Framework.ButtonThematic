// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Doom.cs" company="Zeroit Dev Technologies">
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
        
        Color doomBorder = Color.Black;
        private Color doomBackground = Color.Black;

        private void DoomPaintHook()
        {
            G.Clear(doomBackground);
            G.DrawRectangle(new Pen(doomBorder), new Rectangle(0, 0, Width - 3, Height - 1));
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(8, 20, Width - 10, Height - 8), Color.FromArgb(24, 24, 24), Color.FromArgb(15, 15, 15), 75f);
                    G.FillRectangle(LGB, new Rectangle(1, 1, Width - 2, Height - 2));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Over:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(8, 30, Width - 10, Height - 8), Color.FromArgb(24, 24, 24), Color.FromArgb(15, 15, 15), 75f);
                    G.FillRectangle(LGB1, new Rectangle(1, 1, Width - 2, Height - 2));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Down:
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(8, 70, Width - 10, Height - 8), Color.FromArgb(30, 192, 0, 0), Color.FromArgb(70, 192, 0, 0), 75f);
                    G.FillRectangle(LGB2, new Rectangle(1, 1, Width - 2, Height - 2));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
            }
            DrawCorners(Color.Transparent, 0);
        }

    }

}

