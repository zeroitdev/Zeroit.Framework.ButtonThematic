// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_GameBooster.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_GameBooster : UserControl
    {
        public UserControl_GameBooster()
        {
            InitializeComponent();
        }

        private void customGameBooster_TopGradient_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_TopGradient_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterTopGradient = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_TopGradientClick_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_TopGradientClick_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterTopGradientClick = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_BottomGradient_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_BottomGradient_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterBotGradient = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_BottomGradientClick_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_BottomGradientClick_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterBotGradientClick = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_OuterBorderHover_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_OuterBorderHover_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterOuterBorderHover = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_InnerBorder_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterInnerBorder = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_OuterBorder_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_OuterBorder_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterOuterBorder = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_InnerBorderClick_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_InnerBorderClick_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterInnerBorderClick = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_OuterBorderClick_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_OuterBorderClick_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterOuterBorderClick = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_InnerBorderHover_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_InnerBorderHover_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterInnerBorderHover = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_TopGradHover_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_TopGradHover_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterTopGradientHover = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_BottomGradHover_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_BottomGradHover_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterBotGradientHover = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customGameBooster_Corner_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customGameBooster_Corner_Btn.BackColor = color.Color;
                previewBtn.CustomGameBoosterCornerColor = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
