// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Redwagon.cs" company="Zeroit Dev Technologies">
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
        private Color redwagonC1 = Color.FromArgb(153, 0, 0);

        private Color redwagonC2 = Color.FromArgb(255, 0, 0);
        

        private void RedwagonPaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(redwagonC1, redwagonC2, 0, 0, Width, Height, 90);
            }
            else
            {
                DrawGradient(redwagonC2, redwagonC1, 0, 0, Width, Height, 90);
            }

            //DrawText(Brushes.Black, HorizontalAlignment.Center, 0, 0);
            DrawBorders(Pens.Transparent, ClientRectangle);

            DrawCorners(Color.FromArgb(34, 34, 34), ClientRectangle);
        }

    }

}

