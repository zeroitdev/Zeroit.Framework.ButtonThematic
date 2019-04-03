// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Exotic.cs" company="Zeroit Dev Technologies">
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
        private void ExoticPaintHook()
        {
            G.Clear(Color.LightGray);
            switch (State)
            {
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(240, 248, 255), 3, 4, Width - 6, Height - 6, 90);
                    //DrawText(HorizontalAlignment.Center, Color.Black, 0);
                    break;
                case MouseState.None:
                    DrawGradient(Color.FromArgb(240, 248, 255), Color.FromArgb(0, 0, 0), 3, 4, Width - 6, Height - 6, 90);
                    //DrawText(HorizontalAlignment.Center, Color.Black, 0);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(240, 248, 255), Color.FromArgb(0, 0, 0), 3, 4, Width - 6, Height - 6, 90);
                    //DrawText(HorizontalAlignment.Center, Color.Black, 0);
                    break;
            }
            DrawBorders(Pens.Black, Pens.AliceBlue, ClientRectangle);
            DrawCorners(Color.LightGray, ClientRectangle);
        }

    }

}

