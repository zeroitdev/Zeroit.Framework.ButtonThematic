// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="CocaColaButton.cs" company="Zeroit Dev Technologies">
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

        private void CocaColaPaintHook()
        {
            G.Clear(Color.FromArgb(192, 0, 0));
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            DrawBorders(new Pen(new SolidBrush(Color.LightGray)));
            DrawBorders(new Pen(new SolidBrush(Color.RosyBrown)), 1);
            DrawCorners(Color.RosyBrown, ClientRectangle);
            if (State == MouseState.Over)
            {
                DrawBorders(new Pen(new SolidBrush(Color.Goldenrod)));
                DrawBorders(new Pen(new SolidBrush(Color.Goldenrod)), 1);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            }
            else if (State == MouseState.Down)
            {
                G.Clear(Color.FromArgb(204, 0, 5));
                DrawBorders(new Pen(new SolidBrush(Color.Gold)));
                DrawBorders(new Pen(new SolidBrush(Color.Gold)), 1);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            }


        }
    }

}

