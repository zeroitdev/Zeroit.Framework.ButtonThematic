// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="FlatUI.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

        #region " Variables"

        private int flatUIWidth;
        private int flatUIHeight;
        private bool flatUIRounded = false;

        #endregion

        #region " Properties"

        #region " Colors"

        [Browsable(false)]
        [Category("Colors")]
        public Color FlatUIBaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Browsable(false)]
        [Category("Options")]
        public bool FlatUIRounded
        {
            get { return flatUIRounded; }
            set { flatUIRounded = value; }
        }

        #endregion

        
        #endregion

        #region " Colors"

        private Color _BaseColor = Color.FromArgb(35, 168, 109);

        #endregion

        
        private void FlatUIPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            flatUIWidth = Width - 1;
            flatUIHeight = Height - 1;

            GraphicsPath GP = new GraphicsPath();
            Rectangle Base = new Rectangle(0, 0, flatUIWidth, flatUIHeight);

            
            //G.SmoothingMode = SmoothingMode.HighQuality;
            //G.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //G.TextRenderingHint = TextRendering;
            G.Clear(Parent.BackColor);


            StringFormat CenterSF = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center

            };

            switch (State)
            {
                case MouseState.None:
                    if (FlatUIRounded)
                    {
                        //-- Base
                        GP = Draw.RoundRec(Base, 6);
                        G.FillPath(new SolidBrush(_BaseColor), GP);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, CenterSF);
                    }
                    else
                    {
                        //-- Base
                        G.FillRectangle(new SolidBrush(_BaseColor), Base);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, CenterSF);
                    }
                    break;
                case MouseState.Over:
                    if (FlatUIRounded)
                    {
                        //-- Base
                        GP = Draw.RoundRec(Base, 6);
                        G.FillPath(new SolidBrush(_BaseColor), GP);
                        G.FillPath(new SolidBrush(Color.FromArgb(20, Color.White)), GP);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, CenterSF);
                    }
                    else
                    {
                        //-- Base
                        G.FillRectangle(new SolidBrush(_BaseColor), Base);
                        G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), Base);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, CenterSF);
                    }
                    break;
                case MouseState.Down:
                    if (FlatUIRounded)
                    {
                        //-- Base
                        GP = Draw.RoundRec(Base, 6);
                        G.FillPath(new SolidBrush(_BaseColor), GP);
                        G.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), GP);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, CenterSF);
                    }
                    else
                    {
                        //-- Base
                        G.FillRectangle(new SolidBrush(_BaseColor), Base);
                        G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), Base);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, CenterSF);
                    }
                    break;
            }

            
            e.Graphics.InterpolationMode = (InterpolationMode)7;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            //B.Dispose();
            //G.Dispose();
            
        }


    }

}

