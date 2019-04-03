// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="TheBlack.cs" company="Zeroit Dev Technologies">
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

        
        private Color theBlackC1 = Color.FromArgb(98, 122, 173);
        private Color theBlackC2 = Color.FromArgb(109, 134, 183);
        private Color theBlackP1 = Color.FromArgb(29, 64, 136);

        private void TheBlackPaintHook()
        {
            G.Clear(theBlackC2);
            if (State == MouseState.Down)
            {
                G.Clear(theBlackC1);
            }
            DrawBorders(new Pen(theBlackP1), 0, 0, Width, Height);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }

    }

}

