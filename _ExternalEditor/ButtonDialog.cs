// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="ButtonDialog.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    public partial class ButtonDialog : Form
    {
        #region Private Fields

        private UserControl_Adobe adobe = new UserControl_Adobe();
        private UserControl_AdvancedSystem advancedSystem = new UserControl_AdvancedSystem();
        private UserControl_Advantium advantium = new UserControl_Advantium();
        private UserControl_Aresio aresio = new UserControl_Aresio();
        private UserControl_Basic basic = new UserControl_Basic();
        private UserControl_BitDefender bitDefender = new UserControl_BitDefender();
        private UserControl_BlackShades blackShades = new UserControl_BlackShades();
        private UserControl_Booster booster = new UserControl_Booster();
        private UserControl_Classic classic = new UserControl_Classic();
        private UserControl_Deumos deumos = new UserControl_Deumos();
        private UserControl_Excision excision = new UserControl_Excision();
        private UserControl_Future future = new UserControl_Future();
        private UserControl_GameBooster gameBooster = new UserControl_GameBooster();
        private UserControl_Intel intel = new UserControl_Intel();
        private UserControl_Mizer mizer = new UserControl_Mizer();
        private UserControl_Nameless nameless = new UserControl_Nameless();
        private UserControl_NetSeal netSeal = new UserControl_NetSeal();
        private UserControl_Orains orains = new UserControl_Orains();
        private UserControl_Recon recon = new UserControl_Recon();
        private UserControl_Roaster roaster = new UserControl_Roaster();
        private UserControl_SpicyLips spicyLips = new UserControl_SpicyLips();
        private UserControl_Zeus zeus = new UserControl_Zeus();
        


        #endregion

        #region Constructor

        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// 	at the default window position.
        /// </summary>
        public ButtonDialog() : this(ButtonInput.Empty())
        {
        }

        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        ///		and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public ButtonDialog(Control c) : this(ButtonInput.Empty(), c)
        {
        }

        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        ///		and positioned beneath the specified control.
        /// </summary>
        /// <param name="filler">Existing <c>Filler</c> object.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">
        ///		Thrown if <paramref name="filler" /> is null.
        ///	</exception>
        public ButtonDialog(ButtonInput buttonInput, Control c) : this(buttonInput)
        {
            Zeroit.Framework.ButtonThematic.Editors.Utils.SetStartPositionBelowControl(this, c);
        }

        /// <summary>
        /// 	Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// 	at the default window position.
        /// </summary>
        /// <param name="peaceInput">Existing <c>Filler</c> object.</param>
        /// <exception cref="System.ArgumentNullException">
        ///		Thrown if <paramref name="peaceInput" /> is null.
        ///	</exception>
        public ButtonDialog(ButtonInput buttonInput)
        {
            if (buttonInput == null)
            {
                throw new ArgumentNullException("buttonInput");
            }


            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            LoadInitialValues(buttonInput);
            AdobeInitialValues(buttonInput);
            AdvancedSystemInitialValues(buttonInput);
            AdvantiumInitialValues(buttonInput);
            AresioInitialValues(buttonInput);
            BasicInitialValues(buttonInput);
            BitDefenderInitialValues(buttonInput);
            BlackShadesInitialValues(buttonInput);
            BoosterInitialValues(buttonInput);
            ClassicInitialValues(buttonInput);
            DeumosInitialValues(buttonInput);
            ExcisionInitialValues(buttonInput);
            FutureInitialValues(buttonInput);
            GameBoosterInitialValues(buttonInput);
            IntelInitialValues(buttonInput);
            CustomizedMizerInitialValues(buttonInput);
            NamelessInitialValues(buttonInput);
            NetSealInitialValues(buttonInput);
            OrainsInitialValues(buttonInput);
            ReconInitialValues(buttonInput);
            SpicyLipsInitialValues(buttonInput);
            ZeusInitialValues(buttonInput);
            RoasterInitialValues(buttonInput);
            //AdjustDialogSize();
            //SetInitial_Values(pizaroAnimatorInput);

        }

        #endregion

        #region Public Properties

        private ButtonInput buttonInput;

        public ButtonInput ButtonInput
        {
            get { return buttonInput; }
        }


        #endregion

        #region Set Initial Style

        private void LoadInitialValues(ButtonInput buttonInput)
        {

            #region Main Control
            
            #region Add Button Styles to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(CustomizableStyles)))
            {
                mainControl_ButtonType_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < mainControl_ButtonType_ComboBox.Items.Count; i++)
            {
                if (buttonInput.CustomizableStyle == (CustomizableStyles)Enum.Parse(typeof(CustomizableStyles), mainControl_ButtonType_ComboBox.Items[i].ToString()))
                {
                    mainControl_ButtonType_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add RenderMode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(ButtonThematic.RenderMode)))
            {
                mainControl_RenderMode_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < mainControl_RenderMode_ComboBox.Items.Count; i++)
            {
                if (buttonInput.DrawMode == (ButtonThematic.RenderMode)Enum.Parse(typeof(ButtonThematic.RenderMode), mainControl_RenderMode_ComboBox.Items[i].ToString()))
                {
                    mainControl_RenderMode_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            #region Add Gradient Mode to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(LinearGradientMode)))
            {
                mainControl_GradientMode_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < mainControl_GradientMode_ComboBox.Items.Count; i++)
            {
                if (buttonInput.GradientMode == (LinearGradientMode)Enum.Parse(typeof(LinearGradientMode), mainControl_GradientMode_ComboBox.Items[i].ToString()))
                {
                    mainControl_GradientMode_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            mainControl_HatchStyle_ComboBox.SelectedHatchStyle = buttonInput.HatchStyle;

            mainControl_Curve_Numeric.Value = buttonInput.Curve;

            #endregion
            
        }

        private void AdobeInitialValues(ButtonInput buttonInput)
        {
            adobe.customizableAdobeColors_0.BackColor = buttonInput.CustomizableAdobeColors[0];
            adobe.customizableAdobeColors_1.BackColor = buttonInput.CustomizableAdobeColors[1];
            adobe.customizableAdobeColors_2.BackColor = buttonInput.CustomizableAdobeColors[2];
            adobe.customizableAdobeColors_3.BackColor = buttonInput.CustomizableAdobeColors[3];
            adobe.customizableAdobeColors_4.BackColor = buttonInput.CustomizableAdobeColors[4];
            adobe.customizableAdobeColors_5.BackColor = buttonInput.CustomizableAdobeColors[5];
            adobe.customizableAdobeBackground.BackColor = buttonInput.CustomizableAdobeBackground;

            adobe.previewBtn.CustomizableAdobeColors[0] = buttonInput.CustomizableAdobeColors[0];
            adobe.previewBtn.CustomizableAdobeColors[1] = buttonInput.CustomizableAdobeColors[1];
            adobe.previewBtn.CustomizableAdobeColors[2] = buttonInput.CustomizableAdobeColors[2];
            adobe.previewBtn.CustomizableAdobeColors[3] = buttonInput.CustomizableAdobeColors[3];
            adobe.previewBtn.CustomizableAdobeColors[4] = buttonInput.CustomizableAdobeColors[4];
            adobe.previewBtn.CustomizableAdobeColors[5] = buttonInput.CustomizableAdobeColors[5];
            adobe.previewBtn.CustomizableAdobeBackground = buttonInput.CustomizableAdobeBackground;


            //-------VALUES---------//

            adobe.customizableAdobe_Coefficient_Numeric.Value = buttonInput.CustomizableAdobeCoefficient;

        }

        private void AdobeSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomizableAdobeColors[0] = adobe.customizableAdobeColors_0.BackColor;
            buttonInput.CustomizableAdobeColors[1] = adobe.customizableAdobeColors_1.BackColor;
            buttonInput.CustomizableAdobeColors[2] = adobe.customizableAdobeColors_2.BackColor;
            buttonInput.CustomizableAdobeColors[3] = adobe.customizableAdobeColors_3.BackColor;
            buttonInput.CustomizableAdobeColors[4] = adobe.customizableAdobeColors_4.BackColor;
            buttonInput.CustomizableAdobeColors[5] = adobe.customizableAdobeColors_5.BackColor;
            buttonInput.CustomizableAdobeBackground = adobe.customizableAdobeBackground.BackColor;


            //-------VALUES---------//

            buttonInput.CustomizableAdobeCoefficient = (int)adobe.customizableAdobe_Coefficient_Numeric.Value;

        }

        private void AdvancedSystemInitialValues(ButtonInput buttonInput)
        {
            
            advancedSystem.customizableAdvancedSystem_Glow.BackColor = buttonInput.CustomizableAdvancedSystemGlow;
            advancedSystem.customizableAdvancedSystem_BackColor.BackColor = buttonInput.CustomizableAdvSysBackColor;
            advancedSystem.customizableAdvancedSystem_Dilution.BackColor = buttonInput.CustomAdvSysColorDilution;
            advancedSystem.customizable_Slope_Numeric.Value = buttonInput.CustomizableAdvancedSystemSlope;


            advancedSystem.previewBtn.CustomizableAdvancedSystemGlow = buttonInput.CustomizableAdvancedSystemGlow ;
            advancedSystem.previewBtn.CustomizableAdvSysBackColor = buttonInput.CustomizableAdvSysBackColor;
            advancedSystem.previewBtn.CustomAdvSysColorDilution = buttonInput.CustomAdvSysColorDilution;
            advancedSystem.previewBtn.CustomizableAdvancedSystemSlope = buttonInput.CustomizableAdvancedSystemSlope / 4;
            
        }

        private void AdvancedSystemSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomizableAdvancedSystemGlow = advancedSystem.customizableAdvancedSystem_Glow.BackColor;
            buttonInput.CustomizableAdvSysBackColor = advancedSystem.customizableAdvancedSystem_BackColor.BackColor;
            buttonInput.CustomAdvSysColorDilution = advancedSystem.customizableAdvancedSystem_Dilution.BackColor;

            buttonInput.CustomizableAdvancedSystemSlope = (int)advancedSystem.customizable_Slope_Numeric.Value;

        }

        private void AdvantiumInitialValues(ButtonInput buttonInput)
        {
            advantium.customAdvantium_Offset1_Numeric.Value = buttonInput.CustomAdvantiumOffsets[0];
            advantium.customAdvantium_Offset2_Numeric.Value = buttonInput.CustomAdvantiumOffsets[1];
            advantium.customAdvantium_Offset3_Numeric.Value = buttonInput.CustomAdvantiumOffsets[2];

            advantium.customAdvantium_BorderColors0_Btn.BackColor = buttonInput.CustomAdvantiumBorderColors[0];
            advantium.customAdvantium_BorderColors1_Btn.BackColor = buttonInput.CustomAdvantiumBorderColors[1];
            advantium.customAdvantium_BorderColors2_Btn.BackColor = buttonInput.CustomAdvantiumBorderColors[2];

            advantium.customAdvantium_NoneColors0_Btn.BackColor = buttonInput.CustomAdvantiumNoneColors[0];
            advantium.customAdvantium_NoneColors1_Btn.BackColor = buttonInput.CustomAdvantiumNoneColors[1];

            advantium.customAdvantium_OverColors0_Btn.BackColor = buttonInput.CustomAdvantiumOverColors[0];
            advantium.customAdvantium_OverColors1_Btn.BackColor = buttonInput.CustomAdvantiumOverColors[1];

            advantium.customAdvantium_DownColors0_Btn.BackColor = buttonInput.CustomAdvantiumDownColors[0];
            advantium.customAdvantium_DownColors1_Btn.BackColor = buttonInput.CustomAdvantiumDownColors[1];

            advantium.customAdvantium_Background_Btn.BackColor = buttonInput.CustomAdvantiumBackground;


            advantium.previewBtn.CustomAdvantiumOffsets[0] = buttonInput.CustomAdvantiumOffsets[0];
            advantium.previewBtn.CustomAdvantiumOffsets[1] = buttonInput.CustomAdvantiumOffsets[1];
            advantium.previewBtn.CustomAdvantiumOffsets[1] = buttonInput.CustomAdvantiumOffsets[2];

            advantium.previewBtn.CustomAdvantiumBorderColors[0] = buttonInput.CustomAdvantiumBorderColors[0];
            advantium.previewBtn.CustomAdvantiumBorderColors[1] = buttonInput.CustomAdvantiumBorderColors[1];
            advantium.previewBtn.CustomAdvantiumBorderColors[2] = buttonInput.CustomAdvantiumBorderColors[2];

            advantium.previewBtn.CustomAdvantiumNoneColors[0] = buttonInput.CustomAdvantiumNoneColors[0];
            advantium.previewBtn.CustomAdvantiumNoneColors[1] = buttonInput.CustomAdvantiumNoneColors[1];

            advantium.previewBtn.CustomAdvantiumOverColors[0] = buttonInput.CustomAdvantiumOverColors[0];
            advantium.previewBtn.CustomAdvantiumOverColors[1] = buttonInput.CustomAdvantiumOverColors[1];

            advantium.previewBtn.CustomAdvantiumDownColors[0] = buttonInput.CustomAdvantiumDownColors[0];
            advantium.previewBtn.CustomAdvantiumDownColors[1] = buttonInput.CustomAdvantiumDownColors[1];

            advantium.previewBtn.CustomAdvantiumBackground = buttonInput.CustomAdvantiumBackground;

        }

        private void AdvantiumSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomAdvantiumOffsets[0] = (int)advantium.customAdvantium_Offset1_Numeric.Value;
            buttonInput.CustomAdvantiumOffsets[1] = (int)advantium.customAdvantium_Offset2_Numeric.Value;
            buttonInput.CustomAdvantiumOffsets[2] = (int)advantium.customAdvantium_Offset3_Numeric.Value;

            buttonInput.CustomAdvantiumBorderColors[0] = advantium.customAdvantium_BorderColors0_Btn.BackColor;
            buttonInput.CustomAdvantiumBorderColors[1] = advantium.customAdvantium_BorderColors1_Btn.BackColor;
            buttonInput.CustomAdvantiumBorderColors[2] = advantium.customAdvantium_BorderColors2_Btn.BackColor;

            buttonInput.CustomAdvantiumNoneColors[0] = advantium.customAdvantium_NoneColors0_Btn.BackColor;
            buttonInput.CustomAdvantiumNoneColors[1] = advantium.customAdvantium_NoneColors1_Btn.BackColor;

            buttonInput.CustomAdvantiumOverColors[0] = advantium.customAdvantium_OverColors0_Btn.BackColor;
            buttonInput.CustomAdvantiumOverColors[1] = advantium.customAdvantium_OverColors1_Btn.BackColor;

            buttonInput.CustomAdvantiumDownColors[0] = advantium.customAdvantium_DownColors0_Btn.BackColor;
            buttonInput.CustomAdvantiumDownColors[1] = advantium.customAdvantium_DownColors1_Btn.BackColor;

            buttonInput.CustomAdvantiumBackground = advantium.customAdvantium_Background_Btn.BackColor;
        }

        private void AresioInitialValues(ButtonInput buttonInput)
        {
            aresio.customAresio_NoneColors0_Btn.BackColor = buttonInput.CustomAresioNoneColors[0];
            aresio.customAresio_NoneColors1_Btn.BackColor = buttonInput.CustomAresioNoneColors[1];

            aresio.customAresio_DownColors0_Btn.BackColor = buttonInput.CustomAresioDownColors[0];
            aresio.customAresio_DownColors1_Btn.BackColor = buttonInput.CustomAresioDownColors[1];

            aresio.customAresio_OverColors0_Btn.BackColor = buttonInput.CustomAresioOverColors[0];
            aresio.customAresio_OverColors1_Btn.BackColor = buttonInput.CustomAresioOverColors[1];

            aresio.customAresio_BorderColors0_Btn.BackColor = buttonInput.CustomAresioBorderColors[0];
            aresio.customAresio_BorderColors1_Btn.BackColor = buttonInput.CustomAresioBorderColors[1];



            aresio.previewBtn.CustomAresioNoneColors[0] = buttonInput.CustomAresioNoneColors[0];
            aresio.previewBtn.CustomAresioNoneColors[1] = buttonInput.CustomAresioNoneColors[1];

            aresio.previewBtn.CustomAresioDownColors[0] = buttonInput.CustomAresioDownColors[0];
            aresio.previewBtn.CustomAresioDownColors[1] = buttonInput.CustomAresioDownColors[1];

            aresio.previewBtn.CustomAresioOverColors[0] = buttonInput.CustomAresioOverColors[0];
            aresio.previewBtn.CustomAresioOverColors[1] = buttonInput.CustomAresioOverColors[1];

            aresio.previewBtn.CustomAresioBorderColors[0] = buttonInput.CustomAresioBorderColors[0];
            aresio.previewBtn.CustomAresioBorderColors[1] = buttonInput.CustomAresioBorderColors[1];


            aresio.previewBtn.Curve = buttonInput.Curve / 4;

        }

        private void AresioSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomAresioNoneColors[0] = aresio.customAresio_NoneColors0_Btn.BackColor;
            buttonInput.CustomAresioNoneColors[1] = aresio.customAresio_NoneColors1_Btn.BackColor;

            buttonInput.CustomAresioDownColors[0] = aresio.customAresio_DownColors0_Btn.BackColor;
            buttonInput.CustomAresioDownColors[1] = aresio.customAresio_DownColors1_Btn.BackColor;

            buttonInput.CustomAresioOverColors[0] = aresio.customAresio_OverColors0_Btn.BackColor;
            buttonInput.CustomAresioOverColors[1] = aresio.customAresio_OverColors1_Btn.BackColor;

            buttonInput.CustomAresioBorderColors[0] = aresio.customAresio_BorderColors0_Btn.BackColor;
            buttonInput.CustomAresioBorderColors[1] = aresio.customAresio_BorderColors1_Btn.BackColor;
        }

        private void BasicInitialValues(ButtonInput buttonInput)
        {
            basic.customBasic_Offset_Numeric.Value = buttonInput.CustomBasicOffset;

            basic.customBasic_Colors0_Btn.BackColor = buttonInput.CustomBasicColors[0];
            basic.customBasic_Colors1_Btn.BackColor = buttonInput.CustomBasicColors[1];
            basic.customBasic_Colors2_Btn.BackColor = buttonInput.CustomBasicColors[2];
            basic.customBasic_Colors3_Btn.BackColor = buttonInput.CustomBasicColors[3];

            basic.customBasic_StateColors0_Btn.BackColor = buttonInput.CustomBasicStateColors[0];
            basic.customBasic_StateColors1_Btn.BackColor = buttonInput.CustomBasicStateColors[1];

            basic.customBasic_HighlightColors0_Btn.BackColor = buttonInput.CustomBasicHighlights[0];
            basic.customBasic_HighlightColors1_Btn.BackColor = buttonInput.CustomBasicHighlights[1];
            basic.customBasic_HighlightColors2_Btn.BackColor = buttonInput.CustomBasicHighlights[2];

            basic.customBasic_DisabledColors0_Btn.BackColor = buttonInput.CustomBasicDisabled[0];
            basic.customBasic_DisabledColors1_Btn.BackColor = buttonInput.CustomBasicDisabled[1];
            basic.customBasic_DisabledColors2_Btn.BackColor = buttonInput.CustomBasicDisabled[2];

            basic.customBasic_BorderColors0_Btn.BackColor = buttonInput.CustomBasicBorderColors[0];
            basic.customBasic_BorderColors1_Btn.BackColor = buttonInput.CustomBasicBorderColors[1];
            basic.customBasic_BorderColors2_Btn.BackColor = buttonInput.CustomBasicBorderColors[2];
            basic.customBasic_BorderColors3_Btn.BackColor = buttonInput.CustomBasicBorderColors[3];
            basic.customBasic_BorderColors4_Btn.BackColor = buttonInput.CustomBasicBorderColors[4];
            basic.customBasic_BorderColors5_Btn.BackColor = buttonInput.CustomBasicBorderColors[5];
            basic.customBasic_BorderColors6_Btn.BackColor = buttonInput.CustomBasicBorderColors[6];




            basic.previewBtn.CustomBasicOffset = buttonInput.CustomBasicOffset;

            basic.previewBtn.CustomBasicColors[0] = buttonInput.CustomBasicColors[0];
            basic.previewBtn.CustomBasicColors[1] = buttonInput.CustomBasicColors[1];
            basic.previewBtn.CustomBasicColors[2] = buttonInput.CustomBasicColors[2];
            basic.previewBtn.CustomBasicColors[3] = buttonInput.CustomBasicColors[3];

            basic.previewBtn.CustomBasicStateColors[0] = buttonInput.CustomBasicStateColors[0];
            basic.previewBtn.CustomBasicStateColors[1] = buttonInput.CustomBasicStateColors[1];

            basic.previewBtn.CustomBasicHighlights[0] = buttonInput.CustomBasicHighlights[0];
            basic.previewBtn.CustomBasicHighlights[1] = buttonInput.CustomBasicHighlights[1];
            basic.previewBtn.CustomBasicHighlights[2] = buttonInput.CustomBasicHighlights[2];

            basic.previewBtn.CustomBasicDisabled[0] = buttonInput.CustomBasicDisabled[0];
            basic.previewBtn.CustomBasicDisabled[1] = buttonInput.CustomBasicDisabled[1];
            basic.previewBtn.CustomBasicDisabled[2] = buttonInput.CustomBasicDisabled[2];

            basic.previewBtn.CustomBasicBorderColors[0] = buttonInput.CustomBasicBorderColors[0];
            basic.previewBtn.CustomBasicBorderColors[1] = buttonInput.CustomBasicBorderColors[1];
            basic.previewBtn.CustomBasicBorderColors[2] = buttonInput.CustomBasicBorderColors[2];
            basic.previewBtn.CustomBasicBorderColors[3] = buttonInput.CustomBasicBorderColors[3];
            basic.previewBtn.CustomBasicBorderColors[4] = buttonInput.CustomBasicBorderColors[4];
            basic.previewBtn.CustomBasicBorderColors[5] = buttonInput.CustomBasicBorderColors[5];
            basic.previewBtn.CustomBasicBorderColors[6] = buttonInput.CustomBasicBorderColors[6];


        }

        private void BasicSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomBasicOffset = (int)basic.customBasic_Offset_Numeric.Value;

            buttonInput.CustomBasicColors[0] = basic.customBasic_Colors0_Btn.BackColor;
            buttonInput.CustomBasicColors[1] = basic.customBasic_Colors1_Btn.BackColor;
            buttonInput.CustomBasicColors[2] = basic.customBasic_Colors2_Btn.BackColor;
            buttonInput.CustomBasicColors[3] = basic.customBasic_Colors3_Btn.BackColor;


            buttonInput.CustomBasicStateColors[0] = basic.customBasic_StateColors0_Btn.BackColor;
            buttonInput.CustomBasicStateColors[1] = basic.customBasic_StateColors1_Btn.BackColor;

            buttonInput.CustomBasicHighlights[0] = basic.customBasic_HighlightColors0_Btn.BackColor;
            buttonInput.CustomBasicHighlights[1] = basic.customBasic_HighlightColors1_Btn.BackColor;
            buttonInput.CustomBasicHighlights[2] = basic.customBasic_HighlightColors2_Btn.BackColor;

            buttonInput.CustomBasicDisabled[0] = basic.customBasic_DisabledColors0_Btn.BackColor;
            buttonInput.CustomBasicDisabled[1] = basic.customBasic_DisabledColors1_Btn.BackColor;
            buttonInput.CustomBasicDisabled[2] = basic.customBasic_DisabledColors2_Btn.BackColor;

            buttonInput.CustomBasicBorderColors[0] = basic.customBasic_BorderColors0_Btn.BackColor;
            buttonInput.CustomBasicBorderColors[1] = basic.customBasic_BorderColors1_Btn.BackColor;
            buttonInput.CustomBasicBorderColors[2] = basic.customBasic_BorderColors2_Btn.BackColor;
            buttonInput.CustomBasicBorderColors[3] = basic.customBasic_BorderColors3_Btn.BackColor;
            buttonInput.CustomBasicBorderColors[4] = basic.customBasic_BorderColors4_Btn.BackColor;
            buttonInput.CustomBasicBorderColors[5] = basic.customBasic_BorderColors5_Btn.BackColor;
            buttonInput.CustomBasicBorderColors[6] = basic.customBasic_BorderColors6_Btn.BackColor;

            
        }

        private void BitDefenderInitialValues(ButtonInput buttonInput)
        {
            bitDefender.customDefender_C1_Btn.BackColor = buttonInput.CustomBitDefenderC1;
            bitDefender.customDefender_C2_Btn.BackColor = buttonInput.CustomBitDefenderC2;
            bitDefender.customDefender_C3_Btn.BackColor = buttonInput.CustomBitDefenderC3;
            bitDefender.customDefender_C4_Btn.BackColor = buttonInput.CustomBitDefenderC4;
            bitDefender.customDefender_C5_Btn.BackColor = buttonInput.CustomBitDefenderC5;
            bitDefender.customDefender_C6_Btn.BackColor = buttonInput.CustomBitDefenderC6;

            bitDefender.customDefender_BorderColor_Btn.BackColor = buttonInput.CustomBitDefenderBorder;
            bitDefender.customDefender_FadeColor_Btn.BackColor = buttonInput.CustomBitDefenderFadeColor;



            bitDefender.previewBtn.CustomBitDefenderC1 = buttonInput.CustomBitDefenderC1;
            bitDefender.previewBtn.CustomBitDefenderC2 = buttonInput.CustomBitDefenderC2;
            bitDefender.previewBtn.CustomBitDefenderC3 = buttonInput.CustomBitDefenderC3;
            bitDefender.previewBtn.CustomBitDefenderC4 = buttonInput.CustomBitDefenderC4;
            bitDefender.previewBtn.CustomBitDefenderC5 = buttonInput.CustomBitDefenderC5;
            bitDefender.previewBtn.CustomBitDefenderC6 = buttonInput.CustomBitDefenderC6;

            bitDefender.previewBtn.CustomBitDefenderBorder = buttonInput.CustomBitDefenderBorder;
            bitDefender.previewBtn.CustomBitDefenderFadeColor = buttonInput.CustomBitDefenderFadeColor;

            bitDefender.previewBtn.Curve = buttonInput.Curve / 4;
        }

        private void BitDefenderSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomBitDefenderC1 = bitDefender.customDefender_C1_Btn.BackColor;
            buttonInput.CustomBitDefenderC2 = bitDefender.customDefender_C2_Btn.BackColor;
            buttonInput.CustomBitDefenderC3 = bitDefender.customDefender_C3_Btn.BackColor;
            buttonInput.CustomBitDefenderC4 = bitDefender.customDefender_C4_Btn.BackColor;
            buttonInput.CustomBitDefenderC5 = bitDefender.customDefender_C5_Btn.BackColor;
            buttonInput.CustomBitDefenderC6 = bitDefender.customDefender_C6_Btn.BackColor;
            
            buttonInput.CustomBitDefenderBorder = bitDefender.customDefender_BorderColor_Btn.BackColor;
            buttonInput.CustomBitDefenderFadeColor = bitDefender.customDefender_FadeColor_Btn.BackColor;
            
        }

        private void BlackShadesInitialValues(ButtonInput buttonInput)
        {
            blackShades.customBlackShades_NoneColors0_Btn.BackColor = buttonInput.CustomBlackShadesNoneColors[0];
            blackShades.customBlackShades_NoneColors1_Btn.BackColor = buttonInput.CustomBlackShadesNoneColors[1];
            blackShades.customBlackShades_NoneColors2_Btn.BackColor = buttonInput.CustomBlackShadesNoneColors[2];
            blackShades.customBlackShades_NoneColors3_Btn.BackColor = buttonInput.CustomBlackShadesNoneColors[3];
            blackShades.customBlackShades_NoneColors4_Btn.BackColor = buttonInput.CustomBlackShadesNoneColors[4];
            blackShades.customBlackShades_NoneColors5_Btn.BackColor = buttonInput.CustomBlackShadesNoneColors[5];
            blackShades.customBlackShades_NoneColors6_Btn.BackColor = buttonInput.CustomBlackShadesNoneColors[6];

            blackShades.customBlackShades_DownColors0_Btn.BackColor = buttonInput.CustomBlackShadesDownColors[0];
            blackShades.customBlackShades_DownColors1_Btn.BackColor = buttonInput.CustomBlackShadesDownColors[1];
            blackShades.customBlackShades_DownColors2_Btn.BackColor = buttonInput.CustomBlackShadesDownColors[2];
            blackShades.customBlackShades_DownColors3_Btn.BackColor = buttonInput.CustomBlackShadesDownColors[3];
            blackShades.customBlackShades_DownColors4_Btn.BackColor = buttonInput.CustomBlackShadesDownColors[4];
            blackShades.customBlackShades_DownColors5_Btn.BackColor = buttonInput.CustomBlackShadesDownColors[5];
            blackShades.customBlackShades_DownColors6_Btn.BackColor = buttonInput.CustomBlackShadesDownColors[6];
            blackShades.customBlackShades_DownColors7_Btn.BackColor = buttonInput.CustomBlackShadesDownColors[7];
            
            blackShades.customBlackShades_OverColors0_Btn.BackColor = buttonInput.CustomBlackShadesOverColors[0];
            blackShades.customBlackShades_OverColors1_Btn.BackColor = buttonInput.CustomBlackShadesOverColors[1];
            blackShades.customBlackShades_OverColors2_Btn.BackColor = buttonInput.CustomBlackShadesOverColors[2];
            blackShades.customBlackShades_OverColors3_Btn.BackColor = buttonInput.CustomBlackShadesOverColors[3];
            blackShades.customBlackShades_OverColors4_Btn.BackColor = buttonInput.CustomBlackShadesOverColors[4];
            blackShades.customBlackShades_OverColors5_Btn.BackColor = buttonInput.CustomBlackShadesOverColors[5];
            blackShades.customBlackShades_OverColors6_Btn.BackColor = buttonInput.CustomBlackShadesOverColors[6];
            blackShades.customBlackShades_OverColors7_Btn.BackColor = buttonInput.CustomBlackShadesOverColors[7];




            blackShades.previewBtn.CustomBlackShadesNoneColors[0] = buttonInput.CustomBlackShadesNoneColors[0];
            blackShades.previewBtn.CustomBlackShadesNoneColors[1] = buttonInput.CustomBlackShadesNoneColors[1];
            blackShades.previewBtn.CustomBlackShadesNoneColors[2] = buttonInput.CustomBlackShadesNoneColors[2];
            blackShades.previewBtn.CustomBlackShadesNoneColors[3] = buttonInput.CustomBlackShadesNoneColors[3];
            blackShades.previewBtn.CustomBlackShadesNoneColors[4] = buttonInput.CustomBlackShadesNoneColors[4];
            blackShades.previewBtn.CustomBlackShadesNoneColors[5] = buttonInput.CustomBlackShadesNoneColors[5];
            blackShades.previewBtn.CustomBlackShadesNoneColors[6] = buttonInput.CustomBlackShadesNoneColors[6];

            blackShades.previewBtn.CustomBlackShadesDownColors[0] = buttonInput.CustomBlackShadesDownColors[0];
            blackShades.previewBtn.CustomBlackShadesDownColors[1] = buttonInput.CustomBlackShadesDownColors[1];
            blackShades.previewBtn.CustomBlackShadesDownColors[2] = buttonInput.CustomBlackShadesDownColors[2];
            blackShades.previewBtn.CustomBlackShadesDownColors[3] = buttonInput.CustomBlackShadesDownColors[3];
            blackShades.previewBtn.CustomBlackShadesDownColors[4] = buttonInput.CustomBlackShadesDownColors[4];
            blackShades.previewBtn.CustomBlackShadesDownColors[5] = buttonInput.CustomBlackShadesDownColors[5];
            blackShades.previewBtn.CustomBlackShadesDownColors[6] = buttonInput.CustomBlackShadesDownColors[6];
            blackShades.previewBtn.CustomBlackShadesDownColors[7] = buttonInput.CustomBlackShadesDownColors[7];
            
            blackShades.previewBtn.CustomBlackShadesOverColors[0] = buttonInput.CustomBlackShadesOverColors[0];
            blackShades.previewBtn.CustomBlackShadesOverColors[1] = buttonInput.CustomBlackShadesOverColors[1];
            blackShades.previewBtn.CustomBlackShadesOverColors[2] = buttonInput.CustomBlackShadesOverColors[2];
            blackShades.previewBtn.CustomBlackShadesOverColors[3] = buttonInput.CustomBlackShadesOverColors[3];
            blackShades.previewBtn.CustomBlackShadesOverColors[4] = buttonInput.CustomBlackShadesOverColors[4];
            blackShades.previewBtn.CustomBlackShadesOverColors[5] = buttonInput.CustomBlackShadesOverColors[5];
            blackShades.previewBtn.CustomBlackShadesOverColors[6] = buttonInput.CustomBlackShadesOverColors[6];
            blackShades.previewBtn.CustomBlackShadesOverColors[7] = buttonInput.CustomBlackShadesOverColors[7];

            blackShades.previewBtn.Curve = buttonInput.Curve / 4;
        }

        private void BlackShadesSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomBlackShadesNoneColors[0] = blackShades.customBlackShades_NoneColors0_Btn.BackColor;
            buttonInput.CustomBlackShadesNoneColors[1] = blackShades.customBlackShades_NoneColors1_Btn.BackColor;
            buttonInput.CustomBlackShadesNoneColors[2] = blackShades.customBlackShades_NoneColors2_Btn.BackColor;
            buttonInput.CustomBlackShadesNoneColors[3] = blackShades.customBlackShades_NoneColors3_Btn.BackColor;
            buttonInput.CustomBlackShadesNoneColors[4] = blackShades.customBlackShades_NoneColors4_Btn.BackColor;
            buttonInput.CustomBlackShadesNoneColors[5] = blackShades.customBlackShades_NoneColors5_Btn.BackColor;
            buttonInput.CustomBlackShadesNoneColors[6] = blackShades.customBlackShades_NoneColors6_Btn.BackColor;


            buttonInput.CustomBlackShadesDownColors[0] = blackShades.customBlackShades_DownColors0_Btn.BackColor;
            buttonInput.CustomBlackShadesDownColors[1] = blackShades.customBlackShades_DownColors1_Btn.BackColor;
            buttonInput.CustomBlackShadesDownColors[2] = blackShades.customBlackShades_DownColors2_Btn.BackColor;
            buttonInput.CustomBlackShadesDownColors[3] = blackShades.customBlackShades_DownColors3_Btn.BackColor;
            buttonInput.CustomBlackShadesDownColors[4] = blackShades.customBlackShades_DownColors4_Btn.BackColor;
            buttonInput.CustomBlackShadesDownColors[5] = blackShades.customBlackShades_DownColors5_Btn.BackColor;
            buttonInput.CustomBlackShadesDownColors[6] = blackShades.customBlackShades_DownColors6_Btn.BackColor;
            buttonInput.CustomBlackShadesDownColors[7] = blackShades.customBlackShades_DownColors7_Btn.BackColor;


            buttonInput.CustomBlackShadesOverColors[0] = blackShades.customBlackShades_OverColors0_Btn.BackColor;
            buttonInput.CustomBlackShadesOverColors[1] = blackShades.customBlackShades_OverColors1_Btn.BackColor;
            buttonInput.CustomBlackShadesOverColors[2] = blackShades.customBlackShades_OverColors2_Btn.BackColor;
            buttonInput.CustomBlackShadesOverColors[3] = blackShades.customBlackShades_OverColors3_Btn.BackColor;
            buttonInput.CustomBlackShadesOverColors[4] = blackShades.customBlackShades_OverColors4_Btn.BackColor;
            buttonInput.CustomBlackShadesOverColors[5] = blackShades.customBlackShades_OverColors5_Btn.BackColor;
            buttonInput.CustomBlackShadesOverColors[6] = blackShades.customBlackShades_OverColors6_Btn.BackColor;
            buttonInput.CustomBlackShadesOverColors[7] = blackShades.customBlackShades_OverColors7_Btn.BackColor;

            
        }

        private void BoosterInitialValues(ButtonInput buttonInput)
        {
            booster.customBooster_UpperLeftCurve_Numeric.Value = buttonInput.UpperLeftCurve;
            booster.customBooster_UpperRightCurve_Numeric.Value = buttonInput.UpperRightCurve;
            booster.customBooster_DownLeftCurve_Numeric.Value = buttonInput.DownLeftCurve;
            booster.customBooster_DownRightCurve_Numeric.Value = buttonInput.DownRightCurve;
            booster.customBooster_Offset_Numeric.Value = buttonInput.CustomBoosterOffset;
            booster.customBooster_HoverTransparency_Numeric.Value = (decimal)buttonInput.CustomBoosterHoverTransparency;
            booster.customBooster_GradientAngle_Numeric.Value = (decimal)buttonInput.CustomBoosterGradientAngle;

            booster.customBooster_Colors0_Btn.BackColor = buttonInput.CustomBoosterColors[0];
            booster.customBooster_Colors1_Btn.BackColor = buttonInput.CustomBoosterColors[1];

            booster.customBooster_BorderColors0_Btn.BackColor = buttonInput.CustomBoosterInnerBorder;
            booster.customBooster_BorderColors1_Btn.BackColor = buttonInput.CustomBoosterOuterBorder;

            booster.customBooster_HatchColors0_Btn.BackColor = buttonInput.CustomBoosterHatchColors[0];
            booster.customBooster_HatchColors1_Btn.BackColor = buttonInput.CustomBoosterHatchColors[1];

            if (buttonInput.CustomBoosterInfluenceOuter == true)
            {
                booster.customBooster_InfluenceOuter_Yes_RadioBtn.Checked = true;
                booster.previewBtn.CustomBoosterInfluenceOuter = true;
            }
            else
            {
                booster.customBooster_InfluenceOuter_No_RadioBtn.Checked = true;
                booster.previewBtn.CustomBoosterInfluenceOuter = false;
            }


            booster.previewBtn.UpperLeftCurve = buttonInput.UpperLeftCurve;
            booster.previewBtn.UpperRightCurve = buttonInput.UpperRightCurve;
            booster.previewBtn.DownLeftCurve = buttonInput.DownLeftCurve;
            booster.previewBtn.DownRightCurve = buttonInput.DownRightCurve;
            booster.previewBtn.CustomBoosterOffset = buttonInput.CustomBoosterOffset;
            booster.previewBtn.CustomBoosterHoverTransparency = buttonInput.CustomBoosterHoverTransparency;
            booster.previewBtn.CustomBoosterGradientAngle = buttonInput.CustomBoosterGradientAngle;

            booster.previewBtn.CustomBoosterColors[0] = buttonInput.CustomBoosterColors[0];
            booster.previewBtn.CustomBoosterColors[1] = buttonInput.CustomBoosterColors[1];

            booster.previewBtn.CustomBoosterInnerBorder = buttonInput.CustomBoosterInnerBorder;
            booster.previewBtn.CustomBoosterOuterBorder = buttonInput.CustomBoosterOuterBorder;

            booster.previewBtn.CustomBoosterHatchColors[0] = buttonInput.CustomBoosterHatchColors[0];
            booster.previewBtn.CustomBoosterHatchColors[1] = buttonInput.CustomBoosterHatchColors[1];

        }

        private void BoosterSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.UpperLeftCurve = (int)booster.customBooster_UpperLeftCurve_Numeric.Value;
            buttonInput.UpperRightCurve = (int)booster.customBooster_UpperRightCurve_Numeric.Value;
            buttonInput.DownLeftCurve = (int)booster.customBooster_DownLeftCurve_Numeric.Value;
            buttonInput.DownRightCurve = (int)booster.customBooster_DownRightCurve_Numeric.Value;
            buttonInput.CustomBoosterOffset = (int)booster.customBooster_Offset_Numeric.Value;
            buttonInput.CustomBoosterHoverTransparency = (float)booster.customBooster_HoverTransparency_Numeric.Value;
            buttonInput.CustomBoosterGradientAngle = (float)booster.customBooster_GradientAngle_Numeric.Value;

            buttonInput.CustomBoosterColors[0] = booster.customBooster_Colors0_Btn.BackColor;
            buttonInput.CustomBoosterColors[1] = booster.customBooster_Colors1_Btn.BackColor;

            buttonInput.CustomBoosterInnerBorder = booster.customBooster_BorderColors0_Btn.BackColor;
            buttonInput.CustomBoosterOuterBorder = booster.customBooster_BorderColors1_Btn.BackColor;

            buttonInput.CustomBoosterHatchColors[0] = booster.customBooster_HatchColors0_Btn.BackColor;
            buttonInput.CustomBoosterHatchColors[1] = booster.customBooster_HatchColors1_Btn.BackColor;

            if (booster.customBooster_InfluenceOuter_Yes_RadioBtn.Checked == true)
            {
                buttonInput.CustomBoosterInfluenceOuter = true;
            }
            else
            {
                buttonInput.CustomBoosterInfluenceOuter = false;
                 
            }

        }

        private void ClassicInitialValues(ButtonInput buttonInput)
        {
            classic.customClassic_Colors0_Btn.BackColor = buttonInput.CustomClassicColors[0];
            classic.customClassic_Colors1_Btn.BackColor = buttonInput.CustomClassicColors[1];

            classic.customClassic_Background_Btn.BackColor = buttonInput.CustomClassicBackground;
            classic.customClassic_Highlight_Btn.BackColor = buttonInput.CustomClassicHighlight;
            classic.customClassic_Shadow_Btn.BackColor = buttonInput.CustomClassicShadow;


            classic.previewBtn.CustomClassicColors[0] = buttonInput.CustomClassicColors[0];
            classic.previewBtn.CustomClassicColors[1] = buttonInput.CustomClassicColors[1];

            classic.previewBtn.CustomClassicBackground = buttonInput.CustomClassicBackground;
            classic.previewBtn.CustomClassicHighlight = buttonInput.CustomClassicHighlight;
            classic.previewBtn.CustomClassicShadow = buttonInput.CustomClassicShadow;


        }

        private void ClassicSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomClassicColors[0] = classic.customClassic_Colors0_Btn.BackColor;
            buttonInput.CustomClassicColors[1] = classic.customClassic_Colors1_Btn.BackColor;

            buttonInput.CustomClassicBackground = classic.customClassic_Background_Btn.BackColor;
            buttonInput.CustomClassicHighlight = classic.customClassic_Highlight_Btn.BackColor;
            buttonInput.CustomClassicShadow = classic.customClassic_Shadow_Btn.BackColor;
        }

        private void DeumosInitialValues(ButtonInput buttonInput)
        {

            deumos.customDeumos_BorderColors0_Btn.BackColor = buttonInput.CustomDeumosBorderColors[0];
            deumos.customDeumos_BorderColors1_Btn.BackColor = buttonInput.CustomDeumosBorderColors[1];
            deumos.customDeumos_BorderColors2_Btn.BackColor = buttonInput.CustomDeumosBorderColors[2];

            deumos.customDeumos_DownColors0_Btn.BackColor = buttonInput.CustomDeumosDownStateColors[0];
            deumos.customDeumos_DownColors1_Btn.BackColor = buttonInput.CustomDeumosDownStateColors[1];

            deumos.customDeumos_NoneColors0_Btn.BackColor = buttonInput.CustomDeumosNoneStateColors[0];
            deumos.customDeumos_NoneColors1_Btn.BackColor = buttonInput.CustomDeumosNoneStateColors[1];

            deumos.customDeumos_Over_Btn.BackColor = buttonInput.CustomDeumosOverStateColor;
            deumos.customDeumos_Background_Btn.BackColor = buttonInput.CustomDeumosBackground;
            deumos.customDeumos_Corner_Btn.BackColor = buttonInput.CustomDeumosCornerColor;


            deumos.previewBtn.CustomDeumosBorderColors[0] = buttonInput.CustomDeumosBorderColors[0];
            deumos.previewBtn.CustomDeumosBorderColors[1] = buttonInput.CustomDeumosBorderColors[1];
            deumos.previewBtn.CustomDeumosBorderColors[2] = buttonInput.CustomDeumosBorderColors[2];

            deumos.previewBtn.CustomDeumosDownStateColors[0] = buttonInput.CustomDeumosDownStateColors[0];
            deumos.previewBtn.CustomDeumosDownStateColors[1] = buttonInput.CustomDeumosDownStateColors[1];

            deumos.previewBtn.CustomDeumosNoneStateColors[0] = buttonInput.CustomDeumosNoneStateColors[0];
            deumos.previewBtn.CustomDeumosNoneStateColors[1] = buttonInput.CustomDeumosNoneStateColors[1];

            deumos.previewBtn.CustomDeumosOverStateColor = buttonInput.CustomDeumosOverStateColor;
            deumos.previewBtn.CustomDeumosBackground = buttonInput.CustomDeumosBackground;
            deumos.previewBtn.CustomDeumosCornerColor = buttonInput.CustomDeumosCornerColor;


        }

        private void DeumosSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomDeumosBorderColors[0] = deumos.customDeumos_BorderColors0_Btn.BackColor;
            buttonInput.CustomDeumosBorderColors[1] = deumos.customDeumos_BorderColors1_Btn.BackColor;
            buttonInput.CustomDeumosBorderColors[2] = deumos.customDeumos_BorderColors2_Btn.BackColor;

            buttonInput.CustomDeumosDownStateColors[0] = deumos.customDeumos_DownColors0_Btn.BackColor;
            buttonInput.CustomDeumosDownStateColors[1] = deumos.customDeumos_DownColors1_Btn.BackColor;

            buttonInput.CustomDeumosNoneStateColors[0] = deumos.customDeumos_NoneColors0_Btn.BackColor;
            buttonInput.CustomDeumosNoneStateColors[1] = deumos.customDeumos_NoneColors1_Btn.BackColor;

            buttonInput.CustomDeumosOverStateColor = deumos.customDeumos_Over_Btn.BackColor;
            buttonInput.CustomDeumosBackground = deumos.customDeumos_Background_Btn.BackColor;
            buttonInput.CustomDeumosCornerColor = deumos.customDeumos_Corner_Btn.BackColor;

        }

        private void ExcisionInitialValues(ButtonInput buttonInput)
        {
            #region Add Button Styles to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(ButtonThematic.CustomExcisionStyles)))
            {
                excision.customExcision_ButtonType_Combo.Items.Add(volume);

            }

            for (int i = 0; i < excision.customExcision_ButtonType_Combo.Items.Count; i++)
            {
                if (buttonInput.CustomExcisionStyle == (ButtonThematic.CustomExcisionStyles)Enum.Parse(typeof(ButtonThematic.CustomExcisionStyles), excision.customExcision_ButtonType_Combo.Items[i].ToString()))
                {
                    excision.customExcision_ButtonType_Combo.SelectedIndex = i;

                    excision.previewBtn.CustomExcisionStyle = 
                        (ExcisionPreview.CustomExcisionStyles) Enum.Parse(
                        typeof(ExcisionPreview.CustomExcisionStyles),
                        excision.customExcision_ButtonType_Combo.Items[i].ToString());


                }

            }


            #endregion

            excision.customExcision_BorderColors0_Btn.BackColor = buttonInput.CustomExcisionBorderColors[0];
            excision.customExcision_BorderColors1_Btn.BackColor = buttonInput.CustomExcisionBorderColors[1];

            excision.customExcision_ImageCodeString_TxtBox.Text = buttonInput.ImageCodeString;
            excision.customExcision_ImageViewer_PicBox.Image = excision.CodeToImage(excision.customExcision_ImageCodeString_TxtBox.Text);


            excision.previewBtn.CustomExcisionBorderColors[0] = buttonInput.CustomExcisionBorderColors[0];
            excision.previewBtn.CustomExcisionBorderColors[1] = buttonInput.CustomExcisionBorderColors[1];

            excision.previewBtn.ImageCodeString = buttonInput.ImageCodeString;
            

        }

        private void ExcisionSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            #region Add Button Styles to ComboBox

            buttonInput.CustomExcisionStyle =
                (ButtonThematic.CustomExcisionStyles)Enum.Parse(typeof
                        (ButtonThematic.CustomExcisionStyles),
                    excision.customExcision_ButtonType_Combo.SelectedItem.ToString());

            #endregion

            buttonInput.CustomExcisionBorderColors[0] = excision.customExcision_BorderColors0_Btn.BackColor;
            buttonInput.CustomExcisionBorderColors[1] = excision.customExcision_BorderColors1_Btn.BackColor;

            buttonInput.ImageCodeString = excision.customExcision_ImageCodeString_TxtBox.Text;
            
        }

        private void FutureInitialValues(ButtonInput buttonInput)
        {
            future.customFusion_BlendPos1_Numeric.Value = (decimal)buttonInput.CustomFusionBlend.Positions[0];
            future.customFusion_BlendPos2_Numeric.Value = (decimal)buttonInput.CustomFusionBlend.Positions[1];
            future.customFusion_BlendPos3_Numeric.Value = (decimal)buttonInput.CustomFusionBlend.Positions[2];

            future.customFusion_BlendColor0_Btn.BackColor = buttonInput.CustomFusionBlend.Colors[0];
            future.customFusion_BlendColor1_Btn.BackColor = buttonInput.CustomFusionBlend.Colors[1];
            future.customFusion_BlendColor2_Btn.BackColor = buttonInput.CustomFusionBlend.Colors[2];

            future.customFusion_GradColors0_Btn.BackColor = buttonInput.CustomFusionGradColors[0];
            future.customFusion_GradColors1_Btn.BackColor = buttonInput.CustomFusionGradColors[1];

            future.customFusion_Inactive_Btn.BackColor = buttonInput.CustomFusionNoneBorderColor;
            future.customFusion_Hover_Btn.BackColor = buttonInput.CustomFusionOverBorderColor;
            future.customFusion_Pressed_Btn.BackColor = buttonInput.CustomFusionDownBorderColor;
            future.customFusion_Corner_Btn.BackColor = buttonInput.CustomFusionCornerColor;


            future.previewBtn.CustomFusionBlend.Positions[0] = (float)buttonInput.CustomFusionBlend.Positions[0];
            future.previewBtn.CustomFusionBlend.Positions[1] = (float)buttonInput.CustomFusionBlend.Positions[1];
            future.previewBtn.CustomFusionBlend.Positions[2] = (float)buttonInput.CustomFusionBlend.Positions[2];

            future.previewBtn.CustomFusionBlend.Colors[0] = buttonInput.CustomFusionBlend.Colors[0];
            future.previewBtn.CustomFusionBlend.Colors[1] = buttonInput.CustomFusionBlend.Colors[1];
            future.previewBtn.CustomFusionBlend.Colors[2] = buttonInput.CustomFusionBlend.Colors[2];

            future.previewBtn.CustomFusionGradColors[0] = buttonInput.CustomFusionGradColors[0];
            future.previewBtn.CustomFusionGradColors[1] = buttonInput.CustomFusionGradColors[1];

            future.previewBtn.CustomFusionNoneBorderColor = buttonInput.CustomFusionNoneBorderColor;
            future.previewBtn.CustomFusionOverBorderColor = buttonInput.CustomFusionOverBorderColor;
            future.previewBtn.CustomFusionDownBorderColor = buttonInput.CustomFusionDownBorderColor;
            future.previewBtn.CustomFusionCornerColor = buttonInput.CustomFusionCornerColor;


        }
        
        private void FutureSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomFusionBlend.Positions[0] = (float)future.customFusion_BlendPos1_Numeric.Value;
            buttonInput.CustomFusionBlend.Positions[1] = (float)future.customFusion_BlendPos2_Numeric.Value;
            buttonInput.CustomFusionBlend.Positions[2] = (float)future.customFusion_BlendPos3_Numeric.Value;


            buttonInput.CustomFusionBlend.Colors[0] = future.customFusion_BlendColor0_Btn.BackColor;
            buttonInput.CustomFusionBlend.Colors[1] = future.customFusion_BlendColor0_Btn.BackColor;
            buttonInput.CustomFusionBlend.Colors[2] = future.customFusion_BlendColor0_Btn.BackColor;


            buttonInput.CustomFusionGradColors[0] = future.customFusion_GradColors0_Btn.BackColor;
            buttonInput.CustomFusionGradColors[1] = future.customFusion_GradColors1_Btn.BackColor;

            buttonInput.CustomFusionNoneBorderColor = future.customFusion_Inactive_Btn.BackColor;
            buttonInput.CustomFusionOverBorderColor = future.customFusion_Hover_Btn.BackColor;
            buttonInput.CustomFusionDownBorderColor = future.customFusion_Pressed_Btn.BackColor;
            buttonInput.CustomFusionCornerColor = future.customFusion_Corner_Btn.BackColor;
        }

        private void GameBoosterInitialValues(ButtonInput buttonInput)
        {


            gameBooster.customGameBooster_TopGradient_Btn.BackColor = buttonInput.CustomGameBoosterTopGradient;
            gameBooster.customGameBooster_TopGradientClick_Btn.BackColor = buttonInput.CustomGameBoosterTopGradientClick;
            gameBooster.customGameBooster_BottomGradient_Btn.BackColor = buttonInput.CustomGameBoosterBotGradient;
            gameBooster.customGameBooster_BottomGradientClick_Btn.BackColor = buttonInput.CustomGameBoosterBotGradientClick;
            gameBooster.customGameBooster_OuterBorderHover_Btn.BackColor = buttonInput.CustomGameBoosterOuterBorderHover;

            gameBooster.customGameBooster_InnerBorder_Btn.BackColor = buttonInput.CustomGameBoosterInnerBorder;
            gameBooster.customGameBooster_OuterBorder_Btn.BackColor = buttonInput.CustomGameBoosterOuterBorder;
            gameBooster.customGameBooster_InnerBorderClick_Btn.BackColor = buttonInput.CustomGameBoosterInnerBorderClick;
            gameBooster.customGameBooster_OuterBorderClick_Btn.BackColor = buttonInput.CustomGameBoosterOuterBorderClick;
            gameBooster.customGameBooster_InnerBorderHover_Btn.BackColor = buttonInput.CustomGameBoosterInnerBorderHover;
            
            gameBooster.customGameBooster_TopGradHover_Btn.BackColor = buttonInput.CustomGameBoosterTopGradientHover;
            gameBooster.customGameBooster_BottomGradHover_Btn.BackColor = buttonInput.CustomGameBoosterBotGradientHover;
            gameBooster.customGameBooster_Corner_Btn.BackColor = buttonInput.CustomGameBoosterCornerColor;


            gameBooster.previewBtn.CustomGameBoosterTopGradient = buttonInput.CustomGameBoosterTopGradient;
            gameBooster.previewBtn.CustomGameBoosterTopGradientClick = buttonInput.CustomGameBoosterTopGradientClick;
            gameBooster.previewBtn.CustomGameBoosterBotGradient = buttonInput.CustomGameBoosterBotGradient;
            gameBooster.previewBtn.CustomGameBoosterBotGradientClick = buttonInput.CustomGameBoosterBotGradientClick;
            gameBooster.previewBtn.CustomGameBoosterOuterBorderHover = buttonInput.CustomGameBoosterOuterBorderHover;

            gameBooster.previewBtn.CustomGameBoosterInnerBorder = buttonInput.CustomGameBoosterInnerBorder;
            gameBooster.previewBtn.CustomGameBoosterOuterBorder = buttonInput.CustomGameBoosterOuterBorder;
            gameBooster.previewBtn.CustomGameBoosterInnerBorderClick = buttonInput.CustomGameBoosterInnerBorderClick;
            gameBooster.previewBtn.CustomGameBoosterOuterBorderClick = buttonInput.CustomGameBoosterOuterBorderClick;
            gameBooster.previewBtn.CustomGameBoosterInnerBorderHover = buttonInput.CustomGameBoosterInnerBorderHover;

            gameBooster.previewBtn.CustomGameBoosterTopGradientHover = buttonInput.CustomGameBoosterTopGradientHover;
            gameBooster.previewBtn.CustomGameBoosterBotGradientHover = buttonInput.CustomGameBoosterBotGradientHover;
            gameBooster.previewBtn.CustomGameBoosterCornerColor = buttonInput.CustomGameBoosterCornerColor;


        }
        
        private void GameBoosterSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomGameBoosterTopGradient = gameBooster.customGameBooster_TopGradient_Btn.BackColor;
            buttonInput.CustomGameBoosterTopGradientClick = gameBooster.customGameBooster_TopGradientClick_Btn.BackColor;
            buttonInput.CustomGameBoosterBotGradient = gameBooster.customGameBooster_BottomGradient_Btn.BackColor;
            buttonInput.CustomGameBoosterBotGradientClick = gameBooster.customGameBooster_BottomGradientClick_Btn.BackColor;
            buttonInput.CustomGameBoosterOuterBorderHover = gameBooster.customGameBooster_OuterBorderHover_Btn.BackColor;

            buttonInput.CustomGameBoosterInnerBorder = gameBooster.customGameBooster_InnerBorder_Btn.BackColor;
            buttonInput.CustomGameBoosterOuterBorder = gameBooster.customGameBooster_OuterBorder_Btn.BackColor;
            buttonInput.CustomGameBoosterInnerBorderClick = gameBooster.customGameBooster_InnerBorderClick_Btn.BackColor;
            buttonInput.CustomGameBoosterOuterBorderClick = gameBooster.customGameBooster_OuterBorderClick_Btn.BackColor;
            buttonInput.CustomGameBoosterInnerBorderHover = gameBooster.customGameBooster_InnerBorderHover_Btn.BackColor;

            buttonInput.CustomGameBoosterTopGradientHover = gameBooster.customGameBooster_TopGradHover_Btn.BackColor;
            buttonInput.CustomGameBoosterBotGradientHover = gameBooster.customGameBooster_BottomGradHover_Btn.BackColor;
            buttonInput.CustomGameBoosterCornerColor = gameBooster.customGameBooster_Corner_Btn.BackColor;


        }

        private void IntelInitialValues(ButtonInput buttonInput)
        {
            intel.customIntel_Background_Btn.BackColor = buttonInput.CustomIntelBackgroundColor;
            intel.customIntel_Border_Btn.BackColor = buttonInput.CustomIntelBorderColor;
            intel.customIntel_Shade_Btn.BackColor = buttonInput.CustomIntelShade;

            intel.customIntel_Glow_Numeric.Value = buttonInput.CustomIntelGlow;



            intel.previewBtn.CustomIntelBackgroundColor = buttonInput.CustomIntelBackgroundColor;
            intel.previewBtn.CustomIntelBorderColor = buttonInput.CustomIntelBorderColor;
            intel.previewBtn.CustomIntelShade = buttonInput.CustomIntelShade;

            intel.previewBtn.CustomIntelGlow = buttonInput.CustomIntelGlow;

            intel.previewBtn.CustomIntelCurve = buttonInput.Curve / 4;
        }

        private void IntelSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());
            
            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomIntelBackgroundColor = intel.customIntel_Background_Btn.BackColor;
            buttonInput.CustomIntelBorderColor = intel.customIntel_Border_Btn.BackColor;
            buttonInput.CustomIntelShade = intel.customIntel_Shade_Btn.BackColor;

            buttonInput.CustomIntelGlow = (int)intel.customIntel_Glow_Numeric.Value;


        }

        private void CustomizedMizerInitialValues(ButtonInput buttonInput)
        {
            mizer.customizedBtn_Inactive_Border_Btn.BackColor = buttonInput.CustomizedBtnInactiveBorder;

            mizer.customizedBtn_Inactive_Colors0_Btn.BackColor = buttonInput.CustomizedBtnInactive[0];
            mizer.customizedBtn_Inactive_Colors1_Btn.BackColor = buttonInput.CustomizedBtnInactive[1];

            mizer.customizedBtn_OffsetBorder0_Btn.BackColor = buttonInput.CustomizedBtnOffsetBorder[0];
            mizer.customizedBtn_OffsetBorder1_Btn.BackColor = buttonInput.CustomizedBtnOffsetBorder[1];

            mizer.customizedBtn_ActiveColors0_Btn.BackColor = buttonInput.CustomizedBtnActive[0];
            mizer.customizedBtn_ActiveColors1_Btn.BackColor = buttonInput.CustomizedBtnActive[1];

            mizer.customizedBtn_PressedColors0_Btn.BackColor = buttonInput.CustomizedBtnPressed[0];
            mizer.customizedBtn_PressedColors1_Btn.BackColor = buttonInput.CustomizedBtnPressed[1];

            mizer.customizedBtn_OffsetGradient0_Btn.BackColor = buttonInput.CustomizedBtnOffsetGradient[0];
            mizer.customizedBtn_OffsetGradient1_Btn.BackColor = buttonInput.CustomizedBtnOffsetGradient[1];

            mizer.customizedBtn_ActiveBorderColors0_Btn.BackColor = buttonInput.CustomizedBtnActiveBorder[0];
            mizer.customizedBtn_ActiveBorderColors1_Btn.BackColor = buttonInput.CustomizedBtnActiveBorder[1];

            mizer.customizedBtn_PressedBorder0_Btn.BackColor = buttonInput.CustomizedBtnPressedBorder[0];
            mizer.customizedBtn_PressedBorder1_Btn.BackColor = buttonInput.CustomizedBtnPressedBorder[1];

            mizer.customizedBtn_Offset_Numeric.Value = buttonInput.CustomizedBtnOffset;




            mizer.previewBtn.CustomizedBtnInactiveBorder = buttonInput.CustomizedBtnInactiveBorder;

            mizer.previewBtn.CustomizedBtnInactive[0] = buttonInput.CustomizedBtnInactive[0];
            mizer.previewBtn.CustomizedBtnInactive[1] = buttonInput.CustomizedBtnInactive[1];

            mizer.previewBtn.CustomizedBtnOffsetBorder[0] = buttonInput.CustomizedBtnOffsetBorder[0];
            mizer.previewBtn.CustomizedBtnOffsetBorder[1] = buttonInput.CustomizedBtnOffsetBorder[1];

            mizer.previewBtn.CustomizedBtnActive[0] = buttonInput.CustomizedBtnActive[0];
            mizer.previewBtn.CustomizedBtnActive[1] = buttonInput.CustomizedBtnActive[1];

            mizer.previewBtn.CustomizedBtnPressed[0] = buttonInput.CustomizedBtnPressed[0];
            mizer.previewBtn.CustomizedBtnPressed[1] = buttonInput.CustomizedBtnPressed[1];

            mizer.previewBtn.CustomizedBtnOffsetGradient[0] = buttonInput.CustomizedBtnOffsetGradient[0];
            mizer.previewBtn.CustomizedBtnOffsetGradient[0] = buttonInput.CustomizedBtnOffsetGradient[1];

            mizer.previewBtn.CustomizedBtnActiveBorder[0] = buttonInput.CustomizedBtnActiveBorder[0];
            mizer.previewBtn.CustomizedBtnActiveBorder[1] = buttonInput.CustomizedBtnActiveBorder[1];

            mizer.previewBtn.CustomizedBtnPressedBorder[0] = buttonInput.CustomizedBtnPressedBorder[0];
            mizer.previewBtn.CustomizedBtnPressedBorder[1] = buttonInput.CustomizedBtnPressedBorder[1];

            mizer.previewBtn.CustomizedBtnOffset = buttonInput.CustomizedBtnOffset;

            mizer.previewBtn.Curve = buttonInput.Curve / 4;
        }

        private void CustomizedMizerSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomizedBtnInactiveBorder = mizer.customizedBtn_Inactive_Border_Btn.BackColor;

            buttonInput.CustomizedBtnInactive[0] = mizer.customizedBtn_Inactive_Colors0_Btn.BackColor;
            buttonInput.CustomizedBtnInactive[1] = mizer.customizedBtn_Inactive_Colors1_Btn.BackColor;

            buttonInput.CustomizedBtnOffsetBorder[0] = mizer.customizedBtn_OffsetBorder0_Btn.BackColor;
            buttonInput.CustomizedBtnOffsetBorder[1] = mizer.customizedBtn_OffsetBorder1_Btn.BackColor;

            buttonInput.CustomizedBtnActive[0] = mizer.customizedBtn_ActiveColors0_Btn.BackColor;
            buttonInput.CustomizedBtnActive[1] = mizer.customizedBtn_ActiveColors1_Btn.BackColor;

            buttonInput.CustomizedBtnPressed[0] = mizer.customizedBtn_PressedColors0_Btn.BackColor;
            buttonInput.CustomizedBtnPressed[1] = mizer.customizedBtn_PressedColors1_Btn.BackColor;

            buttonInput.CustomizedBtnOffsetGradient[0] = mizer.customizedBtn_OffsetGradient0_Btn.BackColor;
            buttonInput.CustomizedBtnOffsetGradient[1] = mizer.customizedBtn_OffsetGradient1_Btn.BackColor;

            buttonInput.CustomizedBtnActiveBorder[0] = mizer.customizedBtn_ActiveBorderColors0_Btn.BackColor;
            buttonInput.CustomizedBtnActiveBorder[1] = mizer.customizedBtn_ActiveBorderColors1_Btn.BackColor;

            buttonInput.CustomizedBtnPressedBorder[0] = mizer.customizedBtn_PressedBorder0_Btn.BackColor;
            buttonInput.CustomizedBtnPressedBorder[1] = mizer.customizedBtn_PressedBorder1_Btn.BackColor;

            buttonInput.CustomizedBtnOffset = (int)mizer.customizedBtn_Offset_Numeric.Value;


        }

        private void NamelessInitialValues(ButtonInput buttonInput)
        {
            nameless.customNameless_BorderColors0_Btn.BackColor = buttonInput.CustomNamelessBorderColors[0];
            nameless.customNameless_BorderColors1_Btn.BackColor = buttonInput.CustomNamelessBorderColors[1];
            nameless.customNameless_BorderColors2_Btn.BackColor = buttonInput.CustomNamelessBorderColors[2];

            nameless.customNameless_NoneHighlight0_Btn.BackColor = buttonInput.CustomNamelessNoneHighlight[0];
            nameless.customNameless_NoneHighlight1_Btn.BackColor = buttonInput.CustomNamelessNoneHighlight[1];
            nameless.customNameless_NoneHighlight2_Btn.BackColor = buttonInput.CustomNamelessNoneHighlight[2];

            nameless.customNameless_OverHighlight0_Btn.BackColor = buttonInput.CustomNamelessOverHighlight[0];
            nameless.customNameless_OverHighlight1_Btn.BackColor = buttonInput.CustomNamelessOverHighlight[1];
            nameless.customNameless_OverHighlight2_Btn.BackColor = buttonInput.CustomNamelessOverHighlight[2];

            nameless.customNameless_DownHighlight0_Btn.BackColor = buttonInput.CustomNamelessDownHighlight[0];
            nameless.customNameless_DownHighlight1_Btn.BackColor = buttonInput.CustomNamelessDownHighlight[1];
            nameless.customNameless_DownHighlight2_Btn.BackColor = buttonInput.CustomNamelessDownHighlight[2];

            nameless.customNameless_Corners_Btn.BackColor = buttonInput.CustomNamelessCorners;


            nameless.previewBtn.CustomNamelessBorderColors[0] = buttonInput.CustomNamelessBorderColors[0];
            nameless.previewBtn.CustomNamelessBorderColors[1] = buttonInput.CustomNamelessBorderColors[1];
            nameless.previewBtn.CustomNamelessBorderColors[2] = buttonInput.CustomNamelessBorderColors[2];

            nameless.previewBtn.CustomNamelessNoneHighlight[0] = buttonInput.CustomNamelessNoneHighlight[0];
            nameless.previewBtn.CustomNamelessNoneHighlight[1] = buttonInput.CustomNamelessNoneHighlight[1];
            nameless.previewBtn.CustomNamelessNoneHighlight[2] = buttonInput.CustomNamelessNoneHighlight[2];

            nameless.previewBtn.CustomNamelessOverHighlight[0] = buttonInput.CustomNamelessOverHighlight[0];
            nameless.previewBtn.CustomNamelessOverHighlight[1] = buttonInput.CustomNamelessOverHighlight[1];
            nameless.previewBtn.CustomNamelessOverHighlight[2] = buttonInput.CustomNamelessOverHighlight[2];

            nameless.previewBtn.CustomNamelessDownHighlight[0] = buttonInput.CustomNamelessDownHighlight[0];
            nameless.previewBtn.CustomNamelessDownHighlight[1] = buttonInput.CustomNamelessDownHighlight[1];
            nameless.previewBtn.CustomNamelessDownHighlight[2] = buttonInput.CustomNamelessDownHighlight[2];

            nameless.previewBtn.CustomNamelessCorners = buttonInput.CustomNamelessCorners;


        }

        private void NamelessSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomNamelessBorderColors[0] = nameless.customNameless_BorderColors0_Btn.BackColor;
            buttonInput.CustomNamelessBorderColors[1] = nameless.customNameless_BorderColors1_Btn.BackColor;
            buttonInput.CustomNamelessBorderColors[2] = nameless.customNameless_BorderColors2_Btn.BackColor;

            buttonInput.CustomNamelessNoneHighlight[0] = nameless.customNameless_NoneHighlight0_Btn.BackColor;
            buttonInput.CustomNamelessNoneHighlight[1] = nameless.customNameless_NoneHighlight1_Btn.BackColor;
            buttonInput.CustomNamelessNoneHighlight[2] = nameless.customNameless_NoneHighlight2_Btn.BackColor;

            buttonInput.CustomNamelessOverHighlight[0] = nameless.customNameless_OverHighlight0_Btn.BackColor;
            buttonInput.CustomNamelessOverHighlight[1] = nameless.customNameless_OverHighlight1_Btn.BackColor;
            buttonInput.CustomNamelessOverHighlight[2] = nameless.customNameless_OverHighlight2_Btn.BackColor;

            buttonInput.CustomNamelessDownHighlight[0] = nameless.customNameless_DownHighlight0_Btn.BackColor;
            buttonInput.CustomNamelessDownHighlight[1] = nameless.customNameless_DownHighlight1_Btn.BackColor;
            buttonInput.CustomNamelessDownHighlight[2] = nameless.customNameless_DownHighlight2_Btn.BackColor;

            buttonInput.CustomNamelessCorners = nameless.customNameless_Corners_Btn.BackColor;


        }

        private void NetSealInitialValues(ButtonInput buttonInput)
        {
            netSeal.customNetSeal_FocusScale1_Numeric.Value = (decimal)buttonInput.CustomFocusScales.X;
            netSeal.customNetSeal_FocusScale2_Numeric.Value = (decimal)buttonInput.CustomFocusScales.Y;

            netSeal.customNetSeal_PathBorder0_Btn.BackColor = buttonInput.CustomNetSealPathBorders[0];
            netSeal.customNetSeal_PathBorder1_Btn.BackColor = buttonInput.CustomNetSealPathBorders[1];

            netSeal.customNetSeal_Centre_Btn.BackColor = buttonInput.CustomNetSealCenterColor;
            netSeal.customNetSeal_Surround_Btn.BackColor = buttonInput.CustomNetSealSurroundColor;

            netSeal.previewBtn.Curve = buttonInput.Curve / 4;
        }
        
        private void NetSealSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion
            
            buttonInput.CustomFocusScales = new PointF((float)netSeal.customNetSeal_FocusScale1_Numeric.Value, (float)netSeal.customNetSeal_FocusScale2_Numeric.Value);
            
            buttonInput.CustomNetSealPathBorders[0] = netSeal.customNetSeal_PathBorder0_Btn.BackColor;
            buttonInput.CustomNetSealPathBorders[1] = netSeal.customNetSeal_PathBorder1_Btn.BackColor;

            buttonInput.CustomNetSealCenterColor = netSeal.customNetSeal_Centre_Btn.BackColor;
            buttonInput.CustomNetSealSurroundColor = netSeal.customNetSeal_Surround_Btn.BackColor;

        }

        private void OrainsInitialValues(ButtonInput buttonInput)
        {

            orains.customOrains_Color0_Btn.BackColor = buttonInput.CustomOrainsButton[0];
            orains.customOrains_Color1_Btn.BackColor = buttonInput.CustomOrainsButton[1];

            orains.customOrains_Hatch0_Btn.BackColor = buttonInput.CustomOrainsHatch[0];
            orains.customOrains_Hatch1_Btn.BackColor = buttonInput.CustomOrainsHatch[1];

            orains.customOrains_Header_Btn.BackColor = buttonInput.CustomOrainsHeader;

            orains.customOrains_InnerBorder_Btn.BackColor = buttonInput.CustomOrainsInnerBorder;
            orains.customOrains_OuterBorder_Btn.BackColor = buttonInput.CustomOrainsOuterBorder;


            orains.previewBtn.CustomOrainsButton[0] = buttonInput.CustomOrainsButton[0];
            orains.previewBtn.CustomOrainsButton[1] = buttonInput.CustomOrainsButton[1];

            orains.previewBtn.CustomOrainsHatch[0] = buttonInput.CustomOrainsHatch[0];
            orains.previewBtn.CustomOrainsHatch[1] = buttonInput.CustomOrainsHatch[1];

            orains.previewBtn.CustomOrainsHeader = buttonInput.CustomOrainsHeader;

            orains.previewBtn.CustomOrainsInnerBorder = buttonInput.CustomOrainsInnerBorder;
            orains.previewBtn.CustomOrainsOuterBorder = buttonInput.CustomOrainsOuterBorder;

        }

        private void OrainsSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomOrainsButton[0] = orains.customOrains_Color0_Btn.BackColor;
            buttonInput.CustomOrainsButton[1] = orains.customOrains_Color1_Btn.BackColor;

            buttonInput.CustomOrainsHatch[0] = orains.customOrains_Hatch0_Btn.BackColor;
            buttonInput.CustomOrainsHatch[1] = orains.customOrains_Hatch1_Btn.BackColor;

            buttonInput.CustomOrainsHeader = orains.customOrains_Header_Btn.BackColor;

            buttonInput.CustomOrainsInnerBorder = orains.customOrains_InnerBorder_Btn.BackColor;
            buttonInput.CustomOrainsOuterBorder = orains.customOrains_OuterBorder_Btn.BackColor;

        }

        private void ReconInitialValues(ButtonInput buttonInput)
        {
            recon.customRecon_NoneColor0_Btn.BackColor = buttonInput.CustomReconNoneStateColors[0];
            recon.customRecon_NoneColor1_Btn.BackColor = buttonInput.CustomReconNoneStateColors[1];

            recon.customRecon_OverColors0_Btn.BackColor = buttonInput.CustomReconOverStateColors[0];
            recon.customRecon_OverColors1_Btn.BackColor = buttonInput.CustomReconOverStateColors[1];
            recon.customRecon_OverColors2_Btn.BackColor = buttonInput.CustomReconOverStateColors[2];
            recon.customRecon_OverColors3_Btn.BackColor = buttonInput.CustomReconOverStateColors[3];

            recon.customRecon_DownColors0_Btn.BackColor = buttonInput.CustomReconDownStateColors[0];
            recon.customRecon_DownColors1_Btn.BackColor = buttonInput.CustomReconDownStateColors[1];
            recon.customRecon_DownColors2_Btn.BackColor = buttonInput.CustomReconDownStateColors[2];
            recon.customRecon_DownColors3_Btn.BackColor = buttonInput.CustomReconDownStateColors[3];

            recon.customRecon_BorderColors0_Btn.BackColor = buttonInput.CustomReconBorder[0];
            recon.customRecon_BorderColors1_Btn.BackColor = buttonInput.CustomReconBorder[1];

            recon.customRecon_Background_Btn.BackColor = buttonInput.CustomReconBackground;

            
        }

        private void ReconSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomReconNoneStateColors[0] = recon.customRecon_NoneColor0_Btn.BackColor;
            buttonInput.CustomReconNoneStateColors[1] = recon.customRecon_NoneColor1_Btn.BackColor;

            buttonInput.CustomReconOverStateColors[0] = recon.customRecon_OverColors0_Btn.BackColor;
            buttonInput.CustomReconOverStateColors[1] = recon.customRecon_OverColors1_Btn.BackColor;
            buttonInput.CustomReconOverStateColors[2] = recon.customRecon_OverColors2_Btn.BackColor;
            buttonInput.CustomReconOverStateColors[3] = recon.customRecon_OverColors3_Btn.BackColor;

            buttonInput.CustomReconDownStateColors[0] = recon.customRecon_DownColors0_Btn.BackColor;
            buttonInput.CustomReconDownStateColors[1] = recon.customRecon_DownColors1_Btn.BackColor;
            buttonInput.CustomReconDownStateColors[2] = recon.customRecon_DownColors2_Btn.BackColor;
            buttonInput.CustomReconDownStateColors[3] = recon.customRecon_DownColors3_Btn.BackColor;

            buttonInput.CustomReconBorder[0] = recon.customRecon_BorderColors0_Btn.BackColor;
            buttonInput.CustomReconBorder[1] = recon.customRecon_BorderColors1_Btn.BackColor;

            buttonInput.CustomReconBackground = recon.customRecon_Background_Btn.BackColor;
            
        }

        private void SpicyLipsInitialValues(ButtonInput buttonInput)
        {
            spicyLips.customSpicy_NoneColor0_Btn.BackColor = buttonInput.CustomSpicyNoneStateColors[0];
            spicyLips.customSpicy_NoneColor1_Btn.BackColor = buttonInput.CustomSpicyNoneStateColors[1];

            spicyLips.customSpicy_HoverColor0_Btn.BackColor = buttonInput.CustomSpicyOverStateColors[0];
            spicyLips.customSpicy_HoverColor1_Btn.BackColor = buttonInput.CustomSpicyOverStateColors[1];

            spicyLips.customSpicy_PressedColor0_Btn.BackColor = buttonInput.CustomSpicyDownStateColors[0];
            spicyLips.customSpicy_PressedColor1_Btn.BackColor = buttonInput.CustomSpicyDownStateColors[1];

            spicyLips.customSpicy_BorderColor0_Btn.BackColor = buttonInput.CustomSpicyBorderColors[0];
            spicyLips.customSpicy_BorderColor1_Btn.BackColor = buttonInput.CustomSpicyBorderColors[1];

            spicyLips.customSpicy_Background_Btn.BackColor = buttonInput.CustomSpicyBackground;

            spicyLips.customSpicy_Corner_Btn.BackColor = buttonInput.CustomSpicyCornerColor;
            spicyLips.customSpicy_Highlight_Btn.BackColor = buttonInput.CustomSpicyHighlight;

        }

        private void SpicyLipsSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomSpicyNoneStateColors[0] = spicyLips.customSpicy_NoneColor0_Btn.BackColor;
            buttonInput.CustomSpicyNoneStateColors[1] = spicyLips.customSpicy_NoneColor1_Btn.BackColor;

            buttonInput.CustomSpicyOverStateColors[0] = spicyLips.customSpicy_HoverColor0_Btn.BackColor;
            buttonInput.CustomSpicyOverStateColors[1] = spicyLips.customSpicy_HoverColor1_Btn.BackColor;

            buttonInput.CustomSpicyDownStateColors[0] = spicyLips.customSpicy_PressedColor0_Btn.BackColor;
            buttonInput.CustomSpicyDownStateColors[1] = spicyLips.customSpicy_PressedColor1_Btn.BackColor;

            buttonInput.CustomSpicyBorderColors[0] = spicyLips.customSpicy_BorderColor0_Btn.BackColor;
            buttonInput.CustomSpicyBorderColors[1] = spicyLips.customSpicy_BorderColor1_Btn.BackColor;

            buttonInput.CustomSpicyBackground = spicyLips.customSpicy_Background_Btn.BackColor;

            buttonInput.CustomSpicyCornerColor = spicyLips.customSpicy_Corner_Btn.BackColor;
            buttonInput.CustomSpicyHighlight = spicyLips.customSpicy_Highlight_Btn.BackColor;

        }

        private void ZeusInitialValues(ButtonInput buttonInput)
        {
            zeus.customZeus_ClickReduce_Numeric.Value = buttonInput.CustomZeusClickReduce;
            zeus.customZeus_ClickLocate_Numeric.Value = buttonInput.CustomZeusClickLocate;

            zeus.customZeus_Background_Btn.BackColor = buttonInput.CustomZeusBackground;

            zeus.customZeus_GradientColors0_Btn.BackColor = buttonInput.CustomZeusGradientColors[0];
            zeus.customZeus_GradientColors1_Btn.BackColor = buttonInput.CustomZeusGradientColors[1];

            zeus.customZeus_BorderColors0_Btn.BackColor = buttonInput.CustomZeusBorderColors[0];
            zeus.customZeus_BorderColors1_Btn.BackColor = buttonInput.CustomZeusBorderColors[1];



            zeus.previewBtn.CustomZeusClickReduce = buttonInput.CustomZeusClickReduce;
            zeus.previewBtn.CustomZeusClickLocate = buttonInput.CustomZeusClickLocate;

            zeus.previewBtn.CustomZeusBackground = buttonInput.CustomZeusBackground;

            zeus.previewBtn.CustomZeusGradientColors[0] = buttonInput.CustomZeusGradientColors[0];
            zeus.previewBtn.CustomZeusGradientColors[1] = buttonInput.CustomZeusGradientColors[1];

            zeus.previewBtn.CustomZeusBorderColors[0] = buttonInput.CustomZeusBorderColors[0];
            zeus.previewBtn.CustomZeusBorderColors[1] = buttonInput.CustomZeusBorderColors[1];


        }

        private void ZeusSubmitValues(ButtonInput buttonInput)
        {
            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomZeusClickReduce = (int)zeus.customZeus_ClickReduce_Numeric.Value;
            buttonInput.CustomZeusClickLocate = (int)zeus.customZeus_ClickLocate_Numeric.Value;

            buttonInput.CustomZeusBackground = zeus.customZeus_Background_Btn.BackColor;

            buttonInput.CustomZeusGradientColors[0] = zeus.customZeus_GradientColors0_Btn.BackColor;
            buttonInput.CustomZeusGradientColors[1] = zeus.customZeus_GradientColors1_Btn.BackColor;

            buttonInput.CustomZeusBorderColors[0] = zeus.customZeus_BorderColors0_Btn.BackColor;
            buttonInput.CustomZeusBorderColors[1] = zeus.customZeus_BorderColors1_Btn.BackColor;

        }

        private void RoasterInitialValues(ButtonInput buttonInput)
        {
            roaster.customRoaster_BorderColor_Btn.BackColor = buttonInput.CustomRoasterBorderColor;

            roaster.customRoaster_GradientColors0_Btn.BackColor = buttonInput.CustomRoasterGradientColors[0];
            roaster.customRoaster_GradientColors1_Btn.BackColor = buttonInput.CustomRoasterGradientColors[1];
            roaster.customRoaster_GradientColors2_Btn.BackColor = buttonInput.CustomRoasterGradientColors[2];
            roaster.customRoaster_GradientColors3_Btn.BackColor = buttonInput.CustomRoasterGradientColors[3];

            roaster.customRoaster_BackgroundStateColors0_Btn.BackColor =
                buttonInput.CustomRoasterBackgroundStateColors[0];

            roaster.customRoaster_BackgroundStateColors1_Btn.BackColor =
                buttonInput.CustomRoasterBackgroundStateColors[1];
        }

        private void RoasterSubmitValues(ButtonInput buttonInput)
        {

            #region Main Submit

            buttonInput.CustomizableStyle =
                (CustomizableStyles)Enum.Parse(typeof
                        (CustomizableStyles),
                    mainControl_ButtonType_ComboBox.SelectedItem.ToString());

            buttonInput.DrawMode =
                (ButtonThematic.RenderMode)Enum.Parse(typeof
                        (ButtonThematic.RenderMode),
                    mainControl_RenderMode_ComboBox.SelectedItem.ToString());

            buttonInput.GradientMode =
                (LinearGradientMode)Enum.Parse(typeof
                        (LinearGradientMode),
                    mainControl_GradientMode_ComboBox.SelectedItem.ToString());

            buttonInput.HatchStyle = mainControl_HatchStyle_ComboBox.SelectedHatchStyle;

            buttonInput.Curve = (int)mainControl_Curve_Numeric.Value;

            #endregion

            buttonInput.CustomRoasterBorderColor = roaster.customRoaster_BorderColor_Btn.BackColor;

            buttonInput.CustomRoasterGradientColors[0] = roaster.customRoaster_GradientColors0_Btn.BackColor;
            buttonInput.CustomRoasterGradientColors[1] = roaster.customRoaster_GradientColors1_Btn.BackColor;
            buttonInput.CustomRoasterGradientColors[2] = roaster.customRoaster_GradientColors2_Btn.BackColor;
            buttonInput.CustomRoasterGradientColors[3] = roaster.customRoaster_GradientColors3_Btn.BackColor;
            
            buttonInput.CustomRoasterBackgroundStateColors[0] = roaster.customRoaster_BackgroundStateColors0_Btn.BackColor;
            buttonInput.CustomRoasterBackgroundStateColors[1] = roaster.customRoaster_BackgroundStateColors1_Btn.BackColor;

        }


        #endregion

        #region Add User Controls to Form

        private void AddControls()
        {
            //backgroundTheme.Controls.Add(adobe);
            //backgroundTheme.Controls.Add(advancedSystem);
            //backgroundTheme.Controls.Add(advantium);
            //backgroundTheme.Controls.Add(aresio);
            //backgroundTheme.Controls.Add(basic);
            //backgroundTheme.Controls.Add(bitDefender);
            //backgroundTheme.Controls.Add(blackShades);
            //backgroundTheme.Controls.Add(booster);
            //backgroundTheme.Controls.Add(classic);
            //backgroundTheme.Controls.Add(deumos);
            //backgroundTheme.Controls.Add(excision);
            //backgroundTheme.Controls.Add(future);
            //backgroundTheme.Controls.Add(gameBooster);
            //backgroundTheme.Controls.Add(intel);
            //backgroundTheme.Controls.Add(mizer);
            //backgroundTheme.Controls.Add(nameless);
            //backgroundTheme.Controls.Add(netSeal);
            //backgroundTheme.Controls.Add(orains);
            //backgroundTheme.Controls.Add(recon);
            //backgroundTheme.Controls.Add(roaster);
            //backgroundTheme.Controls.Add(spicyLips);
            //backgroundTheme.Controls.Add(zeus);

            adobe.Visible = false;
            advancedSystem.Visible = false;
            advantium.Visible = false;
            basic.Visible = false;
            bitDefender.Visible = false;
            blackShades.Visible = false;
            booster.Visible = false;
            classic.Visible = false;
            deumos.Visible = false;
            excision.Visible = false;
            future.Visible = false;
            gameBooster.Visible = false;
            intel.Visible = false;
            mizer.Visible = false;
            nameless.Visible = false;
            netSeal.Visible = false;
            orains.Visible = false;
            recon.Visible = false;
            roaster.Visible = false;
            spicyLips.Visible = false;
            zeus.Visible = false;

            //adobe.Location = new Point(300, 50);
            //advancedSystem.Location = new Point(300, 50);
            //advantium.Location = new Point(300, 50);
            //basic.Location = new Point(300, 50);
            //bitDefender.Location = new Point(300, 50);
            //blackShades.Location = new Point(300, 50);
            //booster.Location = new Point(300, 50);
            //classic.Location = new Point(300, 50);
            //deumos.Location = new Point(300, 50);
            //excision.Location = new Point(300, 50);
            //future.Location = new Point(300, 50);
            //gameBooster.Location = new Point(300, 50);
            //intel.Location = new Point(300, 50);
            //mizer.Location = new Point(300, 50);
            //nameless.Location = new Point(300, 50);
            //netSeal.Location = new Point(300, 50);
            //orains.Location = new Point(300, 50);
            //recon.Location = new Point(300, 50);
            //roaster.Location = new Point(300, 50);
            //spicyLips.Location = new Point(300, 50);
            //zeus.Location = new Point(300, 50);

        }
        
        private void AdobeAdd()
        {
            adobe.Visible = true;
            adobe.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void AdvancedSystemAdd()
        {
            advancedSystem.Visible = true;
            advancedSystem.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(advancedSystem);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void AdvantiumAdd()
        {
            advantium.Visible = true;
            advantium.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(advantium);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void AresioAdd()
        {
            aresio.Visible = true;
            aresio.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(aresio);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void BasicAdd()
        {
            basic.Visible = true;
            basic.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(basic);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void BitDefenderAdd()
        {
            bitDefender.Visible = true;
            bitDefender.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(bitDefender);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void BlackShadesAdd()
        {
            blackShades.Visible = true;
            blackShades.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(blackShades);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void BoosterAdd()
        {
            booster.Visible = true;
            booster.Location = new Point(380, 50);

            backgroundTheme.Controls.Add(booster);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void ClassicAdd()
        {
            classic.Visible = true;
            classic.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(classic);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void DeumosAdd()
        {
            deumos.Visible = true;
            deumos.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(deumos);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void ExcisionAdd()
        {
            excision.Visible = true;
            excision.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(excision);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void FutureAdd()
        {
            future.Visible = true;
            future.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(future);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void GameBoosterAdd()
        {
            gameBooster.Visible = true;
            gameBooster.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(gameBooster);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void IntelAdd()
        {
            intel.Visible = true;
            intel.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(intel);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void MizerAdd()
        {
            mizer.Visible = true;
            mizer.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(mizer);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void NamelessAdd()
        {
            nameless.Visible = true;
            nameless.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(nameless);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void NetSealAdd()
        {
            netSeal.Visible = true;
            netSeal.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(netSeal);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void OrainsAdd()
        {
            orains.Visible = true;
            orains.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(orains);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void ReconAdd()
        {
            recon.Visible = true;
            recon.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(recon);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void RoasterAdd()
        {
            roaster.Visible = true;
            roaster.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(roaster);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(spicyLips);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void SpicyLipsAdd()
        {
            spicyLips.Visible = true;
            spicyLips.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(spicyLips);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(zeus);

        }

        private void ZeusAdd()
        {
            zeus.Visible = true;
            zeus.Location = new Point(300, 50);

            backgroundTheme.Controls.Add(zeus);
            backgroundTheme.Controls.Remove(adobe);
            backgroundTheme.Controls.Remove(advancedSystem);
            backgroundTheme.Controls.Remove(advantium);
            backgroundTheme.Controls.Remove(aresio);
            backgroundTheme.Controls.Remove(basic);
            backgroundTheme.Controls.Remove(bitDefender);
            backgroundTheme.Controls.Remove(blackShades);
            backgroundTheme.Controls.Remove(booster);
            backgroundTheme.Controls.Remove(classic);
            backgroundTheme.Controls.Remove(deumos);
            backgroundTheme.Controls.Remove(excision);
            backgroundTheme.Controls.Remove(future);
            backgroundTheme.Controls.Remove(gameBooster);
            backgroundTheme.Controls.Remove(intel);
            backgroundTheme.Controls.Remove(mizer);
            backgroundTheme.Controls.Remove(nameless);
            backgroundTheme.Controls.Remove(netSeal);
            backgroundTheme.Controls.Remove(orains);
            backgroundTheme.Controls.Remove(recon);
            backgroundTheme.Controls.Remove(roaster);
            backgroundTheme.Controls.Remove(spicyLips);

        }

        #endregion

        #region Close Button
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Red;
            closeBtn.FlatAppearance.BorderSize = 0;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.FlatAppearance.BorderSize = 1;
            closeBtn.BackColor = Color.FromArgb(20, 20, 20);
        } 
        #endregion
        
        private void mainControl_ButtonType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddControls();

            if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                (int)CustomizableStyles.Dobe)
            {
                
                AdobeAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.System)
            {
                AdvancedSystemAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int) CustomizableStyles.Vant)
            {
                AdvantiumAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Resio)
            {
                AresioAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Basic)
            {
                BasicAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Defend)
            {
                BitDefenderAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Shades)
            {
                BlackShadesAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Boost)
            {
                BoosterAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Class)
            {
                ClassicAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Duos)
            {
                DeumosAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Exon)
            {
                ExcisionAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Fute)
            {
                FutureAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Gamer)
            {
                GameBoosterAdd();
            }


            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Intel)
            {
                IntelAdd();
            }


            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Mizer)
            {
                MizerAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Neless)
            {
                NamelessAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Neal)
            {
                NetSealAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Rainy)
            {
                OrainsAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Reon)
            {
                ReconAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Roast)
            {
                RoasterAdd();
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Spice)
            {
                SpicyLipsAdd();
            }

            //else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
            //         (int)CustomizableStyles.Ezus)
            //{
            //    ZeusAdd();
            //}

            else 
            {
                ZeusAdd();
            }


        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                (int)CustomizableStyles.Dobe)
            {

                buttonInput = new ButtonInput(Color.FromArgb(102, 102, 102), 15, 2, new Color[]
                {
                    Color.FromArgb(105, 105, 105),
                    Color.FromArgb(56, 56, 56),
                    Color.FromArgb(73, 73, 73),
                    Color.FromArgb(48, 48, 48),
                    Color.White,
                    Color.Black
                });

                AdobeSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.System)
            {
                
                buttonInput = new ButtonInput(Color.FromArgb(40, 95, 210), 5, Color.FromArgb(25, 25, 25), Color.FromArgb(25, Color.Black));

                AdvancedSystemSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Vant)
            {


                buttonInput = new ButtonInput(
                    Color.FromArgb(40, 40, 40),
                    new Color[] {Color.FromArgb(50, 50, 50), Color.FromArgb(42, 42, 42)},
                    new Color[] {Color.FromArgb(50, 50, 50), Color.FromArgb(42, 42, 42)},
                    new Color[] {Color.FromArgb(42, 42, 42), Color.FromArgb(50, 50, 50)},
                    new Color[]
                    {
                        Color.FromArgb(59, 59, 59), Color.FromArgb(25, 25, 25),
                        Color.FromArgb(35, 35, 35)
                    },
                    new int[] {1, 0, 0});
                
                AdvantiumSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Resio)
            {

                
                buttonInput = new ButtonInput(
                    new Color[] {Color.FromArgb(50,Color.White),
                        Color.FromArgb(150, 100, 70)},
                    new Color[] {Color.FromArgb(250, 200, 70),
                        Color.FromArgb(250, 160, 40)},
                    new Color[] {Color.FromArgb(50, Color.White),
                        Color.Transparent},
                    new Color[] {Color.FromArgb(50, Color.Black),
                        Color.Transparent}
                    );

                AresioSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Basic)
            {
                
                buttonInput = new ButtonInput(
                    new Color[] {Color.FromArgb(255, 55, 55, 55),
                        Color.FromArgb(255, 22, 22, 22),
                        Color.FromArgb(255, 100, 0, 0),
                        Color.FromArgb(255, 60, 0, 0)},
                    new Color[] {Color.FromArgb(255, 60, 0, 0),
                        Color.FromArgb(255, 100, 0, 0)},
                    new Color[] {Color.FromArgb(25, 255, 255, 255),
                        Color.FromArgb(25, 255, 255, 255),
                        Color.FromArgb(25, 255, 255, 255)},
                    new Color[] {Color.Black,
                        Color.Black,
                        Color.Black,
                        Color.Black,
                        Color.Black,
                        Color.Black,
                        Color.Black,
                        Color.Black}, 
                    new Color[] {Color.FromArgb(255, 40, 40, 40),
                        Color.FromArgb(255, 20, 20, 20),
                        Color.FromArgb(13, 255, 255, 255)},3
                );

                BasicSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Defend)
            {

            
                 buttonInput = new ButtonInput(
                     Color.FromArgb(100, 41, 41, 41),
                     Color.White,
                     Color.FromArgb(101, 101, 101),
                     Color.FromArgb(60, 60, 60),
                     Color.FromArgb(28, 28, 28),
                     Color.FromArgb(45, 45, 45),
                     Color.Black,
                     Color.White,5
                     );

                BitDefenderSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Shades)
            {


                buttonInput = new ButtonInput(
                    new Color[]{ Color.FromArgb(32, 36, 38),
                        Color.FromArgb(70, Color.White),
                        Color.Transparent,
                        Color.FromArgb(36, 31, 43),
                        Color.FromArgb(61, 65, 68),
                        Color.FromArgb(99, 103, 105),
                        Color.FromArgb(27, 31, 33)},
                    new Color[]{Color.FromArgb(32, 36, 38),
                        Color.FromArgb(70, Color.White),
                        Color.Transparent,
                        Color.FromArgb(36, 31, 43),
                        Color.FromArgb(61, 65, 68),
                        Color.FromArgb(99, 103, 105),
                        Color.FromArgb(100, 99, 103, 105),
                        Color.FromArgb(27, 31, 33),
                        Color.FromArgb(0, 186, 255)},
                    new Color[] {Color.FromArgb(32, 36, 38),
                        Color.FromArgb(32, 36, 38),
                        Color.FromArgb(57, 57, 57),
                        Color.FromArgb(57, 57, 57),
                        Color.FromArgb(32, 36, 38),
                        Color.FromArgb(57, 57, 57),
                        Color.FromArgb(36, 31, 43),
                        Color.FromArgb(61, 65, 68),
                        Color.FromArgb(27, 31, 33)},5
                );

                BlackShadesSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Boost)
            {

                
                buttonInput = new ButtonInput(
                    new Color[] {Color.FromArgb(22,22,22),
                        Color.FromArgb(95,0,0)},
                    new Color[] {Color.FromArgb(0,0,0),
                        Color.FromArgb(50, 95,0,0)},
                    Color.Black,Color.Black,
                    10,10,10,10,6,270f,50f,false
                    );

                BoosterSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Class)
            {

                buttonInput = new ButtonInput(
                    new Color[] {Color.FromArgb(0, 156, 255),
                        Color.Transparent}, 
                    Color.Black,
                    Color.FromArgb(35, 35, 35),
                    Color.FromArgb(24, 24, 24),
                    Color.Black
                    );

                ClassicSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Duos)
            {

                buttonInput = new ButtonInput(
                    Color.FromArgb(14, 14, 14),
                    Color.FromArgb(16, 16, 16),
                    Color.FromArgb(5, Color.White),
                    new Color[] {Color.FromArgb(62, 62, 62),
                        Color.FromArgb(15, Color.White),
                        Color.Black},
                    new Color[] {Color.FromArgb(14, 14, 14),
                        Color.FromArgb(41, 41, 41)},
                    new Color[] {Color.FromArgb(30, Color.White),
                        Color.FromArgb(5, Color.White)}
                    );

                DeumosSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Exon)
            {

                buttonInput = new ButtonInput(
                    ButtonThematic.CustomExcisionStyles.Default,
                    "/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAIBAQIBAQICAgICAgICAwUDAwMDAwYEBAMFBwYHBwcGBwcICQsJCAgKCAcHCg0KCgsMDAwMBwkODw0MDgsMDAz/2wBDAQICAgMDAwYDAwYMCAcIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAA1AHUDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD8nk3IuWycY6HFDsFIJYHnPTPB9aUAMc4OFxz05oCbmxgKDz1xxQUgYGTJzvYf/qoQkglQwPUnOfaiP94xyOnT34pVjC5ABGDgjPXigaEkZiWVsceopFLeVtXvwBjilRMMTJkdvunmkjAJ68g8Y60CE37woJwMHOTxT45AMEBiMYx26daRgrIPlICt2HShXVUBIy2RyOKBjRG2wFslc8+tGQvHuRzyacRuBIJYevak3/NuJLA8EZ6UCFZCVJYDJ5z/AEpRl4yAAS3f0oPCAlWIznIPWo1I4GCR6E0DFGGfBAyfwxRwCW3AAnIyKdncAcKQvJyfWgox+TIIH48UBYVQhGGVyw6kUU0kEA7ACfVaKBIG7sATkntxQu7gEjJA56/hQoYspGcnjjAFKBlgBwT6CgY7Z935dox1J703c27DZO71pQGXqdzjqDzgU0syoBjHHWgLDlYKQFLIT0GOKbExJJIIJ4pVBJBBI47DH40oO1yWGS2CMc0AGCN43AY496FJZDkgAHjPAo3/ADE4AOc+9NZl6hT9TyaBAc5BKlgPTikXjduJA7jHSiNgzlgRjHGTTtuDkEkk8+lACgFUUqAMjk570nDrk5BBxxSTKyYBACjvTmbeVXDYPH/16AGiUK4Gcgnnnt9KHbYFBBO3npg0uN0hHBKjuMUNhGJBIDde9Axy2vmEjfnaB+tFJGzKSASD3xRQJDWcbyVAGTjHp70oyFVWyB7AGhlBByCCTnnpRtLNgnJPP0oC4MoJKqpUNxQ6HauF5I5HTNJtKIcAkHucE0u0CJQwyT0OKAuIoCttCg7eMZORSgoEA24btzgjrSlcYZQpJ54poyzZBJI4ANADombgkDB6np3ppjzgsTgnGcUofPyg7c5Ht+tIg5AJ68YyKBodEAxJyFAH6004yPmYkHGf/rUqgjcM5J49h1pHKnAIBI7+poEKcBiCBg8ZFNY4PGcD88UrZHAPygjj8KVV5I6Y7ngCgBqDMgzuyOeAc053boMBicj/ADmguwQhiGweM4NL8zEADbg8cUDTGjbyWDEHpzRSuFLYIGR6ciigVwjYvjPIwOvNICGYHBG4kHFFFA0JwzEqNuQf5U8sUUk4ZSenTtRRQJBuEiYAK454pquFQrtyVzz3oooBMCxOAMLkHkdetPiUPKytzlcknk0UUAQl96g4wQaeF+QE9G9PqKKKAYMuVLAkZJp+3MUj5IYn8KKKBoYSWbGcY4HApAxMjAk/KfWiigTY5CyLlTt3UUUUCbP/2Q==",
                    new Color[] {Color.Black,
                        Color.White}
                    );

                ExcisionSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Fute)
            {

                
                buttonInput = new ButtonInput(
                    new Color[] {Color.FromArgb(40, 40, 40),
                        Color.FromArgb(48, 48, 48)},
                    Color.FromArgb(40, 40, 40),
                    Color.Black,
                    Color.FromArgb(24, 24, 24),
                    Color.FromArgb(44, 44, 44),
                    new ColorBlend
                    {
                        Colors = new Color[]
                        {
                            Color.FromArgb(28, 28, 28),
                            Color.FromArgb(32, 32, 32),
                            Color.FromArgb(24, 24, 24),
                        },
                        Positions = new float[] {
                            0f,
                            0.5f,
                            1f
                        }
                    }
                    );

                FutureSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Gamer)
            {

                
                buttonInput = new ButtonInput(
                    Color.FromArgb(55, 55, 55),
                    Color.FromArgb(32, 32, 32),
                    Color.FromArgb(60, 60, 60),
                    Color.FromArgb(37, 37, 37),
                    Color.FromArgb(66, 66, 66),
                    Color.FromArgb(41, 41, 41),
                    Color.FromArgb(51, 51, 51),
                    Color.FromArgb(76, 76, 76),
                    Color.Black,
                    Color.FromArgb(87, 87, 87),
                    Color.Black,
                    Color.FromArgb(71, 71, 71),
                    Color.Black
                    );

                GameBoosterSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Intel)
            {

                
                buttonInput = new ButtonInput(
                    Color.SteelBlue,
                    Color.DeepSkyBlue,
                    Color.Black,
                    180,5
                    );

                IntelSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Mizer)
            {

                
                buttonInput = new ButtonInput(
                    new Color[] {Color.FromArgb(25,25,25),
                        Color.FromArgb(0,0,0)},
                    new Color[] {Color.FromArgb(0,0,0),
                        Color.FromArgb(25,25,25)},
                    new Color[] {Color.FromArgb(60,60,60),
                        Color.FromArgb(100,100,100)},
                    new Color[] {Color.FromArgb(0,0,0),
                        Color.FromArgb(25,25,25)},
                    new Color[] {Color.FromArgb(60, 60, 60),
                        Color.FromArgb(100, 100, 100)},
                    new Color[] {Color.FromArgb(25, 25, 25),
                        Color.FromArgb(60, 60, 60)},
                    new Color[] {Color.FromArgb(10,10,10),
                        Color.FromArgb(100,100,100)},
                    Color.FromArgb(20, 20, 20),3,5
                    );

                CustomizedMizerSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Neless)
            {

                buttonInput = new ButtonInput(
                    new Color[] { Color.FromArgb(50, 50, 50),
                        Color.Black,
                        Color.Black},
                    new Color[] {Color.White,
                        Color.FromArgb(130, 130, 130),
                        Color.FromArgb(40, 40, 40)},
                    new Color[] {Color.White,
                        Color.FromArgb(150, 150, 150),
                        Color.FromArgb(50, 50, 50)},
                    new Color[] {Color.White,
                        Color.FromArgb(60, 60, 60),
                        Color.FromArgb(22, 22, 22)},
                    Color.Black
                    );

                NamelessSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Neal)
            {

                
                buttonInput = new ButtonInput(
                    new Color[] {Color.FromArgb(24, 24, 24),
                        Color.FromArgb(65, 65, 65)},
                    Color.FromArgb(60, 60, 60),
                    Color.FromArgb(55, 55, 55),
                    new PointF(0.8f, 0.5f),5
                    );

                NetSealSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Neal)
            {

                buttonInput = new ButtonInput(
                    Color.FromArgb(40, 40, 40),
                    Color.FromArgb(40, 40, 40),
                    Color.Black,
                    new Color[] {Color.FromArgb(35, 35, 35),
                        Color.FromArgb(20, 20, 20)},
                    new Color[] {Color.Black,
                        Color.Transparent}
                    );

                OrainsSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Reon)
            {
                
                buttonInput = new ButtonInput(
                    Color.FromArgb(49, 49, 49),
                    new Color[] {Color.FromArgb(22, 22, 22),
                        Color.FromArgb(34, 34, 34)},
                    new Color[] {Color.FromArgb(28, 28, 28),
                        Color.FromArgb(38, 38, 38),
                        Color.FromArgb(100, 0, 0, 0),
                        Color.Transparent},
                    new Color[] {Color.FromArgb(28, 28, 28),
                        Color.FromArgb(38, 38, 38),
                        Color.FromArgb(100, 50, 50, 50),
                        Color.Transparent},
                    new Color[] {Color.Black,
                        Color.FromArgb(52, 52, 52)}
                    );

                ReconSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Spice)
            {

                buttonInput = new ButtonInput(
                    Color.FromArgb(1, 1, 1),
                    new Color[] {Color.FromArgb(40, 40, 40),
                        Color.FromArgb(28, 28, 28)},
                    new Color[] {Color.FromArgb(40, 40, 40),
                        Color.FromArgb(28, 28, 28)},
                    new Color[] {Color.FromArgb(4, 4, 4),
                        Color.FromArgb(20, 20, 20)},
                    Color.White,
                    new Color[] {Color.Black,
                        Color.Black},
                    Color.FromArgb(20, 20, 20)

                    );

                SpicyLipsSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Ezus)
            {

                buttonInput = new ButtonInput(
                    Color.FromArgb(38, 38, 38),
                    new Color[] {Color.AliceBlue,
                        Color.FromArgb(150, 255, 255)},
                    new Color[] {Color.Black,
                        Color.AliceBlue},
                    5,2
                    );

                ZeusSubmitValues(buttonInput);
            }

            else if (mainControl_ButtonType_ComboBox.SelectedIndex ==
                     (int)CustomizableStyles.Ezus)
            {

                buttonInput = new ButtonInput(
                    new Color[] {Color.FromArgb(0, 0, 0),
                        Color.FromArgb(95, 0, 0),
                        Color.FromArgb(73, 73, 73),
                        Color.FromArgb(93, 93, 93)},
                    Color.Black,
                    new Color[] {Color.White,
                        Color.Black}
                    );

                RoasterSubmitValues(buttonInput);
            }
            
            DialogResult = DialogResult.OK;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void mainControl_Curve_Numeric_ValueChanged(object sender, EventArgs e)
        {

            int value = (int) mainControl_Curve_Numeric.Value / 4;

            if (value < 1)
            {
                value = 1;
            }
            advancedSystem.previewBtn.CustomizableAdvancedSystemSlope = value;
            advancedSystem.previewBtn.Invalidate();

            aresio.previewBtn.Curve = value;
            aresio.previewBtn.Invalidate();

            bitDefender.previewBtn.Curve = value;
            bitDefender.previewBtn.Invalidate();

            blackShades.previewBtn.Curve = value;
            blackShades.previewBtn.Invalidate();

            mizer.previewBtn.Curve = value;
            mizer.previewBtn.Invalidate();

            netSeal.previewBtn.Curve = value;
            netSeal.previewBtn.Invalidate();

            intel.previewBtn.CustomIntelCurve = value;
            intel.previewBtn.Invalidate();

        }
    }
}
