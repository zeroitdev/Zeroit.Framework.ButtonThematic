﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Steam.cs" company="Zeroit Dev Technologies">
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

        private void SteamPaintHook()
        {
            G.Clear(Color.FromArgb(56, 54, 53));
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(77, 75, 72))));
            DrawCorners(Color.FromArgb(56, 54, 53));



            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(92, 89, 86), Color.FromArgb(74, 72, 70), ClientRectangle, 90);
                    DrawBorders(new Pen(new SolidBrush(Color.FromArgb(112, 109, 105))));
                    DrawCorners(Color.FromArgb(82, 79, 77));
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(112, 109, 106), Color.FromArgb(94, 92, 90), ClientRectangle, 90);
                    DrawBorders(new Pen(new SolidBrush(Color.FromArgb(141, 148, 130))));
                    DrawCorners(Color.FromArgb(82, 79, 77));
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(56, 54, 53), Color.FromArgb(73, 71, 69), ClientRectangle, 90);
                    DrawBorders(new Pen(new SolidBrush(Color.FromArgb(112, 109, 105))));
                    DrawCorners(Color.FromArgb(82, 79, 77));
                    break;
            }
            //DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), Text.ToUpper(), HorizontalAlignment.Left, 4, 0);
        }

    }

}
