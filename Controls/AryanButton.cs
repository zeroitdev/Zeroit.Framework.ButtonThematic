// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AryanButton.cs" company="Zeroit Dev Technologies">
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
    //Button
    public partial class ButtonThematic
    {

        private Color[] aryanNonestateColors = new Color[]
        {
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(50, 50, 50)
        };

        private Color[] aryanDownstateColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(42, 42, 42)
        };

        private Color[] aryanOverstateColors = new Color[]
        {
            Color.FromArgb(42, 42, 42),
            Color.FromArgb(50, 50, 50)
        };

        private Color[] aryanBorderColors = new Color[]
        {
            Color.FromArgb(59, 59, 59),
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(35, 35, 35)

        };

        Color background = Color.FromArgb(25, 25, 25);

        [Browsable(false)]
        public Color[] AryanNonestateColors
        {
            get { return aryanNonestateColors; }
            set { aryanNonestateColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] AryanDownstateColors
        {
            get { return aryanDownstateColors; }
            set { aryanDownstateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] AryanOverstateColors
        {
            get { return aryanOverstateColors; }
            set { aryanOverstateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] AryanBorderColors
        {
            get { return aryanBorderColors; }
            set { aryanBorderColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color Background
        {
            get { return background; }
            set { background = value; Invalidate(); }
        }
        //Color T1 = Color.Red;
        

        private void AryanPaint()
        {
            G.Clear(background);
            switch (State)
            {
                case MouseState.None:
                    //None
                    DrawGradient(Color.FromArgb(25, 25, 25), Color.FromArgb(50, 50, 50), ClientRectangle, 90);
                    Cursor = Cursors.Arrow;
                    break;
                case MouseState.Down:
                    //Down
                    DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(42, 42, 42), ClientRectangle, 90);
                    Cursor = Cursors.Hand;
                    break;
                case MouseState.Over:
                    //Over
                    DrawGradient(Color.FromArgb(42, 42, 42), Color.FromArgb(50, 50, 50), ClientRectangle, 90);
                    Cursor = Cursors.Hand;
                    break;
            }
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(59, 59, 59))), 1);
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(25, 25, 25))));
            DrawCorners(Color.FromArgb(35, 35, 35));
            //DrawText(new SolidBrush(T1), HorizontalAlignment.Center, 0, 0);
        }
    }

}
