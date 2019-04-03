// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BullionButton.cs" company="Zeroit Dev Technologies">
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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {


        private Image bullionImage;
        private bool BullionImageSet;

        [Browsable(false)]
        public Image BullionImage
        {
            get { return bullionImage; }
            set
            {
                bullionImage = value;
                BullionImageSet = value != null;
            }
        }


        
        
        Color BullionC1 = Color.FromArgb(244, 244, 244);
        Color BullionC2 = Color.FromArgb(220, 220, 220);
        Color BullionC3 = Color.FromArgb(248, 248, 248);
        Color BullionC4 = Color.FromArgb(24, Color.Black);
        Pen BullionP1 = new Pen(Color.FromArgb(255, 255, 255));
        Pen BullionP2 = new Pen(Color.FromArgb(40, Color.White));
        Pen BullionP3 = new Pen(Color.FromArgb(20, Color.White));
        Pen BullionP4 = new Pen(Color.FromArgb(10, Color.Black));
        Brush BullionB1;
        Brush BullionB2;
        Brush BullionB5;
        LinearGradientBrush BullionB3;

        LinearGradientBrush BullionB4;
        
        private void BullionPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            Rectangle R1 = new Rectangle(2, 2, Width - 4, 4);
            BullionB3 = new LinearGradientBrush(ClientRectangle, BullionC3, BullionC2, 90f);
            BullionB4 = new LinearGradientBrush(R1, BullionC4, Color.Transparent, 90f);
            BullionB1 = new SolidBrush(BullionC1);
            BullionB2 = new SolidBrush(BullionC3);
            BullionB5 = new SolidBrush(Color.FromArgb(170, 170, 170));

            G.FillRectangle(BullionB3, ClientRectangle);

            switch (State)
            {
                case MouseState.None:
                    //Up
                    G.FillRectangle(BullionB2, 1, 1, Width - 2, Height - 2);
                    G.DrawRectangle(BullionP4, 2, 2, Width - 5, Height - 5);
                    break;
                case MouseState.Over:
                    //Over
                    G.FillRectangle(BullionB1, 1, 1, Width - 2, Height - 2);
                    G.DrawRectangle(BullionP4, 2, 2, Width - 5, Height - 5);
                    break;
                case MouseState.Down:
                    //Down
                    G.FillRectangle(BullionB1, 1, 1, Width - 2, Height - 2);
                    G.FillRectangle(BullionB4, R1);
                    G.DrawLine(BullionP4, 2, 2, 2, Height - 3);
                    break;
            }

            SizeF S = G.MeasureString(Text, Font);
            //G.DrawString(Text, Font, BullionB5, Convert.ToInt32(Width / 2 - S.Width / 2), Convert.ToInt32(Height / 2 - S.Height / 2));

            G.DrawRectangle(BullionP1, 1, 1, Width - 3, Height - 3);

            if (BullionImageSet)
                G.DrawImage(bullionImage, 5, Convert.ToInt32(Height / 2 - bullionImage.Height / 2), bullionImage.Width, bullionImage.Height);

            e.Graphics.DrawImage(B, 0, 0);
            
        }
        
    }

}

