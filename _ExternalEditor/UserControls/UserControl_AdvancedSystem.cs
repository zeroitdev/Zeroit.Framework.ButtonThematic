// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_AdvancedSystem.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_AdvancedSystem : UserControl
    {
        public UserControl_AdvancedSystem()
        {
            InitializeComponent();
        }

        private void customizableAdvancedSystem_Glow_MouseEnter(object sender, EventArgs e)
        {
            customizableAdvancedSystem_Glow.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdvancedSystem_Glow_MouseLeave(object sender, EventArgs e)
        {
            customizableAdvancedSystem_Glow.FlatAppearance.BorderSize = 0;
        }

        private void customizableAdvancedSystem_BackColor_MouseEnter(object sender, EventArgs e)
        {
            customizableAdvancedSystem_BackColor.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdvancedSystem_BackColor_MouseLeave(object sender, EventArgs e)
        {
            customizableAdvancedSystem_BackColor.FlatAppearance.BorderSize = 0;
        }

        private void customizableAdvancedSystem_Dilution_MouseEnter(object sender, EventArgs e)
        {
            customizableAdvancedSystem_Dilution.FlatAppearance.BorderSize = 1;
        }

        private void customizableAdvancedSystem_Dilution_MouseLeave(object sender, EventArgs e)
        {
            customizableAdvancedSystem_Dilution.FlatAppearance.BorderSize = 0;
        }

        private void customizable_Slope_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomizableAdvancedSystemSlope = (int)customizable_Slope_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customizableAdvancedSystem_Glow_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdvancedSystem_Glow.BackColor = color.Color;
                previewBtn.CustomizableAdvancedSystemGlow = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdvancedSystem_BackColor_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdvancedSystem_BackColor.BackColor = color.Color;
                previewBtn.CustomizableAdvSysBackColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizableAdvancedSystem_Dilution_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizableAdvancedSystem_Dilution.BackColor = color.Color;
                previewBtn.CustomAdvSysColorDilution = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
