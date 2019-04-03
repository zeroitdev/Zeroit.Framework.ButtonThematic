// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Element.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        
        
        

        #region " Properties "

        private Color elementBaseColor = Color.FromArgb(231, 75, 60);

        [Browsable(false)]
        public Color ElementBaseColor
        {
            get { return elementBaseColor; }
            set { elementBaseColor = value;
                Invalidate();
            }
        }


        #endregion
        
        private void ElementOnPaint(PaintEventArgs e)
        {
            
            G.Clear(elementBaseColor);

            switch (State)
            {
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(0, 0, Width, Height));

                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), new Rectangle(0, 0, Width, Height));
                    break;
            }

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            //G.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(0, 0, Width, Height), _StringF);

        }


    }

}

