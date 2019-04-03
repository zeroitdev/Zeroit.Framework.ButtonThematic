// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="InnerDarkness.cs" company="Zeroit Dev Technologies">
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

        private void InnerDarknessPaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(Color.DarkGray, Color.DimGray, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(Color.DarkGray, Color.DarkGray, 0, 0, Width, Height, 90);
            }
            else
            {
                DrawGradient(Color.DimGray, Color.DarkGray, 0, 0, Width, Height, 90);
            }
            //DrawText(HorizontalAlignment.Center, ForeColor, 0);
            DrawBorders(Pens.Transparent, Pens.Black, ClientRectangle);
        }

    }

}

