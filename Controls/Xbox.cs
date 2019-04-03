// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Xbox.cs" company="Zeroit Dev Technologies">
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

        private void XboxPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.LightGray);
                    DrawGradient(Color.GhostWhite, Color.LightGray, 0, 0, Width, 20, 90);
                    break;
                case MouseState.Over:
                    G.Clear(Color.Orange);
                    DrawGradient(Color.FromArgb(0, 255, 36), (Color.FromArgb(0, 140, 20)), 0, 0, Width, 25, 90);
                    break;
                case MouseState.Down:
                    G.Clear(Color.Orange);
                    DrawGradient(Color.DarkGreen, (Color.FromArgb(18, 255, 0)), 0, 0, Width, 30, 90);
                    break;
            }
            //DrawText(HorizontalAlignment.Center, Color.FromArgb(190, 190, 190), 0);
            DrawBorders(Pens.DarkGreen, Pens.LightGray, ClientRectangle);
            DrawCorners(Color.DarkGreen, ClientRectangle);
        }

    }

}

