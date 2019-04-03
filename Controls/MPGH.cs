// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="MPGH.cs" company="Zeroit Dev Technologies">
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

        //private Pen P1;
        //private Pen P2;
        private Color mpghC1 = Color.FromArgb(50, 34, 34, 34);

        private Color mpghC2 = Color.FromArgb(0, 0, 228);
        

        private void MPGHPaintHook()
        {
            G.Clear(Parent.BackColor);
            if (State == MouseState.Down)
            {
                DrawGradient(mpghC1, mpghC2, 0, 0, Width, Height, 90);
            }
            else
            {
                DrawGradient(mpghC2, mpghC1, 0, 0, Width, Height, 90);
            }

            //DrawText(Brushes.Black, HorizontalAlignment.Center, 0, 0);
            DrawBorders(Pens.Transparent, ClientRectangle);

            DrawCorners(Color.FromArgb(34, 34, 34), ClientRectangle);
        }

    }

}

