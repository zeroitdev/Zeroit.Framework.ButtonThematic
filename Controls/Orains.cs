// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Orains.cs" company="Zeroit Dev Technologies">
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

        
        Color orainsButtonColor1 = Color.FromArgb(35, 35, 35);
        Color orainsButtonColor2 = Color.FromArgb(20, 20, 20);
        Color orainsInnerBorder = Color.FromArgb(40, 40, 40);
        Color orainsHeader = Color.FromArgb(40, 40, 40);

        Color orainsOuterBorder = Color.Black;
        
        private void OrainsPaintHook()
        {
            //G.Clear(BackColor)


            switch (State)
            {
                case MouseState.None:

                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), orainsButtonColor1, orainsButtonColor2, 90);
                    G.FillRectangle(LGB, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent);
                    G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 0, 0);

                    G.DrawRectangle(new Pen(orainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(orainsInnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Over:

                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), orainsButtonColor1, Color.FromArgb(20, 20, 20), 90);
                    G.FillRectangle(LGB1, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent);
                    G.FillRectangle(BodyHatch1, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -1, -1);

                    G.DrawRectangle(new Pen(orainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(45, 45, 45)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Down:
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(20, 20, 20), orainsButtonColor2, 90);
                    G.FillRectangle(LGB2, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch2 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent);
                    G.FillRectangle(BodyHatch2, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 1, 1);

                    G.DrawRectangle(new Pen(orainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(32, 32, 32)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
            }




            //Dim BodyHatch As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent)
            // G.FillRectangle(BodyHatch, New Rectangle(0, 0, Width - 1, Height - 1))
        }


    }

}

