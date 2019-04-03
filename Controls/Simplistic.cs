// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Simplistic.cs" company="Zeroit Dev Technologies">
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

        private void SimplisticPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.SteelBlue);
                    break;
                case MouseState.Down:
                    G.Clear(Color.DodgerBlue);
                    break;
            }

            //DrawText(HorizontalAlignment.Center, Color.Black, 0);
            DrawBorders(Pens.Black, Pens.LightGray, ClientRectangle);
            DrawCorners(BackColor, ClientRectangle);
        }

    }

}

