// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="FireFox.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

