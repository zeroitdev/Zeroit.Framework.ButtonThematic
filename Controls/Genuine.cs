// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Genuine.cs" company="Zeroit Dev Technologies">
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
        
        private Color genuineC1 = Color.FromArgb(41, 41, 41);
        private Color genuineC2 = Color.FromArgb(51, 51, 51);
        private Color genuineC3 = Color.FromArgb(51, 51, 51);
        private Color genuineC4 = Color.FromArgb(41, 41, 41);
        private Color genuineP1 = Color.FromArgb(12, Color.White);

        private Color genuineP2 = Color.FromArgb(25, 25, 25);
        

        private void GenuinePaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(genuineC1, genuineC2, ClientRectangle, 90f);
            }
            else
            {
                DrawGradient(genuineC3, genuineC4, ClientRectangle, 90f);
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

            DrawBorders(new Pen(genuineP1), 1);
            DrawBorders(new Pen(genuineP2));

            DrawCorners(Parent.BackColor);
        }

    }

}

