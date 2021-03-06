﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Deumos.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Deumos : UserControl
    {
        public UserControl_Deumos()
        {
            InitializeComponent();
        }

        private void customDeumos_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_BorderColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_BorderColors2_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosBorderColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_DownColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_DownColors0_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosDownStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_DownColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_DownColors1_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosDownStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_Background_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_NoneColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_NoneColors0_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosNoneStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_NoneColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_NoneColors1_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosNoneStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_Corner_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_Corner_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosCornerColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_Over_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_Over_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosOverStateColor = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
