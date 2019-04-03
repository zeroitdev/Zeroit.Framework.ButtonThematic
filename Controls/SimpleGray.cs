// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="SimpleGray.cs" company="Zeroit Dev Technologies">
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

        Color simpleGr = Color.Gray;
        Color simpleLG = Color.LightGray;
        Color simpleO = Color.FromArgb(244, 244, 244);
        Color simpleD = Color.FromArgb(183, 183, 183);
        Color simpleP = Color.DarkGray;

        Color simplePG = Color.Gray;
        

        private void SimpleGrayPaintHook()
        {
            G.Clear(Color.DarkGray);

            if (State == MouseState.None)
            {
                DrawGradient(simpleLG, simpleGr, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(simpleO, simpleGr, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(simpleD, simpleGr, 0, 0, Width, Height, 90);
            }

            //DrawText(HorizontalAlignment.Center, ForeColor, 0);

            DrawBorders(new Pen(simpleP), new Pen(simplePG), ClientRectangle);
            DrawCorners(BackColor, ClientRectangle);
        }

    }

}

