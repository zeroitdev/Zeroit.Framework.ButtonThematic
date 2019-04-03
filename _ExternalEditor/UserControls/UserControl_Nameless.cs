// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Nameless.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Nameless : UserControl
    {
        public UserControl_Nameless()
        {
            InitializeComponent();
        }

        private void UserControl_Intel_Load(object sender, EventArgs e)
        {

        }

        private void customNameless_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_BorderColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_BorderColors2_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessBorderColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_NoneHighlight0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_NoneHighlight0_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessNoneHighlight[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_NoneHighlight1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_NoneHighlight1_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessNoneHighlight[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_NoneHighlight2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_NoneHighlight2_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessNoneHighlight[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_OverHighlight0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_OverHighlight0_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessOverHighlight[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_OverHighlight1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_OverHighlight1_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessOverHighlight[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_OverHighlight2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_OverHighlight2_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessOverHighlight[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_DownHighlight0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_DownHighlight0_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessDownHighlight[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_DownHighlight1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_DownHighlight1_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessDownHighlight[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_DownHighlight2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_DownHighlight2_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessDownHighlight[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_Corners_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_Corners_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessCorners = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
