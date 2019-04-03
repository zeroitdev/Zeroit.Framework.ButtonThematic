// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="21. CustomZeus.cs" company="Zeroit Dev Technologies">
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

    /// <summary>
    /// Class ButtonThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    public partial class ButtonThematic
    {

        #region Private Fields
        //Color customZeusBackground = Color.FromArgb(38, 38, 38);

        //private Color[] customZeusGradientColors = new Color[]
        //{
        //    Color.AliceBlue,
        //    Color.FromArgb(150, 255, 255)
        //};

        //private Color[] customZeusBorderColors = new Color[]
        //{
        //    Color.Black,
        //    Color.AliceBlue
        //};

        //private int customZeusClickReduce = 5;

        //private int customZeusClickLocate = 2;
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color CustomZeusBackground
        {
            get { return buttonInput.CustomZeusBackground; }
            set
            {
                buttonInput.CustomZeusBackground = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomZeusGradientColors
        {
            get { return buttonInput.CustomZeusGradientColors; }
            set
            {
                buttonInput.CustomZeusGradientColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomZeusBorderColors
        {
            get { return buttonInput.CustomZeusBorderColors; }
            set
            {
                buttonInput.CustomZeusBorderColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public int CustomZeusClickReduce
        {
            get { return buttonInput.CustomZeusClickReduce; }
            set {
                buttonInput.CustomZeusClickReduce = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public int CustomZeusClickLocate
        {
            get { return buttonInput.CustomZeusClickLocate; }
            set {
                buttonInput.CustomZeusClickLocate = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        private void CustomZeusPaintHook()
        {

            switch (State)
            {

                case MouseState.None:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width, Height, 90);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
                case MouseState.Over:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width, Height, 90);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
                case MouseState.Down:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width - (CustomZeusClickLocate / 2), Height - (CustomZeusClickLocate / 2), 90);
                    G.DrawRectangle(new Pen(CustomZeusBorderColors[0]), CustomZeusClickLocate, CustomZeusClickLocate, Width - CustomZeusClickReduce, Height - CustomZeusClickReduce);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
            }

        }

        #endregion
        
    }

}

