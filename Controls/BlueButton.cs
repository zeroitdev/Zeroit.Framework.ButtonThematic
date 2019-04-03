// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BlueButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        
        private Color blueC1 = Color.FromArgb(99, 123, 173);
        private Color blueC2 = Color.FromArgb(79, 106, 163);
        private Color sideColor = Color.FromArgb(41, 68, 126);
        private Color downColor = Color.FromArgb(41, 68, 126);
        private Color upperColor = Color.FromArgb(41, 68, 126);

        [Browsable(false)]
        public Color BlueC1
        {
            get { return blueC1; }
            set { blueC1 = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color BlueC2
        {
            get { return blueC2; }
            set { blueC2 = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color SideColor
        {
            get { return sideColor; }
            set { sideColor = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color DownColor
        {
            get { return downColor; }
            set { downColor = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color UpperColor
        {
            get { return upperColor; }
            set { upperColor = value;
                Invalidate();
            }
        }

        private void BluePaint()
        {
            G.Clear(BlueC1);
            if (State == MouseState.Down)
            {
                G.Clear(BlueC2);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            }
            else
            {
                G.DrawLine(new Pen(UpperColor), 1, 1, Width, 1);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            }
            G.DrawLine(new Pen(SideColor), 0, 0, Width, 0);
            G.DrawLine(new Pen(SideColor), 0, 0, 0, Height - 2);
            G.DrawLine(new Pen(SideColor), 0, Height - 2, Width, Height - 2);
            G.DrawLine(new Pen(SideColor), Width - 1, 0, Width - 1, Height - 2);
            G.DrawLine(new Pen(DownColor), 0, Height - 1, Width, Height - 1);
        }


    }


}
