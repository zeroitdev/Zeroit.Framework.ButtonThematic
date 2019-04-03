// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Mizer.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Mizer : UserControl
    {
        public UserControl_Mizer()
        {
            InitializeComponent();
        }

        private void UserControl_Intel_Load(object sender, EventArgs e)
        {

        }

        private void customizedBtn_Inactive_Border_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_Inactive_Border_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnInactiveBorder = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_Inactive_Colors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_Inactive_Colors0_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnInactive[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_Inactive_Colors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_Inactive_Colors1_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnInactive[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_OffsetBorder0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_OffsetBorder0_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnOffsetBorder[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_OffsetBorder1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_OffsetBorder1_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnOffsetBorder[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_ActiveColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_ActiveColors0_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnActive[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_ActiveColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_ActiveColors1_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnActive[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_PressedColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_PressedColors0_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnPressed[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_PressedColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_PressedColors1_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnPressed[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_OffsetGradient0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_OffsetGradient0_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnOffsetGradient[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_OffsetGradient1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_OffsetGradient1_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnOffsetGradient[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_ActiveBorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_ActiveBorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnActiveBorder[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_ActiveBorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_ActiveBorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnActiveBorder[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_PressedBorder0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_PressedBorder0_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnPressedBorder[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_PressedBorder1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customizedBtn_PressedBorder1_Btn.BackColor = color.Color;
                previewBtn.CustomizedBtnPressedBorder[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customizedBtn_Offset_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomizedBtnOffset = (int)customizedBtn_Offset_Numeric.Value;
            previewBtn.Invalidate();
        }
    }
}
