// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Meph.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        
        
        private void MephPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            G.Clear(BackColor);
            Font drawFont = new Font("Verdana", 8, FontStyle.Regular);

            //G.FillPath(new SolidBrush(Color.FromArgb(40, 40, 40)), Draw.RoundRect(ClientRectangle, 3));
            //G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), Draw.RoundRect(ClientRectangle, 3));
            //G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 3));

            switch (State)
            {
                case MouseState.None:

                    G.FillPath(new SolidBrush(Color.FromArgb(40, 40, 40)), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 3));

                    //G.DrawString(Text, drawFont, Brushes.Silver, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    G.FillPath(new SolidBrush(Color.FromArgb(30, 30, 30)), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 3));

                    //G.DrawString(Text, drawFont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                break;
                case MouseState.Down:
                    G.FillPath(new SolidBrush(Color.FromArgb(25, 25, 25)), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 3));

                    //G.DrawString(Text, drawFont, Brushes.Gray, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }



    }

}

