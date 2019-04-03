// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Elegant.cs" company="Zeroit Dev Technologies">
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

        #region "Declarations"
        private Color elegantBaseColour = Color.FromArgb(245, 245, 245);
        private Color elegantPressedTextColour = Color.FromArgb(42, 42, 42);
        #endregion
        private Color elegantBorderColour = Color.FromArgb(163, 190, 146);

        #region "Properties"

        [Browsable(false)]
        [Category("Colours")]
        public Color ElegantBaseColor
        {
            get { return elegantBaseColour; }
            set { elegantBaseColour = value; }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color ElegantPressedTextColor
        {
            get { return elegantPressedTextColour; }
            set { elegantPressedTextColour = value; }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color ElegantBorderColor
        {
            get { return elegantBorderColour; }
            set { elegantBorderColour = value; }
        }
        

        #endregion

        #region "Mouse States"

        

        #endregion

        #region "Draw Control"

        

        private void ElegantOnPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            GraphicsPath GP = default(GraphicsPath);
            GraphicsPath GP1 = new GraphicsPath();
            //var G = G;
            G.TextRenderingHint = TextRendering;
            G.SmoothingMode = Smoothing;
            G.PixelOffsetMode = PixelOffsetMode.HighQuality;
            G.Clear(Parent.BackColor);
            switch (State)
            {
                case MouseState.None:
                    G.FillRectangle(new SolidBrush(elegantBaseColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(elegantBorderColour, 1), new Rectangle(0, 0, Width, Height));
                    //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(0, 0, Width, Height), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(elegantBaseColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(elegantBorderColour, 2), new Rectangle(0, 0, Width, Height));
                    //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(0, 0, Width, Height), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(elegantBaseColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(elegantBorderColour, 2), new Rectangle(0, 0, Width, Height));
                    //G.DrawString(Text, Font, new SolidBrush(elegantPressedTextColour), new Rectangle(0, 0, Width, Height), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }
            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            
        }

        #endregion

    }

}

