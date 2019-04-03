// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="04. CustomAresio.cs" company="Zeroit Dev Technologies">
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
    /// <summary>
    /// Class AresioButton.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ButtonThematic
    {

        #region Private Fields

        //private Color[] customAresioBorderColors = new Color[]
        //{
        //    Color.FromArgb(50,Color.White),
        //    Color.FromArgb(150, 100, 70)
        //};


        //private Color[] customAresioNoneColors = new Color[]
        //{
        //    Color.FromArgb(250, 200, 70),
        //    Color.FromArgb(250, 160, 40)
        //};

        //private Color[] customAresioOverColors = new Color[]
        //{
        //    Color.FromArgb(50, Color.White),
        //    Color.Transparent
        //};

        //private Color[] customAresioDownColors = new Color[]
        //{
        //    Color.FromArgb(50, Color.Black),
        //    Color.Transparent
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom aresio border colors.
        /// </summary>
        /// <value>The custom aresio border colors.</value>
        [Browsable(false)]
        public Color[] CustomAresioBorderColors
        {
            get { return buttonInput.CustomAresioBorderColors; }
            set
            {
                buttonInput.CustomAresioBorderColors = value;
                Invalidate();
            }
        }

        //public int CustomAresioCurve
        //{
        //    get { return Curve; }
        //    set
        //    {
        //        Curve = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the custom aresio none colors.
        /// </summary>
        /// <value>The custom aresio none colors.</value>
        [Browsable(false)]
        public Color[] CustomAresioNoneColors
        {
            get { return buttonInput.CustomAresioNoneColors; }
            set { buttonInput.CustomAresioNoneColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom aresio over colors.
        /// </summary>
        /// <value>The custom aresio over colors.</value>
        [Browsable(false)]
        public Color[] CustomAresioOverColors
        {
            get { return buttonInput.CustomAresioOverColors; }
            set { buttonInput.CustomAresioOverColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom aresio down colors.
        /// </summary>
        /// <value>The custom aresio down colors.</value>
        [Browsable(false)]
        public Color[] CustomAresioDownColors
        {
            get { return buttonInput.CustomAresioDownColors; }
            set
            {
                buttonInput.CustomAresioDownColors = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        /// <summary>
        /// Customs the aresio paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void CustomAresioPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);

            G.DrawPath(DesignFunctions.ToPen(CustomAresioBorderColors[0]), DesignFunctions.RoundRect(0, 1, Width - 1, Height - 2, Curve));
            G.DrawPath(DesignFunctions.ToPen(CustomAresioBorderColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
            switch (Enabled)
            {
                case true:
                    switch (State)
                    {
                        case MouseState.None:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioNoneColors[0], CustomAresioNoneColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                        case MouseState.Over:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioOverColors[0], CustomAresioOverColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                        case MouseState.Down:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioDownColors[0], CustomAresioDownColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                    }

                    break;
                case false:
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.White, new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)) + 1, Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2)) + 1));
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.Gray, new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2))));
                    break;
            }

        }

        #endregion

    }


}
