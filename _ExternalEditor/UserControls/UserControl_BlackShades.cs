// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_BlackShades.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    [ToolboxItem(false)]
    public partial class UserControl_BlackShades : UserControl
    {
        public UserControl_BlackShades()
        {
            InitializeComponent();
        }

        private void customBlackShades_NoneColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_NoneColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesNoneColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_NoneColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_NoneColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesNoneColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_NoneColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_NoneColors2_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesNoneColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_NoneColors3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_NoneColors3_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesNoneColors[3] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_NoneColors4_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_NoneColors4_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesNoneColors[4] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_NoneColors5_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_NoneColors5_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesNoneColors[5] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_NoneColors6_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_NoneColors6_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesNoneColors[6] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors2_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors3_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[3] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors4_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors4_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[4] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors5_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors5_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[5] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors6_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors6_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[6] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors7_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors7_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[7] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_DownColors8_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_DownColors8_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesDownColors[8] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors2_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors3_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[3] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors4_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors4_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[4] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors5_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors5_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[5] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors6_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors6_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[6] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors7_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors7_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[7] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBlackShades_OverColors8_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBlackShades_OverColors8_Btn.BackColor = color.Color;
                previewBtn.CustomBlackShadesOverColors[8] = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
