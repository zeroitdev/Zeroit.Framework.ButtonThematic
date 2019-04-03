// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BaseContainer.cs" company="Zeroit Dev Technologies">
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
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class ButtonThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [Designer(typeof(ButtonThematicDesigner))]
    public partial class ButtonThematic : ThemeManagers.ThemeControl
    {
        
        #region Private Fields

        private Themes theme = Themes.Customized;
        
        MouseState State = MouseState.None;

        //private HatchStyle hatchStyle = HatchStyle.LightDownwardDiagonal;
        //private RenderMode drawMode = RenderMode.Gradient;

        #region Painter Effects
        //private BrushPainter2 brushPainter = new BrushPainter2(new ColorBlend() {
        //    Colors = new Color[]
        //    {
        //        Color.FromArgb(25,25,25),
        //        Color.FromArgb(65,25,25),
        //        Color.FromArgb(120,80,65)

        //    },
        //    Positions = new float[]
        //    {
        //        0f,0.5f,1.0f
        //    }

        //});

        //private PenPainter borderPainter = new PenPainter(Color.Black, 2f, DashStyle.DashDotDot);

        //private Polygon polygonMaker = new Polygon(); 
        #endregion

        //private int curve = 20;

        //private float gradientAngle = 90f;

        //private LinearGradientMode gradientMode = LinearGradientMode.Vertical;

        //private CustomizableStyles customizableStyle = CustomizableStyles.Boost;

        private ButtonInput buttonInput = new ButtonInput();

        //private int borderSize = 1;
        #endregion

        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonThematic"/> class.
        /// </summary>
        public ButtonThematic()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            //BackColor = Color.Transparent;

            IncludeInConstructor();
        }


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the customize.
        /// </summary>
        /// <value>The customize.</value>
        public ButtonInput Customize
        {
            get { return buttonInput; }
            set
            {
                buttonInput = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        /// <value>The theme.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        public Themes Theme
        {
            get { return theme; }
            set
            {
                switch (value)
                {
                    case Themes.Adobe:
                        break;
                    case Themes.AdvancedSystem:
                        break;
                    case Themes.Advantium:
                        break;
                    case Themes.Alpha:
                        break;
                    case Themes.Angel:
                        break;
                    case Themes.Anom:
                        break;
                    case Themes.Aresio:
                        break;
                    case Themes.Aryan:
                        break;
                    case Themes.Atrocity:
                        break;
                    case Themes.Avatar:
                        break;
                    case Themes.AVG:
                        break;
                    case Themes.BasicCode:
                        break;
                    case Themes.BetaBlue:
                        break;
                    case Themes.Beyond:
                        break;
                    case Themes.Bionic:
                        break;
                    case Themes.BitDefender:
                        break;
                    case Themes.BlackShades:
                        break;
                    case Themes.Bloody:
                        break;
                    case Themes.BlueAndWhite:
                        break;
                    case Themes.Blue:
                        break;
                    case Themes.Booster:
                        break;
                    case Themes.Border:
                        break;
                    case Themes.Bullion:
                        break;
                    case Themes.ButterScotch:
                        break;
                    case Themes.CarbonFibre:
                        break;
                    case Themes.Chrome:
                        break;
                    case Themes.Clarity:
                        break;
                    case Themes.Classic:
                        break;
                    case Themes.clsNeoBux:
                        break;
                    case Themes.CocaCola:
                        break;
                    case Themes.Complex:
                        break;
                    case Themes.Crystal:
                        CrystalClearButton();
                        break;
                    case Themes.Cypher:
                        break;
                    case Themes.CypherX:
                        break;
                    case Themes.DarkMatter:
                        break;
                    case Themes.DarkMatterAlt:
                        break;
                    case Themes.Design:
                        break;
                    case Themes.Destiny:
                        break;
                    case Themes.Deumos:
                        break;
                    case Themes.Doom:
                        break;
                    case Themes.Drone:
                        break;
                    case Themes.Earn:
                        break;
                    case Themes.Effectual:
                        break;
                    case Themes.EightBall:
                        EightBallButton();
                        break;
                    case Themes.Electric:
                        break;
                    case Themes.Electrified:
                        break;
                    case Themes.Elegant:
                        break;
                    case Themes.Element:
                        break;
                    case Themes.Empire:
                        break;
                    case Themes.Empress:
                        break;
                    case Themes.ETheme:
                        break;
                    case Themes.Evolve:
                        break;
                    case Themes.Excision:
                        break;
                    case Themes.Exotic:
                        break;
                    case Themes.Facebook:
                        break;
                    case Themes.Festus:
                        break;
                    case Themes.FireFox:
                        break;
                    case Themes.FlatUI:
                        break;
                    case Themes.Flow:
                        break;
                    case Themes.Frog:
                        break;
                    case Themes.Fusion:
                        break;
                    case Themes.Future:
                        break;
                    case Themes.GTheme:
                        break;
                    case Themes.GameBooster:
                        break;
                    case Themes.Genuine:
                        break;
                    case Themes.Ghostv2:
                        GhostButton();
                        break;
                    case Themes.GhostTheme:
                        break;
                    case Themes.Gray:
                        break;
                    case Themes.Green:
                        break;
                    case Themes.Hacker:
                        break;
                    case Themes.Hero:
                        break;
                    case Themes.Hex:
                        break;
                    case Themes.HF:
                        break;
                    case Themes.Hura:
                        HuraButton();
                        break;
                    case Themes.iBlack:
                        break;
                    case Themes.Influence:
                        break;
                    case Themes.Influx:
                        break;
                    case Themes.InnerDarkness:
                        break;
                    case Themes.Insomia:
                        break;
                    case Themes.Intel:
                        iButton();
                        break;
                    case Themes.JTheme:
                        break;
                    case Themes.Knight:
                        break;
                    case Themes.Light:
                        break;
                    case Themes.Login:
                        break;
                    case Themes.Loyal:
                        break;
                    case Themes.Meph:
                        break;
                    case Themes.Metal:
                        break;
                    case Themes.MetroUI:
                        break;
                    case Themes.MetroDisk:
                        break;
                    case Themes.Modern:
                        break;
                    case Themes.MPGH:
                        break;
                    case Themes.Mumtz:
                        break;
                    case Themes.Mystic:
                        break;
                    case Themes.Nameless:
                        break;
                    case Themes.NeoBux:
                        break;
                    case Themes.NetSeal:
                        break;
                    case Themes.New:
                        break;
                    case Themes.NYX:
                        break;
                    case Themes.Orains:
                        break;
                    case Themes.Origin:
                        break;
                    case Themes.Paladin:
                        break;
                    case Themes.Patrick:
                        break;
                    case Themes.Perplex:
                        break;
                    case Themes.Positron:
                        break;
                    case Themes.Prime:
                        break;
                    case Themes.Purity:
                        break;
                    case Themes.Qube:
                        break;
                    case Themes.Reactor:
                        break;
                    case Themes.Recon:
                        break;
                    case Themes.Recuperare:
                        break;
                    case Themes.Redwagon:
                        break;
                    case Themes.Redemption:
                        break;
                    case Themes.Resizable:
                        break;
                    case Themes.Rockstar:
                        break;
                    case Themes.Sasi:
                        break;
                    case Themes.Secure:
                        break;
                    case Themes.Sharp:
                        break;
                    case Themes.Simpla:
                        break;
                    case Themes.SimpleGrey:
                        break;
                    case Themes.Simplistic:
                        break;
                    case Themes.Situation:
                        break;
                    case Themes.SkyBase:
                        break;
                    case Themes.Skype:
                        break;
                    case Themes.SLC:
                        break;
                    case Themes.Somnium:
                        break;
                    case Themes.Spicylips:
                        break;
                    case Themes.Steam:
                        break;
                    case Themes.SteamAlt:
                        break;
                    case Themes.Storm:
                        break;
                    case Themes.Studio:
                        break;
                    case Themes.Subspace:
                        break;
                    case Themes.Sugar:
                        break;
                    case Themes.TeamViewer:
                        break;
                    case Themes.Tech:
                        break;
                    case Themes.Teen:
                        break;
                    case Themes.Tennis:
                        break;
                    case Themes.TheBlack:
                        break;
                    case Themes.Thief:
                        Thief3Button();
                        break;
                    case Themes.Twitch:
                        break;
                    case Themes.Ubuntu:
                        break;
                    case Themes.Uclear:
                        UnClearbutton();
                        break;
                    case Themes.Uplay:
                        UPlaybutton();
                        break;
                    case Themes.VTheme:
                        break;
                    case Themes.VibeLander:
                        break;
                    case Themes.Visceral:
                        break;
                    case Themes.Vitality:
                        break;
                    case Themes.Vs:
                        break;
                    case Themes.White:
                        break;
                    case Themes.Winter:
                        break;
                    case Themes.Xbox:
                        break;
                    case Themes.Xtreme:
                        break;
                    case Themes.xVisual:
                        break;
                    case Themes.Youtube:
                        break;
                    case Themes.Zeus:
                        break;
                    case Themes.Customized:
                        switch (CustomizableStyle)
                        {
                            case CustomizableStyles.Basic:
                                break;
                            case CustomizableStyles.Boost:
                                break;
                            case CustomizableStyles.Class:
                                break;
                            case CustomizableStyles.Defend:
                                break;
                            case CustomizableStyles.Dobe:
                                break;
                            case CustomizableStyles.Duos:
                                break;
                            case CustomizableStyles.Exon:
                                break;
                            case CustomizableStyles.Ezus:
                                break;
                            case CustomizableStyles.Fute:
                                break;
                            case CustomizableStyles.Gamer:
                                break;
                            case CustomizableStyles.Intel:
                                break;
                            case CustomizableStyles.Mizer:
                                break;
                            case CustomizableStyles.Neal:
                                break;
                            case CustomizableStyles.Neless:
                                break;
                            case CustomizableStyles.Rainy:
                                break;
                            case CustomizableStyles.Reon:
                                break;
                            case CustomizableStyles.Resio:
                                break;
                            case CustomizableStyles.Roast:
                                break;
                            case CustomizableStyles.Shades:
                                break;
                            case CustomizableStyles.Spice:
                                break;
                            case CustomizableStyles.System:
                                break;
                            case CustomizableStyles.Vant:
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                theme = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the hatch style.
        /// </summary>
        /// <value>The hatch style.</value>
        public HatchStyle HatchStyle
        {
            get { return buttonInput.HatchStyle; }
            set
            {
                buttonInput.HatchStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the draw mode.
        /// </summary>
        /// <value>The draw mode.</value>
        public RenderMode DrawMode
        {
            get { return buttonInput.DrawMode; }
            set
            {
                buttonInput.DrawMode = value;
                Invalidate();
            }
        }
        

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
        private Image _Image;
        private Size _ImageSize;
        private ContentAlignment _ImageAlign = ContentAlignment.MiddleCenter;
        private StringAlignment _TextAlignment = StringAlignment.Center;
        private bool showText = true;
        #endregion

        #region Include in Public Properties
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

        public Size ImageSize
        {
            get { return _ImageSize; }
            set
            {
                _ImageSize = value;
                Invalidate();
            }
        }

        public ContentAlignment ImageAlign
        {
            get { return _ImageAlign; }
            set
            {
                _ImageAlign = value;
                Invalidate();
            }
        }

        public bool ShowText
        {
            get { return showText; }
            set
            {
                showText = value;
                Invalidate();
            }
        }

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

        private void DrawImage(Graphics G, Rectangle R1)
        {
            //Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          
            G.SmoothingMode = SmoothingMode.HighQuality;

            PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);

            if ((Image == null))
            {
                if (State !=MouseState.Down)
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

        
        #region Smoothing Mode

        private SmoothingMode smoothing = SmoothingMode.AntiAlias;

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

        TextRenderingHint textrendering = TextRenderingHint.SystemDefault;

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

        private InterpolationMode interpolationMode = InterpolationMode.HighQualityBicubic;

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
        private PixelOffsetMode pixelOffsetMode = PixelOffsetMode.None;

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

        #region Brush Effects
        //public BrushPainter2 FillPainter
        //{
        //    get { return brushPainter; }
        //    set { brushPainter = value;
        //        Invalidate();
        //    }
        //}

        //public PenPainter BorderPainter
        //{
        //    get { return borderPainter; }
        //    set { borderPainter = value;
        //        Invalidate();
        //    }
        //}

        //public Polygon PolygonMaker
        //{
        //    get { return polygonMaker; }
        //    set { polygonMaker = value;
        //        Invalidate();
        //    }
        //} 
        #endregion

        public int Curve
        {
            get { return buttonInput.Curve; }
            set { buttonInput.Curve = value;
                Invalidate();
            }
        }

        public float GradientAngle
        {
            get { return buttonInput.GradientAngle; }
            set { buttonInput.GradientAngle = value; Invalidate(); }
        }

        public LinearGradientMode GradientMode
        {
            get { return buttonInput.GradientMode; }
            set {
                buttonInput.GradientMode = value;
                Invalidate();
            }
        }

        public CustomizableStyles CustomizableStyle
        {
            get { return buttonInput.CustomizableStyle; }
            set {
                buttonInput.CustomizableStyle = value;
                Invalidate();
            }
        }

        public int BorderSize
        {
            get { return buttonInput.BorderSize; }
            set {
                buttonInput.BorderSize = value;
                Invalidate();
            }
        }

        #endregion

        #region Events and Overrides

        /// <summary>
        /// Paints the Control.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// </exception>
        protected override void PaintHook(PaintEventArgs e)
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            switch (Theme)
            {
                case Themes.Adobe:
                    AdobePaintHook();
                    break;
                case Themes.AdvancedSystem:
                    AdvancedSystemPaint(e);
                    break;
                case Themes.Advantium:
                    AdvantiumPaintHook();
                    break;
                case Themes.Alpha:
                    AlphaPaintHook(e);
                    break;
                case Themes.Angel:
                    AngelPaint(e);
                    break;
                case Themes.Anom:
                    AnomPaintHook(e);
                    break;
                case Themes.Aresio:
                    AresioPaint(e);
                    break;
                case Themes.Aryan:
                    AryanPaint();
                    break;
                case Themes.Atrocity:
                    AtrocityPaint();
                    break;
                case Themes.Avatar:
                    AvatarPaint();
                    break;
                case Themes.AVG:
                    AVGPaint();
                    break;
                case Themes.BasicCode:
                    BasicPaint();
                    break;
                case Themes.BetaBlue:
                    BetaBluePaintHook();
                    break;
                case Themes.Beyond:
                    BeyondPaint();
                    break;
                case Themes.Bionic:
                    BionicPaint();
                    break;
                case Themes.BitDefender:
                    BitDefenderPaint(e);
                    break;
                case Themes.BlackShades:
                    BlackShadesPaint(e);
                    break;
                case Themes.Bloody:
                    BloodyPaint();
                    break;
                case Themes.BlueAndWhite:
                    CustomBaWOnPaint(e);
                    BaWOnPaint(e);
                    break;
                case Themes.Blue:
                    BluePaint();
                    break;
                case Themes.Booster:
                    BoosterPaintHook();
                    break;
                case Themes.Border:
                    BorderButtonPaint();
                    break;
                case Themes.Bullion:
                    BullionPaint(e);
                    break;
                case Themes.ButterScotch:
                    ButterScotchOnPaint(e);
                    break;
                case Themes.CarbonFibre:
                    CarbonFibrePaintHook();
                    break;
                case Themes.Chrome:
                    ChromePaintHook();
                    break;
                case Themes.Clarity:
                    ClarityOnPaint(e);
                    break;
                case Themes.Classic:
                    ClassicPaintHook();
                    break;
                case Themes.clsNeoBux:
                    ClsPaintHook();
                    break;
                case Themes.CocaCola:
                    CocaColaPaintHook();
                    break;
                case Themes.Complex:
                    ComplexPaintHook();
                    break;
                case Themes.Crystal:
                    CrystalPaintHook();
                    break;
                case Themes.Cypher:
                    CypherOnPaint(e);
                    break;
                case Themes.CypherX:
                    CypherXOnPaint(e);
                    break;
                case Themes.DarkMatter:
                    DarkMatterPaintHook();
                    break;
                case Themes.DarkMatterAlt:
                    DarkMatterAltPaintHook();
                    break;
                case Themes.Design:
                    DesignPaint(e);
                    break;
                case Themes.Destiny:
                    DestinyPaintHook();
                    break;
                case Themes.Deumos:
                    DeumosPaintHook();
                    break;
                case Themes.Doom:
                    DoomPaintHook();
                    break;
                case Themes.Drone:
                    DronePaintHook();
                    break;
                case Themes.Earn:
                    EarnPaintHook();
                    break;
                case Themes.Effectual:
                    EffectualPaint(e);
                    break;
                case Themes.EightBall:
                    EightBallOnPaint(e);
                    break;
                case Themes.Electric:
                    ElectricPaintHook();
                    break;
                case Themes.Electrified:
                    ElectrifiedPaintHook();
                    break;
                case Themes.Elegant:
                    ElegantOnPaint(e);
                    break;
                case Themes.Element:
                    ElementOnPaint(e);
                    break;
                case Themes.Empire:
                    EmpirePaint();
                    break;
                case Themes.Empress:
                    EmpressPaintHook();
                    break;
                case Themes.ETheme:
                    EThemePaintHook();
                    break;
                case Themes.Evolve:
                    EvolvePaintHook();
                    break;
                case Themes.Excision:
                    ExcisionPaint(e);
                    break;
                case Themes.Exotic:
                    ExoticPaintHook();
                    break;
                case Themes.Facebook:
                    FaceBookPaint(e);
                    break;
                case Themes.Festus:
                    FestusPaintHook();
                    break;
                case Themes.FireFox:
                    FireFoxPaint(e);
                    break;
                case Themes.FlatUI:
                    FlatUIPaint(e);
                    break;
                case Themes.Flow:
                    FlowPaintHook();
                    break;
                case Themes.Frog:
                    FrogPaintHook();
                    break;
                case Themes.Fusion:
                    FusionPaintHook();
                    break;
                case Themes.Future:
                    FuturePaintHook();
                    break;
                case Themes.GTheme:
                    GThemePaintHook();
                    break;
                case Themes.GameBooster:
                    GameBoosterPaintHook();
                    break;
                case Themes.Genuine:
                    GenuinePaintHook();
                    break;
                case Themes.Ghostv2:
                    GhostPaintHook();
                    break;
                case Themes.GhostTheme:
                    GhostPaintHook();
                    break;
                case Themes.Gray:
                    GrayPaint();
                    break;
                case Themes.Green:
                    GreenPaint(e);
                    break;
                case Themes.Hacker:
                    HackerPaint();
                    break;
                case Themes.Hero:
                    HeroPaintHook();
                    break;
                case Themes.Hex:
                    HexPaint();
                    break;
                case Themes.HF:
                    HFPaintHook();
                    break;
                case Themes.Hura:
                    HuraPaint(e);
                    break;
                case Themes.iBlack:
                    iBlackPaintHook();
                    break;
                case Themes.Influence:
                    InfluencePaint(e);
                    break;
                case Themes.Influx:
                    InfluxPaintHook();
                    break;
                case Themes.InnerDarkness:
                    InnerDarknessPaintHook();
                    break;
                case Themes.Insomia:
                    InsomiaPaintHook();
                    break;
                case Themes.Intel:
                    IntelPaintHook();
                    break;
                case Themes.JTheme:
                    JPaintHook();
                    break;
                case Themes.Knight:
                    KnightPaint(e);
                    break;
                case Themes.Light:
                    LightPaintHook();
                    break;
                case Themes.Login:
                    LoginPaint(e);
                    break;
                case Themes.Loyal:
                    LoyalPaint(e);
                    break;
                case Themes.Meph:
                    MephPaint(e);
                    break;
                case Themes.Metal:
                    MetalPaintHook();
                    break;
                case Themes.MetroUI:
                    MetroUIPaintHook();
                    break;
                case Themes.MetroDisk:
                    MetroDiskPaint(e);
                    break;
                case Themes.Modern:
                    ModernPaint(e);
                    break;
                case Themes.MPGH:
                    MPGHPaintHook();
                    break;
                case Themes.Mumtz:
                    MumtzPaintHook();
                    break;
                case Themes.Mystic:
                    MysticPaint(e);
                    break;
                case Themes.Nameless:
                    NameLessPaintHook();
                    break;
                case Themes.NeoBux:
                    NeoBuxPaint();
                    break;
                case Themes.NetSeal:
                    NetSealPaint(e);
                    break;
                case Themes.New:
                    NewPaintHook();
                    break;
                case Themes.NYX:
                    NYXPaintHook();
                    break;
                case Themes.Orains:
                    OrainsPaintHook();
                    break;
                case Themes.Origin:
                    OriginPaintHook();
                    break;
                case Themes.Paladin:
                    PaladinPaintHook();
                    break;
                case Themes.Patrick:
                    PatrickPaintHook();
                    break;
                case Themes.Perplex:
                    PerplexPaint(e);
                    break;
                case Themes.Positron:
                    PositronPaintHook();
                    break;
                case Themes.Prime:
                    PrimePaintHook();
                    break;
                case Themes.Purity:
                    PurityPaintHook();
                    break;
                case Themes.Qube:
                    QubePaint(e);
                    break;
                case Themes.Reactor:
                    ReactorPaint(e);
                    break;
                case Themes.Recon:
                    ReconPaintHook();
                    break;
                case Themes.Recuperare:
                    RecupararePaint(e);
                    break;
                case Themes.Redwagon:
                    RedwagonPaintHook();
                    break;
                case Themes.Redemption:
                    RedemptionPaint(e);
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    RockstarPaintHook();
                    break;
                case Themes.Sasi:
                    SasiPaintHook();
                    break;
                case Themes.Secure:
                    SecurePaintHook();
                    break;
                case Themes.Sharp:
                    SharpPaint(e);
                    break;
                case Themes.Simpla:
                    SimplaPaint(e);
                    break;
                case Themes.SimpleGrey:
                    SimpleGrayPaintHook();
                    break;
                case Themes.Simplistic:
                    SimplisticPaintHook();
                    break;
                case Themes.Situation:
                    SituationPaintHook();
                    break;
                case Themes.SkyBase:
                    SkyBasePaint(e);
                    break;
                case Themes.Skype:
                    SkyBasePaintHook();
                    break;
                case Themes.SLC:
                    SLCPaintHook();
                    break;
                case Themes.Somnium:
                    SomniumPaintHook();
                    break;
                case Themes.Spicylips:
                    SpicyLipsPaintHook();
                    break;
                case Themes.Steam:
                    SteamPaintHook();
                    break;
                case Themes.SteamAlt:
                    SteamPaintHook();
                    break;
                case Themes.Storm:
                    StormPaintHook();
                    break;
                case Themes.Studio:
                    StudioPaintHook();
                    break;
                case Themes.Subspace:
                    SubspacePaintHook();
                    break;
                case Themes.Sugar:
                    SugarPaintHook();
                    break;
                case Themes.TeamViewer:
                    TeamViewerPaintHook();
                    break;
                case Themes.Tech:
                    TechPaintHook();
                    break;
                case Themes.Teen:
                    TeenPaint(e);
                    break;
                case Themes.Tennis:
                    TennisPaintHook();
                    break;
                case Themes.TheBlack:
                    TheBlackPaintHook();
                    break;
                case Themes.Thief:
                    ThiefPaintHook();
                    break;
                case Themes.Twitch:
                    TwitchPaintHook();
                    break;
                case Themes.Ubuntu:
                    UbuntuPaint(e);
                    break;
                case Themes.Uclear:
                    UClearPaintHook();
                    break;
                case Themes.Uplay:
                    UPlayPaintHook();
                    break;
                case Themes.VTheme:
                    VThemePaintHook();
                    break;
                case Themes.VibeLander:
                    VibeLanderPaintHook();
                    break;
                case Themes.Visceral:
                    VisceralPaint(e);
                    break;
                case Themes.Vitality:
                    VitalityPaintHook();
                    break;
                case Themes.Vs:
                    VsPaint(e);
                    break;
                case Themes.White:
                    WhitePaintHook();
                    break;
                case Themes.Winter:
                    WinterPaint(e);
                    break;
                case Themes.Xbox:
                    XboxPaintHook();
                    break;
                case Themes.Xtreme:
                    XtremePaintHook();
                    break;
                case Themes.xVisual:
                    XVisualPaint(e);
                    break;
                case Themes.Youtube:
                    YoutubePaintHook();
                    break;
                case Themes.Zeus:
                    ZeusPaintHook();
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            CustomBasicPaint();
                            break;
                        case CustomizableStyles.Boost:
                            CustomBoosterPaintHook();
                            break;
                        case CustomizableStyles.Class:
                            CustomClassicPaintHook();
                            break;
                        case CustomizableStyles.Defend:
                            CustomBitDefenderPaint(e);
                            break;
                        case CustomizableStyles.Dobe:
                            CustomizableAdobePaintHook();
                            break;
                        case CustomizableStyles.Duos:
                            CustomDeumosPaintHook();
                            break;
                        case CustomizableStyles.Exon:
                            CustomExcisionPaint(e);
                            break;
                        case CustomizableStyles.Ezus:
                            CustomZeusPaintHook();
                            break;
                        case CustomizableStyles.Fute:
                            CustomFuturePaintHook();
                            break;
                        case CustomizableStyles.Gamer:
                            CustomGameBoosterPaintHook();
                            break;
                        case CustomizableStyles.Intel:
                            CustomIntelPaintHook();
                            break;
                        case CustomizableStyles.Mizer:
                            CustomizedButtonPaint(e);
                            break;
                        case CustomizableStyles.Neal:
                            CustomNetSealPaint(e);
                            break;
                        case CustomizableStyles.Neless:
                            CustomNameLessPaintHook();
                            break;
                        case CustomizableStyles.Rainy:
                            CustomOrainsPaintHook();
                            break;
                        case CustomizableStyles.Reon:
                            CustomReconPaintHook();
                            break;
                        case CustomizableStyles.Resio:
                            CustomAresioPaint(e);
                            break;
                        case CustomizableStyles.Roast:
                            CustomRoasterPaintHook();
                            break;
                        case CustomizableStyles.Shades:
                            CustomBlackShadesPaint(e);
                            break;
                        case CustomizableStyles.Spice:
                            CustomSpicyLipsPaintHook();
                            break;
                        case CustomizableStyles.System:
                            CustomizableAdvancedSystemPaint(e);
                            break;
                        case CustomizableStyles.Vant:
                            CustomAdvantiumPaintHook();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            if (State == MouseState.Down)
            {
                //DrawText(new SolidBrush(studioB1), HorizontalAlignment.Center, 2, 2);
                //DrawText(new SolidBrush(studioB2), HorizontalAlignment.Center, 1, 1);
            }
            else
            {
                //DrawText(new SolidBrush(studioB1), HorizontalAlignment.Center, 1, 1);
                //DrawText(new SolidBrush(studioB2), HorizontalAlignment.Center, 0, 0);
            }

            DrawImage(G, this.ClientRectangle);
        }

        protected override void ColorHook()
        {
           
        }

        #region " State Handling "
        
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            
            switch (Theme)
            {
                case Themes.Adobe:
                    break;
                case Themes.AdvancedSystem:
                    break;
                case Themes.Advantium:
                    break;
                case Themes.Alpha:
                    break;
                case Themes.Angel:
                    AngelOnMouseEnter(e);
                    break;
                case Themes.Anom:
                    break;
                case Themes.Aresio:
                    break;
                case Themes.Aryan:
                    break;
                case Themes.Atrocity:
                    break;
                case Themes.Avatar:
                    break;
                case Themes.AVG:
                    break;
                case Themes.BasicCode:
                    break;
                case Themes.BetaBlue:
                    break;
                case Themes.Beyond:
                    break;
                case Themes.Bionic:
                    break;
                case Themes.BitDefender:
                    BitDefenderOnMouseEnter(e);
                    break;
                case Themes.BlackShades:
                    break;
                case Themes.Bloody:
                    break;
                case Themes.BlueAndWhite:
                    BaWOnMouseEnter(e);
                    break;
                case Themes.Blue:
                    break;
                case Themes.Booster:
                    //CustomBoosterOnMouseEnter(e);
                    break;
                case Themes.Border:
                    break;
                case Themes.Bullion:
                    break;
                case Themes.ButterScotch:
                    break;
                case Themes.CarbonFibre:
                    break;
                case Themes.Chrome:
                    break;
                case Themes.Clarity:
                    break;
                case Themes.Classic:
                    break;
                case Themes.clsNeoBux:
                    break;
                case Themes.CocaCola:
                    break;
                case Themes.Complex:
                    break;
                case Themes.Crystal:
                    break;
                case Themes.Cypher:
                    break;
                case Themes.CypherX:
                    break;
                case Themes.DarkMatter:
                    break;
                case Themes.DarkMatterAlt:
                    break;
                case Themes.Design:
                    break;
                case Themes.Destiny:
                    break;
                case Themes.Deumos:
                    break;
                case Themes.Doom:
                    break;
                case Themes.Drone:
                    break;
                case Themes.Earn:
                    break;
                case Themes.Effectual:
                    break;
                case Themes.EightBall:
                    EightBallOnMouseEnter(e);
                    break;
                case Themes.Electric:
                    break;
                case Themes.Electrified:
                    break;
                case Themes.Elegant:
                    break;
                case Themes.Element:
                    break;
                case Themes.Empire:
                    break;
                case Themes.Empress:
                    break;
                case Themes.ETheme:
                    break;
                case Themes.Evolve:
                    break;
                case Themes.Excision:
                    break;
                case Themes.Exotic:
                    break;
                case Themes.Facebook:
                    break;
                case Themes.Festus:
                    break;
                case Themes.FireFox:
                    break;
                case Themes.FlatUI:
                    break;
                case Themes.Flow:
                    break;
                case Themes.Frog:
                    break;
                case Themes.Fusion:
                    break;
                case Themes.Future:
                    break;
                case Themes.GTheme:
                    break;
                case Themes.GameBooster:
                    break;
                case Themes.Genuine:
                    break;
                case Themes.Ghostv2:
                    break;
                case Themes.GhostTheme:
                    break;
                case Themes.Gray:
                    break;
                case Themes.Green:
                    break;
                case Themes.Hacker:
                    break;
                case Themes.Hero:
                    break;
                case Themes.Hex:
                    break;
                case Themes.HF:
                    break;
                case Themes.Hura:
                    break;
                case Themes.iBlack:
                    break;
                case Themes.Influence:
                    break;
                case Themes.Influx:
                    break;
                case Themes.InnerDarkness:
                    break;
                case Themes.Insomia:
                    break;
                case Themes.Intel:
                    break;
                case Themes.JTheme:
                    break;
                case Themes.Knight:
                    break;
                case Themes.Light:
                    break;
                case Themes.Login:
                    break;
                case Themes.Loyal:
                    break;
                case Themes.Meph:
                    break;
                case Themes.Metal:
                    break;
                case Themes.MetroUI:
                    break;
                case Themes.MetroDisk:
                    break;
                case Themes.Modern:
                    break;
                case Themes.MPGH:
                    break;
                case Themes.Mumtz:
                    break;
                case Themes.Mystic:
                    break;
                case Themes.Nameless:
                    break;
                case Themes.NeoBux:
                    break;
                case Themes.NetSeal:
                    break;
                case Themes.New:
                    break;
                case Themes.NYX:
                    break;
                case Themes.Orains:
                    break;
                case Themes.Origin:
                    break;
                case Themes.Paladin:
                    break;
                case Themes.Patrick:
                    break;
                case Themes.Perplex:
                    break;
                case Themes.Positron:
                    break;
                case Themes.Prime:
                    break;
                case Themes.Purity:
                    break;
                case Themes.Qube:
                    break;
                case Themes.Reactor:
                    break;
                case Themes.Recon:
                    break;
                case Themes.Recuperare:
                    break;
                case Themes.Redwagon:
                    break;
                case Themes.Redemption:
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    break;
                case Themes.Sasi:
                    break;
                case Themes.Secure:
                    break;
                case Themes.Sharp:
                    break;
                case Themes.Simpla:
                    break;
                case Themes.SimpleGrey:
                    break;
                case Themes.Simplistic:
                    break;
                case Themes.Situation:
                    break;
                case Themes.SkyBase:
                    break;
                case Themes.Skype:
                    break;
                case Themes.SLC:
                    break;
                case Themes.Somnium:
                    break;
                case Themes.Spicylips:
                    break;
                case Themes.Steam:
                    break;
                case Themes.SteamAlt:
                    break;
                case Themes.Storm:
                    break;
                case Themes.Studio:
                    break;
                case Themes.Subspace:
                    break;
                case Themes.Sugar:
                    break;
                case Themes.TeamViewer:
                    break;
                case Themes.Tech:
                    break;
                case Themes.Teen:
                    break;
                case Themes.Tennis:
                    break;
                case Themes.TheBlack:
                    break;
                case Themes.Thief:
                    break;
                case Themes.Twitch:
                    break;
                case Themes.Ubuntu:
                    break;
                case Themes.Uclear:
                    break;
                case Themes.Uplay:
                    break;
                case Themes.VTheme:
                    break;
                case Themes.VibeLander:
                    break;
                case Themes.Visceral:
                    break;
                case Themes.Vitality:
                    break;
                case Themes.Vs:
                    break;
                case Themes.White:
                    break;
                case Themes.Winter:
                    break;
                case Themes.Xbox:
                    break;
                case Themes.Xtreme:
                    break;
                case Themes.xVisual:
                    break;
                case Themes.Youtube:
                    break;
                case Themes.Zeus:
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            break;
                        case CustomizableStyles.Boost:
                            CustomBoosterOnMouseEnter(e);
                            break;
                        case CustomizableStyles.Class:
                            break;
                        case CustomizableStyles.Defend:
                            CustomBitDefenderOnMouseEnter(e);
                            break;
                        case CustomizableStyles.Dobe:
                            break;
                        case CustomizableStyles.Duos:
                            break;
                        case CustomizableStyles.Exon:
                            break;
                        case CustomizableStyles.Ezus:
                            break;
                        case CustomizableStyles.Fute:
                            break;
                        case CustomizableStyles.Gamer:
                            break;
                        case CustomizableStyles.Intel:
                            break;
                        case CustomizableStyles.Mizer:
                            break;
                        case CustomizableStyles.Neal:
                            break;
                        case CustomizableStyles.Neless:
                            break;
                        case CustomizableStyles.Rainy:
                            break;
                        case CustomizableStyles.Reon:
                            break;
                        case CustomizableStyles.Resio:
                            break;
                        case CustomizableStyles.Roast:
                            break;
                        case CustomizableStyles.Shades:
                            break;
                        case CustomizableStyles.Spice:
                            break;
                        case CustomizableStyles.System:
                            break;
                        case CustomizableStyles.Vant:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            
            switch (Theme)
            {
                case Themes.Adobe:
                    break;
                case Themes.AdvancedSystem:
                    break;
                case Themes.Advantium:
                    break;
                case Themes.Alpha:
                    break;
                case Themes.Angel:
                    AngelOnMouseUp(e);
                    break;
                case Themes.Anom:
                    break;
                case Themes.Aresio:
                    break;
                case Themes.Aryan:
                    break;
                case Themes.Atrocity:
                    break;
                case Themes.Avatar:
                    break;
                case Themes.AVG:
                    break;
                case Themes.BasicCode:
                    break;
                case Themes.BetaBlue:
                    break;
                case Themes.Beyond:
                    break;
                case Themes.Bionic:
                    break;
                case Themes.BitDefender:
                    //BitDefenderOnMouseUp(e);
                    break;
                case Themes.BlackShades:
                    break;
                case Themes.Bloody:
                    break;
                case Themes.BlueAndWhite:
                    BaWOnMouseUp(e);
                    break;
                case Themes.Blue:
                    break;
                case Themes.Booster:
                    break;
                case Themes.Border:
                    break;
                case Themes.Bullion:
                    break;
                case Themes.ButterScotch:
                    break;
                case Themes.CarbonFibre:
                    break;
                case Themes.Chrome:
                    break;
                case Themes.Clarity:
                    break;
                case Themes.Classic:
                    break;
                case Themes.clsNeoBux:
                    break;
                case Themes.CocaCola:
                    break;
                case Themes.Complex:
                    break;
                case Themes.Crystal:
                    break;
                case Themes.Cypher:
                    break;
                case Themes.CypherX:
                    break;
                case Themes.DarkMatter:
                    break;
                case Themes.DarkMatterAlt:
                    break;
                case Themes.Design:
                    break;
                case Themes.Destiny:
                    break;
                case Themes.Deumos:
                    break;
                case Themes.Doom:
                    break;
                case Themes.Drone:
                    break;
                case Themes.Earn:
                    break;
                case Themes.Effectual:
                    break;
                case Themes.EightBall:
                    EightBallOnMouseUp(e);
                    break;
                case Themes.Electric:
                    break;
                case Themes.Electrified:
                    break;
                case Themes.Elegant:
                    break;
                case Themes.Element:
                    break;
                case Themes.Empire:
                    State = MouseState.Over;
                    
                    if (e.Button == MouseButtons.Left)
                        base.OnClick(null);
                    //This fixes some fucked up lag you get...
                    Invalidate();
                    break;
                case Themes.Empress:
                    break;
                case Themes.ETheme:
                    break;
                case Themes.Evolve:
                    break;
                case Themes.Excision:
                    break;
                case Themes.Exotic:
                    break;
                case Themes.Facebook:
                    break;
                case Themes.Festus:
                    break;
                case Themes.FireFox:
                    break;
                case Themes.FlatUI:
                    break;
                case Themes.Flow:
                    break;
                case Themes.Frog:
                    break;
                case Themes.Fusion:
                    break;
                case Themes.Future:
                    break;
                case Themes.GTheme:
                    break;
                case Themes.GameBooster:
                    break;
                case Themes.Genuine:
                    break;
                case Themes.Ghostv2:
                    break;
                case Themes.GhostTheme:
                    break;
                case Themes.Gray:
                    break;
                case Themes.Green:
                    break;
                case Themes.Hacker:
                    break;
                case Themes.Hero:
                    break;
                case Themes.Hex:
                    break;
                case Themes.HF:
                    break;
                case Themes.Hura:
                    break;
                case Themes.iBlack:
                    break;
                case Themes.Influence:
                    break;
                case Themes.Influx:
                    break;
                case Themes.InnerDarkness:
                    break;
                case Themes.Insomia:
                    break;
                case Themes.Intel:
                    break;
                case Themes.JTheme:
                    break;
                case Themes.Knight:
                    break;
                case Themes.Light:
                    break;
                case Themes.Login:
                    break;
                case Themes.Loyal:
                    break;
                case Themes.Meph:
                    break;
                case Themes.Metal:
                    break;
                case Themes.MetroUI:
                    break;
                case Themes.MetroDisk:
                    break;
                case Themes.Modern:
                    break;
                case Themes.MPGH:
                    break;
                case Themes.Mumtz:
                    break;
                case Themes.Mystic:
                    break;
                case Themes.Nameless:
                    break;
                case Themes.NeoBux:
                    break;
                case Themes.NetSeal:
                    break;
                case Themes.New:
                    break;
                case Themes.NYX:
                    break;
                case Themes.Orains:
                    break;
                case Themes.Origin:
                    break;
                case Themes.Paladin:
                    break;
                case Themes.Patrick:
                    break;
                case Themes.Perplex:
                    break;
                case Themes.Positron:
                    break;
                case Themes.Prime:
                    break;
                case Themes.Purity:
                    break;
                case Themes.Qube:
                    break;
                case Themes.Reactor:
                    break;
                case Themes.Recon:
                    break;
                case Themes.Recuperare:
                    break;
                case Themes.Redwagon:
                    break;
                case Themes.Redemption:
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    break;
                case Themes.Sasi:
                    break;
                case Themes.Secure:
                    break;
                case Themes.Sharp:
                    break;
                case Themes.Simpla:
                    break;
                case Themes.SimpleGrey:
                    break;
                case Themes.Simplistic:
                    break;
                case Themes.Situation:
                    break;
                case Themes.SkyBase:
                    break;
                case Themes.Skype:
                    break;
                case Themes.SLC:
                    break;
                case Themes.Somnium:
                    break;
                case Themes.Spicylips:
                    break;
                case Themes.Steam:
                    break;
                case Themes.SteamAlt:
                    break;
                case Themes.Storm:
                    break;
                case Themes.Studio:
                    break;
                case Themes.Subspace:
                    break;
                case Themes.Sugar:
                    break;
                case Themes.TeamViewer:
                    break;
                case Themes.Tech:
                    break;
                case Themes.Teen:
                    break;
                case Themes.Tennis:
                    break;
                case Themes.TheBlack:
                    break;
                case Themes.Thief:
                    break;
                case Themes.Twitch:
                    break;
                case Themes.Ubuntu:
                    break;
                case Themes.Uclear:
                    break;
                case Themes.Uplay:
                    break;
                case Themes.VTheme:
                    break;
                case Themes.VibeLander:
                    break;
                case Themes.Visceral:
                    break;
                case Themes.Vitality:
                    break;
                case Themes.Vs:
                    break;
                case Themes.White:
                    break;
                case Themes.Winter:
                    break;
                case Themes.Xbox:
                    break;
                case Themes.Xtreme:
                    break;
                case Themes.xVisual:
                    break;
                case Themes.Youtube:
                    break;
                case Themes.Zeus:
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            break;
                        case CustomizableStyles.Boost:
                            break;
                        case CustomizableStyles.Class:
                            break;
                        case CustomizableStyles.Defend:
                            CustomBitDefenderOnMouseUp(e);
                            break;
                        case CustomizableStyles.Dobe:
                            break;
                        case CustomizableStyles.Duos:
                            break;
                        case CustomizableStyles.Exon:
                            break;
                        case CustomizableStyles.Ezus:
                            break;
                        case CustomizableStyles.Fute:
                            break;
                        case CustomizableStyles.Gamer:
                            break;
                        case CustomizableStyles.Intel:
                            break;
                        case CustomizableStyles.Mizer:
                            break;
                        case CustomizableStyles.Neal:
                            break;
                        case CustomizableStyles.Neless:
                            break;
                        case CustomizableStyles.Rainy:
                            break;
                        case CustomizableStyles.Reon:
                            break;
                        case CustomizableStyles.Resio:
                            break;
                        case CustomizableStyles.Roast:
                            break;
                        case CustomizableStyles.Shades:
                            break;
                        case CustomizableStyles.Spice:
                            break;
                        case CustomizableStyles.System:
                            break;
                        case CustomizableStyles.Vant:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            ClickOnMouseUp(e);

            Invalidate();

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            
            switch (Theme)
            {
                case Themes.Adobe:
                    break;
                case Themes.AdvancedSystem:
                    break;
                case Themes.Advantium:
                    break;
                case Themes.Alpha:
                    break;
                case Themes.Angel:
                    AngelOnMouseDown(e);
                    break;
                case Themes.Anom:
                    break;
                case Themes.Aresio:
                    break;
                case Themes.Aryan:
                    break;
                case Themes.Atrocity:
                    break;
                case Themes.Avatar:
                    break;
                case Themes.AVG:
                    break;
                case Themes.BasicCode:
                    break;
                case Themes.BetaBlue:
                    break;
                case Themes.Beyond:
                    break;
                case Themes.Bionic:
                    break;
                case Themes.BitDefender:
                    //BitDefenderOnMouseDown(e);
                    break;
                case Themes.BlackShades:
                    break;
                case Themes.Bloody:
                    break;
                case Themes.BlueAndWhite:
                    BaWOnMouseDown(e);
                    break;
                case Themes.Blue:
                    break;
                case Themes.Booster:
                    break;
                case Themes.Border:
                    break;
                case Themes.Bullion:
                    break;
                case Themes.ButterScotch:
                    break;
                case Themes.CarbonFibre:
                    break;
                case Themes.Chrome:
                    break;
                case Themes.Clarity:
                    break;
                case Themes.Classic:
                    break;
                case Themes.clsNeoBux:
                    break;
                case Themes.CocaCola:
                    break;
                case Themes.Complex:
                    break;
                case Themes.Crystal:
                    break;
                case Themes.Cypher:
                    break;
                case Themes.CypherX:
                    break;
                case Themes.DarkMatter:
                    break;
                case Themes.DarkMatterAlt:
                    break;
                case Themes.Design:
                    break;
                case Themes.Destiny:
                    break;
                case Themes.Deumos:
                    break;
                case Themes.Doom:
                    break;
                case Themes.Drone:
                    break;
                case Themes.Earn:
                    break;
                case Themes.Effectual:
                    break;
                case Themes.EightBall:
                    EightBallOnMouseDown(e);
                    break;
                case Themes.Electric:
                    break;
                case Themes.Electrified:
                    break;
                case Themes.Elegant:
                    break;
                case Themes.Element:
                    break;
                case Themes.Empire:
                    break;
                case Themes.Empress:
                    break;
                case Themes.ETheme:
                    break;
                case Themes.Evolve:
                    break;
                case Themes.Excision:
                    break;
                case Themes.Exotic:
                    break;
                case Themes.Facebook:
                    break;
                case Themes.Festus:
                    break;
                case Themes.FireFox:
                    break;
                case Themes.FlatUI:
                    break;
                case Themes.Flow:
                    break;
                case Themes.Frog:
                    break;
                case Themes.Fusion:
                    break;
                case Themes.Future:
                    break;
                case Themes.GTheme:
                    break;
                case Themes.GameBooster:
                    break;
                case Themes.Genuine:
                    break;
                case Themes.Ghostv2:
                    break;
                case Themes.GhostTheme:
                    break;
                case Themes.Gray:
                    break;
                case Themes.Green:
                    break;
                case Themes.Hacker:
                    break;
                case Themes.Hero:
                    break;
                case Themes.Hex:
                    break;
                case Themes.HF:
                    break;
                case Themes.Hura:
                    break;
                case Themes.iBlack:
                    break;
                case Themes.Influence:
                    break;
                case Themes.Influx:
                    break;
                case Themes.InnerDarkness:
                    break;
                case Themes.Insomia:
                    break;
                case Themes.Intel:
                    break;
                case Themes.JTheme:
                    break;
                case Themes.Knight:
                    break;
                case Themes.Light:
                    break;
                case Themes.Login:
                    break;
                case Themes.Loyal:
                    break;
                case Themes.Meph:
                    break;
                case Themes.Metal:
                    break;
                case Themes.MetroUI:
                    break;
                case Themes.MetroDisk:
                    break;
                case Themes.Modern:
                    break;
                case Themes.MPGH:
                    break;
                case Themes.Mumtz:
                    break;
                case Themes.Mystic:
                    break;
                case Themes.Nameless:
                    break;
                case Themes.NeoBux:
                    break;
                case Themes.NetSeal:
                    break;
                case Themes.New:
                    break;
                case Themes.NYX:
                    break;
                case Themes.Orains:
                    break;
                case Themes.Origin:
                    break;
                case Themes.Paladin:
                    break;
                case Themes.Patrick:
                    break;
                case Themes.Perplex:
                    break;
                case Themes.Positron:
                    break;
                case Themes.Prime:
                    break;
                case Themes.Purity:
                    break;
                case Themes.Qube:
                    break;
                case Themes.Reactor:
                    break;
                case Themes.Recon:
                    break;
                case Themes.Recuperare:
                    break;
                case Themes.Redwagon:
                    break;
                case Themes.Redemption:
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    break;
                case Themes.Sasi:
                    break;
                case Themes.Secure:
                    break;
                case Themes.Sharp:
                    break;
                case Themes.Simpla:
                    break;
                case Themes.SimpleGrey:
                    break;
                case Themes.Simplistic:
                    break;
                case Themes.Situation:
                    break;
                case Themes.SkyBase:
                    break;
                case Themes.Skype:
                    break;
                case Themes.SLC:
                    break;
                case Themes.Somnium:
                    break;
                case Themes.Spicylips:
                    break;
                case Themes.Steam:
                    break;
                case Themes.SteamAlt:
                    break;
                case Themes.Storm:
                    break;
                case Themes.Studio:
                    break;
                case Themes.Subspace:
                    break;
                case Themes.Sugar:
                    break;
                case Themes.TeamViewer:
                    break;
                case Themes.Tech:
                    break;
                case Themes.Teen:
                    break;
                case Themes.Tennis:
                    break;
                case Themes.TheBlack:
                    break;
                case Themes.Thief:
                    break;
                case Themes.Twitch:
                    break;
                case Themes.Ubuntu:
                    break;
                case Themes.Uclear:
                    break;
                case Themes.Uplay:
                    break;
                case Themes.VTheme:
                    break;
                case Themes.VibeLander:
                    break;
                case Themes.Visceral:
                    break;
                case Themes.Vitality:
                    break;
                case Themes.Vs:
                    break;
                case Themes.White:
                    break;
                case Themes.Winter:
                    break;
                case Themes.Xbox:
                    break;
                case Themes.Xtreme:
                    break;
                case Themes.xVisual:
                    break;
                case Themes.Youtube:
                    break;
                case Themes.Zeus:
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            break;
                        case CustomizableStyles.Boost:
                            break;
                        case CustomizableStyles.Class:
                            break;
                        case CustomizableStyles.Defend:
                            CustomBitDefenderOnMouseDown(e);
                            break;
                        case CustomizableStyles.Dobe:
                            break;
                        case CustomizableStyles.Duos:
                            break;
                        case CustomizableStyles.Exon:
                            break;
                        case CustomizableStyles.Ezus:
                            break;
                        case CustomizableStyles.Fute:
                            break;
                        case CustomizableStyles.Gamer:
                            break;
                        case CustomizableStyles.Intel:
                            break;
                        case CustomizableStyles.Mizer:
                            break;
                        case CustomizableStyles.Neal:
                            break;
                        case CustomizableStyles.Neless:
                            break;
                        case CustomizableStyles.Rainy:
                            break;
                        case CustomizableStyles.Reon:
                            break;
                        case CustomizableStyles.Resio:
                            break;
                        case CustomizableStyles.Roast:
                            break;
                        case CustomizableStyles.Shades:
                            break;
                        case CustomizableStyles.Spice:
                            break;
                        case CustomizableStyles.System:
                            break;
                        case CustomizableStyles.Vant:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            ClickOnMouseDown(e);

            Invalidate();

        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            
            switch (Theme)
            {
                case Themes.Adobe:
                    break;
                case Themes.AdvancedSystem:
                    break;
                case Themes.Advantium:
                    break;
                case Themes.Alpha:
                    break;
                case Themes.Angel:
                    AngelOnMouseLeave(e);
                    break;
                case Themes.Anom:
                    break;
                case Themes.Aresio:
                    break;
                case Themes.Aryan:
                    break;
                case Themes.Atrocity:
                    break;
                case Themes.Avatar:
                    break;
                case Themes.AVG:
                    break;
                case Themes.BasicCode:
                    break;
                case Themes.BetaBlue:
                    break;
                case Themes.Beyond:
                    break;
                case Themes.Bionic:
                    break;
                case Themes.BitDefender:
                    break;
                case Themes.BlackShades:
                    break;
                case Themes.Bloody:
                    break;
                case Themes.BlueAndWhite:
                    BaWOnMouseLeave(e);
                    break;
                case Themes.Blue:
                    break;
                case Themes.Booster:
                    break;
                case Themes.Border:
                    break;
                case Themes.Bullion:
                    break;
                case Themes.ButterScotch:
                    break;
                case Themes.CarbonFibre:
                    break;
                case Themes.Chrome:
                    break;
                case Themes.Clarity:
                    break;
                case Themes.Classic:
                    break;
                case Themes.clsNeoBux:
                    break;
                case Themes.CocaCola:
                    break;
                case Themes.Complex:
                    break;
                case Themes.Crystal:
                    break;
                case Themes.Cypher:
                    break;
                case Themes.CypherX:
                    break;
                case Themes.DarkMatter:
                    break;
                case Themes.DarkMatterAlt:
                    break;
                case Themes.Design:
                    break;
                case Themes.Destiny:
                    break;
                case Themes.Deumos:
                    break;
                case Themes.Doom:
                    break;
                case Themes.Drone:
                    break;
                case Themes.Earn:
                    break;
                case Themes.Effectual:
                    break;
                case Themes.EightBall:
                    EightBallOnMouseLeave(e);
                    break;
                case Themes.Electric:
                    break;
                case Themes.Electrified:
                    break;
                case Themes.Elegant:
                    break;
                case Themes.Element:
                    break;
                case Themes.Empire:
                    break;
                case Themes.Empress:
                    break;
                case Themes.ETheme:
                    break;
                case Themes.Evolve:
                    break;
                case Themes.Excision:
                    break;
                case Themes.Exotic:
                    break;
                case Themes.Facebook:
                    break;
                case Themes.Festus:
                    break;
                case Themes.FireFox:
                    break;
                case Themes.FlatUI:
                    break;
                case Themes.Flow:
                    break;
                case Themes.Frog:
                    break;
                case Themes.Fusion:
                    break;
                case Themes.Future:
                    break;
                case Themes.GTheme:
                    break;
                case Themes.GameBooster:
                    break;
                case Themes.Genuine:
                    break;
                case Themes.Ghostv2:
                    break;
                case Themes.GhostTheme:
                    break;
                case Themes.Gray:
                    break;
                case Themes.Green:
                    break;
                case Themes.Hacker:
                    break;
                case Themes.Hero:
                    break;
                case Themes.Hex:
                    break;
                case Themes.HF:
                    break;
                case Themes.Hura:
                    break;
                case Themes.iBlack:
                    break;
                case Themes.Influence:
                    break;
                case Themes.Influx:
                    break;
                case Themes.InnerDarkness:
                    break;
                case Themes.Insomia:
                    break;
                case Themes.Intel:
                    break;
                case Themes.JTheme:
                    break;
                case Themes.Knight:
                    break;
                case Themes.Light:
                    break;
                case Themes.Login:
                    break;
                case Themes.Loyal:
                    break;
                case Themes.Meph:
                    break;
                case Themes.Metal:
                    break;
                case Themes.MetroUI:
                    break;
                case Themes.MetroDisk:
                    break;
                case Themes.Modern:
                    break;
                case Themes.MPGH:
                    break;
                case Themes.Mumtz:
                    break;
                case Themes.Mystic:
                    break;
                case Themes.Nameless:
                    break;
                case Themes.NeoBux:
                    break;
                case Themes.NetSeal:
                    break;
                case Themes.New:
                    break;
                case Themes.NYX:
                    break;
                case Themes.Orains:
                    break;
                case Themes.Origin:
                    break;
                case Themes.Paladin:
                    break;
                case Themes.Patrick:
                    break;
                case Themes.Perplex:
                    break;
                case Themes.Positron:
                    break;
                case Themes.Prime:
                    break;
                case Themes.Purity:
                    break;
                case Themes.Qube:
                    break;
                case Themes.Reactor:
                    break;
                case Themes.Recon:
                    break;
                case Themes.Recuperare:
                    break;
                case Themes.Redwagon:
                    break;
                case Themes.Redemption:
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    break;
                case Themes.Sasi:
                    break;
                case Themes.Secure:
                    break;
                case Themes.Sharp:
                    break;
                case Themes.Simpla:
                    break;
                case Themes.SimpleGrey:
                    break;
                case Themes.Simplistic:
                    break;
                case Themes.Situation:
                    break;
                case Themes.SkyBase:
                    break;
                case Themes.Skype:
                    break;
                case Themes.SLC:
                    break;
                case Themes.Somnium:
                    break;
                case Themes.Spicylips:
                    break;
                case Themes.Steam:
                    break;
                case Themes.SteamAlt:
                    break;
                case Themes.Storm:
                    break;
                case Themes.Studio:
                    break;
                case Themes.Subspace:
                    break;
                case Themes.Sugar:
                    break;
                case Themes.TeamViewer:
                    break;
                case Themes.Tech:
                    break;
                case Themes.Teen:
                    break;
                case Themes.Tennis:
                    break;
                case Themes.TheBlack:
                    break;
                case Themes.Thief:
                    break;
                case Themes.Twitch:
                    break;
                case Themes.Ubuntu:
                    break;
                case Themes.Uclear:
                    break;
                case Themes.Uplay:
                    break;
                case Themes.VTheme:
                    break;
                case Themes.VibeLander:
                    break;
                case Themes.Visceral:
                    break;
                case Themes.Vitality:
                    break;
                case Themes.Vs:
                    break;
                case Themes.White:
                    break;
                case Themes.Winter:
                    break;
                case Themes.Xbox:
                    break;
                case Themes.Xtreme:
                    break;
                case Themes.xVisual:
                    break;
                case Themes.Youtube:
                    break;
                case Themes.Zeus:
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            break;
                        case CustomizableStyles.Boost:
                            break;
                        case CustomizableStyles.Class:
                            break;
                        case CustomizableStyles.Defend:
                            break;
                        case CustomizableStyles.Dobe:
                            break;
                        case CustomizableStyles.Duos:
                            break;
                        case CustomizableStyles.Exon:
                            break;
                        case CustomizableStyles.Ezus:
                            break;
                        case CustomizableStyles.Fute:
                            break;
                        case CustomizableStyles.Gamer:
                            break;
                        case CustomizableStyles.Intel:
                            break;
                        case CustomizableStyles.Mizer:
                            break;
                        case CustomizableStyles.Neal:
                            break;
                        case CustomizableStyles.Neless:
                            break;
                        case CustomizableStyles.Rainy:
                            break;
                        case CustomizableStyles.Reon:
                            break;
                        case CustomizableStyles.Resio:
                            break;
                        case CustomizableStyles.Roast:
                            break;
                        case CustomizableStyles.Shades:
                            break;
                        case CustomizableStyles.Spice:
                            break;
                        case CustomizableStyles.System:
                            break;
                        case CustomizableStyles.Vant:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Invalidate();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {

            switch (Theme)
            {
                case Themes.Adobe:
                    break;
                case Themes.AdvancedSystem:
                    break;
                case Themes.Advantium:
                    break;
                case Themes.Alpha:
                    break;
                case Themes.Angel:
                    break;
                case Themes.Anom:
                    break;
                case Themes.Aresio:
                    break;
                case Themes.Aryan:
                    break;
                case Themes.Atrocity:
                    break;
                case Themes.Avatar:
                    break;
                case Themes.AVG:
                    break;
                case Themes.BasicCode:
                    break;
                case Themes.BetaBlue:
                    break;
                case Themes.Beyond:
                    break;
                case Themes.Bionic:
                    break;
                case Themes.BitDefender:
                    break;
                case Themes.BlackShades:
                    break;
                case Themes.Bloody:
                    break;
                case Themes.BlueAndWhite:
                    break;
                case Themes.Blue:
                    break;
                case Themes.Booster:
                    break;
                case Themes.Border:
                    break;
                case Themes.Bullion:
                    break;
                case Themes.ButterScotch:
                    break;
                case Themes.CarbonFibre:
                    break;
                case Themes.Chrome:
                    break;
                case Themes.Clarity:
                    break;
                case Themes.Classic:
                    break;
                case Themes.clsNeoBux:
                    break;
                case Themes.CocaCola:
                    break;
                case Themes.Complex:
                    break;
                case Themes.Crystal:
                    break;
                case Themes.Cypher:
                    break;
                case Themes.CypherX:
                    break;
                case Themes.DarkMatter:
                    break;
                case Themes.DarkMatterAlt:
                    break;
                case Themes.Design:
                    break;
                case Themes.Destiny:
                    break;
                case Themes.Deumos:
                    break;
                case Themes.Doom:
                    break;
                case Themes.Drone:
                    break;
                case Themes.Earn:
                    break;
                case Themes.Effectual:
                    break;
                case Themes.EightBall:
                    break;
                case Themes.Electric:
                    break;
                case Themes.Electrified:
                    break;
                case Themes.Elegant:
                    break;
                case Themes.Element:
                    break;
                case Themes.Empire:
                    break;
                case Themes.Empress:
                    break;
                case Themes.ETheme:
                    break;
                case Themes.Evolve:
                    break;
                case Themes.Excision:
                    break;
                case Themes.Exotic:
                    break;
                case Themes.Facebook:
                    break;
                case Themes.Festus:
                    break;
                case Themes.FireFox:
                    break;
                case Themes.FlatUI:
                    break;
                case Themes.Flow:
                    break;
                case Themes.Frog:
                    break;
                case Themes.Fusion:
                    break;
                case Themes.Future:
                    break;
                case Themes.GTheme:
                    break;
                case Themes.GameBooster:
                    break;
                case Themes.Genuine:
                    break;
                case Themes.Ghostv2:
                    break;
                case Themes.GhostTheme:
                    break;
                case Themes.Gray:
                    break;
                case Themes.Green:
                    break;
                case Themes.Hacker:
                    break;
                case Themes.Hero:
                    break;
                case Themes.Hex:
                    break;
                case Themes.HF:
                    break;
                case Themes.Hura:
                    break;
                case Themes.iBlack:
                    break;
                case Themes.Influence:
                    break;
                case Themes.Influx:
                    break;
                case Themes.InnerDarkness:
                    break;
                case Themes.Insomia:
                    break;
                case Themes.Intel:
                    break;
                case Themes.JTheme:
                    break;
                case Themes.Knight:
                    break;
                case Themes.Light:
                    break;
                case Themes.Login:
                    break;
                case Themes.Loyal:
                    break;
                case Themes.Meph:
                    break;
                case Themes.Metal:
                    break;
                case Themes.MetroUI:
                    break;
                case Themes.MetroDisk:
                    break;
                case Themes.Modern:
                    break;
                case Themes.MPGH:
                    break;
                case Themes.Mumtz:
                    break;
                case Themes.Mystic:
                    break;
                case Themes.Nameless:
                    break;
                case Themes.NeoBux:
                    break;
                case Themes.NetSeal:
                    break;
                case Themes.New:
                    break;
                case Themes.NYX:
                    break;
                case Themes.Orains:
                    break;
                case Themes.Origin:
                    break;
                case Themes.Paladin:
                    break;
                case Themes.Patrick:
                    break;
                case Themes.Perplex:
                    break;
                case Themes.Positron:
                    break;
                case Themes.Prime:
                    break;
                case Themes.Purity:
                    break;
                case Themes.Qube:
                    break;
                case Themes.Reactor:
                    break;
                case Themes.Recon:
                    break;
                case Themes.Recuperare:
                    break;
                case Themes.Redwagon:
                    break;
                case Themes.Redemption:
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    break;
                case Themes.Sasi:
                    break;
                case Themes.Secure:
                    break;
                case Themes.Sharp:
                    break;
                case Themes.Simpla:
                    break;
                case Themes.SimpleGrey:
                    break;
                case Themes.Simplistic:
                    break;
                case Themes.Situation:
                    break;
                case Themes.SkyBase:
                    break;
                case Themes.Skype:
                    break;
                case Themes.SLC:
                    break;
                case Themes.Somnium:
                    break;
                case Themes.Spicylips:
                    break;
                case Themes.Steam:
                    break;
                case Themes.SteamAlt:
                    break;
                case Themes.Storm:
                    break;
                case Themes.Studio:
                    break;
                case Themes.Subspace:
                    break;
                case Themes.Sugar:
                    break;
                case Themes.TeamViewer:
                    break;
                case Themes.Tech:
                    break;
                case Themes.Teen:
                    break;
                case Themes.Tennis:
                    break;
                case Themes.TheBlack:
                    break;
                case Themes.Thief:
                    break;
                case Themes.Twitch:
                    break;
                case Themes.Ubuntu:
                    break;
                case Themes.Uclear:
                    break;
                case Themes.Uplay:
                    break;
                case Themes.VTheme:
                    break;
                case Themes.VibeLander:
                    break;
                case Themes.Visceral:
                    break;
                case Themes.Vitality:
                    break;
                case Themes.Vs:
                    break;
                case Themes.White:
                    break;
                case Themes.Winter:
                    break;
                case Themes.Xbox:
                    break;
                case Themes.Xtreme:
                    break;
                case Themes.xVisual:
                    break;
                case Themes.Youtube:
                    break;
                case Themes.Zeus:
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            break;
                        case CustomizableStyles.Boost:
                            break;
                        case CustomizableStyles.Class:
                            break;
                        case CustomizableStyles.Defend:
                            break;
                        case CustomizableStyles.Dobe:
                            break;
                        case CustomizableStyles.Duos:
                            break;
                        case CustomizableStyles.Exon:
                            break;
                        case CustomizableStyles.Ezus:
                            break;
                        case CustomizableStyles.Fute:
                            break;
                        case CustomizableStyles.Gamer:
                            break;
                        case CustomizableStyles.Intel:
                            break;
                        case CustomizableStyles.Mizer:
                            break;
                        case CustomizableStyles.Neal:
                            break;
                        case CustomizableStyles.Neless:
                            break;
                        case CustomizableStyles.Rainy:
                            break;
                        case CustomizableStyles.Reon:
                            break;
                        case CustomizableStyles.Resio:
                            break;
                        case CustomizableStyles.Roast:
                            break;
                        case CustomizableStyles.Shades:
                            break;
                        case CustomizableStyles.Spice:
                            break;
                        case CustomizableStyles.System:
                            break;
                        case CustomizableStyles.Vant:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
        {
        }

        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();

            switch (Theme)
            {
                case Themes.Adobe:
                    break;
                case Themes.AdvancedSystem:
                    break;
                case Themes.Advantium:
                    break;
                case Themes.Alpha:
                    break;
                case Themes.Angel:
                    break;
                case Themes.Anom:
                    break;
                case Themes.Aresio:
                    break;
                case Themes.Aryan:
                    break;
                case Themes.Atrocity:
                    break;
                case Themes.Avatar:
                    break;
                case Themes.AVG:
                    break;
                case Themes.BasicCode:
                    break;
                case Themes.BetaBlue:
                    break;
                case Themes.Beyond:
                    break;
                case Themes.Bionic:
                    break;
                case Themes.BitDefender:
                    break;
                case Themes.BlackShades:
                    break;
                case Themes.Bloody:
                    break;
                case Themes.BlueAndWhite:
                    break;
                case Themes.Blue:
                    break;
                case Themes.Booster:
                    break;
                case Themes.Border:
                    break;
                case Themes.Bullion:
                    break;
                case Themes.ButterScotch:
                    break;
                case Themes.CarbonFibre:
                    break;
                case Themes.Chrome:
                    break;
                case Themes.Clarity:
                    break;
                case Themes.Classic:
                    break;
                case Themes.clsNeoBux:
                    break;
                case Themes.CocaCola:
                    break;
                case Themes.Complex:
                    break;
                case Themes.Crystal:
                    break;
                case Themes.Cypher:
                    break;
                case Themes.CypherX:
                    break;
                case Themes.DarkMatter:
                    break;
                case Themes.DarkMatterAlt:
                    break;
                case Themes.Design:
                    break;
                case Themes.Destiny:
                    break;
                case Themes.Deumos:
                    break;
                case Themes.Doom:
                    break;
                case Themes.Drone:
                    break;
                case Themes.Earn:
                    break;
                case Themes.Effectual:
                    break;
                case Themes.EightBall:
                    break;
                case Themes.Electric:
                    break;
                case Themes.Electrified:
                    break;
                case Themes.Elegant:
                    break;
                case Themes.Element:
                    break;
                case Themes.Empire:
                    break;
                case Themes.Empress:
                    break;
                case Themes.ETheme:
                    break;
                case Themes.Evolve:
                    break;
                case Themes.Excision:
                    break;
                case Themes.Exotic:
                    break;
                case Themes.Facebook:
                    break;
                case Themes.Festus:
                    break;
                case Themes.FireFox:
                    break;
                case Themes.FlatUI:
                    break;
                case Themes.Flow:
                    break;
                case Themes.Frog:
                    break;
                case Themes.Fusion:
                    break;
                case Themes.Future:
                    break;
                case Themes.GTheme:
                    break;
                case Themes.GameBooster:
                    break;
                case Themes.Genuine:
                    break;
                case Themes.Ghostv2:
                    GhostTextChanged(e);
                    break;
                case Themes.GhostTheme:
                    break;
                case Themes.Gray:
                    break;
                case Themes.Green:
                    break;
                case Themes.Hacker:
                    break;
                case Themes.Hero:
                    break;
                case Themes.Hex:
                    break;
                case Themes.HF:
                    break;
                case Themes.Hura:
                    break;
                case Themes.iBlack:
                    break;
                case Themes.Influence:
                    break;
                case Themes.Influx:
                    break;
                case Themes.InnerDarkness:
                    break;
                case Themes.Insomia:
                    break;
                case Themes.Intel:
                    break;
                case Themes.JTheme:
                    break;
                case Themes.Knight:
                    break;
                case Themes.Light:
                    break;
                case Themes.Login:
                    break;
                case Themes.Loyal:
                    break;
                case Themes.Meph:
                    break;
                case Themes.Metal:
                    break;
                case Themes.MetroUI:
                    break;
                case Themes.MetroDisk:
                    break;
                case Themes.Modern:
                    break;
                case Themes.MPGH:
                    break;
                case Themes.Mumtz:
                    break;
                case Themes.Mystic:
                    break;
                case Themes.Nameless:
                    break;
                case Themes.NeoBux:
                    break;
                case Themes.NetSeal:
                    break;
                case Themes.New:
                    break;
                case Themes.NYX:
                    break;
                case Themes.Orains:
                    break;
                case Themes.Origin:
                    break;
                case Themes.Paladin:
                    break;
                case Themes.Patrick:
                    break;
                case Themes.Perplex:
                    break;
                case Themes.Positron:
                    break;
                case Themes.Prime:
                    break;
                case Themes.Purity:
                    break;
                case Themes.Qube:
                    break;
                case Themes.Reactor:
                    break;
                case Themes.Recon:
                    break;
                case Themes.Recuperare:
                    break;
                case Themes.Redwagon:
                    break;
                case Themes.Redemption:
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    break;
                case Themes.Sasi:
                    break;
                case Themes.Secure:
                    break;
                case Themes.Sharp:
                    break;
                case Themes.Simpla:
                    break;
                case Themes.SimpleGrey:
                    break;
                case Themes.Simplistic:
                    break;
                case Themes.Situation:
                    break;
                case Themes.SkyBase:
                    break;
                case Themes.Skype:
                    break;
                case Themes.SLC:
                    break;
                case Themes.Somnium:
                    break;
                case Themes.Spicylips:
                    break;
                case Themes.Steam:
                    break;
                case Themes.SteamAlt:
                    break;
                case Themes.Storm:
                    break;
                case Themes.Studio:
                    break;
                case Themes.Subspace:
                    break;
                case Themes.Sugar:
                    break;
                case Themes.TeamViewer:
                    break;
                case Themes.Tech:
                    break;
                case Themes.Teen:
                    break;
                case Themes.Tennis:
                    break;
                case Themes.TheBlack:
                    break;
                case Themes.Thief:
                    break;
                case Themes.Twitch:
                    break;
                case Themes.Ubuntu:
                    break;
                case Themes.Uclear:
                    break;
                case Themes.Uplay:
                    break;
                case Themes.VTheme:
                    break;
                case Themes.VibeLander:
                    break;
                case Themes.Visceral:
                    break;
                case Themes.Vitality:
                    break;
                case Themes.Vs:
                    break;
                case Themes.White:
                    break;
                case Themes.Winter:
                    break;
                case Themes.Xbox:
                    break;
                case Themes.Xtreme:
                    break;
                case Themes.xVisual:
                    break;
                case Themes.Youtube:
                    break;
                case Themes.Zeus:
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            break;
                        case CustomizableStyles.Boost:
                            break;
                        case CustomizableStyles.Class:
                            break;
                        case CustomizableStyles.Defend:
                            break;
                        case CustomizableStyles.Dobe:
                            break;
                        case CustomizableStyles.Duos:
                            break;
                        case CustomizableStyles.Exon:
                            break;
                        case CustomizableStyles.Ezus:
                            break;
                        case CustomizableStyles.Fute:
                            break;
                        case CustomizableStyles.Gamer:
                            break;
                        case CustomizableStyles.Intel:
                            break;
                        case CustomizableStyles.Mizer:
                            break;
                        case CustomizableStyles.Neal:
                            break;
                        case CustomizableStyles.Neless:
                            break;
                        case CustomizableStyles.Rainy:
                            break;
                        case CustomizableStyles.Reon:
                            break;
                        case CustomizableStyles.Resio:
                            break;
                        case CustomizableStyles.Roast:
                            break;
                        case CustomizableStyles.Shades:
                            break;
                        case CustomizableStyles.Spice:
                            break;
                        case CustomizableStyles.System:
                            break;
                        case CustomizableStyles.Vant:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
        }

        protected override void OnResize(EventArgs e)
        {
            switch (Theme)
            {
                case Themes.Adobe:
                    break;
                case Themes.AdvancedSystem:
                    break;
                case Themes.Advantium:
                    break;
                case Themes.Alpha:
                    break;
                case Themes.Angel:
                    break;
                case Themes.Anom:
                    break;
                case Themes.Aresio:
                    break;
                case Themes.Aryan:
                    break;
                case Themes.Atrocity:
                    break;
                case Themes.Avatar:
                    break;
                case Themes.AVG:
                    break;
                case Themes.BasicCode:
                    break;
                case Themes.BetaBlue:
                    break;
                case Themes.Beyond:
                    break;
                case Themes.Bionic:
                    break;
                case Themes.BitDefender:
                    break;
                case Themes.BlackShades:
                    break;
                case Themes.Bloody:
                    break;
                case Themes.BlueAndWhite:
                    BaWOnResize(e);
                    break;
                case Themes.Blue:
                    break;
                case Themes.Booster:
                    break;
                case Themes.Border:
                    break;
                case Themes.Bullion:
                    break;
                case Themes.ButterScotch:
                    break;
                case Themes.CarbonFibre:
                    break;
                case Themes.Chrome:
                    break;
                case Themes.Clarity:
                    break;
                case Themes.Classic:
                    break;
                case Themes.clsNeoBux:
                    break;
                case Themes.CocaCola:
                    break;
                case Themes.Complex:
                    break;
                case Themes.Crystal:
                    break;
                case Themes.Cypher:
                    break;
                case Themes.CypherX:
                    break;
                case Themes.DarkMatter:
                    break;
                case Themes.DarkMatterAlt:
                    break;
                case Themes.Design:
                    break;
                case Themes.Destiny:
                    break;
                case Themes.Deumos:
                    break;
                case Themes.Doom:
                    break;
                case Themes.Drone:
                    break;
                case Themes.Earn:
                    break;
                case Themes.Effectual:
                    break;
                case Themes.EightBall:
                    break;
                case Themes.Electric:
                    break;
                case Themes.Electrified:
                    break;
                case Themes.Elegant:
                    break;
                case Themes.Element:
                    break;
                case Themes.Empire:
                    break;
                case Themes.Empress:
                    break;
                case Themes.ETheme:
                    break;
                case Themes.Evolve:
                    break;
                case Themes.Excision:
                    break;
                case Themes.Exotic:
                    break;
                case Themes.Facebook:
                    break;
                case Themes.Festus:
                    break;
                case Themes.FireFox:
                    break;
                case Themes.FlatUI:
                    break;
                case Themes.Flow:
                    break;
                case Themes.Frog:
                    break;
                case Themes.Fusion:
                    break;
                case Themes.Future:
                    break;
                case Themes.GTheme:
                    break;
                case Themes.GameBooster:
                    break;
                case Themes.Genuine:
                    break;
                case Themes.Ghostv2:
                    break;
                case Themes.GhostTheme:
                    break;
                case Themes.Gray:
                    break;
                case Themes.Green:
                    break;
                case Themes.Hacker:
                    break;
                case Themes.Hero:
                    break;
                case Themes.Hex:
                    break;
                case Themes.HF:
                    break;
                case Themes.Hura:
                    break;
                case Themes.iBlack:
                    break;
                case Themes.Influence:
                    break;
                case Themes.Influx:
                    break;
                case Themes.InnerDarkness:
                    break;
                case Themes.Insomia:
                    break;
                case Themes.Intel:
                    break;
                case Themes.JTheme:
                    break;
                case Themes.Knight:
                    break;
                case Themes.Light:
                    break;
                case Themes.Login:
                    switch (Loginstyle)
                    {
                        case LoginStyles.Button:
                            Invalidate();
                            break;
                        case LoginStyles.ButtonWithProgress:
                            Invalidate();
                            break;
                        case LoginStyles.Log:
                            Size = new Size(50, 50);
                            Invalidate();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                case Themes.Loyal:
                    break;
                case Themes.Meph:
                    break;
                case Themes.Metal:
                    break;
                case Themes.MetroUI:
                    break;
                case Themes.MetroDisk:
                    break;
                case Themes.Modern:
                    break;
                case Themes.MPGH:
                    break;
                case Themes.Mumtz:
                    break;
                case Themes.Mystic:
                    break;
                case Themes.Nameless:
                    break;
                case Themes.NeoBux:
                    break;
                case Themes.NetSeal:
                    break;
                case Themes.New:
                    break;
                case Themes.NYX:
                    break;
                case Themes.Orains:
                    break;
                case Themes.Origin:
                    break;
                case Themes.Paladin:
                    break;
                case Themes.Patrick:
                    break;
                case Themes.Perplex:
                    break;
                case Themes.Positron:
                    break;
                case Themes.Prime:
                    break;
                case Themes.Purity:
                    break;
                case Themes.Qube:
                    break;
                case Themes.Reactor:
                    break;
                case Themes.Recon:
                    break;
                case Themes.Recuperare:
                    break;
                case Themes.Redwagon:
                    break;
                case Themes.Redemption:
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    break;
                case Themes.Sasi:
                    break;
                case Themes.Secure:
                    break;
                case Themes.Sharp:
                    break;
                case Themes.Simpla:
                    break;
                case Themes.SimpleGrey:
                    break;
                case Themes.Simplistic:
                    break;
                case Themes.Situation:
                    break;
                case Themes.SkyBase:
                    break;
                case Themes.Skype:
                    break;
                case Themes.SLC:
                    break;
                case Themes.Somnium:
                    break;
                case Themes.Spicylips:
                    break;
                case Themes.Steam:
                    break;
                case Themes.SteamAlt:
                    break;
                case Themes.Storm:
                    break;
                case Themes.Studio:
                    break;
                case Themes.Subspace:
                    break;
                case Themes.Sugar:
                    break;
                case Themes.TeamViewer:
                    break;
                case Themes.Tech:
                    break;
                case Themes.Teen:
                    break;
                case Themes.Tennis:
                    break;
                case Themes.TheBlack:
                    break;
                case Themes.Thief:
                    break;
                case Themes.Twitch:
                    break;
                case Themes.Ubuntu:
                    break;
                case Themes.Uclear:
                    break;
                case Themes.Uplay:
                    break;
                case Themes.VTheme:
                    break;
                case Themes.VibeLander:
                    break;
                case Themes.Visceral:
                    break;
                case Themes.Vitality:
                    break;
                case Themes.Vs:
                    break;
                case Themes.White:
                    break;
                case Themes.Winter:
                    break;
                case Themes.Xbox:
                    break;
                case Themes.Xtreme:
                    break;
                case Themes.xVisual:
                    break;
                case Themes.Youtube:
                    break;
                case Themes.Zeus:
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            break;
                        case CustomizableStyles.Boost:
                            break;
                        case CustomizableStyles.Class:
                            break;
                        case CustomizableStyles.Defend:
                            break;
                        case CustomizableStyles.Dobe:
                            break;
                        case CustomizableStyles.Duos:
                            break;
                        case CustomizableStyles.Exon:
                            break;
                        case CustomizableStyles.Ezus:
                            break;
                        case CustomizableStyles.Fute:
                            break;
                        case CustomizableStyles.Gamer:
                            break;
                        case CustomizableStyles.Intel:
                            break;
                        case CustomizableStyles.Mizer:
                            break;
                        case CustomizableStyles.Neal:
                            break;
                        case CustomizableStyles.Neless:
                            break;
                        case CustomizableStyles.Rainy:
                            break;
                        case CustomizableStyles.Reon:
                            break;
                        case CustomizableStyles.Resio:
                            break;
                        case CustomizableStyles.Roast:
                            break;
                        case CustomizableStyles.Shades:
                            break;
                        case CustomizableStyles.Spice:
                            break;
                        case CustomizableStyles.System:
                            break;
                        case CustomizableStyles.Vant:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        protected override void OnAnimation()
        {
            switch (Theme)
            {
                case Themes.Adobe:
                    break;
                case Themes.AdvancedSystem:
                    break;
                case Themes.Advantium:
                    break;
                case Themes.Alpha:
                    break;
                case Themes.Angel:
                    break;
                case Themes.Anom:
                    break;
                case Themes.Aresio:
                    break;
                case Themes.Aryan:
                    break;
                case Themes.Atrocity:
                    break;
                case Themes.Avatar:
                    break;
                case Themes.AVG:
                    break;
                case Themes.BasicCode:
                    break;
                case Themes.BetaBlue:
                    break;
                case Themes.Beyond:
                    break;
                case Themes.Bionic:
                    break;
                case Themes.BitDefender:
                    break;
                case Themes.BlackShades:
                    break;
                case Themes.Bloody:
                    break;
                case Themes.BlueAndWhite:
                    break;
                case Themes.Blue:
                    break;
                case Themes.Booster:
                    break;
                case Themes.Border:
                    break;
                case Themes.Bullion:
                    break;
                case Themes.ButterScotch:
                    break;
                case Themes.CarbonFibre:
                    break;
                case Themes.Chrome:
                    break;
                case Themes.Clarity:
                    break;
                case Themes.Classic:
                    break;
                case Themes.clsNeoBux:
                    break;
                case Themes.CocaCola:
                    break;
                case Themes.Complex:
                    break;
                case Themes.Crystal:
                    switch (State)
                    {
                        case MouseState.Over:
                            if (crystalA < 40)
                            {
                                crystalA += 8;
                                Invalidate();
                                Application.DoEvents();
                            }
                            break;
                        case MouseState.None:
                            if (crystalA > 0)
                            {
                                crystalA -= 10;
                                if (crystalA < 0)
                                    crystalA = 0;
                                Invalidate();
                                Application.DoEvents();
                            }
                            break;
                    }
                    break;
                case Themes.Cypher:
                    break;
                case Themes.CypherX:
                    break;
                case Themes.DarkMatter:
                    break;
                case Themes.DarkMatterAlt:
                    break;
                case Themes.Design:
                    break;
                case Themes.Destiny:
                    break;
                case Themes.Deumos:
                    break;
                case Themes.Doom:
                    break;
                case Themes.Drone:
                    break;
                case Themes.Earn:
                    break;
                case Themes.Effectual:
                    break;
                case Themes.EightBall:
                    break;
                case Themes.Electric:
                    break;
                case Themes.Electrified:
                    break;
                case Themes.Elegant:
                    break;
                case Themes.Element:
                    break;
                case Themes.Empire:
                    break;
                case Themes.Empress:
                    break;
                case Themes.ETheme:
                    break;
                case Themes.Evolve:
                    break;
                case Themes.Excision:
                    break;
                case Themes.Exotic:
                    break;
                case Themes.Facebook:
                    break;
                case Themes.Festus:
                    break;
                case Themes.FireFox:
                    break;
                case Themes.FlatUI:
                    break;
                case Themes.Flow:
                    break;
                case Themes.Frog:
                    break;
                case Themes.Fusion:
                    break;
                case Themes.Future:
                    break;
                case Themes.GTheme:
                    break;
                case Themes.GameBooster:
                    break;
                case Themes.Genuine:
                    break;
                case Themes.Ghostv2:
                    switch (State)
                    {
                        case MouseState.Over:
                            if (a < 20)
                            {
                                a += 5;
                                Invalidate();
                                Application.DoEvents();
                            }
                            break;
                        case MouseState.None:
                            if (a > 0)
                            {
                                a -= 5;
                                if (a < 0)
                                    a = 0;
                                Invalidate();
                                Application.DoEvents();
                            }
                            break;
                    }
                    break;
                case Themes.GhostTheme:
                    break;
                case Themes.Gray:
                    break;
                case Themes.Green:
                    break;
                case Themes.Hacker:
                    break;
                case Themes.Hero:
                    break;
                case Themes.Hex:
                    break;
                case Themes.HF:
                    break;
                case Themes.Hura:
                    break;
                case Themes.iBlack:
                    break;
                case Themes.Influence:
                    break;
                case Themes.Influx:
                    break;
                case Themes.InnerDarkness:
                    break;
                case Themes.Insomia:
                    break;
                case Themes.Intel:
                    IntelOnAnimation();
                    break;
                case Themes.JTheme:
                    break;
                case Themes.Knight:
                    break;
                case Themes.Light:
                    break;
                case Themes.Login:
                    break;
                case Themes.Loyal:
                    break;
                case Themes.Meph:
                    break;
                case Themes.Metal:
                    break;
                case Themes.MetroUI:
                    break;
                case Themes.MetroDisk:
                    break;
                case Themes.Modern:
                    break;
                case Themes.MPGH:
                    break;
                case Themes.Mumtz:
                    break;
                case Themes.Mystic:
                    break;
                case Themes.Nameless:
                    break;
                case Themes.NeoBux:
                    break;
                case Themes.NetSeal:
                    break;
                case Themes.New:
                    break;
                case Themes.NYX:
                    break;
                case Themes.Orains:
                    break;
                case Themes.Origin:
                    break;
                case Themes.Paladin:
                    break;
                case Themes.Patrick:
                    break;
                case Themes.Perplex:
                    break;
                case Themes.Positron:
                    break;
                case Themes.Prime:
                    break;
                case Themes.Purity:
                    break;
                case Themes.Qube:
                    break;
                case Themes.Reactor:
                    break;
                case Themes.Recon:
                    break;
                case Themes.Recuperare:
                    break;
                case Themes.Redwagon:
                    break;
                case Themes.Redemption:
                    break;
                case Themes.Resizable:
                    break;
                case Themes.Rockstar:
                    break;
                case Themes.Sasi:
                    break;
                case Themes.Secure:
                    break;
                case Themes.Sharp:
                    break;
                case Themes.Simpla:
                    break;
                case Themes.SimpleGrey:
                    break;
                case Themes.Simplistic:
                    break;
                case Themes.Situation:
                    break;
                case Themes.SkyBase:
                    break;
                case Themes.Skype:
                    break;
                case Themes.SLC:
                    break;
                case Themes.Somnium:
                    break;
                case Themes.Spicylips:
                    break;
                case Themes.Steam:
                    break;
                case Themes.SteamAlt:
                    break;
                case Themes.Storm:
                    break;
                case Themes.Studio:
                    break;
                case Themes.Subspace:
                    break;
                case Themes.Sugar:
                    break;
                case Themes.TeamViewer:
                    break;
                case Themes.Tech:
                    break;
                case Themes.Teen:
                    break;
                case Themes.Tennis:
                    break;
                case Themes.TheBlack:
                    break;
                case Themes.Thief:
                    break;
                case Themes.Twitch:
                    break;
                case Themes.Ubuntu:
                    break;
                case Themes.Uclear:
                    UClearOnAnimation();
                    break;
                case Themes.Uplay:
                    UPlayOnAnimation();
                    break;
                case Themes.VTheme:
                    break;
                case Themes.VibeLander:
                    break;
                case Themes.Visceral:
                    break;
                case Themes.Vitality:
                    break;
                case Themes.Vs:
                    break;
                case Themes.White:
                    break;
                case Themes.Winter:
                    break;
                case Themes.Xbox:
                    break;
                case Themes.Xtreme:
                    break;
                case Themes.xVisual:
                    break;
                case Themes.Youtube:
                    break;
                case Themes.Zeus:
                    break;
                case Themes.Customized:
                    switch (CustomizableStyle)
                    {
                        case CustomizableStyles.Basic:
                            break;
                        case CustomizableStyles.Boost:
                            break;
                        case CustomizableStyles.Class:
                            break;
                        case CustomizableStyles.Defend:
                            break;
                        case CustomizableStyles.Dobe:
                            break;
                        case CustomizableStyles.Duos:
                            break;
                        case CustomizableStyles.Exon:
                            break;
                        case CustomizableStyles.Ezus:
                            break;
                        case CustomizableStyles.Fute:
                            break;
                        case CustomizableStyles.Gamer:
                            break;
                        case CustomizableStyles.Intel:
                            CustomIntelOnAnimation();
                            break;
                        case CustomizableStyles.Mizer:
                            break;
                        case CustomizableStyles.Neal:
                            break;
                        case CustomizableStyles.Neless:
                            break;
                        case CustomizableStyles.Rainy:
                            break;
                        case CustomizableStyles.Reon:
                            break;
                        case CustomizableStyles.Resio:
                            break;
                        case CustomizableStyles.Roast:
                            break;
                        case CustomizableStyles.Shades:
                            break;
                        case CustomizableStyles.Spice:
                            break;
                        case CustomizableStyles.System:
                            break;
                        case CustomizableStyles.Vant:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            
        }


        #endregion

        #endregion

        
        #region Click Animation

        #region Include in Constructor

        private void IncludeInConstructor()
        {
            locate = new Point(Location.X, Location.Y);
            ClickTimer.Tick += ClickTimer_Tick;
        }

        #endregion

        #region Fields
        int xx;
        int yy;
        private bool clicked = false;
        private Point locate;
        Timer ClickTimer = new Timer();
        private bool allowClickAnimation = true;
        private int clickinterval = 1;
        private int offset = 1;
        private int maxOffset = 10;
        #endregion

        #region Properties

        public int ClickOffset
        {
            get { return offset; }
            set
            {
                offset = value;
                Invalidate();
            }
        }

        public int ClickMaxOffset
        {
            get { return maxOffset; }
            set
            {
                maxOffset = value;
                Invalidate();
            }
        }

        public int ClickSpeed
        {
            get { return clickinterval; }
            set
            {
                clickinterval = value;
                Invalidate();
            }
        }

        public bool AllowClickAnimation
        {
            get { return allowClickAnimation; }
            set { allowClickAnimation = value; }
        }

        #endregion

        #region Events

        private void ClickTimer_Tick(object sender, EventArgs e)
        {

            if (clicked)
            {
                this.Location = new Point(Location.X, Location.Y + ClickOffset);
                //this.Location = new Point(Location.X, Location.Y - 10);
            }
            else
            {
                this.Location = locate;
            }

            if (Location.Y > locate.Y + ClickMaxOffset)
            {
                this.Location = locate;
                ClickTimer.Stop();
            }

            Invalidate();

        }

        private void ClickOnMouseDown(MouseEventArgs e)
        {
            locate = new Point(Location.X, Location.Y);
            clicked = true;

            xx = e.X;
            yy = e.Y;
            //Focus = true;
            //AnimationTimer.Start();

            ClickTimer.Start();

            Invalidate();
        }

        private void ClickOnMouseUp(MouseEventArgs e)
        {
            
            clicked = false;

            //Focus = false;
            //AnimationTimer.Start();
            if (allowClickAnimation)
            {
                ClickTimer.Start();
            }

            Invalidate();
        }

        #endregion

        #endregion
        
        


    }


    #region Smart Tag Code

    #region Cut and Paste it on top of the component class

    //--------------- [Designer(typeof(ButtonThematicDesigner))] --------------------//
    #endregion

    #region ControlDesigner
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class ButtonThematicDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        private DesignerActionListCollection actionLists;

        // Use pull model to populate smart tag menu.
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (null == actionLists)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new ButtonThematicSmartTagActionList(this.Component));
                }
                return actionLists;
            }
        }

        #region Zeroit Filter (Remove Properties)
        /// <summary>
        /// Remove Button and Control properties that are 
        /// not supported by the <see cref="MACButton"/>.
        /// </summary>
        protected override void PostFilterProperties(IDictionary Properties)
        {
            //Properties.Remove("AllowDrop");
            //Properties.Remove("FlatStyle");
            //Properties.Remove("ForeColor");
            //Properties.Remove("ImageIndex");
            //Properties.Remove("ImageList");
        }
        #endregion

    }

    #endregion

    #region SmartTagActionList
    public class ButtonThematicSmartTagActionList : System.ComponentModel.Design.DesignerActionList
    {
        //Replace SmartTag with the Component Class Name. In this case the component class name is SmartTag
        private ButtonThematic colUserControl;


        private DesignerActionUIService designerActionUISvc = null;


        public ButtonThematicSmartTagActionList(IComponent component) : base(component)
        {
            this.colUserControl = component as ButtonThematic;

            // Cache a reference to DesignerActionUIService, so the 
            // DesigneractionList can be refreshed. 
            this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        // Helper method to retrieve control properties. Use of GetProperties enables undo and menu updates to work properly.
        private PropertyDescriptor GetPropertyByName(String propName)
        {
            PropertyDescriptor prop;
            prop = TypeDescriptor.GetProperties(colUserControl)[propName];
            if (null == prop)
                throw new ArgumentException("Matching ColorLabel property not found!", propName);
            else
                return prop;
        }

        #region Properties that are targets of DesignerActionPropertyItem entries.

        
        public Themes Theme
        {
            get
            {
                return colUserControl.Theme;
            }
            set
            {
                GetPropertyByName("Theme").SetValue(colUserControl, value);
            }
        }

        public ButtonInput Customize
        {
            get
            {
                return colUserControl.Customize;
            }
            set
            {
                GetPropertyByName("Customize").SetValue(colUserControl, value);
            }
        }

        #endregion

        #region DesignerActionItemCollection

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection();

            //Define static section header entries.
            items.Add(new DesignerActionHeaderItem("Appearance"));

            
            items.Add(new DesignerActionPropertyItem("Theme",
                                 "Theme", "Appearance",
                                 "Sets the theme of the button."));

            items.Add(new DesignerActionPropertyItem("Customize",
                "Customize", "Appearance",
                "Customize the control."));

            //Create entries for static Information section.
            StringBuilder location = new StringBuilder("Product: ");
            location.Append(colUserControl.ProductName);
            StringBuilder size = new StringBuilder("Version: ");
            size.Append(colUserControl.ProductVersion);
            items.Add(new DesignerActionTextItem(location.ToString(),
                             "Information"));
            items.Add(new DesignerActionTextItem(size.ToString(),
                             "Information"));

            return items;
        }

        #endregion




    }

    #endregion

    #endregion

}
