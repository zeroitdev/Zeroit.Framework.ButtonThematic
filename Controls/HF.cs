// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="HF.cs" company="Zeroit Dev Technologies">
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

        private void HFPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.Purple);

                    break;
                case MouseState.Over:
                    DrawGradient(Color.Gray, Color.Purple, 0, 0, Width, Height, 90);

                    break;
                case MouseState.Down:
                    DrawGradient(Color.Purple, Color.Gray, 0, 0, Width, Height, 90);
                    break;
            }

            DrawBorders(Pens.Black, Pens.Purple, ClientRectangle);
            // Form Border
            DrawCorners(Color.Black, ClientRectangle);
            // Clean Corners
            //DrawText(HorizontalAlignment.Center, Color.White, 0);
        }

    }

}

