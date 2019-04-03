// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Fusion.cs" company="Zeroit Dev Technologies">
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
        private Color fusionC1 = Color.FromArgb(255, 127, 1);
        private Color fusionC2 = Color.FromArgb(255, 175, 12);
        private Color fusionC3 = Color.FromArgb(255, 175, 12);
        private Color fusionC4 = Color.FromArgb(255, 127, 1);
        private Color fusionB1 = Color.FromArgb(30, Color.Black);
        private Color fusionB2 = Color.White;
        private Color fusionP1 = Color.FromArgb(255, 197, 19);

        private Color fusionP2 = Color.FromArgb(254, 133, 0);

        
        private void FusionPaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(fusionC1, fusionC2, ClientRectangle, 90f);
            }
            else
            {
                DrawGradient(fusionC3, fusionC4, ClientRectangle, 90f);
            }

            //DrawText(new SolidBrush(fusionB1), HorizontalAlignment.Center, 1, 1);
            //DrawText(new SolidBrush(fusionB2), HorizontalAlignment.Center, 0, 0);

            DrawBorders(new Pen(fusionP1), 1);
            DrawBorders(new Pen(fusionP2));

            DrawCorners(BackColor);
        }

    }

}

