﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Adobe.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Adobe : UserControl
    {
        public UserControl_Adobe()
        {
            InitializeComponent();
        }

        private void customizableAdobe_Coefficient_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomizableAdobeCoefficient = (int)customizableAdobe_Coefficient_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customizableAdobeColors_0_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdobeColors_0.BackColor = color.Color;
                previewBtn.CustomizableAdobeColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdobeColors_1_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdobeColors_1.BackColor = color.Color;
                previewBtn.CustomizableAdobeColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdobeColors_2_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdobeColors_2.BackColor = color.Color;
                previewBtn.CustomizableAdobeColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdobeColors_3_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdobeColors_3.BackColor = color.Color;
                previewBtn.CustomizableAdobeColors[3] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdobeColors_4_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdobeColors_4.BackColor = color.Color;
                previewBtn.CustomizableAdobeColors[4] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdobeColors_5_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdobeColors_5.BackColor = color.Color;
                previewBtn.CustomizableAdobeColors[5] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdobeBackground_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdobeBackground.BackColor = color.Color;
                previewBtn.CustomizableAdobeBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdobeColors_0_MouseEnter(object sender, EventArgs e)
        {
            customizableAdobeColors_0.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdobeColors_0_MouseLeave(object sender, EventArgs e)
        {
            customizableAdobeColors_0.FlatAppearance.BorderSize = 0;
        }

        private void customizableAdobeColors_1_MouseEnter(object sender, EventArgs e)
        {
            customizableAdobeColors_1.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdobeColors_1_MouseLeave(object sender, EventArgs e)
        {
            customizableAdobeColors_1.FlatAppearance.BorderSize = 0;
        }

        private void customizableAdobeColors_2_MouseEnter(object sender, EventArgs e)
        {
            customizableAdobeColors_2.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdobeColors_2_MouseLeave(object sender, EventArgs e)
        {
            customizableAdobeColors_2.FlatAppearance.BorderSize = 0;
        }

        private void customizableAdobeColors_3_MouseEnter(object sender, EventArgs e)
        {
            customizableAdobeColors_3.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdobeColors_3_MouseLeave(object sender, EventArgs e)
        {
            customizableAdobeColors_3.FlatAppearance.BorderSize = 0;
        }

        private void customizableAdobeColors_4_MouseEnter(object sender, EventArgs e)
        {
            customizableAdobeColors_4.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdobeColors_4_MouseLeave(object sender, EventArgs e)
        {
            customizableAdobeColors_4.FlatAppearance.BorderSize = 0;
        }

        private void customizableAdobeColors_5_MouseEnter(object sender, EventArgs e)
        {
            customizableAdobeColors_5.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdobeColors_5_MouseLeave(object sender, EventArgs e)
        {
            customizableAdobeColors_5.FlatAppearance.BorderSize = 0;
        }

        private void customizableAdobeBackground_MouseEnter(object sender, EventArgs e)
        {
            customizableAdobeBackground.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdobeBackground_MouseLeave(object sender, EventArgs e)
        {
            customizableAdobeBackground.FlatAppearance.BorderSize = 0;
        }
    }
}
