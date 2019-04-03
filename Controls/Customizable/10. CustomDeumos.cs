// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="10. CustomDeumos.cs" company="Zeroit Dev Technologies">
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

        #region Private Fields
        //private Color customDeumosBackground = Color.FromArgb(14, 14, 14);
        //private Color customDeumosCornerColor = Color.FromArgb(16, 16, 16);
        //private Color customDeumosOverStateColor = Color.FromArgb(5, Color.White);


        //private Color[] customDeumosBorderColors = new Color[]
        //{
        //    Color.FromArgb(62, 62, 62),
        //    Color.FromArgb(15, Color.White),
        //    Color.Black
        //};


        //private Color[] customDeumosDownStateColors = new Color[]
        //{
        //    Color.FromArgb(14, 14, 14),
        //    Color.FromArgb(41, 41, 41)
        //};

        //private Color[] customDeumosNoneStateColors = new Color[]
        //{
        //    Color.FromArgb(30, Color.White),
        //    Color.FromArgb(5, Color.White)
        //};
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color[] CustomDeumosBorderColors
        {
            get { return buttonInput.CustomDeumosBorderColors; }
            set
            {
                buttonInput.CustomDeumosBorderColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomDeumosBackground
        {
            get { return buttonInput.CustomDeumosBackground; }
            set
            {
                buttonInput.CustomDeumosBackground = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomDeumosDownStateColors
        {
            get { return buttonInput.CustomDeumosDownStateColors; }
            set
            {
                buttonInput.CustomDeumosDownStateColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomDeumosOverStateColor
        {
            get { return buttonInput.CustomDeumosOverStateColor; }
            set { buttonInput.CustomDeumosOverStateColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomDeumosNoneStateColors
        {
            get { return buttonInput.CustomDeumosNoneStateColors; }
            set { buttonInput.CustomDeumosNoneStateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomDeumosCornerColor
        {
            get { return buttonInput.CustomDeumosCornerColor; }
            set { buttonInput.CustomDeumosCornerColor = value; Invalidate();}
        }

        #endregion

        #region Paint
        private void CustomDeumosPaintHook()
        {
            G.Clear(CustomDeumosBackground);

            if (State == MouseState.Down)
            {
                DrawGradient(CustomDeumosDownStateColors[0], CustomDeumosDownStateColors[1], 0, 0, Width, Height, 90);
            }

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(CustomDeumosOverStateColor), ClientRectangle);
            }

            DrawGradient(CustomDeumosNoneStateColors[0], CustomDeumosNoneStateColors[1], 0, 0, Width, Height / 2, 90);

            G.DrawLine(new Pen(CustomDeumosBorderColors[0]), 0, 1, Width, 1);
            DrawBorders(new Pen(CustomDeumosBorderColors[1]), ClientRectangle, 1);

            DrawBorders(new Pen(CustomDeumosBorderColors[2]), ClientRectangle);

            DrawCorners(CustomDeumosCornerColor, new Rectangle(1, 1, Width - 2, Height - 2));
            DrawCorners(BackColor, ClientRectangle);

            //DrawText(new SolidBrush(deumosB2), HorizontalAlignment.Center, 0, 0);
        }

        #endregion
    }

}

