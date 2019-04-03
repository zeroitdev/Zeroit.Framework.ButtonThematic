// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Advantium.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Advantium : UserControl
    {
        public UserControl_Advantium()
        {
            InitializeComponent();

            
        }

        private void customAdvantium_Offset1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomAdvantiumOffsets[0] = (int)customAdvantium_Offset1_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customAdvantium_Offset2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomAdvantiumOffsets[1] = (int)customAdvantium_Offset2_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customAdvantium_Offset3_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomAdvantiumOffsets[2] = (int)customAdvantium_Offset3_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customAdvantium_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_BorderColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_BorderColors2_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumBorderColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_Background_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_NoneColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_NoneColors0_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumNoneColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_NoneColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_NoneColors1_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumNoneColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_OverColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_OverColors0_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumOverColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_OverColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_OverColors1_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumOverColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_DownColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_DownColors0_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumDownColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_DownColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAdvantium_DownColors1_Btn.BackColor = color.Color;
                previewBtn.CustomAdvantiumDownColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAdvantium_BorderColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_BorderColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAdvantium_BorderColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_BorderColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAdvantium_BorderColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_BorderColors1_Btn.FlatAppearance.BorderSize = 1;
            
        }

        private void customAdvantium_BorderColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_BorderColors1_Btn.FlatAppearance.BorderSize = 0;

        }

        private void customAdvantium_BorderColors2_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_BorderColors2_Btn.FlatAppearance.BorderSize = 1;

        }

        private void customAdvantium_BorderColors2_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_BorderColors2_Btn.FlatAppearance.BorderSize = 0;

        }

        private void customAdvantium_NoneColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_NoneColors0_Btn.FlatAppearance.BorderSize = 1;

        }

        private void customAdvantium_NoneColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_NoneColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAdvantium_NoneColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_NoneColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAdvantium_NoneColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_NoneColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAdvantium_OverColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_OverColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAdvantium_OverColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_OverColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAdvantium_OverColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_OverColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAdvantium_OverColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_OverColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAdvantium_DownColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_DownColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAdvantium_DownColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_DownColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAdvantium_DownColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_DownColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAdvantium_DownColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_DownColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAdvantium_Background_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAdvantium_Background_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAdvantium_Background_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAdvantium_Background_Btn.FlatAppearance.BorderSize = 0;
        }
    }
}
