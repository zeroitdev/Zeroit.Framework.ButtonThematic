// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Flow.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        
        private Color flowC1 = Color.FromArgb(24, 24, 24);
        private Color flowC2 = Color.FromArgb(38, 38, 38);
        private Color flowC3 = Color.FromArgb(38, 38, 38);
        private Color flowC4 = Color.FromArgb(24, 24, 24);
        private Color flowC5 = Color.FromArgb(60, 60, 60);
        private Color flowC6 = Color.FromArgb(36, 36, 36);
        private Color flowB1 = Color.FromArgb(0, 132, 255);
        
        private Color flowP1 = Color.FromArgb(22, 22, 22);
        

        private void FlowPaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(flowC1, flowC2, ClientRectangle, 90f);
            }
            else
            {
                DrawGradient(flowC3, flowC4, ClientRectangle, 90f);
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

            LinearGradientBrush B2 = new LinearGradientBrush(ClientRectangle, flowC5, flowC6, 90f);
            Pen P2 = new Pen(B2);

            DrawBorders(new Pen(flowP1));
            DrawBorders(P2, 1);
        }

    }

}

