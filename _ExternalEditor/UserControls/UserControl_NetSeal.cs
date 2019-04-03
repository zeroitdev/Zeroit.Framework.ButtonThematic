// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_NetSeal.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    [ToolboxItem(false)]
    public partial class UserControl_NetSeal : UserControl
    {
        public UserControl_NetSeal()
        {
            InitializeComponent();
        }

        private void customNetSeal_FocusScale1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomFocusScales = new PointF((float)customNetSeal_FocusScale1_Numeric.Value,
                (float)customNetSeal_FocusScale2_Numeric.Value);

            previewBtn.Invalidate();
        }

        private void customNetSeal_FocusScale2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomFocusScales = new PointF((float)customNetSeal_FocusScale1_Numeric.Value,
                (float)customNetSeal_FocusScale2_Numeric.Value);

            previewBtn.Invalidate();
        }

        private void customNetSeal_PathBorder0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNetSeal_PathBorder0_Btn.BackColor = color.Color;
                previewBtn.CustomNetSealPathBorders[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNetSeal_PathBorder1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNetSeal_PathBorder1_Btn.BackColor = color.Color;
                previewBtn.CustomNetSealPathBorders[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNetSeal_Centre_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNetSeal_Centre_Btn.BackColor = color.Color;
                previewBtn.CustomNetSealCenterColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNetSeal_Surround_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNetSeal_Surround_Btn.BackColor = color.Color;
                previewBtn.CustomNetSealSurroundColor = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
