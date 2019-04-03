// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_BitDefender.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_BitDefender : UserControl
    {
        public UserControl_BitDefender()
        {
            InitializeComponent();
        }

        private void customDefender_C1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDefender_C1_Btn.BackColor = color.Color;
                previewBtn.CustomBitDefenderC1 = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDefender_C2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDefender_C2_Btn.BackColor = color.Color;
                previewBtn.CustomBitDefenderC2 = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDefender_C3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDefender_C3_Btn.BackColor = color.Color;
                previewBtn.CustomBitDefenderC3 = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDefender_C4_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDefender_C4_Btn.BackColor = color.Color;
                previewBtn.CustomBitDefenderC4 = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDefender_C5_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDefender_C5_Btn.BackColor = color.Color;
                previewBtn.CustomBitDefenderC5 = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDefender_C6_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDefender_C6_Btn.BackColor = color.Color;
                previewBtn.CustomBitDefenderC6 = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDefender_BorderColor_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDefender_BorderColor_Btn.BackColor = color.Color;
                previewBtn.CustomBitDefenderBorder = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDefender_FadeColor_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDefender_FadeColor_Btn.BackColor = color.Color;
                previewBtn.CustomBitDefenderFadeColor = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
