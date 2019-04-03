// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Electric.cs" company="Zeroit Dev Technologies">
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

        

        Color electricG1 = Color.FromArgb(23, 102, 139);
        Color electricG2 = Color.FromArgb(12, 77, 103);
        Color electricG3 = Color.FromArgb(34, 133, 179);
        Color electricG4 = Color.FromArgb(17, 89, 119);
        Color electricBorder = Color.Black;
        Color electricG5 = Color.FromArgb(28, 107, 144);

        Color electricBacground = Color.Navy;

        private void ElectricPaintHook()
        {
            G.Clear(electricBacground);
            //Temporary, gradient will cover it

            //Draws a gradient depending on the mousestate
            if (State == MouseState.None)
            {
                DrawGradient(electricG1, electricG2, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(electricG3, electricG5, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(electricG4, electricG4, 0, 0, Width, Height, 90);
            }

            //DrawText(HorizontalAlignment.Center, ForeColor, 0);
            //Draws the text...
            G.DrawRectangle(new Pen(electricBorder), ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            //Border
        }
    }


}

