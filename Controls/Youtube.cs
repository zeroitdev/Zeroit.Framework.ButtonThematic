// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Youtube.cs" company="Zeroit Dev Technologies">
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

        private void YoutubePaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(Color.Red, Color.DarkRed, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(Color.DarkRed, Color.Red, 0, 0, Width, Height, 90);
            }
            else
            {
                DrawGradient(Color.Red, Color.DarkRed, 0, 0, Width, Height, 90);
            }
            //DrawText(HorizontalAlignment.Center, ForeColor, 0);
            DrawBorders(Pens.Red, Pens.White, ClientRectangle);
        }

    }

}

