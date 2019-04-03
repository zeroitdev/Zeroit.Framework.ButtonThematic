// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Roaster.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Roaster : UserControl
    {
        public UserControl_Roaster()
        {
            InitializeComponent();
        }

        private void customRoaster_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRoaster_BorderColor_Btn.BackColor = color.Color;
                previewBtn.CustomRoasterBorderColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRoaster_GradientColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRoaster_GradientColors0_Btn.BackColor = color.Color;
                previewBtn.CustomRoasterGradientColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRoaster_GradientColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRoaster_GradientColors1_Btn.BackColor = color.Color;
                previewBtn.CustomRoasterGradientColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRoaster_GradientColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRoaster_GradientColors2_Btn.BackColor = color.Color;
                previewBtn.CustomRoasterGradientColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRoaster_GradientColors3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRoaster_GradientColors3_Btn.BackColor = color.Color;
                previewBtn.CustomRoasterGradientColors[3] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRoaster_BackgroundStateColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRoaster_BackgroundStateColors0_Btn.BackColor = color.Color;
                previewBtn.CustomRoasterBackgroundStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRoaster_BackgroundStateColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRoaster_BackgroundStateColors1_Btn.BackColor = color.Color;
                previewBtn.CustomRoasterBackgroundStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
