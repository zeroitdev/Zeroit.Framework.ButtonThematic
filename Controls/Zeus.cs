// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Zeus.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        Color zeusC1 = Color.FromArgb(38, 38, 38);
        Color zeusC2 = Color.AliceBlue;
        Color zeusC3 = Color.FromArgb(150, 255, 255);
        Color zeusP1 = Color.Black;
        Color zeusP2 = Color.AliceBlue;

        private void ZeusPaintHook()
        {
            
            switch (State)
            {

                case MouseState.None:
                    G.Clear(zeusC1);
                    DrawGradient(zeusC2, zeusC3, 0, 0, Width, Height, 90);
                    //DrawText(HorizontalAlignment.Center, zeusC1, 0);
                    DrawBorders(new Pen(zeusP1), new Pen(zeusP2), ClientRectangle);
                    break;
                case MouseState.Over:
                    G.Clear(zeusC1);
                    DrawGradient(zeusC2, zeusC3, 0, 0, Width, Height, 90);
                    //DrawText(HorizontalAlignment.Center, zeusC1, 0);
                    DrawBorders(new Pen(zeusP2), new Pen(zeusP1), ClientRectangle);
                    break;
                case MouseState.Down:
                    G.Clear(zeusC1);
                    DrawGradient(zeusC2, zeusC3, 0, 0, Width - 1, Height - 1, 90);
                    G.DrawRectangle(new Pen(zeusP1), 2, 2, Width - 5, Height - 5);
                    //DrawText(HorizontalAlignment.Center, zeusC1, 0);
                    DrawBorders(new Pen(zeusP1), new Pen(zeusP2), ClientRectangle);
                    break;
            }

        }

    }

}

