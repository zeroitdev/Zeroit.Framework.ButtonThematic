// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="18. CustomOrains.cs" company="Zeroit Dev Technologies">
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
        //Color customOrainsInnerBorder = Color.FromArgb(40, 40, 40);
        //Color customOrainsHeader = Color.FromArgb(40, 40, 40);
        //Color customOrainsOuterBorder = Color.Black;

        //private Color[] customOrainsButton = new Color[]
        //{
        //    Color.FromArgb(35, 35, 35),
        //    Color.FromArgb(20, 20, 20)
        //};

        //private Color[] customOrainsHatch = new Color[]
        //{
        //    Color.Black,
        //    Color.Transparent
        //};
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color[] CustomOrainsHatch
        {
            get { return buttonInput.CustomOrainsHatch; }
            set
            {
                buttonInput.CustomOrainsHatch = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomOrainsButton
        {
            get { return buttonInput.CustomOrainsButton; }
            set { buttonInput.CustomOrainsButton = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomOrainsInnerBorder
        {
            get { return buttonInput.CustomOrainsInnerBorder; }
            set { buttonInput.CustomOrainsInnerBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomOrainsHeader
        {
            get { return buttonInput.CustomOrainsHeader; }
            set { buttonInput.CustomOrainsHeader = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomOrainsOuterBorder
        {
            get { return buttonInput.CustomOrainsOuterBorder; }
            set { buttonInput.CustomOrainsOuterBorder = value; Invalidate(); }
        }
        #endregion

        #region Paint
        private void CustomOrainsPaintHook()
        {
            //G.Clear(BackColor)


            switch (State)
            {
                case MouseState.None:

                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[0], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 0, 0);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(CustomOrainsInnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Over:

                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[0], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB1, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch1 = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch1, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -1, -1);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(45, CustomOrainsInnerBorder /*45, 45, 45*/)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Down:
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[1], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB2, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch2 = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch2, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 1, 1);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(32, CustomOrainsInnerBorder /*32, 32, 32*/)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
            }




            //Dim BodyHatch As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent)
            // G.FillRectangle(BodyHatch, New Rectangle(0, 0, Width - 1, Height - 1))
        }

        #endregion

    }

}

