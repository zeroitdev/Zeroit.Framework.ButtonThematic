// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="MetroDisk.cs" company="Zeroit Dev Technologies">
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

        private int metrodiskWidth;
        private int metrodiskHeight;
        private bool metrodiskRounded = false;

        #endregion

        #region " Properties"

        #region " Colors"
        [Browsable(false)]
        [Category("Colors")]
        public Color metrodiskBaseColor
        {
            get { return metroDiskBaseColor; }
            set { metroDiskBaseColor = value; }
        }

        [Browsable(false)]
        [Category("Options")]
        public bool MetrodiskRounded
        {
            get { return metrodiskRounded; }
            set { metrodiskRounded = value; }
        }

        #endregion

        
        #endregion

        #region " Colors"

        private Color metroDiskBaseColor = Color.FromArgb(35, 168, 109);

        #endregion

        
        private void MetroDiskPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            metrodiskWidth = Width - 1;
            metrodiskHeight = Height - 1;

            GraphicsPath GP = new GraphicsPath();
            Rectangle Base = new Rectangle(0, 0, metrodiskWidth, metrodiskHeight);

            
            G.Clear(BackColor);

            switch (State)
            {
                case MouseState.None:
                    if (MetrodiskRounded)
                    {
                        //-- Base
                        GP = Draw.RoundRec(Base, 6);
                        G.FillPath(new SolidBrush(metroDiskBaseColor), GP);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, Draw.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        G.FillRectangle(new SolidBrush(metroDiskBaseColor), Base);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, Draw.CenterSF);
                    }
                    break;
                case MouseState.Over:
                    if (MetrodiskRounded)
                    {
                        //-- Base
                        GP = Draw.RoundRec(Base, 6);
                        G.FillPath(new SolidBrush(metroDiskBaseColor), GP);
                        G.FillPath(new SolidBrush(Color.FromArgb(20, Color.White)), GP);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, Draw.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        G.FillRectangle(new SolidBrush(metroDiskBaseColor), Base);
                        G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), Base);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, Draw.CenterSF);
                    }
                    break;
                case MouseState.Down:
                    if (MetrodiskRounded)
                    {
                        //-- Base
                        GP = Draw.RoundRec(Base, 6);
                        G.FillPath(new SolidBrush(metroDiskBaseColor), GP);
                        G.FillPath(new SolidBrush(Color.FromArgb(20, Color.Black)), GP);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, Draw.CenterSF);
                    }
                    else
                    {
                        //-- Base
                        G.FillRectangle(new SolidBrush(metroDiskBaseColor), Base);
                        G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), Base);

                        //-- Text
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), Base, Draw.CenterSF);
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

