// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BloodyButton.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        Color bloodyButtonColor = Color.WhiteSmoke;
        Color bloodyBorder = Color.Black;

        ColorBlend bicouleur = new ColorBlend(2);

        [Browsable(false)]
        public Color BloodyButtonColor
        {
            get { return bloodyButtonColor; }
            set { bloodyButtonColor = value; }
        }

        [Browsable(false)]
        public Color BloodyBorder
        {
            get { return bloodyBorder; }
            set { bloodyBorder = value; }
        }

        private void BloodyPaint()
        {
            G.Clear(bloodyButtonColor);
            switch (State)
            {
                case MouseState.None:


                    bicouleur.Colors[0] = Color.FromArgb(255, 40, 0, 0);
                    //Rouge foncé
                    bicouleur.Colors[1] = Color.FromArgb(240, 90, 0, 0);
                    //Rouge
                    bicouleur.Positions[0] = 0;
                    bicouleur.Positions[1] = 1;
                    DrawGradient(bicouleur, new Rectangle(0, 0, Width, Height));
                    bicouleur.Colors[0] = Color.FromArgb(0, 0, 0, 0);
                    bicouleur.Colors[1] = Color.FromArgb(40, Color.White);
                    G.DrawRectangle(new Pen(bloodyBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;


                case MouseState.Over:

                    bicouleur.Colors[0] = Color.FromArgb(235, 40, 0, 0);
                    //Rouge foncé
                    bicouleur.Colors[1] = Color.FromArgb(200, 90, 0, 0);
                    //Rouge
                    bicouleur.Positions[0] = 0;
                    bicouleur.Positions[1] = 1;
                    DrawGradient(bicouleur, new Rectangle(0, 0, Width, Height));
                    bicouleur.Colors[0] = Color.FromArgb(0, 0, 0, 0);
                    bicouleur.Colors[1] = Color.FromArgb(40, Color.White);
                    G.DrawRectangle(new Pen(bloodyBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Down:

                    bicouleur.Colors[0] = Color.FromArgb(205, 40, 0, 0);
                    //Rouge foncé
                    bicouleur.Colors[1] = Color.FromArgb(185, 90, 0, 0);
                    //Rouge
                    bicouleur.Positions[0] = 0;
                    bicouleur.Positions[1] = 1;
                    DrawGradient(bicouleur, new Rectangle(0, 0, Width, Height));
                    bicouleur.Colors[0] = Color.FromArgb(0, 0, 0, 0);
                    bicouleur.Colors[1] = Color.FromArgb(40, Color.White);
                    G.DrawRectangle(new Pen(bloodyBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
            }
        }

    }


}
