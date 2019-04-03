// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Secure.cs" company="Zeroit Dev Technologies">
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

        private void SecurePaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(Color.PowderBlue, Color.DarkSlateGray, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(Color.PowderBlue, Color.DarkSlateGray, 0, 0, Width, Height, 90);
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

