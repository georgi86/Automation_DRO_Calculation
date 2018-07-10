﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace DRO
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("bfcf6447-ed58-4ed8-a9a8-8386b265be2b", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the DRORepository repository.
        /// </summary>
        public static DRORepository repo = DRORepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ButtonX' at Center.", repo.ButtonXInfo, new RecordItemIndex(0));
            repo.ButtonX.Click();
            Delay.Milliseconds(200);
                                   
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ButtonY' at Center.", repo.ButtonYInfo, new RecordItemIndex(2));
            repo.ButtonY.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ButtonZ' at Center.", repo.ButtonZInfo, new RecordItemIndex(3));
            repo.ButtonZ.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='+0.0000        ') on item 'SnapXUntitled.X_DRO_Value'.", repo.SnapXUntitled.X_DRO_ValueInfo, new RecordItemIndex(4));
                Validate.Attribute(repo.SnapXUntitled.X_DRO_ValueInfo, "WindowText", "+0.0000        ", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='+0.0000        ') on item 'SnapXUntitled.Y_DRO_Value'.", repo.SnapXUntitled.Y_DRO_ValueInfo, new RecordItemIndex(5));
                Validate.Attribute(repo.SnapXUntitled.Y_DRO_ValueInfo, "WindowText", "+0.0000        ", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='+0.0           ') on item 'SnapXUntitled.Z_DRO_Value'.", repo.SnapXUntitled.Z_DRO_ValueInfo, new RecordItemIndex(6));
                Validate.Attribute(repo.SnapXUntitled.Z_DRO_ValueInfo, "WindowText", "+0.0           ", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.MoveStageButton' at Center.", repo.SnapXUntitled.MoveStageButtonInfo, new RecordItemIndex(7));
            repo.SnapXUntitled.MoveStageButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.MoveStageOption.X_Value' at 83;10.", repo.SnapXUntitled.MoveStageOption.X_ValueInfo, new RecordItemIndex(8));
            repo.SnapXUntitled.MoveStageOption.X_Value.DoubleClick("83;10");
            Delay.Milliseconds(200);

            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Keyboard.Press("30");
            Delay.Milliseconds(200);
            
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.MoveStageOption.Y_Value' at 81;10.", repo.SnapXUntitled.MoveStageOption.Y_ValueInfo, new RecordItemIndex(11));
            repo.SnapXUntitled.MoveStageOption.Y_Value.DoubleClick("81;10");
            Delay.Milliseconds(200);

            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Keyboard.Press("15");
            Delay.Milliseconds(200);

            Keyboard.Press("{Return}");
            Delay.Milliseconds(200);
                        
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.MoveStageOption.ButtonGoTo' at 63;10.", repo.SnapXUntitled.MoveStageOption.ButtonGoToInfo, new RecordItemIndex(14));
            repo.SnapXUntitled.MoveStageOption.ButtonGoTo.Click("63;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(15));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.X_DRO_Value' at 95;21.", repo.SnapXUntitled.X_DRO_ValueInfo, new RecordItemIndex(16));
            repo.SnapXUntitled.X_DRO_Value.Click("95;21");
            Delay.Milliseconds(200);

            string Hardcoded_X_Value = "30";
            string Actual_X_Value = repo.SnapXUntitled.X_DRO_Value.TextValue;
            ComparingDROValues.DROValue(Hardcoded_X_Value, Actual_X_Value);
            Delay.Milliseconds(500);

            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Y_DRO_Value' at 85;17.", repo.SnapXUntitled.Y_DRO_ValueInfo, new RecordItemIndex(17));
            repo.SnapXUntitled.Y_DRO_Value.Click("85;17");
            Delay.Milliseconds(200);

            string Hardcoded_Y_Value = "15";
            string Actual_Y_Value = repo.SnapXUntitled.Y_DRO_Value.TextValue;
            ComparingDROValues.DROValue(Hardcoded_Y_Value, Actual_Y_Value);
            Delay.Milliseconds(200);
                                  
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.MoveStageOption.ButtonClose' at 52;9.", repo.SnapXUntitled.MoveStageOption.ButtonCloseInfo, new RecordItemIndex(21));
            repo.SnapXUntitled.MoveStageOption.ButtonClose.Click("52;9");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(18));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(19));
            Keyboard.Press("f");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'n'.", new RecordItemIndex(20));
            Keyboard.Press("n");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.AxisAlignmentButton' at 15;15.", repo.SnapXUntitled.AxisAlignmentButtonInfo, new RecordItemIndex(22));
            repo.SnapXUntitled.AxisAlignmentButton.Click("15;15");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (WindowText='-0.0000        ') on item 'SnapXUntitled.Y_DRO_Value'.", repo.SnapXUntitled.Y_DRO_ValueInfo, new RecordItemIndex(23));
                Validate.Attribute(repo.SnapXUntitled.Y_DRO_ValueInfo, "WindowText", "-0.0000        ", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.AxisAlignmentButton' at Center.", repo.SnapXUntitled.AxisAlignmentButtonInfo, new RecordItemIndex(24));
            repo.SnapXUntitled.AxisAlignmentButton.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot_mm_inch' with region {X=0,Y=0,Width=36,Height=36}) on item 'SnapXUntitled.InchMillimeterButton'.", repo.SnapXUntitled.InchMillimeterButtonInfo, new RecordItemIndex(25));
                Validate.ContainsImage(repo.SnapXUntitled.InchMillimeterButtonInfo, InchMillimeterButton_Screenshot_mm_inch, InchMillimeterButton_Screenshot_mm_inch_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(25)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.InchMillimeterButton' at Center.", repo.SnapXUntitled.InchMillimeterButtonInfo, new RecordItemIndex(26));
            repo.SnapXUntitled.InchMillimeterButton.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'Screenshot_inch_mm' with region {X=0,Y=0,Width=36,Height=36}) on item 'SnapXUntitled.InchMillimeterButton'.", repo.SnapXUntitled.InchMillimeterButtonInfo, new RecordItemIndex(27));
                Validate.ContainsImage(repo.SnapXUntitled.InchMillimeterButtonInfo, InchMillimeterButton_Screenshot_inch_mm, InchMillimeterButton_Screenshot_inch_mm_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.InchMillimeterButton' at Center.", repo.SnapXUntitled.InchMillimeterButtonInfo, new RecordItemIndex(28));
            repo.SnapXUntitled.InchMillimeterButton.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'ScreenshotXY_RA' with region {X=0,Y=0,Width=36,Height=36}) on item 'SnapXUntitled.CartesianPolarButton'.", repo.SnapXUntitled.CartesianPolarButtonInfo, new RecordItemIndex(29));
                Validate.ContainsImage(repo.SnapXUntitled.CartesianPolarButtonInfo, CartesianPolarButton_ScreenshotXY_RA, CartesianPolarButton_ScreenshotXY_RA_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(29)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.CartesianPolarButton' at Center.", repo.SnapXUntitled.CartesianPolarButtonInfo, new RecordItemIndex(30));
            repo.SnapXUntitled.CartesianPolarButton.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'ScreenshotRA_XY' with region {X=0,Y=0,Width=36,Height=36}) on item 'SnapXUntitled.CartesianPolarButton'.", repo.SnapXUntitled.CartesianPolarButtonInfo, new RecordItemIndex(31));
                Validate.ContainsImage(repo.SnapXUntitled.CartesianPolarButtonInfo, CartesianPolarButton_ScreenshotRA_XY, CartesianPolarButton_ScreenshotRA_XY_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(31)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.CartesianPolarButton' at Center.", repo.SnapXUntitled.CartesianPolarButtonInfo, new RecordItemIndex(32));
            repo.SnapXUntitled.CartesianPolarButton.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'ScreenshotAxisOff' with region {X=0,Y=0,Width=36,Height=36}) on item 'SnapXUntitled.AxisAlignmentButton'.", repo.SnapXUntitled.AxisAlignmentButtonInfo, new RecordItemIndex(33));
                Validate.ContainsImage(repo.SnapXUntitled.AxisAlignmentButtonInfo, AxisAlignmentButton_ScreenshotAxisOff, AxisAlignmentButton_ScreenshotAxisOff_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(33)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.AxisAlignmentButton' at Center.", repo.SnapXUntitled.AxisAlignmentButtonInfo, new RecordItemIndex(34));
            repo.SnapXUntitled.AxisAlignmentButton.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating ContainsImage (Screenshot: 'ScreenshotAxisOn' with region {X=0,Y=0,Width=36,Height=36}) on item 'SnapXUntitled.AxisAlignmentButton'.", repo.SnapXUntitled.AxisAlignmentButtonInfo, new RecordItemIndex(35));
                Validate.ContainsImage(repo.SnapXUntitled.AxisAlignmentButtonInfo, AxisAlignmentButton_ScreenshotAxisOn, AxisAlignmentButton_ScreenshotAxisOn_Options, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(35)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.AxisAlignmentButton' at Center.", repo.SnapXUntitled.AxisAlignmentButtonInfo, new RecordItemIndex(36));
            repo.SnapXUntitled.AxisAlignmentButton.Click();
            Delay.Milliseconds(200);


            //////////////////////////////////
            //////////////////////////////////////////////
            ////////////////////////////////////////////////////////////
            //Here we check the value when switching from MM to INCH and from XY to RAZ

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.MoveStageButton' at Center.", repo.SnapXUntitled.MoveStageButtonInfo, new RecordItemIndex(37));
            repo.SnapXUntitled.MoveStageButton.Click();
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.MoveStageOption.X_Value' at 83;10.", repo.SnapXUntitled.MoveStageOption.X_ValueInfo, new RecordItemIndex(38));
            repo.SnapXUntitled.MoveStageOption.X_Value.DoubleClick("83;10");
            Delay.Milliseconds(200);

            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Keyboard.Press("20");
            Delay.Milliseconds(200);

            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'SnapXUntitled.MoveStageOption.Y_Value' at 81;10.", repo.SnapXUntitled.MoveStageOption.Y_ValueInfo, new RecordItemIndex(42));
            repo.SnapXUntitled.MoveStageOption.Y_Value.DoubleClick("81;10");
            Delay.Milliseconds(200);

            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Keyboard.Press("10");
            Delay.Milliseconds(200);

            Keyboard.Press("{Return}");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.MoveStageOption.ButtonGoTo' at 63;10.", repo.SnapXUntitled.MoveStageOption.ButtonGoToInfo, new RecordItemIndex(14));
            repo.SnapXUntitled.MoveStageOption.ButtonGoTo.Click("63;10");
            Delay.Milliseconds(200);
                       
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.InchMillimeterButton' at Center.", repo.SnapXUntitled.InchMillimeterButtonInfo, new RecordItemIndex(26));
            repo.SnapXUntitled.InchMillimeterButton.Click();
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.X_DRO_Value' at 95;21.", repo.SnapXUntitled.X_DRO_ValueInfo, new RecordItemIndex(16));
            repo.SnapXUntitled.X_DRO_Value.Click("95;21");
            Delay.Milliseconds(200);

            string ActualInchValueX = repo.SnapXUntitled.X_DRO_Value.TextValue;
            string HardcodedInchValueX = "0.787";
            ComparingDROValues.DROValueInch(HardcodedInchValueX, ActualInchValueX);
            Delay.Milliseconds(200);           
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Y_DRO_Value' at 85;17.", repo.SnapXUntitled.Y_DRO_ValueInfo, new RecordItemIndex(17));
            repo.SnapXUntitled.Y_DRO_Value.Click("85;17");
            Delay.Milliseconds(200);

            string ActualInchValueY = repo.SnapXUntitled.Y_DRO_Value.TextValue;
            string HardcodedInchValueY = "0.392";
            ComparingDROValues.DROValueInch(HardcodedInchValueY, ActualInchValueY);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.CartesianPolarButton' at Center.", repo.SnapXUntitled.CartesianPolarButtonInfo, new RecordItemIndex(32));
            repo.SnapXUntitled.CartesianPolarButton.Click();
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.X_DRO_Value' at 95;21.", repo.SnapXUntitled.X_DRO_ValueInfo, new RecordItemIndex(16));
            repo.SnapXUntitled.X_DRO_Value.Click("95;21");
            Delay.Milliseconds(200);

            string ActualXValueRAZ = repo.SnapXUntitled.X_DRO_Value.TextValue;
            string HardcodedXValueRAZ = "0.879";
            ComparingDROValues.DROValueInch(HardcodedXValueRAZ, ActualXValueRAZ);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Y_DRO_Value' at 85;17.", repo.SnapXUntitled.Y_DRO_ValueInfo, new RecordItemIndex(17));
            repo.SnapXUntitled.Y_DRO_Value.Click("85;17");
            Delay.Milliseconds(200);

            string ActualYValueRAZ = repo.SnapXUntitled.Y_DRO_Value.TextValue; 
            string HardcodedYValueRAZ = "26.466";
            ComparingDROValues.DROValue(HardcodedYValueRAZ, ActualYValueRAZ);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.InchMillimeterButton' at Center.", repo.SnapXUntitled.InchMillimeterButtonInfo, new RecordItemIndex(26));
            repo.SnapXUntitled.InchMillimeterButton.Click();
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.X_DRO_Value' at 95;21.", repo.SnapXUntitled.X_DRO_ValueInfo, new RecordItemIndex(16));
            repo.SnapXUntitled.X_DRO_Value.Click("95;21");
            Delay.Milliseconds(200);

            string ActualXValueRAZinMM = repo.SnapXUntitled.X_DRO_Value.TextValue;
            string HardcodedXValueRAZinMM = "22.329";
            ComparingDROValues.DROValue(HardcodedXValueRAZinMM, ActualXValueRAZinMM);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Y_DRO_Value' at 85;17.", repo.SnapXUntitled.Y_DRO_ValueInfo, new RecordItemIndex(17));
            repo.SnapXUntitled.Y_DRO_Value.Click("85;17");
            Delay.Milliseconds(200);

            string ActualYValueRAZinMM = repo.SnapXUntitled.Y_DRO_Value.TextValue;
            string HardcodedYValueRAZinMM = "26.468";
            ComparingDROValues.DROValue(HardcodedYValueRAZinMM, ActualYValueRAZinMM);
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.CartesianPolarButton' at Center.", repo.SnapXUntitled.CartesianPolarButtonInfo, new RecordItemIndex(32));
            repo.SnapXUntitled.CartesianPolarButton.Click();
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.MoveStageOption.ButtonClose' at 52;9.", repo.SnapXUntitled.MoveStageOption.ButtonCloseInfo, new RecordItemIndex(21));
            repo.SnapXUntitled.MoveStageOption.ButtonClose.Click("52;9");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(18));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(19));
            Keyboard.Press("f");
            Delay.Milliseconds(0);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'n'.", new RecordItemIndex(20));
            Keyboard.Press("n");
            Delay.Milliseconds(0);









        }

#region Image Feature Data
        CompressedImage InchMillimeterButton_Screenshot_mm_inch
        { get { return repo.SnapXUntitled.InchMillimeterButtonInfo.GetScreenshot_mm_inch(new Rectangle(0, 0, 36, 36)); } }

        Imaging.FindOptions InchMillimeterButton_Screenshot_mm_inch_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage InchMillimeterButton_Screenshot_inch_mm
        { get { return repo.SnapXUntitled.InchMillimeterButtonInfo.GetScreenshot_inch_mm(new Rectangle(0, 0, 36, 36)); } }

        Imaging.FindOptions InchMillimeterButton_Screenshot_inch_mm_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage CartesianPolarButton_ScreenshotXY_RA
        { get { return repo.SnapXUntitled.CartesianPolarButtonInfo.GetScreenshotXY_RA(new Rectangle(0, 0, 36, 36)); } }

        Imaging.FindOptions CartesianPolarButton_ScreenshotXY_RA_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage CartesianPolarButton_ScreenshotRA_XY
        { get { return repo.SnapXUntitled.CartesianPolarButtonInfo.GetScreenshotRA_XY(new Rectangle(0, 0, 36, 36)); } }

        Imaging.FindOptions CartesianPolarButton_ScreenshotRA_XY_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage AxisAlignmentButton_ScreenshotAxisOff
        { get { return repo.SnapXUntitled.AxisAlignmentButtonInfo.GetScreenshotAxisOff(new Rectangle(0, 0, 36, 36)); } }

        Imaging.FindOptions AxisAlignmentButton_ScreenshotAxisOff_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage AxisAlignmentButton_ScreenshotAxisOn
        { get { return repo.SnapXUntitled.AxisAlignmentButtonInfo.GetScreenshotAxisOn(new Rectangle(0, 0, 36, 36)); } }

        Imaging.FindOptions AxisAlignmentButton_ScreenshotAxisOn_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}