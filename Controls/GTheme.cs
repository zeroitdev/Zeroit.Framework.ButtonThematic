// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="GTheme.cs" company="Zeroit Dev Technologies">
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
        private Color gThemeP1 = Color.FromArgb(31, 31, 31);
        private Color gThemeP3 = Color.FromArgb(92, 92, 92);
        private Color gThemeC1 = Color.FromArgb(25, 25, 25);
        private Color gThemeC2 = Color.FromArgb(43, 43, 43);

        private Color gThemeB1 = Color.FromArgb(204, 204, 204);
        

        private void GThemePaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(gThemeC1, gThemeC2, 0, 0, Width, Height, 90);
            }
            else
            {
                DrawGradient(gThemeC2, gThemeC1, 0, 0, Width, Height, 90);
            }
            //DrawText(HorizontalAlignment.Center, gThemeB1, 0);
            //DrawIcon(HorizontalAlignment.Left, 0);

            DrawBorders(new Pen(gThemeP1), new Pen(gThemeP3), ClientRectangle);
            DrawCorners(Color.FromArgb(25, 25, 25), ClientRectangle);
        }

    }

}

