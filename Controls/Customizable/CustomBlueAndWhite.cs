﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="CustomBlueAndWhite.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;
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
        
        private Color customBnWInactiveBorder = Color.FromArgb(185, 185, 185);
        //private Pen customBNWBawP4 = new Pen(Color.FromArgb(135, 182, 233));
        //private Color customBNWBawB1 = Color.FromArgb(114, 114, 114);
        //private Color customBNWBawB2 = Color.FromArgb(246, 247, 250);
        //private Color customBNWBawB3 = Color.FromArgb(25, 55, 82);
        private int customBWOffset = 10;
        private int customBnWRounding = 50;

        private Color[] customBnWOffsetFill = new Color[]
        {
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(60, 60, 60)
        };

        #endregion

        #region Public Properties

        [Browsable(false)]
        public int CustomBwOffset
        {
            get { return customBWOffset; }
            set
            {
                customBWOffset = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomBnWInactiveBorder
        {
            get { return customBnWInactiveBorder; }
            set { customBnWInactiveBorder = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public int CustomBnWRounding
        {
            get { return customBnWRounding; }
            set { customBnWRounding = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomBnWOffsetFill
        {
            get { return customBnWOffsetFill; }
            set { customBnWOffsetFill = value; }
        }

        #endregion

        private void CustomBaWOnPaint(PaintEventArgs e)
        {
            //Rectangle BaWR1 = new Rectangle(0, 0, Width, Height);
            //Rectangle BaWR2 = new Rectangle(0, 1, Width, Height);
            

            G.Clear(Parent.BackColor);
            //GraphicsPath BaWShape = new GraphicsPath();
            LinearGradientBrush BaWInactiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(249, 249, 249), Color.FromArgb(222, 222, 222), 90);
            LinearGradientBrush BaWActiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(171, 210, 244), Color.FromArgb(84, 153, 228), 90);
            LinearGradientBrush BaWActiveContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(121, 180, 235), Color.FromArgb(70, 137, 201), 90);
            LinearGradientBrush BaWPressedGB = new LinearGradientBrush(new Rectangle(0, 1, Width, Height), Color.FromArgb(97, 162, 228), Color.FromArgb(114, 173, 233), 90);
            LinearGradientBrush BaWPressedContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(74, 141, 208), Color.FromArgb(114, 173, 230), 90);
            Pen BaWP2 = new Pen(BaWActiveContourGB);
            Pen BaWP3 = new Pen(BaWPressedContourGB);

            #region Old Code
            //int cwOffset = 10;
            //GraphicsPath BaWShapeBorder = Helper.DrawRoundRect(new Rectangle(0, 0, Width - 10, Height - 10), 100,this, true,3);

            //var _with1 = BaWShape;
            //_with1.AddArc(0, 0, 10, 10, 180, 90);
            //_with1.AddArc(Width - 11, 0, 10, 10, -90, 90);
            //_with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
            //_with1.AddArc(0, Height - 11, 10, 10, 90, 90);
            //_with1.CloseAllFigures();

            #endregion

            Rectangle offsetRectangle = new Rectangle(0 + CustomBwOffset, 0 + CustomBwOffset, Width - 2 - (CustomBwOffset * 2),
                Height - 2 - (CustomBwOffset * 2));
            GraphicsPath BaWShape = Helper.RoundRect(new Rectangle(0,0, Width - 2, Height - 2), CustomBnWRounding);
            GraphicsPath BaWShapeOffset = Helper.RoundRect(new Rectangle(0 + CustomBwOffset, 0 + CustomBwOffset, Width - 2 - (CustomBwOffset * 2), Height - 2 - (CustomBwOffset * 2)), CustomBnWRounding);
            
            switch (State)
            {
                case MouseState.None:
                    //Inactive
                    G.FillPath(BaWInactiveGB, BaWShape);
                    G.DrawPath(new Pen(customBnWInactiveBorder), BaWShape);
                    G.DrawPath(new Pen(customBnWInactiveBorder), BaWShapeOffset);
                    //G.DrawString(Text, Font, customBNWBawB1, BaWR1, BaWCSF);
                    break;
                case MouseState.Over:
                    //Active
                    G.FillPath(BaWActiveGB, BaWShape);
                    G.DrawPath(BaWP2, BaWShape);
                    G.FillPath(new LinearGradientBrush(offsetRectangle, CustomBnWOffsetFill[0], CustomBnWOffsetFill[1], 90f), BaWShapeOffset);
                    G.DrawPath(new Pen(Color.LimeGreen), BaWShapeOffset);
                    //G.DrawString(Text, Font, Brushes.DarkSlateGray, BaWR2, BaWCSF);
                    //G.DrawString(Text, Font, customBNWBawB2, BaWR1, BaWCSF);
                    break;
                case MouseState.Down:
                    //Pressed
                    G.FillPath(BaWPressedGB, BaWShape);
                    G.DrawPath(BaWP3, BaWShape);
                    G.FillPath(new LinearGradientBrush(offsetRectangle, CustomBnWOffsetFill[1], CustomBnWOffsetFill[0], 90f), BaWShapeOffset);
                    G.DrawPath(new Pen(Color.LightCyan), BaWShapeOffset);
                    //G.DrawLine(customBNWBawP4, 1, 1, Width - 2, 1);
                    //G.DrawString(Text, Font, Brushes.White, BaWR2, BaWCSF);
                    //G.DrawString(Text, Font, customBNWBawB3, BaWR1, BaWCSF);
                    break;
            }
            
        }
    }


}
