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
        Color customOrainsInnerBorder = Color.FromArgb(40, 40, 40);
        Color customOrainsHeader = Color.FromArgb(40, 40, 40);
        Color customOrainsOuterBorder = Color.Black;

        private Color[] customOrainsButton = new Color[]
        {
            Color.FromArgb(35, 35, 35),
            Color.FromArgb(20, 20, 20)
        };

        private Color[] customOrainsHatch = new Color[]
        {
            Color.Black,
            Color.Transparent
        };
        #endregion

        #region Public Properties
        public Color[] CustomOrainsHatch
        {
            get { return customOrainsHatch; }
            set
            {
                customOrainsHatch = value;
                Invalidate();
            }
        }

        public Color[] CustomOrainsButton
        {
            get { return customOrainsButton; }
            set { customOrainsButton = value; Invalidate(); }
        }

        public Color CustomOrainsInnerBorder
        {
            get { return customOrainsInnerBorder; }
            set { customOrainsInnerBorder = value; Invalidate(); }
        }

        public Color CustomOrainsHeader
        {
            get { return customOrainsHeader; }
            set { customOrainsHeader = value; Invalidate(); }
        }

        public Color CustomOrainsOuterBorder
        {
            get { return customOrainsOuterBorder; }
            set { customOrainsOuterBorder = value; Invalidate(); }
        }
        #endregion

        #region Paint
        private void CustomOrainsPaintHook()
        {
            //G.Clear(BackColor)


            switch (State)
            {
                case MouseState.None:

                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[0], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 0, 0);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(CustomOrainsInnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Over:

                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[0], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB1, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch1 = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch1, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -1, -1);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(45, CustomOrainsInnerBorder /*45, 45, 45*/)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Down:
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), CustomOrainsButton[1], CustomOrainsButton[1], 90);
                    G.FillRectangle(LGB2, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch2 = new HatchBrush(HatchStyle, Color.FromArgb(30, CustomOrainsHatch[0]), CustomOrainsHatch[1]);
                    G.FillRectangle(BodyHatch2, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 1, 1);

                    G.DrawRectangle(new Pen(CustomOrainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(32, CustomOrainsInnerBorder /*32, 32, 32*/)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
            }




            //Dim BodyHatch As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent)
            // G.FillRectangle(BodyHatch, New Rectangle(0, 0, Width - 1, Height - 1))
        }

        #endregion

    }

}

