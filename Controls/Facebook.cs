// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Facebook.cs" company="Zeroit Dev Technologies">
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

    public partial class ButtonThematic
    {


        private Color facebookMainColor = Color.FromArgb(70, 98, 158);
        private Color facebookHoverColor = Color.FromArgb(55, 83, 158);



        #region "Colour Properties"

        [Browsable(false)]
        [Category("Colours"), Description("Background Colour Selection")]
        public Color BackgroundColour
        {
            get { return facebookMainColor; }
            set { facebookMainColor = value; }
        }

        

        #endregion

        #region "Draw Control"

       
        private void FaceBookPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            dynamic GP = default(GraphicsPath);
            GraphicsPath GP1 = new GraphicsPath();
            Rectangle Base = new Rectangle(0, 0, Width - 1, Height - 1);
            
            G.TextRenderingHint = TextRendering;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.PixelOffsetMode = PixelOffsetMode.HighQuality;
            G.Clear(BackColor);
            switch (State)
            {
                case MouseState.None:
                    GP = Draw.RoundRec(Base, 2);
                    G.FillPath(new SolidBrush(facebookMainColor), GP);
                    //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, new StringFormat
                    //{
                    //    LineAlignment = StringAlignment.Center,
                    //    Alignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    GP = Draw.RoundRec(Base, 2);
                    G.FillPath(new SolidBrush(facebookHoverColor), GP);
                    //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, new StringFormat
                    //{
                    //    LineAlignment = StringAlignment.Center,
                    //    Alignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    GP = Draw.RoundRec(Base, 2);
                    G.FillPath(new SolidBrush(facebookHoverColor), GP);
                    //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, new StringFormat
                    //{
                    //    LineAlignment = StringAlignment.Center,
                    //    Alignment = StringAlignment.Center
                    //});
                    GP1 = Draw.RoundRec(new Rectangle(0, 0, Width, Height), 3);
                    G.DrawPath(new Pen(new SolidBrush(Color.LightYellow), 2), GP1);
                    break;
            }
            
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
           
        }

        #endregion

    }

}

