// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="FireFox.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {


        #region Private
        private Color fireFoxETC;
        #endregion
        

        #region " Control "
        
        private void FireFoxPaint(PaintEventArgs e)
        {
            
            G.Clear(Parent.BackColor);

            if (Enabled)
            {
                fireFoxETC = Color.FromArgb(56, 68, 80);

                switch (State)
                {

                    case MouseState.None:

                        using (SolidBrush B = new SolidBrush(Draw.GreyColor(245)))
                        {
                            G.FillRectangle(B, new Rectangle(1, 1, Width - 2, Height - 2));
                        }


                        Draw.DrawRoundRect(G, Draw.FullRectangle(Size, true), 2, Draw.GreyColor(193));

                        break;
                    case MouseState.Over:

                        using (SolidBrush B = new SolidBrush(Draw.GreyColor(232)))
                        {
                            G.FillRectangle(B, new Rectangle(1, 1, Width - 2, Height - 2));
                        }


                        Draw.DrawRoundRect(G, Draw.FullRectangle(Size, true), 2, Draw.GreyColor(193));

                        break;
                    default:

                        using (SolidBrush B = new SolidBrush(Draw.GreyColor(212)))
                        {
                            G.FillRectangle(B, new Rectangle(1, 1, Width - 2, Height - 2));
                        }


                        Draw.DrawRoundRect(G, Draw.FullRectangle(Size, true), 2, Draw.GreyColor(193));

                        break;
                }

            }
            else
            {
                fireFoxETC = Draw.GreyColor(170);

                using (SolidBrush B = new SolidBrush(Draw.GreyColor(245)))
                {
                    G.FillRectangle(B, new Rectangle(1, 1, Width - 2, Height - 2));
                }

                Draw.DrawRoundRect(G, Draw.FullRectangle(Size, true), 2, Draw.GreyColor(223));

            }

            //Draw.CenterString(G, Text, Theme.GlobalFont, fireFoxETC, Draw.FullRectangle(Size, false));

        }
        
        #endregion


    }

}

