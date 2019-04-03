// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ButtonInternal_Converter.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Reflection;
using Zeroit.Framework.ButtonThematic.BaseContainer;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class ButtonInput.
    /// </summary>
    public partial class ButtonInput
    {
        #region Converter

        #region Converter

        /// <summary>
        /// Class ButtonConverter.
        /// </summary>
        /// <seealso cref="System.ComponentModel.TypeConverter" />
        internal class ButtonConverter : TypeConverter
        {

            /// <summary>
            /// Returns whether this converter can convert the object to the specified type, using the specified context.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
            /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor)/* || destinationType == typeof(string)*/)
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            // This code allows the designer to generate the Shape constructor

            /// <summary>
            /// Converts the given value object to the specified type, using the specified context and culture information.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
            /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
            /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
            /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
            public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value,
                Type destinationType)
            {
                
                    if (destinationType == typeof(string))
                    {
                        // Display string in designer
                        return "(Customize)";
                    }


                    else if (destinationType == typeof(InstanceDescriptor) && value is ButtonInput)
                    {
                        ButtonInput buttonInput = (ButtonInput)value;

                        if (buttonInput.CustomizableStyle == CustomizableStyles.Dobe)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[]
                            {


                                typeof(Color),
                                typeof(int),
                                typeof(int),
                                typeof(Color)
                                


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {


                                buttonInput.CustomizableAdobeBackground,
                                buttonInput.CustomizableAdobeCoefficient,
                                buttonInput.CustomizableAdobeBorderOffset,
                                buttonInput.CustomizableAdobeColors

                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.System)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {
                            typeof(Color),
                            typeof(int),
                            typeof(Color),
                            typeof(Color)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                buttonInput.CustomizableAdvancedSystemGlow,
                                buttonInput.Curve,//buttonInput.CustomizableAdvancedSystemSlope,
                                buttonInput.CustomizableAdvSysBackColor,
                                buttonInput.CustomAdvSysColorDilution
                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Vant)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {


                            typeof(Color),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(int[])

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomAdvantiumBackground,
                                buttonInput.CustomAdvantiumNoneColors,
                                buttonInput.CustomAdvantiumDownColors,
                                buttonInput.CustomAdvantiumOverColors,
                                buttonInput.CustomAdvantiumBorderColors,
                                buttonInput.CustomAdvantiumOffsets

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Resio)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            
                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomAresioBorderColors,
                                buttonInput.CustomAresioNoneColors,
                                buttonInput.CustomAresioOverColors,
                                buttonInput.CustomAresioDownColors,
                                
                            });
                            }
                        }
                        
                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Basic)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(int)
                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomBasicColors,
                                buttonInput.CustomBasicStateColors,
                                buttonInput.CustomBasicHighlights,
                                buttonInput.CustomBasicBorderColors,
                                buttonInput.CustomBasicDisabled,
                                buttonInput.CustomBasicOffset,
                                
                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Defend)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(int)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomBitDefenderC1,
                                buttonInput.CustomBitDefenderC2,
                                buttonInput.CustomBitDefenderC3,
                                buttonInput.CustomBitDefenderC4,
                                buttonInput.CustomBitDefenderC5,
                                buttonInput.CustomBitDefenderC6,
                                buttonInput.CustomBitDefenderBorder,
                                buttonInput.CustomBitDefenderFadeColor,
                                buttonInput.Curve //buttonInput.CustomBitDefenderCurve

                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Shades)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(int),

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomBlackShadesNoneColors,
                                buttonInput.CustomBlackShadesOverColors,
                                buttonInput.CustomBlackShadesDownColors,
                                buttonInput.Curve//buttonInput.CustomBlackShadesCurve


                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Boost)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color),
                            typeof(Color),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(int),
                            typeof(float),
                            typeof(float),
                            typeof(bool)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomBoosterColors,
                                buttonInput.CustomBoosterHatchColors,
                                buttonInput.CustomBoosterOuterBorder,
                                buttonInput.CustomBoosterInnerBorder,
                                buttonInput.UpperLeftCurve,
                                buttonInput.UpperRightCurve,
                                buttonInput.DownLeftCurve,
                                buttonInput.DownRightCurve,
                                buttonInput.CustomBoosterOffset,
                                buttonInput.CustomBoosterGradientAngle,
                                buttonInput.CustomBoosterHoverTransparency,
                                buttonInput.CustomBoosterInfluenceOuter


                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Class)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color)

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomClassicColors,
                                buttonInput.CustomClassicBorder,
                                buttonInput.CustomClassicHighlight,
                                buttonInput.CustomClassicBackground,
                                buttonInput.CustomClassicShadow

                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Duos)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {
                                
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[])

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomDeumosBackground,
                                buttonInput.CustomDeumosCornerColor,
                                buttonInput.CustomDeumosOverStateColor,
                                buttonInput.CustomDeumosBorderColors,
                                buttonInput.CustomDeumosDownStateColors,
                                buttonInput.CustomDeumosNoneStateColors

                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Exon)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {


                            typeof(ButtonThematic.CustomExcisionStyles),
                            typeof(string),
                            typeof(Color[])

                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomExcisionStyle,
                                buttonInput.ImageCodeString,
                                buttonInput.CustomExcisionBorderColors

                                });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Fute)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {


                            typeof(Color[]),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(ColorBlend)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomFusionGradColors,
                                buttonInput.CustomFusionCornerColor,
                                buttonInput.CustomFusionNoneBorderColor,
                                buttonInput.CustomFusionDownBorderColor,
                                buttonInput.CustomFusionOverBorderColor,
                                buttonInput.CustomFusionBlend

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Gamer)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {


                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomGameBoosterTopGradient,
                                buttonInput.CustomGameBoosterBotGradient,
                                buttonInput.CustomGameBoosterTopGradientClick,
                                buttonInput.CustomGameBoosterBotGradientClick,
                                buttonInput.CustomGameBoosterTopGradientHover,
                                buttonInput.CustomGameBoosterBotGradientHover,
                                buttonInput.CustomGameBoosterCornerColor,
                                buttonInput.CustomGameBoosterInnerBorder,
                                buttonInput.CustomGameBoosterOuterBorder,
                                buttonInput.CustomGameBoosterInnerBorderHover,
                                buttonInput.CustomGameBoosterOuterBorderHover,
                                buttonInput.CustomGameBoosterInnerBorderClick,
                                buttonInput.CustomGameBoosterOuterBorderClick

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Intel)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(int),
                            typeof(int)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomIntelBackgroundColor,
                                buttonInput.CustomIntelBorderColor,
                                buttonInput.CustomIntelShade,
                                buttonInput.Curve, //buttonInput.CustomIntelCurve,
                                buttonInput.CustomIntelGlow

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Mizer)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color),
                            typeof(int),
                            typeof(int)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomizedBtnInactive,
                                buttonInput.CustomizedBtnActive,
                                buttonInput.CustomizedBtnActiveBorder,
                                buttonInput.CustomizedBtnPressed,
                                buttonInput.CustomizedBtnPressedBorder,
                                buttonInput.CustomizedBtnOffsetGradient,
                                buttonInput.CustomizedBtnOffsetBorder,
                                buttonInput.CustomizedBtnInactiveBorder,
                                buttonInput.CustomizedBtnOffset,
                                buttonInput.Curve, //buttonInput.CustomizedBtnRounding

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Neless)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomNamelessBorderColors,
                                buttonInput.CustomNamelessNoneHighlight,
                                buttonInput.CustomNamelessOverHighlight,
                                buttonInput.CustomNamelessDownHighlight,
                                buttonInput.CustomNamelessCorners

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Neal)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color[]),
                            typeof(Color),
                            typeof(Color),
                            typeof(PointF),
                            typeof(int)
                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomNetSealPathBorders,
                                buttonInput.CustomNetSealCenterColor,
                                buttonInput.CustomNetSealSurroundColor,
                                buttonInput.CustomFocusScales,
                                buttonInput.Curve
                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Rainy)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color),
                            typeof(Color),
                            typeof(Color),
                            typeof(Color[]),
                            typeof(Color[])

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomOrainsInnerBorder,
                                buttonInput.CustomOrainsHeader,
                                buttonInput.CustomOrainsOuterBorder,
                                buttonInput.CustomOrainsButton,
                                buttonInput.CustomOrainsHatch

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Reon)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[])

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomReconBackground,
                                buttonInput.CustomReconNoneStateColors,
                                buttonInput.CustomReconDownStateColors,
                                buttonInput.CustomReconOverStateColors,
                                buttonInput.CustomReconBorder

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Spice)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(Color),
                            typeof(Color[]),
                            typeof(Color)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomSpicyBackground,
                                buttonInput.CustomSpicyNoneStateColors,
                                buttonInput.CustomSpicyOverStateColors,
                                buttonInput.CustomSpicyDownStateColors,
                                buttonInput.CustomSpicyHighlight,
                                buttonInput.CustomSpicyBorderColors,
                                buttonInput.CustomSpicyCornerColor

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Ezus)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color),
                            typeof(Color[]),
                            typeof(Color[]),
                            typeof(int),
                            typeof(int)

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomZeusBackground,
                                buttonInput.CustomZeusGradientColors,
                                buttonInput.CustomZeusBorderColors,
                                buttonInput.CustomZeusClickReduce,
                                buttonInput.CustomZeusClickLocate

                            });
                            }
                        }

                        else if (buttonInput.CustomizableStyle == CustomizableStyles.Roast)
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(new Type[] {

                            typeof(Color[]),
                            typeof(Color),
                            typeof(Color[])

                        });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {

                                buttonInput.CustomRoasterGradientColors,
                                buttonInput.CustomRoasterBorderColor,
                                buttonInput.CustomRoasterBackgroundStateColors

                            });
                            }
                        }

                        else
                        {
                            ConstructorInfo ctor = typeof(ButtonInput).GetConstructor(Type.EmptyTypes);
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, null);
                            }
                        }
                    }
                

                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        #endregion

        #endregion
    }
}
