// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="19. CustomRecon.cs" company="Zeroit Dev Technologies">
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
        //private Color customReconBackground = Color.FromArgb(49, 49, 49);

        //private Color[] customReconNoneStateColors = new Color[]
        //{
        //    Color.FromArgb(22, 22, 22),
        //    Color.FromArgb(34, 34, 34)
        //};

        //private Color[] customReconDownStateColors = new Color[]
        //{
        //    Color.FromArgb(28, 28, 28),
        //    Color.FromArgb(38, 38, 38),
        //    Color.FromArgb(100, 0, 0, 0),
        //    Color.Transparent
        //};

        //private Color[] customReconOverStateColors = new Color[]
        //{
        //    Color.FromArgb(28, 28, 28),
        //    Color.FromArgb(38, 38, 38),
        //    Color.FromArgb(100, 50, 50, 50),
        //    Color.Transparent
        //};

        //private Color[] customReconBorder = new Color[]
        //{
        //    Color.Black,
        //    Color.FromArgb(52, 52, 52)
        //};
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color CustomReconBackground
        {
            get { return buttonInput.CustomReconBackground; }
            set
            {
                buttonInput.CustomReconBackground = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomReconNoneStateColors
        {
            get { return buttonInput.CustomReconNoneStateColors; }
            set { buttonInput.CustomReconNoneStateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomReconDownStateColors
        {
            get { return buttonInput.CustomReconDownStateColors; }
            set { buttonInput.CustomReconDownStateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomReconOverStateColors
        {
            get { return buttonInput.CustomReconOverStateColors; }
            set { buttonInput.CustomReconOverStateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomReconBorder
        {
            get { return buttonInput.CustomReconBorder; }
            set
            {
                buttonInput.CustomReconBorder = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        private void CustomReconPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconNoneStateColors[0], CustomReconNoneStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
                case MouseState.Down:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconDownStateColors[0], CustomReconDownStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawGradient(CustomReconDownStateColors[2], CustomReconDownStateColors[3], 1, 1, ClientRectangle.Width, ClientRectangle.Height / 2, 90);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 1);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
                case MouseState.Over:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconOverStateColors[0], CustomReconOverStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawGradient(CustomReconOverStateColors[2], CustomReconOverStateColors[3], 1, 1, ClientRectangle.Width, ClientRectangle.Height / 2, 90);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, -1);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
            }

        }

        #endregion
    }

}

