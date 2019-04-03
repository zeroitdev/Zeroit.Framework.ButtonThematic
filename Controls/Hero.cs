// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Hero.cs" company="Zeroit Dev Technologies">
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

        private void HeroPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.FromArgb(50, 50, 50));
                    DrawGradient(Color.FromArgb(62, 62, 62), Color.FromArgb(40, 40, 40), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    G.Clear(Color.Gray);
                    DrawGradient(Color.FromArgb(62, 62, 62), Color.FromArgb(40, 40, 40), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    G.Clear(Color.FromArgb(211, 211, 211));
                    DrawGradient(Color.FromArgb(38, 38, 38), Color.FromArgb(40, 40, 40), 0, 0, Width, Height, 90);
                    break;
            }

            DrawCorners(Color.Black, ClientRectangle);
            //DrawText(HorizontalAlignment.Center, Color.FromArgb(211, 211, 211), 0);
        }
    }

}

