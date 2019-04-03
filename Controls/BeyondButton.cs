// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BeyondButton.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        private Color beyondBackground = Color.White;
        private Color beyondBorder = Color.FromArgb(50, 50, 50);
        private BeyondDrawStyle beyondDrawMode = BeyondDrawStyle.Basic;

        public enum BeyondDrawStyle
        {
            Basic,
            Advanced
        }

        [Browsable(false)]
        public BeyondDrawStyle BeyondDrawMode
        {
            get { return beyondDrawMode; }
            set { beyondDrawMode = value;
                Invalidate();
            }
        }

        private void BeyondBasic()
        {
            G.Clear(beyondBackground);
            if ((State == MouseState.Over))
            {
                DrawGradient(Color.FromArgb(30, 30, 30), Color.FromArgb(15, 15, 15), 0, 0, Width, Height);
            }
            else if ((State == MouseState.Down))
            {
                DrawGradient(Color.FromArgb(15, 15, 15), Color.FromArgb(30, 30, 30), 0, 0, Width, Height);
            }
            else
            {
                DrawGradient(Color.FromArgb(15, 15, 15), Color.FromArgb(30, 30, 30), 0, 0, Width, Height);
            }
            DrawBorders(new Pen(beyondBorder), ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }
    
        private Color beyondBackground1 = Color.White;
        private Color beyondGrad1 = Color.FromArgb(50, 50, 50);
        private Color beyondGrad2 = Color.FromArgb(70, 70, 70);
        private Color beyondAdvancedBorder = Color.Black;
        

        private void BeyondAdvanced()
        {
            G.Clear(beyondBackground1);
            if ((State == MouseState.Over))
            {
                DrawGradient(C2, C3, 0, 0, Width, Height);
            }
            else if ((State == MouseState.Down))
            {
                DrawGradient(C3, C2, 0, 0, Width, Height);
            }
            else
            {
                DrawGradient(C3, C2, 0, 0, Width, Height);
            }
            DrawBorders(new Pen(beyondAdvancedBorder), ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
        }


        private void BeyondPaint()
        {
            switch (BeyondDrawMode)
            {

                case BeyondDrawStyle.Basic:
                    BeyondBasic();
                    break;

                case BeyondDrawStyle.Advanced:
                    BeyondAdvanced();
                    break;

            }
        }

    }
}
