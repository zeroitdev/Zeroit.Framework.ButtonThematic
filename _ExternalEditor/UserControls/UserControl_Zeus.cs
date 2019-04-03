// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Zeus.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Zeus : UserControl
    {
        public UserControl_Zeus()
        {
            InitializeComponent();
        }

        private void customZeus_ClickReduce_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomZeusClickReduce = (int)customZeus_ClickReduce_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customZeus_ClickLocate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomZeusClickLocate = (int)customZeus_ClickLocate_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customZeus_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_Background_Btn.BackColor = color.Color;
                previewBtn.CustomZeusBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customZeus_GradientColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_GradientColors0_Btn.BackColor = color.Color;
                previewBtn.CustomZeusGradientColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customZeus_GradientColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_GradientColors1_Btn.BackColor = color.Color;
                previewBtn.CustomZeusGradientColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customZeus_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomZeusBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customZeus_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomZeusBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
