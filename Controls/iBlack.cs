// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="iBlack.cs" company="Zeroit Dev Technologies">
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

        private Color iBlackC1 = Color.White;
        private Color iBlackP1 = Color.FromArgb(50, 50, 50);
        //SolidBrush B2;
        

        private void iBlackPaintHook()
        {
            G.Clear(iBlackC1);
            if ((State == MouseState.Over))
            {
                DrawGradient(Color.FromArgb(30, 30, 30), Color.FromArgb(50, 50, 50), 0, 0, Width, Height);
            }
            else if ((State == MouseState.Down))
            {
                DrawGradient(Color.FromArgb(118, 118, 118), Color.FromArgb(110, 110, 110), 0, 0, Width, Height);
            }
            else
            {
                DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(30, 30, 30), 0, 0, Width, Height);
            }
            DrawBorders(new Pen(iBlackP1), ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

    }

}

