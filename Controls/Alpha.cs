// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Alpha.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    public partial class ButtonThematic
    {

        private Color[] alphaBorders = new Color[]
        {
            Color.Lime,
            Color.DimGray
        };

        [Browsable(false)]
        public Color[] AlphaBorders
        {
            get { return alphaBorders; }
            set
            {
                alphaBorders = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// 
        public void AlphaPaintHook(PaintEventArgs e)
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.DimGray);
                    break;
                case MouseState.Over:
                    G.Clear(Color.Gray);
                    break;
                case MouseState.Down:
                    G.Clear(Color.Green);
                    break;
            }
            
            //DrawText(HorizontalAlignment.Center, Color.Lime, 0);

            DrawBorders(new Pen(alphaBorders[0]), new Pen(alphaBorders[1]), ClientRectangle);
            DrawCorners(BackColor, ClientRectangle);
        }
    }
}
