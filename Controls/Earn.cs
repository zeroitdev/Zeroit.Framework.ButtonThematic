// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Earn.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    /// <summary>
    /// Class ButtonThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    public partial class ButtonThematic
    {


        Color c1 = Color.FromArgb(125, 205, 71);
        Color c2 = Color.FromArgb(84, 181, 54);


        private void EarnPaintHook()
        {

            G.Clear(c1);
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(c1, c2, 0, 0, Width, Height, 90);
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    DrawCorners(Color.FromArgb(240, 240, 240));
                    break;
                case MouseState.Over:
                    DrawGradient(c2, c1, 0, 0, Width, Height, 90);
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    DrawCorners(Color.FromArgb(240, 240, 240));
                    break;
                case MouseState.Down:
                    DrawGradient(c2, c2, 0, 0, Width, Height, 90);
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    DrawCorners(Color.FromArgb(240, 240, 240));
                    break;
            }
        }

    }

}

