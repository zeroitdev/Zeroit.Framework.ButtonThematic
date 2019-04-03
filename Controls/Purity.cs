// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Purity.cs" company="Zeroit Dev Technologies">
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

        private void PurityPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.Red);
                    DrawGradient(Color.FromArgb(62, 62, 62), Color.FromArgb(38, 38, 38), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    G.Clear(Color.Red);
                    DrawGradient(Color.FromArgb(62, 62, 62), Color.FromArgb(38, 38, 38), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    G.Clear(Color.DarkRed);
                    DrawGradient(Color.FromArgb(38, 38, 38), Color.FromArgb(62, 62, 62), 0, 0, Width, Height, 90);
                    break;
            }

            DrawBorders(Pens.Black, Pens.DimGray, ClientRectangle);
            // Form Border
            DrawCorners(Color.Black, ClientRectangle);
            // Clean Corners
            //DrawText(HorizontalAlignment.Center, Color.Red, 0);
        }

    }

}

