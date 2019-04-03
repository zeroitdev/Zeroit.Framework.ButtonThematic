// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="11. CustomExcision.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class ExcisionPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class ExcisionPreview : ThemeControl
    {
        #region Image Designer

        #region Include in paint method

        ///////////////////////////////////////////////////////////////////////////////////////////////// 
        //                                                                                             //                                                                     
        //         ------------------------Add this to the Paint Method ------------------------       //
        //                                                                                             //
        // Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          //
        //                                                                                             //
        // PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);                   //
        //                                                                                             //
        // if ((Image == null))                                                                        //
        //     {                                                                                       //
        //         G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat           //
        //             {                                                                               //
        //                 Alignment = _TextAlignment,                                                 //
        //                 LineAlignment = StringAlignment.Center                                      //
        //             });                                                                             //
        //      }                                                                                      //
        // else                                                                                        //
        //      {                                                                                      //
        //         G.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);              //
        //          G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat          //
        //             {                                                                               //
        //                 Alignment = _TextAlignment,                                                 //
        //                 LineAlignment = StringAlignment.Center                                      //
        //             });                                                                             //
        //      }                                                                                      //
        //                                                                                             //
        /////////////////////////////////////////////////////////////////////////////////////////////////

        #endregion

        #region Include in Private Fields
        /// <summary>
        /// The image
        /// </summary>
        private Image _Image;
        /// <summary>
        /// The image size
        /// </summary>
        private Size _ImageSize;
        /// <summary>
        /// The image align
        /// </summary>
        private ContentAlignment _ImageAlign = ContentAlignment.MiddleCenter;
        /// <summary>
        /// The text alignment
        /// </summary>
        private StringAlignment _TextAlignment = StringAlignment.Center;
        /// <summary>
        /// The show text
        /// </summary>
        private bool showText = true;
        #endregion

        #region Include in Public Properties
        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image.</value>
        public Image Image
        {
            get { return _Image; }
            set
            {
                if (value == null)
                {
                    _ImageSize = Size.Empty;
                }
                else
                {
                    _ImageSize = value.Size;
                }

                _Image = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>The size of the image.</value>
        public Size ImageSize
        {
            get { return _ImageSize; }
            set
            {
                _ImageSize = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the image align.
        /// </summary>
        /// <value>The image align.</value>
        public ContentAlignment ImageAlign
        {
            get { return _ImageAlign; }
            set
            {
                _ImageAlign = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show text].
        /// </summary>
        /// <value><c>true</c> if [show text]; otherwise, <c>false</c>.</value>
        public bool ShowText
        {
            get { return showText; }
            set
            {
                showText = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the text align.
        /// </summary>
        /// <value>The text align.</value>
        public StringAlignment TextAlign
        {
            get { return _TextAlignment; }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }


        #endregion

        #region Include in Private Methods
        /// <summary>
        /// Images the location.
        /// </summary>
        /// <param name="SF">The sf.</param>
        /// <param name="Area">The area.</param>
        /// <param name="ImageArea">The image area.</param>
        /// <returns>PointF.</returns>
        private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
        {
            PointF MyPoint = default(PointF);
            switch (SF.Alignment)
            {
                case StringAlignment.Center:
                    MyPoint.X = Convert.ToSingle((Area.Width - ImageArea.Width) / 2);
                    break;
                case StringAlignment.Near:
                    MyPoint.X = 2;
                    break;
                case StringAlignment.Far:
                    MyPoint.X = Area.Width - ImageArea.Width - 2;
                    break;
            }

            switch (SF.LineAlignment)
            {
                case StringAlignment.Center:
                    MyPoint.Y = Convert.ToSingle((Area.Height - ImageArea.Height) / 2);
                    break;
                case StringAlignment.Near:
                    MyPoint.Y = 2;
                    break;
                case StringAlignment.Far:
                    MyPoint.Y = Area.Height - ImageArea.Height - 2;
                    break;
            }
            return MyPoint;
        }

        /// <summary>
        /// Gets the string format.
        /// </summary>
        /// <param name="_ContentAlignment">The content alignment.</param>
        /// <returns>StringFormat.</returns>
        private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
        {
            StringFormat SF = new StringFormat();
            switch (_ContentAlignment)
            {
                case ContentAlignment.MiddleCenter:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleLeft:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    SF.LineAlignment = StringAlignment.Center;
                    SF.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.TopCenter:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.TopLeft:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    SF.LineAlignment = StringAlignment.Near;
                    SF.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomCenter:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Center;
                    break;
                case ContentAlignment.BottomLeft:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.BottomRight:
                    SF.LineAlignment = StringAlignment.Far;
                    SF.Alignment = StringAlignment.Far;
                    break;
            }
            return SF;
        }

        /// <summary>
        /// Draws the image.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="R1">The r1.</param>
        private void DrawImage(Graphics G, Rectangle R1)
        {
            //Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          
            G.SmoothingMode = SmoothingMode.HighQuality;

            PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);

            if ((Image == null))
            {
                if (State != MouseState.Down)
                {
                    if (ShowText)
                        G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                        {
                            Alignment = _TextAlignment,
                            LineAlignment = StringAlignment.Center

                        });
                }
                else
                {
                    R1.X += 1;
                    R1.Y += 1;
                    if (ShowText)
                        G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                        {
                            Alignment = _TextAlignment,
                            LineAlignment = StringAlignment.Center

                        });
                }

            }
            else
            {
                G.DrawImage(_Image, ipt.X, ipt.Y, ImageSize.Width, ImageSize.Height);

                //if (ShowText)
                //    G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                //    {
                //        Alignment = _TextAlignment,
                //        LineAlignment = StringAlignment.Center
                //    });

                if (State != MouseState.Down)
                {
                    if (ShowText)
                        G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                        {
                            Alignment = _TextAlignment,
                            LineAlignment = StringAlignment.Center

                        });
                }
                else
                {
                    R1.X += 1;
                    R1.Y += 1;
                    if (ShowText)
                        G.DrawString(Text, Font, new SolidBrush(ForeColor), R1, new StringFormat
                        {
                            Alignment = _TextAlignment,
                            LineAlignment = StringAlignment.Center

                        });
                }
            }

        }


        #endregion

        #endregion

        #region Enum
        /// <summary>
        /// Enum CustomExcisionStyles
        /// </summary>
        public enum CustomExcisionStyles
        {
            /// <summary>
            /// The default
            /// </summary>
            Default,
            /// <summary>
            /// The circle
            /// </summary>
            Circle,
            /// <summary>
            /// The blue mode
            /// </summary>
            BlueMode,
            /// <summary>
            /// The white mode
            /// </summary>
            WhiteMode,
        };
        #endregion

        #region Private Fields
        /// <summary>
        /// The custom excision style
        /// </summary>
        private CustomExcisionStyles customExcisionStyle = CustomExcisionStyles.Default;

        /// <summary>
        /// The image code string
        /// </summary>
        private string imageCodeString =
            "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";

        /// <summary>
        /// The custom excision border colors
        /// </summary>
        private Color[] customExcisionBorderColors = new Color[]
        {
            Color.Black,
            Color.White
        };
        #endregion

        #region Public Properties

        #region Smoothing Mode

        /// <summary>
        /// The smoothing
        /// </summary>
        private SmoothingMode smoothing = SmoothingMode.AntiAlias;

        /// <summary>
        /// Gets or sets the smoothing.
        /// </summary>
        /// <value>The smoothing.</value>
        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                if (value == SmoothingMode.Invalid)
                {
                    value = SmoothingMode.HighQuality;
                    Invalidate();
                }
                smoothing = value;
                Invalidate();
            }
        }

        #endregion

        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        /// <summary>
        /// The textrendering
        /// </summary>
        TextRenderingHint textrendering = TextRenderingHint.SystemDefault;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }



        #endregion

        #region Interpolation Mode

        /// <summary>
        /// The interpolation mode
        /// </summary>
        private InterpolationMode interpolationMode = InterpolationMode.HighQualityBicubic;

        /// <summary>
        /// Gets or sets the interpolation mode.
        /// </summary>
        /// <value>The interpolation mode.</value>
        public InterpolationMode InterpolationMode
        {
            get { return interpolationMode; }
            set
            {
                interpolationMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Pixel Offset
        /// <summary>
        /// The pixel offset mode
        /// </summary>
        private PixelOffsetMode pixelOffsetMode = PixelOffsetMode.None;

        /// <summary>
        /// Gets or sets the pixel offset mode.
        /// </summary>
        /// <value>The pixel offset mode.</value>
        public PixelOffsetMode PixelOffsetMode
        {
            get { return pixelOffsetMode; }
            set
            {
                pixelOffsetMode = value;
                Invalidate();
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the custom excision style.
        /// </summary>
        /// <value>The custom excision style.</value>
        public CustomExcisionStyles CustomExcisionStyle
        {
            get { return customExcisionStyle; }
            set
            {
                customExcisionStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the image code string.
        /// </summary>
        /// <value>The image code string.</value>
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string ImageCodeString
        {
            get { return imageCodeString; }
            set
            {
                imageCodeString = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom excision border colors.
        /// </summary>
        /// <value>The custom excision border colors.</value>
        public Color[] CustomExcisionBorderColors
        {
            get { return customExcisionBorderColors; }
            set { customExcisionBorderColors = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint
        /// <summary>
        /// Customs the excision default button paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void CustomExcisionDefaultButtonPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            //G.SmoothingMode = SmoothingMode.HighQuality;
            ImageToCodeClass cti = new ImageToCodeClass();

            Bitmap BUTTONGRAIN = (Bitmap)cti.CodeToImage(ImageCodeString);
            TextureBrush BUTTONIMAGE = new TextureBrush(BUTTONGRAIN, WrapMode.TileFlipXY);
            G.FillPath(BUTTONIMAGE, Draw.RoundRect(ClientRectangle, 4));
            //Pen p = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
            G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
            Pen Ip = new Pen(Color.FromArgb(45, CustomExcisionBorderColors[1]));
            G.DrawPath(Ip, Draw.RoundRect(InnerRect, 4));
            
            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }

        /// <summary>
        /// Customs the excision circle button paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void CustomExcisionCircleButtonPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(BackColor);
            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            G.SmoothingMode = SmoothingMode.HighQuality;
            ImageToCodeClass cti = new ImageToCodeClass();

            Bitmap BUTTONGRAIN = (Bitmap) cti.CodeToImage(ImageCodeString);
            TextureBrush BUTTONIMAGE = new TextureBrush(BUTTONGRAIN, WrapMode.TileFlipXY);
            G.FillEllipse(BUTTONIMAGE, ClientRectangle);
            //Pen p = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
            G.DrawEllipse(new Pen(CustomExcisionBorderColors[0]), ClientRectangle);
            Pen Ip = new Pen(Color.FromArgb(45, CustomExcisionBorderColors[1]));
            G.DrawEllipse(Ip, InnerRect);

            
            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }

        /// <summary>
        /// Customs the excision button blue paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void CustomExcisionButtonBluePaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(Parent.BackColor);
            //Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);
            
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush BBG = new LinearGradientBrush(ClientRectangle, Color.FromArgb(85, 156, 188), Color.FromArgb(58, 136, 175), 90);
                    G.FillPath(BBG, Draw.RoundRect(ClientRectangle, 4));
                    Pen p = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip = new Pen(Color.FromArgb(129, 175, 201));
                    G.DrawPath(Ip, Draw.RoundRect(InnerRect, 4));
                    break;
                case MouseState.Over:
                    LinearGradientBrush BBG1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(45, 105, 135), Color.FromArgb(30, 90, 120), 90);
                    G.FillPath(BBG1, Draw.RoundRect(ClientRectangle, 4));
                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip1 = new Pen(Color.FromArgb(114, 160, 186));
                    G.DrawPath(Ip1, Draw.RoundRect(InnerRect, 4));
                    break;
                case MouseState.Down:
                    LinearGradientBrush BBG2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(85, 156, 188), Color.FromArgb(58, 136, 175), 90);
                    G.FillPath(BBG2, Draw.RoundRect(ClientRectangle, 4));
                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip2 = new Pen(Color.FromArgb(129, 175, 201));
                    G.DrawPath(Ip2, Draw.RoundRect(InnerRect, 4));
                    break;
            }

            //G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }

        /// <summary>
        /// Customs the excision button white paint.
        /// </summary>
        /// <param name="e">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        private void CustomExcisionButtonWhitePaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);

            
            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush BBG = new LinearGradientBrush(ClientRectangle, Color.FromArgb(225, 225, 225), Color.FromArgb(210, 210, 210), 90);
                    G.FillPath(BBG, Draw.RoundRect(ClientRectangle, 4));
                    Pen p = new Pen(new SolidBrush(Color.FromArgb(254, 254, 254)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip = new Pen(Color.FromArgb(255, 255, 255));
                    G.DrawPath(Ip, Draw.RoundRect(InnerRect, 4));
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(82, 87, 93)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    LinearGradientBrush BBG1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(222, 222, 222), Color.FromArgb(222, 222, 222), 90);
                    G.FillPath(BBG1, Draw.RoundRect(ClientRectangle, 4));
                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(222, 222, 222)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip1 = new Pen(Color.FromArgb(255, 255, 255));
                    G.DrawPath(Ip1, Draw.RoundRect(InnerRect, 4));
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(85, 85, 85)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});

                    break;
                case MouseState.Down:
                    LinearGradientBrush BBG2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(254, 254, 254), Color.FromArgb(248, 246, 247), 90);
                    G.FillPath(BBG2, Draw.RoundRect(ClientRectangle, 4));
                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(254, 254, 254)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip2 = new Pen(Color.FromArgb(255, 255, 255));
                    G.DrawPath(Ip2, Draw.RoundRect(InnerRect, 4));
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(82, 87, 93)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }

        /// <summary>
        /// Customs the excision paint.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        private void CustomExcisionPaint(PaintEventArgs e)
        {
            switch (CustomExcisionStyle)
            {
                case CustomExcisionStyles.Default:
                    CustomExcisionDefaultButtonPaint(e);
                    break;
                case CustomExcisionStyles.Circle:
                    CustomExcisionCircleButtonPaint(e);
                    break;
                case CustomExcisionStyles.BlueMode:
                    CustomExcisionButtonBluePaint(e);
                    break;
                case CustomExcisionStyles.WhiteMode:
                    CustomExcisionButtonWhitePaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Addition

        /// <summary>
        /// The state
        /// </summary>
        MouseState State = MouseState.None;


        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {

        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected override void PaintHook(PaintEventArgs e)
        {
            CustomExcisionPaint(e);
        }


        /// <summary>
        /// Handles the <see cref="E:MouseEnter" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseUp" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();

        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();

        }

        /// <summary>
        /// Handles the <see cref="E:MouseLeave" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;

            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:EnabledChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {

        }

        /// <summary>
        /// Paints the background of the control.
        /// </summary>
        /// <param name="pevent">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains information about the control to paint.</param>
        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
        {
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {

        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected override void OnAnimation()
        {

        }


        #endregion
    }

}

