// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_AdvancedSystem.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
