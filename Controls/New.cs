// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="New.cs" company="Zeroit Dev Technologies">
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

        Color newBackground = Color.FromArgb(12, 27, 74);
        

        private void NewPaintHook()
        {
            G.Clear(newBackground);
            if (State == MouseState.Down)
            {
                DrawGradient(Color.FromArgb(25, Color.Black), Color.FromArgb(5, Color.White), ClientRectangle);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
                DrawBorders(Pens.Black, ClientRectangle);
            }
            else if (State == MouseState.None)
            {
                DrawGradient(Color.FromArgb(25, Color.White), Color.FromArgb(5, Color.White), ClientRectangle);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
                DrawBorders(Pens.Black, ClientRectangle);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(Color.FromArgb(40, Color.White), Color.FromArgb(10, Color.White), ClientRectangle);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
                DrawBorders(Pens.Black, ClientRectangle);
            }
        }

    }

}

