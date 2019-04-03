using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields

        private Color customBitDefenderC1 = Color.FromArgb(100, 41, 41, 41);
        private Color customBitDefenderC2 = Color.White;
        private Color customBitDefenderC3 = Color.FromArgb(101, 101, 101);
        private Color customBitDefenderC4 = Color.FromArgb(60, 60, 60);
        private Color customBitDefenderC5 = Color.FromArgb(28, 28, 28);
        private Color customBitDefenderC6 = Color.FromArgb(45, 45, 45);
        private Color customBitDefenderBorder = Color.Black;
        private Rectangle customBitDefenderR1;
        private Rectangle customBitDefenderR2;
        private Rectangle customBitDefenderR3;
        private GraphicsPath customBitDefenderGP1;
        private GraphicsPath customBitDefenderGP2;
        private GraphicsPath customBitDefenderGP3;
        private SolidBrush customBitDefenderB1;
        private SolidBrush customBitDefenderB2;
        private Pen customBitDefenderP1;
        private Pen customBitDefenderP2;
        private LinearGradientBrush customBitDefenderLGB1;
        private LinearGradientBrush customBitDefenderLGB2;

        //private int curve = 11;
        private Color customBitDefenderFadeColor = Color.White;
        private bool customBitDefDown;

        private Thread customOpenT;


        #endregion

        #region Public Properties
        private bool CustomBitDefDown
        {
            get { return customBitDefDown; }
            set
            {
                customBitDefDown = value;
                Invalidate();
            }
        }

        //public int Curve
        //{
        //    get { return Curve; }
        //    set
        //    {
        //        Curve = value;
        //        Invalidate();
        //    }
        //}

        public Color CustomBitDefenderC1
        {
            get { return customBitDefenderC1; }
            set { customBitDefenderC1 = value; Invalidate(); }
        }

        public Color CustomBitDefenderC2
        {
            get { return customBitDefenderC2; }
            set { customBitDefenderC2 = value; Invalidate(); }
        }

        public Color CustomBitDefenderC3
        {
            get { return customBitDefenderC3; }
            set { customBitDefenderC3 = value; Invalidate(); }
        }

        public Color CustomBitDefenderC4
        {
            get { return customBitDefenderC4; }
            set { customBitDefenderC4 = value; Invalidate(); }
        }

        public Color CustomBitDefenderC5
        {
            get { return customBitDefenderC5; }
            set { customBitDefenderC5 = value; Invalidate(); }
        }

        public Color CustomBitDefenderC6
        {
            get { return customBitDefenderC6; }
            set { customBitDefenderC6 = value; Invalidate(); }
        }

        public Color CustomBitDefenderBorder
        {
            get { return customBitDefenderBorder; }
            set { customBitDefenderBorder = value; Invalidate(); }
        }

        public Color CustomBitDefenderFadeColor
        {
            get { return customBitDefenderFadeColor; }
            set
            {
                customBitDefenderFadeColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Mouse Events and Animation

        private void CustomBitDefenderOnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            customOpenT = new Thread(CustomEnterAnimation);
            if (!customOpenT.IsAlive)
            {
                customOpenT.IsBackground = true;
                customOpenT.Start();
            }
        }

        private void CustomBitDefenderOnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            CustomBitDefDown = true;
        }

        private void CustomBitDefenderOnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            CustomBitDefDown = false;
        }
        
        private void CustomEnterAnimation()
        {
            Graphics G = this.CreateGraphics();
            customBitDefenderR2 = new Rectangle(5, 5, Width - 10, Height - 10);
            customBitDefenderGP2 = Helper.RoundRect(customBitDefenderR2, Curve);
            G.SetClip(customBitDefenderGP2);
            for (int fade = 0; fade <= 5; fade += Convert.ToInt32(0.85f))
            {
                Thread.Sleep(50);
                G.FillRectangle(new SolidBrush(Color.FromArgb(fade, CustomBitDefenderFadeColor)), ClientRectangle);
            }
        }

        #endregion
        
        #region Paint
        
        private void CustomInit()
        {

            customBitDefenderR1 = new Rectangle(3, 3, Width - 6, Height - 6);
            customBitDefenderR2 = new Rectangle(5, 5, Width - 10, Height - 10);
            customBitDefenderR3 = new Rectangle(6, 6, Width - 12, Height - 12);

            customBitDefenderGP1 = Helper.RoundRect(customBitDefenderR1, Curve);
            customBitDefenderGP2 = Helper.RoundRect(customBitDefenderR2, Curve);
            customBitDefenderGP3 = Helper.RoundRect(customBitDefenderR3, Curve);

            customBitDefenderB1 = new SolidBrush(customBitDefenderC1);
            customBitDefenderB2 = new SolidBrush(customBitDefenderC2);
            customBitDefenderLGB1 = new LinearGradientBrush(customBitDefenderR2, customBitDefenderC4, customBitDefenderC5, LinearGradientMode.Vertical);
            customBitDefenderLGB2 = new LinearGradientBrush(customBitDefenderR3, customBitDefenderC3, customBitDefenderC6, LinearGradientMode.Vertical);

            customBitDefenderP1 = new Pen(customBitDefenderBorder);
            customBitDefenderP2 = new Pen(customBitDefenderLGB2);

        }
        
        private void CustomBitDefenderPaint(PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);
            CustomInit();
            G.FillPath(customBitDefenderB1, customBitDefenderGP1);
            G.FillPath(customBitDefenderLGB1, customBitDefenderGP2);
            G.DrawPath(customBitDefenderP1, customBitDefenderGP2);
            G.DrawPath(customBitDefenderP2, customBitDefenderGP3);
            if (!CustomBitDefDown)
            {
                //G.DrawString(Text, Font, customBitDefenderB2, customBitDefenderR3, BitDefenderSF1);
            }
            else
            {
                customBitDefenderR3.X += 1;
                customBitDefenderR3.Y += 1;
                //G.DrawString(Text, Font, customBitDefenderB2, customBitDefenderR3, BitDefenderSF1);
            }


        }
        
        #endregion
        

    }

}
