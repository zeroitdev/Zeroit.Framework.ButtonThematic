// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Excision.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Excision : UserControl
    {
        public UserControl_Excision()
        {
            InitializeComponent();
        }

        private void imageToText_Btn_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                customExcision_ImageCodeString_TxtBox.Text = this.ImageToCode(new Bitmap(openFile.FileName));
                customExcision_ImageViewer_PicBox.Image = this.CodeToImage(customExcision_ImageCodeString_TxtBox.Text);
                previewBtn.Invalidate();
            }
        }
        #region Image To Text Library

        public string ImageToCode(Bitmap Img)
        {
            return Convert.ToBase64String((byte[])System.ComponentModel.TypeDescriptor.GetConverter(Img).ConvertTo(Img, typeof(byte[])));
        }

        public Image CodeToImage(string Code)
        {
            return Image.FromStream(new System.IO.MemoryStream(Convert.FromBase64String(Code)));
        }
        #endregion

        private void imageFromText_Btn_Click(object sender, EventArgs e)
        {
            customExcision_ImageViewer_PicBox.Image = this.CodeToImage(customExcision_ImageCodeString_TxtBox.Text);
            previewBtn.Invalidate();
        }

        private void customExcision_ButtonType_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            previewBtn.CustomExcisionStyle =
                (ExcisionPreview.CustomExcisionStyles)Enum.Parse(
                    typeof(ExcisionPreview.CustomExcisionStyles),
                    customExcision_ButtonType_Combo.SelectedItem.ToString());

            previewBtn.Invalidate();
        }

        private void customExcision_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customExcision_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomExcisionBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customExcision_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customExcision_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomExcisionBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
