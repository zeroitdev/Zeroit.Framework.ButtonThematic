// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ChromeButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        
        Color chromeGradTopNormal = Color.FromArgb(237, 237, 237);
        Color chromeGradTopOver = Color.FromArgb(242, 242, 242);
        Color chromeGradTopDown = Color.FromArgb(235, 235, 235);
        Color chromeGradBottomNormal = Color.FromArgb(230, 230, 230);
        Color chromeGradBottomOver = Color.FromArgb(235, 235, 235);
        Color chromeGradBottomDown = Color.FromArgb(223, 223, 223);
        Color chromeBorder = Color.FromArgb(167, 167, 167);
        Color chromeTextNormal = Color.FromArgb(60, 60, 60);
        Color chromeTextDown = Color.FromArgb(20, 20, 20);
        Color chromeTextDownOver = Color.Gray;
        

        private void ChromePaintHook()
        {
            G.Clear(BackColor);
            LinearGradientBrush LGB = default(LinearGradientBrush);
            G.SmoothingMode = SmoothingMode.HighQuality;


            switch (State)
            {
                case MouseState.None:
                    LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), chromeGradTopNormal, chromeGradBottomNormal, 90f);
                    break;
                case MouseState.Over:
                    LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), chromeGradTopOver, chromeGradBottomOver, 90f);
                    break;
                default:
                    LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), chromeGradTopDown, chromeGradBottomDown, 90f);
                    break;
            }

            if (!Enabled)
            {
                LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), chromeGradTopNormal, chromeGradBottomNormal, 90f);
            }

            GraphicsPath buttonpath = CreateRound(Rectangle.Round(LGB.Rectangle), 3);
            G.FillPath(LGB, CreateRound(Rectangle.Round(LGB.Rectangle), 3));
            if (!Enabled)
                G.FillPath(new SolidBrush(Color.FromArgb(50, Color.White)), CreateRound(Rectangle.Round(LGB.Rectangle), 3));
            G.SetClip(buttonpath);
            LGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height / 6), Color.FromArgb(80, Color.White), Color.Transparent, 90f);
            G.FillRectangle(LGB, Rectangle.Round(LGB.Rectangle));



            G.ResetClip();
            G.DrawPath(new Pen(chromeBorder), buttonpath);

            if (Enabled)
            {
                switch (State)
                {
                    case MouseState.None:
                        //DrawText(new SolidBrush(chromeTextNormal), HorizontalAlignment.Center, 1, 0);
                        break;
                    default:
                        //DrawText(new SolidBrush(chromeTextDownOver), HorizontalAlignment.Center, 1, 0);
                        break;
                }
            }
            else
            {
                //DrawText(new SolidBrush(chromeTextDown), HorizontalAlignment.Center, 1, 0);
            }
        }


    }


}

