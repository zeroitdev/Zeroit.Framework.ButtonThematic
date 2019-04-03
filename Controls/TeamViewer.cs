// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="TeamViewer.cs" company="Zeroit Dev Technologies">
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

        private void TeamViewerPaintHook()
        {
            
            G.Clear(Color.FromArgb(1, 1, 1));
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(0, 153, 255), Color.FromArgb(0, 102, 255), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(0, 102, 255), Color.FromArgb(0, 153, 255), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(0, 143, 240), Color.FromArgb(0, 200, 240), 0, 0, Width, Height, 90);
                    break;
            }
            G.FillRectangle(new SolidBrush(Color.FromArgb(6, Color.White)), 0, 0, Width, 12);
            DrawBorders(Pens.Black);
            DrawBorders(Pens.Black, 2);
            DrawCorners(Color.FromArgb(20, 20, 20), ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

    }

}

