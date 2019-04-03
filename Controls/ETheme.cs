// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ETheme.cs" company="Zeroit Dev Technologies">
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

        private void EThemePaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.FromArgb(49, 49, 49));
                    DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(40, 40, 40), ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height, 90);
                    break;
                case MouseState.Down:
                    G.Clear(Color.FromArgb(49, 49, 49));
                    DrawGradient(Color.FromArgb(40, 40, 40), Color.FromArgb(50, 50, 50), ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height, 90);
                    break;
                case MouseState.Over:
                    G.Clear(Color.FromArgb(49, 49, 49));
                    DrawGradient(Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50), ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height, 90);
                    break;
            }
            //DrawText(HorizontalAlignment.Center, Color.Gray, 0);
            DrawBorders(Pens.Black, Pens.DimGray, ClientRectangle);
            DrawCorners(Color.FromArgb(53, 53, 53), ClientRectangle);

        }

    }

}

