// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ButtonInput.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.BaseContainer;


namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class ButtonInput.
    /// </summary>
    [TypeConverter(typeof(ButtonConverter))]
    [Editor(typeof(ButtonEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [Serializable]
    public partial class ButtonInput
    {

        #region Private Fields
        /// <summary>
        /// The customizable style
        /// </summary>
        private CustomizableStyles customizableStyle = CustomizableStyles.Boost;
        /// <summary>
        /// The hatch style
        /// </summary>
        private HatchStyle hatchStyle = HatchStyle.LightDownwardDiagonal;
        /// <summary>
        /// The draw mode
        /// </summary>
        private ButtonThematic.RenderMode drawMode = ButtonThematic.RenderMode.Gradient;
        /// <summary>
        /// The gradient mode
        /// </summary>
        private LinearGradientMode gradientMode = LinearGradientMode.Vertical;
        /// <summary>
        /// The curve
        /// </summary>
        private int curve = 5;
        /// <summary>
        /// The gradient angle
        /// </summary>
        private float gradientAngle = 90f;
        /// <summary>
        /// The border size
        /// </summary>
        private int borderSize = 1;


        #endregion
        
        #region Public Properties

        /// <summary>
        /// Gets or sets the hatch style.
        /// </summary>
        /// <value>The hatch style.</value>
        public HatchStyle HatchStyle
        {
            get { return hatchStyle; }
            set
            {
                hatchStyle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the draw mode.
        /// </summary>
        /// <value>The draw mode.</value>
        public ButtonThematic.RenderMode DrawMode
        {
            get { return drawMode; }
            set
            {
                drawMode = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the curve.
        /// </summary>
        /// <value>The curve.</value>
        public int Curve
        {
            get { return curve; }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }
                curve = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the gradient angle.
        /// </summary>
        /// <value>The gradient angle.</value>
        public float GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value;  }
        }

        /// <summary>
        /// Gets or sets the gradient mode.
        /// </summary>
        /// <value>The gradient mode.</value>
        public LinearGradientMode GradientMode
        {
            get { return gradientMode; }
            set
            {
                gradientMode = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the customizable style.
        /// </summary>
        /// <value>The customizable style.</value>
        public CustomizableStyles CustomizableStyle
        {
            get { return customizableStyle; }
            set
            {
                customizableStyle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the size of the border.
        /// </summary>
        /// <value>The size of the border.</value>
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                
            }
        }

        #endregion

        #region Additions

        #endregion

        #region Public Methods

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>ButtonInput.</returns>
        public ButtonInput Clone()
        {
            return new ButtonInput(
                customizableStyle,
                hatchStyle,
                drawMode,
                gradientMode,
                //curve,
                gradientAngle
            );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>ButtonInput.</returns>
        public static ButtonInput Empty()
        {
            return new ButtonInput();
        }


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customizableStyle">The customizable style.</param>
        /// <param name="hatchStyle">The hatch style.</param>
        /// <param name="drawMode">The draw mode.</param>
        /// <param name="gradientMode">The gradient mode.</param>
        /// <param name="gradientAngle">The gradient angle.</param>
        public ButtonInput(
            CustomizableStyles customizableStyle,
            HatchStyle hatchStyle,
            ButtonThematic.RenderMode drawMode,
            LinearGradientMode gradientMode,
            //int curve,
            float gradientAngle
        )
        {
            this.customizableStyle = customizableStyle;
            this.hatchStyle = hatchStyle;
            this.drawMode = drawMode;
            this.gradientMode = gradientMode;
            //this.curve = curve;
            this.gradientAngle = gradientAngle;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        public ButtonInput() : this(
            CustomizableStyles.System,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
            )
        {

        }

        //-----------Adobe----------//
        /// <summary>
        /// Initializes a new instance of the <c>Adobe</c> <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customizableAdobeBackground">The customizable adobe background.</param>
        /// <param name="customizableAdobeCoefficient">The customizable adobe coefficient.</param>
        /// <param name="customizableAdobeBorderOffset">The customizable adobe border offset.</param>
        /// <param name="customizableAdobeColors">The customizable adobe colors.</param>
        public ButtonInput(
            Color customizableAdobeBackground,
            int customizableAdobeCoefficient,
            int customizableAdobeBorderOffset,
            Color[] customizableAdobeColors

            ) : this(
            CustomizableStyles.Dobe,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customizableAdobeBackground = customizableAdobeBackground;
            this.customizableAdobeCoefficient = customizableAdobeCoefficient;
            this.customizableAdobeBorderOffset = customizableAdobeBorderOffset;
            this.customizableAdobeColors = customizableAdobeColors;
            
        }

        //-----------Custom Advanced System----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customizableadvancedSystemGlow">The customizableadvanced system glow.</param>
        /// <param name="slope">The slope.</param>
        /// <param name="customizableAdvSysBackColor">Color of the customizable adv system back.</param>
        /// <param name="customAdvSysColorDilution">The custom adv system color dilution.</param>
        public ButtonInput(
            Color customizableadvancedSystemGlow,
            int slope,
            Color customizableAdvSysBackColor,
            Color customAdvSysColorDilution

        ) : this(
            CustomizableStyles.System,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customizableadvancedSystemGlow = customizableadvancedSystemGlow;
            this.Curve = slope;
            this.customizableAdvSysBackColor = customizableAdvSysBackColor;
            this.customAdvSysColorDilution = customAdvSysColorDilution;
            
        }

        //-----------Custom Advantium----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customAdvantiumBack">The custom advantium back.</param>
        /// <param name="customAdvantiumNoneColors">The custom advantium none colors.</param>
        /// <param name="customAdvantiumDownColors">The custom advantium down colors.</param>
        /// <param name="customAdvantiumOverColors">The custom advantium over colors.</param>
        /// <param name="customAdvantiumBorderColors">The custom advantium border colors.</param>
        /// <param name="customAdvantiumOffsets">The custom advantium offsets.</param>
        public ButtonInput(
            Color customAdvantiumBack,
            Color[] customAdvantiumNoneColors,
            Color[] customAdvantiumDownColors,
            Color[] customAdvantiumOverColors,
            Color[] customAdvantiumBorderColors,
            int[] customAdvantiumOffsets

        ) : this(
            CustomizableStyles.Vant,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customAdvantiumBack = customAdvantiumBack;
            this.customAdvantiumNoneColors = customAdvantiumNoneColors;
            this.customAdvantiumDownColors = customAdvantiumDownColors;
            this.customAdvantiumOverColors = customAdvantiumOverColors;
            this.customAdvantiumBorderColors = customAdvantiumBorderColors;
            this.customAdvantiumOffsets = customAdvantiumOffsets;

        }

        //-----------Custom Aresio----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customAresioBorderColors">The custom aresio border colors.</param>
        /// <param name="customAresioNoneColors">The custom aresio none colors.</param>
        /// <param name="customAresioOverColors">The custom aresio over colors.</param>
        /// <param name="customAresioDownColors">The custom aresio down colors.</param>
        public ButtonInput(
            Color[] customAresioBorderColors,
            Color[] customAresioNoneColors,
            Color[] customAresioOverColors,
            Color[] customAresioDownColors
            
        ) : this(
            CustomizableStyles.Resio,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customAresioBorderColors = customAresioBorderColors;
            this.customAresioNoneColors = customAresioNoneColors;
            this.customAresioOverColors = customAresioOverColors;
            this.customAresioDownColors = customAresioDownColors;
            
        }

        //-----------Custom Basic----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customBasicColors">The custom basic colors.</param>
        /// <param name="customBasicStateColors">The custom basic state colors.</param>
        /// <param name="customBasicHighlights">The custom basic highlights.</param>
        /// <param name="customBasicBorderColors">The custom basic border colors.</param>
        /// <param name="customBasicDisabled">The custom basic disabled.</param>
        /// <param name="customBasicOffset">The custom basic offset.</param>
        public ButtonInput(
            Color[] customBasicColors,
            Color[] customBasicStateColors,
            Color[] customBasicHighlights,
            Color[] customBasicBorderColors,
            Color[] customBasicDisabled,
            int customBasicOffset

        ) : this(
            CustomizableStyles.Basic,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customBasicColors = customBasicColors;
            this.customBasicStateColors = customBasicStateColors;
            this.customBasicHighlights = customBasicHighlights;
            this.customBasicBorderColors = customBasicBorderColors;
            this.customBasicDisabled = customBasicDisabled;
            this.customBasicOffset = customBasicOffset;

        }

        //-----------Custom BitDefender----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customBitDefenderC1">The custom bit defender c1.</param>
        /// <param name="customBitDefenderC2">The custom bit defender c2.</param>
        /// <param name="customBitDefenderC3">The custom bit defender c3.</param>
        /// <param name="customBitDefenderC4">The custom bit defender c4.</param>
        /// <param name="customBitDefenderC5">The custom bit defender c5.</param>
        /// <param name="customBitDefenderC6">The custom bit defender c6.</param>
        /// <param name="customBitDefenderBorder">The custom bit defender border.</param>
        /// <param name="customBitDefenderFadeColor">Color of the custom bit defender fade.</param>
        /// <param name="curve">The curve.</param>
        public ButtonInput(
            Color customBitDefenderC1,
            Color customBitDefenderC2,
            Color customBitDefenderC3,
            Color customBitDefenderC4,
            Color customBitDefenderC5,
            Color customBitDefenderC6,
            Color customBitDefenderBorder,
            Color customBitDefenderFadeColor,
            int curve//int customBitDefenderCurve

        ) : this(
            CustomizableStyles.Defend,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customBitDefenderC1 = customBitDefenderC1;
            this.customBitDefenderC2 = customBitDefenderC2;
            this.customBitDefenderC3 = customBitDefenderC3;
            this.customBitDefenderC4 = customBitDefenderC4;
            this.customBitDefenderC5 = customBitDefenderC5;
            this.customBitDefenderC6 = customBitDefenderC6;
            this.customBitDefenderBorder = customBitDefenderBorder;
            this.customBitDefenderFadeColor = customBitDefenderFadeColor;
            this.curve = curve;//this.customBitDefenderCurve = customBitDefenderCurve;

        }

        //-----------Custom BlackShades----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customBlackShadesNoneColors">The custom black shades none colors.</param>
        /// <param name="customBlackShadesOverColors">The custom black shades over colors.</param>
        /// <param name="customBlackShadesDownColors">The custom black shades down colors.</param>
        /// <param name="curve">The curve.</param>
        public ButtonInput(
            Color[] customBlackShadesNoneColors,
            Color[] customBlackShadesOverColors,
            Color[] customBlackShadesDownColors,
            int curve//int customBlackShadesCurve

        ) : this(
            CustomizableStyles.Shades,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customBlackShadesNoneColors = customBlackShadesNoneColors;
            this.customBlackShadesOverColors = customBlackShadesOverColors;
            this.customBlackShadesDownColors = customBlackShadesDownColors;
            this.curve = curve; //this.customBlackShadesCurve = customBlackShadesCurve;
            
        }

        //-----------Custom Booster----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customBoosterColors">The custom booster colors.</param>
        /// <param name="customBoosterHatchColors">The custom booster hatch colors.</param>
        /// <param name="customBoosterOuterBorder">The custom booster outer border.</param>
        /// <param name="customBoosterInnerBorder">The custom booster inner border.</param>
        /// <param name="upperLeftCurve">The upper left curve.</param>
        /// <param name="upperRightCurve">The upper right curve.</param>
        /// <param name="downLeftCurve">Down left curve.</param>
        /// <param name="downRightCurve">Down right curve.</param>
        /// <param name="customBoosterOffset">The custom booster offset.</param>
        /// <param name="customGradientAngle">The custom gradient angle.</param>
        /// <param name="customBoosterHoverTransparency">The custom booster hover transparency.</param>
        /// <param name="customBoosterInfluenceOuter">if set to <c>true</c> [custom booster influence outer].</param>
        public ButtonInput(
            Color[] customBoosterColors,
            Color[] customBoosterHatchColors,
            Color customBoosterOuterBorder,
            Color customBoosterInnerBorder,
            int upperLeftCurve,
            int upperRightCurve,
            int downLeftCurve,
            int downRightCurve,
            int customBoosterOffset,
            float customGradientAngle,
            float customBoosterHoverTransparency,
            bool customBoosterInfluenceOuter

        ) : this(
            CustomizableStyles.Boost,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customBoosterColors = customBoosterColors;
            this.customBoosterHatchColors = customBoosterHatchColors;
            this.customBoosterOuterBorder = customBoosterOuterBorder;
            this.customBoosterInnerBorder = customBoosterInnerBorder;
            this.upperLeftCurve = upperLeftCurve;
            this.upperRightCurve = upperRightCurve;
            this.downLeftCurve = downLeftCurve;
            this.downRightCurve = downRightCurve;
            this.customBoosterOffset = customBoosterOffset;
            this.customGradientAngle = customGradientAngle;
            this.customBoosterHoverTransparency = customBoosterHoverTransparency;
            this.customBoosterInfluenceOuter = customBoosterInfluenceOuter;

        }

        //-----------Custom Classic----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customClassicColors">The custom classic colors.</param>
        /// <param name="customClassicBorder">The custom classic border.</param>
        /// <param name="customClassicHighlight">The custom classic highlight.</param>
        /// <param name="customClassicBackground">The custom classic background.</param>
        /// <param name="customClassicShadow">The custom classic shadow.</param>
        public ButtonInput(
            Color[] customClassicColors,
            Color customClassicBorder,
            Color customClassicHighlight,
            Color customClassicBackground,
            Color customClassicShadow
            
        ) : this(
            CustomizableStyles.Class,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customClassicColors = customClassicColors;
            this.customClassicBorder = customClassicBorder;
            this.customClassicHighlight = customClassicHighlight;
            this.customClassicBackground = customClassicBackground;
            this.customClassicShadow = customClassicShadow;
            
        }

        //-----------Custom Deumos----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customDeumosBackground">The custom deumos background.</param>
        /// <param name="customDeumosCornerColor">Color of the custom deumos corner.</param>
        /// <param name="customDeumosOverStateColor">Color of the custom deumos over state.</param>
        /// <param name="customDeumosBorderColors">The custom deumos border colors.</param>
        /// <param name="customDeumosDownStateColors">The custom deumos down state colors.</param>
        /// <param name="customDeumosNoneStateColors">The custom deumos none state colors.</param>
        public ButtonInput(
            Color customDeumosBackground,
            Color customDeumosCornerColor,
            Color customDeumosOverStateColor,
            Color[] customDeumosBorderColors,
            Color[] customDeumosDownStateColors,
            Color[] customDeumosNoneStateColors
            
        ) : this(
            CustomizableStyles.Duos,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customDeumosBackground = customDeumosBackground;
            this.customDeumosCornerColor = customDeumosCornerColor;
            this.customDeumosOverStateColor = customDeumosOverStateColor;
            this.customDeumosBorderColors = customDeumosBorderColors;
            this.customDeumosDownStateColors = customDeumosDownStateColors;
            this.customDeumosNoneStateColors = customDeumosNoneStateColors;
        }

        //-----------Custom Excision----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customExcisionStyle">The custom excision style.</param>
        /// <param name="imageCodeString">The image code string.</param>
        /// <param name="customExcisionBorderColors">The custom excision border colors.</param>
        public ButtonInput(
            ButtonThematic.CustomExcisionStyles customExcisionStyle,
            string imageCodeString,
            Color[] customExcisionBorderColors
        ) : this(
            CustomizableStyles.Exon,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customExcisionStyle = customExcisionStyle;
            this.imageCodeString = imageCodeString;
            this.customExcisionBorderColors = customExcisionBorderColors;
        }

        //-----------Custom Future----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customFusionGradColors">The custom fusion grad colors.</param>
        /// <param name="customFusionCornerColor">Color of the custom fusion corner.</param>
        /// <param name="customFusionNoneBorderColor">Color of the custom fusion none border.</param>
        /// <param name="customFusionDownBorderColor">Color of the custom fusion down border.</param>
        /// <param name="customFusionOverBorderColor">Color of the custom fusion over border.</param>
        /// <param name="customFusionBlend">The custom fusion blend.</param>
        public ButtonInput(
            Color[] customFusionGradColors,
            Color customFusionCornerColor,
            Color customFusionNoneBorderColor,
            Color customFusionDownBorderColor,
            Color customFusionOverBorderColor,
            ColorBlend customFusionBlend

        ) : this(
            CustomizableStyles.Fute,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customFusionGradColors = customFusionGradColors;
            this.customFusionCornerColor = customFusionCornerColor;
            this.customFusionNoneBorderColor = customFusionNoneBorderColor;
            this.customFusionDownBorderColor = customFusionDownBorderColor;
            this.customFusionOverBorderColor = customFusionOverBorderColor;
            this.customFusionBlend = customFusionBlend;

        }

        //-----------Custom Game Booster----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customGameBoosterTopGradient">The custom game booster top gradient.</param>
        /// <param name="customGameBoosterBotGradient">The custom game booster bot gradient.</param>
        /// <param name="customGameBoosterTopGradientClick">The custom game booster top gradient click.</param>
        /// <param name="customGameBoosterBotGradientClick">The custom game booster bot gradient click.</param>
        /// <param name="customGameBoosterTopGradientHover">The custom game booster top gradient hover.</param>
        /// <param name="customGameBoosterBotGradientHover">The custom game booster bot gradient hover.</param>
        /// <param name="customGameBoosterCornerColor">Color of the custom game booster corner.</param>
        /// <param name="customGameBoosterInnerBorder">The custom game booster inner border.</param>
        /// <param name="customGameBoosterOuterBorder">The custom game booster outer border.</param>
        /// <param name="customGameBoosterInnerBorderHover">The custom game booster inner border hover.</param>
        /// <param name="customGameBoosterOuterBorderHover">The custom game booster outer border hover.</param>
        /// <param name="customGameBoosterInnerBorderClick">The custom game booster inner border click.</param>
        /// <param name="customGameBoosterOuterBorderClick">The custom game booster outer border click.</param>
        public ButtonInput(
            Color customGameBoosterTopGradient,
            Color customGameBoosterBotGradient,
            Color customGameBoosterTopGradientClick,
            Color customGameBoosterBotGradientClick,
            Color customGameBoosterTopGradientHover,
            Color customGameBoosterBotGradientHover,
            Color customGameBoosterCornerColor,
            Color customGameBoosterInnerBorder,
            Color customGameBoosterOuterBorder,
            Color customGameBoosterInnerBorderHover,
            Color customGameBoosterOuterBorderHover,
            Color customGameBoosterInnerBorderClick,
            Color customGameBoosterOuterBorderClick

        ) : this(
            CustomizableStyles.Gamer,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customGameBoosterTopGradient = customGameBoosterTopGradient;
            this.customGameBoosterBotGradient = customGameBoosterBotGradient;
            this.customGameBoosterTopGradientClick = customGameBoosterTopGradientClick;
            this.customGameBoosterBotGradientClick = customGameBoosterBotGradientClick;
            this.customGameBoosterTopGradientHover = customGameBoosterTopGradientHover;
            this.customGameBoosterBotGradientHover = customGameBoosterBotGradientHover;
            this.customGameBoosterCornerColor = customGameBoosterCornerColor;
            this.customGameBoosterInnerBorder = customGameBoosterInnerBorder;
            this.customGameBoosterOuterBorder = customGameBoosterOuterBorder;
            this.customGameBoosterInnerBorderHover = customGameBoosterInnerBorderHover;
            this.customGameBoosterOuterBorderHover = customGameBoosterOuterBorderHover;
            this.customGameBoosterInnerBorderClick = customGameBoosterInnerBorderClick;
            this.customGameBoosterOuterBorderClick = customGameBoosterOuterBorderClick;

        }

        //-----------Custom Intel----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customIntelBackgroundColor">Color of the custom intel background.</param>
        /// <param name="customIntelBorderColor">Color of the custom intel border.</param>
        /// <param name="customIntelShade">The custom intel shade.</param>
        /// <param name="curve">The curve.</param>
        /// <param name="customIntelGlow">The custom intel glow.</param>
        public ButtonInput(
            Color customIntelBackgroundColor,
            Color customIntelBorderColor,
            Color customIntelShade,
            int curve,//int customIntelCurve,
            int customIntelGlow


        ) : this(
            CustomizableStyles.Intel,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customIntelBackgroundColor = customIntelBackgroundColor;
            this.customIntelBorderColor = customIntelBorderColor;
            this.customIntelShade = customIntelShade;
            this.curve = curve; //this.customIntelCurve = customIntelCurve;
            this.customIntelGlow = customIntelGlow;
            
        }

        //-----------Customized Button----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customizedBtnInactive">The customized BTN inactive.</param>
        /// <param name="customizedBtnActive">The customized BTN active.</param>
        /// <param name="customizedBtnActiveBorder">The customized BTN active border.</param>
        /// <param name="customizedBtnPressed">The customized BTN pressed.</param>
        /// <param name="customizedBtnPressedBorder">The customized BTN pressed border.</param>
        /// <param name="customizedBtnOffsetGradient">The customized BTN offset gradient.</param>
        /// <param name="customizedBtnOffsetBorder">The customized BTN offset border.</param>
        /// <param name="customizedBtnInactiveBorder">The customized BTN inactive border.</param>
        /// <param name="customizedBtnOffset">The customized BTN offset.</param>
        /// <param name="curve">The curve.</param>
        public ButtonInput(
            Color[] customizedBtnInactive,
            Color[] customizedBtnActive,
            Color[] customizedBtnActiveBorder,
            Color[] customizedBtnPressed,
            Color[] customizedBtnPressedBorder,
            Color[] customizedBtnOffsetGradient,
            Color[] customizedBtnOffsetBorder,
            Color customizedBtnInactiveBorder,
            int customizedBtnOffset,
            int curve//int customizedBtnRounding

        ) : this(
            CustomizableStyles.Mizer,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customizedBtnInactive = customizedBtnInactive;
            this.customizedBtnActive = customizedBtnActive;
            this.customizedBtnActiveBorder = customizedBtnActiveBorder;
            this.customizedBtnPressed = customizedBtnPressed;
            this.customizedBtnPressedBorder = customizedBtnPressedBorder;
            this.customizedBtnOffsetGradient = customizedBtnOffsetGradient;
            this.customizedBtnOffsetBorder = customizedBtnOffsetBorder;
            this.customizedBtnInactiveBorder = customizedBtnInactiveBorder;
            this.customizedBtnOffset = customizedBtnOffset;
            this.curve = curve;//this.customizedBtnRounding = customizedBtnRounding;
            

        }


        //-----------Custom Nameless----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customNamelessBorderColors">The custom nameless border colors.</param>
        /// <param name="customNamelessNoneHighlight">The custom nameless none highlight.</param>
        /// <param name="customNamelessOverHighlight">The custom nameless over highlight.</param>
        /// <param name="customNamelessDownHighlight">The custom nameless down highlight.</param>
        /// <param name="customNamelessCorners">The custom nameless corners.</param>
        public ButtonInput(
            Color[] customNamelessBorderColors,
            Color[] customNamelessNoneHighlight,
            Color[] customNamelessOverHighlight,
            Color[] customNamelessDownHighlight,
            Color customNamelessCorners
            
        ) : this(
            CustomizableStyles.Neless,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customNamelessBorderColors = customNamelessBorderColors;
            this.customNamelessNoneHighlight = customNamelessNoneHighlight;
            this.customNamelessOverHighlight = customNamelessOverHighlight;
            this.customNamelessDownHighlight = customNamelessDownHighlight;
            this.customNamelessCorners = customNamelessCorners;
            

        }

        //-----------Custom NetSeal----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customNetSealPathBorders">The custom net seal path borders.</param>
        /// <param name="customNetSealCenterColor">Color of the custom net seal center.</param>
        /// <param name="customNetSealSurroundColor">Color of the custom net seal surround.</param>
        /// <param name="customFocusScales">The custom focus scales.</param>
        /// <param name="curve">The curve.</param>
        public ButtonInput(
            Color[] customNetSealPathBorders,
            Color customNetSealCenterColor,
            Color customNetSealSurroundColor,
            PointF customFocusScales,
            int curve

        ) : this(
            CustomizableStyles.Neal,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customNetSealPathBorders = customNetSealPathBorders;
            this.customNetSealCenterColor = customNetSealCenterColor;
            this.customNetSealSurroundColor = customNetSealSurroundColor;
            this.customFocusScales = customFocusScales;
            this.curve = curve;
        }

        //-----------Custom Orains----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customOrainsInnerBorder">The custom orains inner border.</param>
        /// <param name="customOrainsHeader">The custom orains header.</param>
        /// <param name="customOrainsOuterBorder">The custom orains outer border.</param>
        /// <param name="customOrainsButton">The custom orains button.</param>
        /// <param name="customOrainsHatch">The custom orains hatch.</param>
        public ButtonInput(
            Color customOrainsInnerBorder,
            Color customOrainsHeader,
            Color customOrainsOuterBorder,
            Color[] customOrainsButton,
            Color[] customOrainsHatch

        ) : this(
            CustomizableStyles.Rainy,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customOrainsInnerBorder = customOrainsInnerBorder;
            this.customOrainsHeader = customOrainsHeader;
            this.customOrainsOuterBorder = customOrainsOuterBorder;
            this.customOrainsButton = customOrainsButton;
            this.customOrainsHatch = customOrainsHatch;

        }

        //-----------Custom Recon----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customReconBackground">The custom recon background.</param>
        /// <param name="customReconNoneStateColors">The custom recon none state colors.</param>
        /// <param name="customReconDownStateColors">The custom recon down state colors.</param>
        /// <param name="customReconOverStateColors">The custom recon over state colors.</param>
        /// <param name="customReconBorder">The custom recon border.</param>
        public ButtonInput(
            Color customReconBackground,
            Color[] customReconNoneStateColors,
            Color[] customReconDownStateColors,
            Color[] customReconOverStateColors,
            Color[] customReconBorder
            
        ) : this(
            CustomizableStyles.Reon,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customReconBackground = customReconBackground;
            this.customReconNoneStateColors = customReconNoneStateColors;
            this.customReconDownStateColors = customReconDownStateColors;
            this.customReconOverStateColors = customReconOverStateColors;
            this.customReconBorder = customReconBorder;

        }


        //-----------Custom SpicyLips----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customSpicyBackground">The custom spicy background.</param>
        /// <param name="customSpicyNoneStateColors">The custom spicy none state colors.</param>
        /// <param name="customSpicyOverStateColors">The custom spicy over state colors.</param>
        /// <param name="customSpicyDownStateColors">The custom spicy down state colors.</param>
        /// <param name="customSpicyHighlight">The custom spicy highlight.</param>
        /// <param name="customSpicyBorderColors">The custom spicy border colors.</param>
        /// <param name="customSpicyCornerColor">Color of the custom spicy corner.</param>
        public ButtonInput(
            Color customSpicyBackground,
            Color[] customSpicyNoneStateColors,
            Color[] customSpicyOverStateColors,
            Color[] customSpicyDownStateColors,
            Color customSpicyHighlight,
            Color[] customSpicyBorderColors,
            Color customSpicyCornerColor

        ) : this(
            CustomizableStyles.Spice,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customSpicyBackground = customSpicyBackground;
            this.customSpicyNoneStateColors = customSpicyNoneStateColors;
            this.customSpicyOverStateColors = customSpicyOverStateColors;
            this.customSpicyDownStateColors = customSpicyDownStateColors;
            this.customSpicyHighlight = customSpicyHighlight;
            this.customSpicyBorderColors = customSpicyBorderColors;
            this.customSpicyCornerColor = customSpicyCornerColor;
            
        }

        //-----------Custom Zeus----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customZeusBackground">The custom zeus background.</param>
        /// <param name="customZeusGradientColors">The custom zeus gradient colors.</param>
        /// <param name="customZeusBorderColors">The custom zeus border colors.</param>
        /// <param name="customZeusClickReduce">The custom zeus click reduce.</param>
        /// <param name="customZeusClickLocate">The custom zeus click locate.</param>
        public ButtonInput(
            Color customZeusBackground,
            Color[] customZeusGradientColors,
            Color[] customZeusBorderColors,
            int customZeusClickReduce,
            int customZeusClickLocate

        ) : this(
            CustomizableStyles.Ezus,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customZeusBackground = customZeusBackground;
            this.customZeusGradientColors = customZeusGradientColors;
            this.customZeusBorderColors = customZeusBorderColors;
            this.customZeusClickReduce = customZeusClickReduce;
            this.customZeusClickLocate = customZeusClickLocate;
            
        }


        //-----------Custom Roaster----------//
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonInput" /> class.
        /// </summary>
        /// <param name="customRoasterGradientColors">The custom roaster gradient colors.</param>
        /// <param name="customRoasterBorderColor">Color of the custom roaster border.</param>
        /// <param name="customRoasterBackgroundStateColors">The custom roaster background state colors.</param>
        public ButtonInput(
            Color[] customRoasterGradientColors,
            Color customRoasterBorderColor,
            Color[] customRoasterBackgroundStateColors
            
        ) : this(
            CustomizableStyles.Roast,
            HatchStyle.LightDownwardDiagonal,
            Controls.ButtonThematic.RenderMode.Gradient,
            LinearGradientMode.Vertical,
            /*10,*/ 90f
        )
        {
            this.customRoasterGradientColors = customRoasterGradientColors;
            this.customRoasterBorderColor = customRoasterBorderColor;
            this.customRoasterBackgroundStateColors = customRoasterBackgroundStateColors;
            
        }



        #endregion

    }
}
