// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BitDefenderButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region "Init"
        public void BitdefenderButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            Width = 100;
            Height = 55;
            BackColor = Color.Transparent;
        }


       
        //private bool _Down;
        //private bool Down
        //{
        //    get { return _Down; }
        //    set
        //    {
        //        _Down = value;
        //        Invalidate();
        //    }
        //}
        //private void BitDefenderOnMouseDown(MouseEventArgs e)
        //{
        //    base.OnMouseDown(e);
        //    Down = true;
        //}

        //private void BitDefenderOnMouseUp(MouseEventArgs e)
        //{
        //    base.OnMouseUp(e);
        //    Down = false;
        //}

        #region "Mouse state"

        private Thread OpenT;
        private void BitDefenderOnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            OpenT = new Thread(EnterAnimation);
            if (!OpenT.IsAlive)
            {
                OpenT.IsBackground = true;
                OpenT.Start();
            }
        }


        private void EnterAnimation()
        {
            Graphics G = this.CreateGraphics();
            BitDefenderR2 = new Rectangle(5, 5, Width - 10, Height - 10);
            BitDefenderGP2 = Helper.RoundRect(BitDefenderR2, 11);
            G.SetClip(BitDefenderGP2);
            for (int fade = 0; fade <= 5; fade += Convert.ToInt32(0.85f))
            {
                Thread.Sleep(50);
                G.FillRectangle(new SolidBrush(Color.FromArgb(fade, Color.White)), ClientRectangle);
            }
        }


        #endregion

        #endregion


        #region "Draw"
        #region "Draw init Object"
        private Color BitDefenderC1 = Color.FromArgb(100, 41, 41, 41);
        private Color BitDefenderC3 = Color.FromArgb(101, 101, 101);
        private Color BitDefenderC4 = Color.FromArgb(60, 60, 60);
        private Color BitDefenderC5 = Color.FromArgb(28, 28, 28);
        private Color BitDefenderC6 = Color.FromArgb(45, 45, 45);

        
        private Rectangle BitDefenderR2;
        GraphicsPath BitDefenderGP2;

        #endregion

        private void BitDefenderPaint(PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);
            
            Rectangle BitDefenderR1 = new Rectangle(3, 3, Width - 6, Height - 6);
            BitDefenderR2 = new Rectangle(5, 5, Width - 10, Height - 10);
            Rectangle BitDefenderR3 = new Rectangle(6, 6, Width - 12, Height - 12);

            GraphicsPath BitDefenderGP1 = Helper.RoundRect(BitDefenderR1, 11);
            GraphicsPath BitDefenderGP3 = Helper.RoundRect(BitDefenderR3, 11);
            SolidBrush BitDefenderB1 = new SolidBrush(BitDefenderC1);
            SolidBrush BitDefenderB2 = new SolidBrush(Color.White);
            LinearGradientBrush BitDefenderLGB1 = new LinearGradientBrush(BitDefenderR2, BitDefenderC4, BitDefenderC5, LinearGradientMode.Vertical);
            LinearGradientBrush BitDefenderLGB2 = new LinearGradientBrush(BitDefenderR3, BitDefenderC3, BitDefenderC6, LinearGradientMode.Vertical);
            Pen BitDefenderP1 = new Pen(Color.Black);
            Pen BitDefenderP2 = new Pen(BitDefenderLGB2);
            StringFormat BitDefenderSF1 = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.Character
            };

            BitDefenderGP2 = Helper.RoundRect(BitDefenderR2, 11);
            
            G.FillPath(BitDefenderB1, BitDefenderGP1);
            G.FillPath(BitDefenderLGB1, BitDefenderGP2);
            G.DrawPath(BitDefenderP1, BitDefenderGP2);
            G.DrawPath(BitDefenderP2, BitDefenderGP3);
            
            //if (!Down)
            //{
            //    //G.DrawString(Text, Font, BitDefenderB2, BitDefenderR3, BitDefenderSF1);
            //}
            //else
            //{
            //    BitDefenderR3.X += 1;
            //    BitDefenderR3.Y += 1;
            //    //G.DrawString(Text, Font, BitDefenderB2, BitDefenderR3, BitDefenderSF1);
            //}

            if (State != MouseState.Down)
            {
                //G.DrawString(Text, Font, BitDefenderB2, BitDefenderR3, BitDefenderSF1);
            }
            else
            {
                BitDefenderR3.X += 1;
                BitDefenderR3.Y += 1;
                //G.DrawString(Text, Font, BitDefenderB2, BitDefenderR3, BitDefenderSF1);
            }


        }


        #endregion

    }

}
