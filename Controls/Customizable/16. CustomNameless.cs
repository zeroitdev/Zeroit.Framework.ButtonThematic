// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="16. CustomNameless.cs" company="Zeroit Dev Technologies">
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

        #region Private Fields
        //private Color[] customNamelessBorderColors = new Color[]
        //{
        //    Color.FromArgb(50, 50, 50),
        //    Color.Black,
        //    Color.Black
        //};

        //private Color customNamelessCorners = Color.Black;

        //private Color[] customNamelessNoneHighlight = new Color[]
        //{
        //    Color.White,
        //    Color.FromArgb(130, 130, 130),
        //    Color.FromArgb(40, 40, 40)

        //};

        //private Color[] customNamelessOverHighlight = new Color[]
        //{
        //    Color.White,
        //    Color.FromArgb(150, 150, 150),
        //    Color.FromArgb(50, 50, 50)

        //};

        //private Color[] customNamelessDownHighlight = new Color[]
        //{
        //    Color.White,
        //    Color.FromArgb(60, 60, 60),
        //    Color.FromArgb(22, 22, 22)

        //};
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color CustomNamelessCorners
        {
            get { return buttonInput.CustomNamelessCorners; }
            set
            {
                buttonInput.CustomNamelessCorners = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomNamelessBorderColors
        {
            get { return buttonInput.CustomNamelessBorderColors; }
            set { buttonInput.CustomNamelessBorderColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomNamelessNoneHighlight
        {
            get { return buttonInput.CustomNamelessNoneHighlight; }
            set { buttonInput.CustomNamelessNoneHighlight = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomNamelessOverHighlight
        {
            get { return buttonInput.CustomNamelessOverHighlight; }
            set
            {
                buttonInput.CustomNamelessOverHighlight = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomNamelessDownHighlight
        {
            get { return buttonInput.CustomNamelessDownHighlight; }
            set
            {
                buttonInput.CustomNamelessDownHighlight = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        private void CustomNameLessPaintHook()
        {
            if (State == MouseState.None)
            {
                G.Clear(Color.FromArgb(20, CustomNamelessNoneHighlight[0]));
                Rectangle GrdRect = new Rectangle(0, 0, Width, this.Height / 2);
                LinearGradientBrush HeaderLGB = new LinearGradientBrush(GrdRect, CustomNamelessNoneHighlight[1], CustomNamelessNoneHighlight[2], 90);
                G.FillRectangle(HeaderLGB, GrdRect);
                //DrawGradient(Color.FromArgb(70, 70, 70), Color.FromArgb(30, 30, 30), 0, 0, Width, Me.Height \ 2)
                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(180, 180, 180)), HorizontalAlignment.Center, 0, 0);

            }

            else if (State == MouseState.Over)
            {
                G.Clear(Color.FromArgb(35, CustomNamelessOverHighlight[0]));
                //DrawGradient(Color.FromArgb(80, 80, 80), Color.FromArgb(40, 40, 40), 0, 0, Width, Me.Height \ 2)

                Rectangle GrdRect1 = new Rectangle(0, 0, Width, this.Height / 2);
                LinearGradientBrush HeaderLGB1 = new LinearGradientBrush(GrdRect1, CustomNamelessOverHighlight[1], CustomNamelessOverHighlight[2], 90);
                G.FillRectangle(HeaderLGB1, GrdRect1);
                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(222, 222, 222)), HorizontalAlignment.Center, 0, 0);


            }

            else if (State == MouseState.Down)
            {
                G.Clear(Color.FromArgb(10, CustomNamelessDownHighlight[0]));
                DrawGradient(CustomNamelessDownHighlight[1], CustomNamelessDownHighlight[2], 0, 0, Width, this.Height / 2);

                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(170, 170, 170)), HorizontalAlignment.Center, 1, 1);

            }
        }

        #endregion

    }

}

