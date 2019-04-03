// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Future.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Future : UserControl
    {
        public UserControl_Future()
        {
            InitializeComponent();
        }

        private void customFusion_GradColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_GradColors0_Btn.BackColor = color.Color;
                previewBtn.CustomFusionGradColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_GradColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_GradColors1_Btn.BackColor = color.Color;
                previewBtn.CustomFusionGradColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_BlendColor0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_BlendColor0_Btn.BackColor = color.Color;
                previewBtn.CustomFusionBlend.Colors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_BlendColor1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_BlendColor1_Btn.BackColor = color.Color;
                previewBtn.CustomFusionBlend.Colors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_BlendColor2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_BlendColor2_Btn.BackColor = color.Color;
                previewBtn.CustomFusionBlend.Colors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_Inactive_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_Inactive_Btn.BackColor = color.Color;
                previewBtn.CustomFusionNoneBorderColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_Hover_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_Hover_Btn.BackColor = color.Color;
                previewBtn.CustomFusionOverBorderColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_Pressed_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_Pressed_Btn.BackColor = color.Color;
                previewBtn.CustomFusionDownBorderColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_Corner_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customFusion_Corner_Btn.BackColor = color.Color;
                previewBtn.CustomFusionCornerColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customFusion_BlendPos1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomFusionBlend.Positions[0] = (float)customFusion_BlendPos1_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customFusion_BlendPos2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomFusionBlend.Positions[1] = (float)customFusion_BlendPos2_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customFusion_BlendPos3_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomFusionBlend.Positions[2] = (float)customFusion_BlendPos3_Numeric.Value;
            previewBtn.Invalidate();
        }
    }
}
