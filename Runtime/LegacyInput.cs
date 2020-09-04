using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace NewBlood
{ 
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Consistency")]
    [InputControlLayout(displayName = "Legacy Input", stateType = typeof(LegacyInputState))]
    public class LegacyInput : InputDevice, IInputUpdateCallbackReceiver
    {
        LegacyInputState state;

        Dictionary<KeyCode, ButtonControl> controls;

        public static LegacyInput current { get; private set; }

        public ButtonControl backspaceKey { get; private set; }

        public ButtonControl tabKey { get; private set; }

        public ButtonControl clearKey { get; private set; }

        public ButtonControl returnKey { get; private set; }

        public ButtonControl pauseKey { get; private set; }

        public ButtonControl escapeKey { get; private set; }

        public ButtonControl spaceKey { get; private set; }

        public ButtonControl exclaimKey { get; private set; }

        public ButtonControl doubleQuoteKey { get; private set; }

        public ButtonControl hashKey { get; private set; }

        public ButtonControl dollarKey { get; private set; }

        public ButtonControl percentKey { get; private set; }

        public ButtonControl ampersandKey { get; private set; }

        public ButtonControl quoteKey { get; private set; }

        public ButtonControl leftParenKey { get; private set; }

        public ButtonControl rightParenKey { get; private set; }

        public ButtonControl asteriskKey { get; private set; }

        public ButtonControl plusKey { get; private set; }

        public ButtonControl commaKey { get; private set; }

        public ButtonControl minusKey { get; private set; }

        public ButtonControl periodKey { get; private set; }

        public ButtonControl slashKey { get; private set; }

        public ButtonControl alpha0Key { get; private set; }

        public ButtonControl alpha1Key { get; private set; }

        public ButtonControl alpha2Key { get; private set; }

        public ButtonControl alpha3Key { get; private set; }

        public ButtonControl alpha4Key { get; private set; }

        public ButtonControl alpha5Key { get; private set; }

        public ButtonControl alpha6Key { get; private set; }

        public ButtonControl alpha7Key { get; private set; }

        public ButtonControl alpha8Key { get; private set; }

        public ButtonControl alpha9Key { get; private set; }

        public ButtonControl colonKey { get; private set; }

        public ButtonControl semicolonKey { get; private set; }

        public ButtonControl lessKey { get; private set; }

        public ButtonControl equalsKey { get; private set; }

        public ButtonControl greaterKey { get; private set; }

        public ButtonControl questionKey { get; private set; }

        public ButtonControl atKey { get; private set; }

        public ButtonControl leftBracketKey { get; private set; }

        public ButtonControl backslashKey { get; private set; }

        public ButtonControl rightBracketKey { get; private set; }

        public ButtonControl caretKey { get; private set; }

        public ButtonControl underscoreKey { get; private set; }

        public ButtonControl backQuoteKey { get; private set; }

        public ButtonControl aKey { get; private set; }

        public ButtonControl bKey { get; private set; }

        public ButtonControl cKey { get; private set; }

        public ButtonControl dKey { get; private set; }

        public ButtonControl eKey { get; private set; }

        public ButtonControl fKey { get; private set; }

        public ButtonControl gKey { get; private set; }

        public ButtonControl hKey { get; private set; }

        public ButtonControl iKey { get; private set; }

        public ButtonControl jKey { get; private set; }

        public ButtonControl kKey { get; private set; }

        public ButtonControl lKey { get; private set; }

        public ButtonControl mKey { get; private set; }

        public ButtonControl nKey { get; private set; }

        public ButtonControl oKey { get; private set; }

        public ButtonControl pKey { get; private set; }

        public ButtonControl qKey { get; private set; }

        public ButtonControl rKey { get; private set; }

        public ButtonControl sKey { get; private set; }

        public ButtonControl tKey { get; private set; }

        public ButtonControl uKey { get; private set; }

        public ButtonControl vKey { get; private set; }

        public ButtonControl wKey { get; private set; }

        public ButtonControl xKey { get; private set; }

        public ButtonControl yKey { get; private set; }

        public ButtonControl zKey { get; private set; }

        public ButtonControl leftCurlyBracketKey { get; private set; }

        public ButtonControl pipeKey { get; private set; }

        public ButtonControl rightCurlyBracketKey { get; private set; }

        public ButtonControl tildeKey { get; private set; }

        public ButtonControl deleteKey { get; private set; }

        public ButtonControl keypad0Key { get; private set; }

        public ButtonControl keypad1Key { get; private set; }

        public ButtonControl keypad2Key { get; private set; }

        public ButtonControl keypad3Key { get; private set; }

        public ButtonControl keypad4Key { get; private set; }

        public ButtonControl keypad5Key { get; private set; }

        public ButtonControl keypad6Key { get; private set; }

        public ButtonControl keypad7Key { get; private set; }

        public ButtonControl keypad8Key { get; private set; }

        public ButtonControl keypad9Key { get; private set; }

        public ButtonControl keypadPeriodKey { get; private set; }

        public ButtonControl keypadDivideKey { get; private set; }

        public ButtonControl keypadMultiplyKey { get; private set; }

        public ButtonControl keypadMinusKey { get; private set; }

        public ButtonControl keypadPlusKey { get; private set; }

        public ButtonControl keypadEnterKey { get; private set; }

        public ButtonControl keypadEqualsKey { get; private set; }

        public ButtonControl upArrowKey { get; private set; }

        public ButtonControl downArrowKey { get; private set; }

        public ButtonControl rightArrowKey { get; private set; }

        public ButtonControl leftArrowKey { get; private set; }

        public ButtonControl insertKey { get; private set; }

        public ButtonControl homeKey { get; private set; }

        public ButtonControl endKey { get; private set; }

        public ButtonControl pageUpKey { get; private set; }

        public ButtonControl pageDownKey { get; private set; }

        public ButtonControl f1Key { get; private set; }

        public ButtonControl f2Key { get; private set; }

        public ButtonControl f3Key { get; private set; }

        public ButtonControl f4Key { get; private set; }

        public ButtonControl f5Key { get; private set; }

        public ButtonControl f6Key { get; private set; }

        public ButtonControl f7Key { get; private set; }

        public ButtonControl f8Key { get; private set; }

        public ButtonControl f9Key { get; private set; }

        public ButtonControl f10Key { get; private set; }

        public ButtonControl f11Key { get; private set; }

        public ButtonControl f12Key { get; private set; }

        public ButtonControl f13Key { get; private set; }

        public ButtonControl f14Key { get; private set; }

        public ButtonControl f15Key { get; private set; }

        public ButtonControl numlockKey { get; private set; }

        public ButtonControl capsLockKey { get; private set; }

        public ButtonControl scrollLockKey { get; private set; }

        public ButtonControl rightShiftKey { get; private set; }

        public ButtonControl leftShiftKey { get; private set; }

        public ButtonControl rightControlKey { get; private set; }

        public ButtonControl leftControlKey { get; private set; }

        public ButtonControl rightAltKey { get; private set; }

        public ButtonControl leftAltKey { get; private set; }

        public ButtonControl rightCommandKey { get; private set; }

        public ButtonControl leftCommandKey { get; private set; }

        public ButtonControl leftWindowsKey { get; private set; }

        public ButtonControl rightWindowsKey { get; private set; }

        public ButtonControl altGrKey { get; private set; }

        public ButtonControl helpKey { get; private set; }

        public ButtonControl printKey { get; private set; }

        public ButtonControl sysReqKey { get; private set; }

        public ButtonControl breakKey { get; private set; }

        public ButtonControl menuKey { get; private set; }

        public ButtonControl mouse0Button { get; private set; }

        public ButtonControl mouse1Button { get; private set; }

        public ButtonControl mouse2Button { get; private set; }

        public ButtonControl mouse3Button { get; private set; }

        public ButtonControl mouse4Button { get; private set; }

        public ButtonControl mouse5Button { get; private set; }

        public ButtonControl mouse6Button { get; private set; }

        public ButtonControl joystickButton0 { get; private set; }

        public ButtonControl joystickButton1 { get; private set; }

        public ButtonControl joystickButton2 { get; private set; }

        public ButtonControl joystickButton3 { get; private set; }

        public ButtonControl joystickButton4 { get; private set; }

        public ButtonControl joystickButton5 { get; private set; }

        public ButtonControl joystickButton6 { get; private set; }

        public ButtonControl joystickButton7 { get; private set; }

        public ButtonControl joystickButton8 { get; private set; }

        public ButtonControl joystickButton9 { get; private set; }

        public ButtonControl joystickButton10 { get; private set; }

        public ButtonControl joystickButton11 { get; private set; }

        public ButtonControl joystickButton12 { get; private set; }

        public ButtonControl joystickButton13 { get; private set; }

        public ButtonControl joystickButton14 { get; private set; }

        public ButtonControl joystickButton15 { get; private set; }

        public ButtonControl joystickButton16 { get; private set; }

        public ButtonControl joystickButton17 { get; private set; }

        public ButtonControl joystickButton18 { get; private set; }

        public ButtonControl joystickButton19 { get; private set; }

        public ButtonControl joystick1Button0 { get; private set; }

        public ButtonControl joystick1Button1 { get; private set; }

        public ButtonControl joystick1Button2 { get; private set; }

        public ButtonControl joystick1Button3 { get; private set; }

        public ButtonControl joystick1Button4 { get; private set; }

        public ButtonControl joystick1Button5 { get; private set; }

        public ButtonControl joystick1Button6 { get; private set; }

        public ButtonControl joystick1Button7 { get; private set; }

        public ButtonControl joystick1Button8 { get; private set; }

        public ButtonControl joystick1Button9 { get; private set; }

        public ButtonControl joystick1Button10 { get; private set; }

        public ButtonControl joystick1Button11 { get; private set; }

        public ButtonControl joystick1Button12 { get; private set; }

        public ButtonControl joystick1Button13 { get; private set; }

        public ButtonControl joystick1Button14 { get; private set; }

        public ButtonControl joystick1Button15 { get; private set; }

        public ButtonControl joystick1Button16 { get; private set; }

        public ButtonControl joystick1Button17 { get; private set; }

        public ButtonControl joystick1Button18 { get; private set; }

        public ButtonControl joystick1Button19 { get; private set; }

        public ButtonControl joystick2Button0 { get; private set; }

        public ButtonControl joystick2Button1 { get; private set; }

        public ButtonControl joystick2Button2 { get; private set; }

        public ButtonControl joystick2Button3 { get; private set; }

        public ButtonControl joystick2Button4 { get; private set; }

        public ButtonControl joystick2Button5 { get; private set; }

        public ButtonControl joystick2Button6 { get; private set; }

        public ButtonControl joystick2Button7 { get; private set; }

        public ButtonControl joystick2Button8 { get; private set; }

        public ButtonControl joystick2Button9 { get; private set; }

        public ButtonControl joystick2Button10 { get; private set; }

        public ButtonControl joystick2Button11 { get; private set; }

        public ButtonControl joystick2Button12 { get; private set; }

        public ButtonControl joystick2Button13 { get; private set; }

        public ButtonControl joystick2Button14 { get; private set; }

        public ButtonControl joystick2Button15 { get; private set; }

        public ButtonControl joystick2Button16 { get; private set; }

        public ButtonControl joystick2Button17 { get; private set; }

        public ButtonControl joystick2Button18 { get; private set; }

        public ButtonControl joystick2Button19 { get; private set; }

        public ButtonControl joystick3Button0 { get; private set; }

        public ButtonControl joystick3Button1 { get; private set; }

        public ButtonControl joystick3Button2 { get; private set; }

        public ButtonControl joystick3Button3 { get; private set; }

        public ButtonControl joystick3Button4 { get; private set; }

        public ButtonControl joystick3Button5 { get; private set; }

        public ButtonControl joystick3Button6 { get; private set; }

        public ButtonControl joystick3Button7 { get; private set; }

        public ButtonControl joystick3Button8 { get; private set; }

        public ButtonControl joystick3Button9 { get; private set; }

        public ButtonControl joystick3Button10 { get; private set; }

        public ButtonControl joystick3Button11 { get; private set; }

        public ButtonControl joystick3Button12 { get; private set; }

        public ButtonControl joystick3Button13 { get; private set; }

        public ButtonControl joystick3Button14 { get; private set; }

        public ButtonControl joystick3Button15 { get; private set; }

        public ButtonControl joystick3Button16 { get; private set; }

        public ButtonControl joystick3Button17 { get; private set; }

        public ButtonControl joystick3Button18 { get; private set; }

        public ButtonControl joystick3Button19 { get; private set; }

        public ButtonControl joystick4Button0 { get; private set; }

        public ButtonControl joystick4Button1 { get; private set; }

        public ButtonControl joystick4Button2 { get; private set; }

        public ButtonControl joystick4Button3 { get; private set; }

        public ButtonControl joystick4Button4 { get; private set; }

        public ButtonControl joystick4Button5 { get; private set; }

        public ButtonControl joystick4Button6 { get; private set; }

        public ButtonControl joystick4Button7 { get; private set; }

        public ButtonControl joystick4Button8 { get; private set; }

        public ButtonControl joystick4Button9 { get; private set; }

        public ButtonControl joystick4Button10 { get; private set; }

        public ButtonControl joystick4Button11 { get; private set; }

        public ButtonControl joystick4Button12 { get; private set; }

        public ButtonControl joystick4Button13 { get; private set; }

        public ButtonControl joystick4Button14 { get; private set; }

        public ButtonControl joystick4Button15 { get; private set; }

        public ButtonControl joystick4Button16 { get; private set; }

        public ButtonControl joystick4Button17 { get; private set; }

        public ButtonControl joystick4Button18 { get; private set; }

        public ButtonControl joystick4Button19 { get; private set; }

        public ButtonControl joystick5Button0 { get; private set; }

        public ButtonControl joystick5Button1 { get; private set; }

        public ButtonControl joystick5Button2 { get; private set; }

        public ButtonControl joystick5Button3 { get; private set; }

        public ButtonControl joystick5Button4 { get; private set; }

        public ButtonControl joystick5Button5 { get; private set; }

        public ButtonControl joystick5Button6 { get; private set; }

        public ButtonControl joystick5Button7 { get; private set; }

        public ButtonControl joystick5Button8 { get; private set; }

        public ButtonControl joystick5Button9 { get; private set; }

        public ButtonControl joystick5Button10 { get; private set; }

        public ButtonControl joystick5Button11 { get; private set; }

        public ButtonControl joystick5Button12 { get; private set; }

        public ButtonControl joystick5Button13 { get; private set; }

        public ButtonControl joystick5Button14 { get; private set; }

        public ButtonControl joystick5Button15 { get; private set; }

        public ButtonControl joystick5Button16 { get; private set; }

        public ButtonControl joystick5Button17 { get; private set; }

        public ButtonControl joystick5Button18 { get; private set; }

        public ButtonControl joystick5Button19 { get; private set; }

        public ButtonControl joystick6Button0 { get; private set; }

        public ButtonControl joystick6Button1 { get; private set; }

        public ButtonControl joystick6Button2 { get; private set; }

        public ButtonControl joystick6Button3 { get; private set; }

        public ButtonControl joystick6Button4 { get; private set; }

        public ButtonControl joystick6Button5 { get; private set; }

        public ButtonControl joystick6Button6 { get; private set; }

        public ButtonControl joystick6Button7 { get; private set; }

        public ButtonControl joystick6Button8 { get; private set; }

        public ButtonControl joystick6Button9 { get; private set; }

        public ButtonControl joystick6Button10 { get; private set; }

        public ButtonControl joystick6Button11 { get; private set; }

        public ButtonControl joystick6Button12 { get; private set; }

        public ButtonControl joystick6Button13 { get; private set; }

        public ButtonControl joystick6Button14 { get; private set; }

        public ButtonControl joystick6Button15 { get; private set; }

        public ButtonControl joystick6Button16 { get; private set; }

        public ButtonControl joystick6Button17 { get; private set; }

        public ButtonControl joystick6Button18 { get; private set; }

        public ButtonControl joystick6Button19 { get; private set; }

        public ButtonControl joystick7Button0 { get; private set; }

        public ButtonControl joystick7Button1 { get; private set; }

        public ButtonControl joystick7Button2 { get; private set; }

        public ButtonControl joystick7Button3 { get; private set; }

        public ButtonControl joystick7Button4 { get; private set; }

        public ButtonControl joystick7Button5 { get; private set; }

        public ButtonControl joystick7Button6 { get; private set; }

        public ButtonControl joystick7Button7 { get; private set; }

        public ButtonControl joystick7Button8 { get; private set; }

        public ButtonControl joystick7Button9 { get; private set; }

        public ButtonControl joystick7Button10 { get; private set; }

        public ButtonControl joystick7Button11 { get; private set; }

        public ButtonControl joystick7Button12 { get; private set; }

        public ButtonControl joystick7Button13 { get; private set; }

        public ButtonControl joystick7Button14 { get; private set; }

        public ButtonControl joystick7Button15 { get; private set; }

        public ButtonControl joystick7Button16 { get; private set; }

        public ButtonControl joystick7Button17 { get; private set; }

        public ButtonControl joystick7Button18 { get; private set; }

        public ButtonControl joystick7Button19 { get; private set; }

        public ButtonControl joystick8Button0 { get; private set; }

        public ButtonControl joystick8Button1 { get; private set; }

        public ButtonControl joystick8Button2 { get; private set; }

        public ButtonControl joystick8Button3 { get; private set; }

        public ButtonControl joystick8Button4 { get; private set; }

        public ButtonControl joystick8Button5 { get; private set; }

        public ButtonControl joystick8Button6 { get; private set; }

        public ButtonControl joystick8Button7 { get; private set; }

        public ButtonControl joystick8Button8 { get; private set; }

        public ButtonControl joystick8Button9 { get; private set; }

        public ButtonControl joystick8Button10 { get; private set; }

        public ButtonControl joystick8Button11 { get; private set; }

        public ButtonControl joystick8Button12 { get; private set; }

        public ButtonControl joystick8Button13 { get; private set; }

        public ButtonControl joystick8Button14 { get; private set; }

        public ButtonControl joystick8Button15 { get; private set; }

        public ButtonControl joystick8Button16 { get; private set; }

        public ButtonControl joystick8Button17 { get; private set; }

        public ButtonControl joystick8Button18 { get; private set; }

        public ButtonControl joystick8Button19 { get; private set; }

        public bool TryGetButton(KeyCode key, out ButtonControl button)
        {
            return controls.TryGetValue(key, out button);
        }

        public ButtonControl GetButton(KeyCode key)
        {
            return TryGetButton(key, out ButtonControl button) ? button : null;
        }

        public void OnUpdate()
        {
            state.Update();
            InputSystem.QueueStateEvent(this, state);
        }

        public override void MakeCurrent()
        {
            base.MakeCurrent();
            current = this;
        }

        protected override void FinishSetup()
        {
            base.FinishSetup();
            controls = new Dictionary<KeyCode, ButtonControl>
            {
                { KeyCode.Backspace, backspaceKey = GetChildControl<ButtonControl>("backspace") },
                { KeyCode.Tab, tabKey = GetChildControl<ButtonControl>("tab") },
                { KeyCode.Clear, clearKey = GetChildControl<ButtonControl>("clear") },
                { KeyCode.Return, returnKey = GetChildControl<ButtonControl>("return") },
                { KeyCode.Pause, pauseKey = GetChildControl<ButtonControl>("pause") },
                { KeyCode.Escape, escapeKey = GetChildControl<ButtonControl>("escape") },
                { KeyCode.Space, spaceKey = GetChildControl<ButtonControl>("space") },
                { KeyCode.Exclaim, exclaimKey = GetChildControl<ButtonControl>("exclaim") },
                { KeyCode.DoubleQuote, doubleQuoteKey = GetChildControl<ButtonControl>("doubleQuote") },
                { KeyCode.Hash, hashKey = GetChildControl<ButtonControl>("hash") },
                { KeyCode.Dollar, dollarKey = GetChildControl<ButtonControl>("dollar") },
                { KeyCode.Percent, percentKey = GetChildControl<ButtonControl>("percent") },
                { KeyCode.Ampersand, ampersandKey = GetChildControl<ButtonControl>("ampersand") },
                { KeyCode.Quote, quoteKey = GetChildControl<ButtonControl>("quote") },
                { KeyCode.LeftParen, leftParenKey = GetChildControl<ButtonControl>("leftParen") },
                { KeyCode.RightParen, rightParenKey = GetChildControl<ButtonControl>("rightParen") },
                { KeyCode.Asterisk, asteriskKey = GetChildControl<ButtonControl>("asterisk") },
                { KeyCode.Plus, plusKey = GetChildControl<ButtonControl>("plus") },
                { KeyCode.Comma, commaKey = GetChildControl<ButtonControl>("comma") },
                { KeyCode.Minus, minusKey = GetChildControl<ButtonControl>("minus") },
                { KeyCode.Period, periodKey = GetChildControl<ButtonControl>("period") },
                { KeyCode.Slash, slashKey = GetChildControl<ButtonControl>("slash") },
                { KeyCode.Alpha0, alpha0Key = GetChildControl<ButtonControl>("alpha0") },
                { KeyCode.Alpha1, alpha1Key = GetChildControl<ButtonControl>("alpha1") },
                { KeyCode.Alpha2, alpha2Key = GetChildControl<ButtonControl>("alpha2") },
                { KeyCode.Alpha3, alpha3Key = GetChildControl<ButtonControl>("alpha3") },
                { KeyCode.Alpha4, alpha4Key = GetChildControl<ButtonControl>("alpha4") },
                { KeyCode.Alpha5, alpha5Key = GetChildControl<ButtonControl>("alpha5") },
                { KeyCode.Alpha6, alpha6Key = GetChildControl<ButtonControl>("alpha6") },
                { KeyCode.Alpha7, alpha7Key = GetChildControl<ButtonControl>("alpha7") },
                { KeyCode.Alpha8, alpha8Key = GetChildControl<ButtonControl>("alpha8") },
                { KeyCode.Alpha9, alpha9Key = GetChildControl<ButtonControl>("alpha9") },
                { KeyCode.Colon, colonKey = GetChildControl<ButtonControl>("colon") },
                { KeyCode.Semicolon, semicolonKey = GetChildControl<ButtonControl>("semicolon") },
                { KeyCode.Less, lessKey = GetChildControl<ButtonControl>("less") },
                { KeyCode.Equals, equalsKey = GetChildControl<ButtonControl>("equals") },
                { KeyCode.Greater, greaterKey = GetChildControl<ButtonControl>("greater") },
                { KeyCode.Question, questionKey = GetChildControl<ButtonControl>("question") },
                { KeyCode.At, atKey = GetChildControl<ButtonControl>("at") },
                { KeyCode.LeftBracket, leftBracketKey = GetChildControl<ButtonControl>("leftBracket") },
                { KeyCode.Backslash, backslashKey = GetChildControl<ButtonControl>("backslash") },
                { KeyCode.RightBracket, rightBracketKey = GetChildControl<ButtonControl>("rightBracket") },
                { KeyCode.Caret, caretKey = GetChildControl<ButtonControl>("caret") },
                { KeyCode.Underscore, underscoreKey = GetChildControl<ButtonControl>("underscore") },
                { KeyCode.BackQuote, backQuoteKey = GetChildControl<ButtonControl>("backQuote") },
                { KeyCode.A, aKey = GetChildControl<ButtonControl>("a") },
                { KeyCode.B, bKey = GetChildControl<ButtonControl>("b") },
                { KeyCode.C, cKey = GetChildControl<ButtonControl>("c") },
                { KeyCode.D, dKey = GetChildControl<ButtonControl>("d") },
                { KeyCode.E, eKey = GetChildControl<ButtonControl>("e") },
                { KeyCode.F, fKey = GetChildControl<ButtonControl>("f") },
                { KeyCode.G, gKey = GetChildControl<ButtonControl>("g") },
                { KeyCode.H, hKey = GetChildControl<ButtonControl>("h") },
                { KeyCode.I, iKey = GetChildControl<ButtonControl>("i") },
                { KeyCode.J, jKey = GetChildControl<ButtonControl>("j") },
                { KeyCode.K, kKey = GetChildControl<ButtonControl>("k") },
                { KeyCode.L, lKey = GetChildControl<ButtonControl>("l") },
                { KeyCode.M, mKey = GetChildControl<ButtonControl>("m") },
                { KeyCode.N, nKey = GetChildControl<ButtonControl>("n") },
                { KeyCode.O, oKey = GetChildControl<ButtonControl>("o") },
                { KeyCode.P, pKey = GetChildControl<ButtonControl>("p") },
                { KeyCode.Q, qKey = GetChildControl<ButtonControl>("q") },
                { KeyCode.R, rKey = GetChildControl<ButtonControl>("r") },
                { KeyCode.S, sKey = GetChildControl<ButtonControl>("s") },
                { KeyCode.T, tKey = GetChildControl<ButtonControl>("t") },
                { KeyCode.U, uKey = GetChildControl<ButtonControl>("u") },
                { KeyCode.V, vKey = GetChildControl<ButtonControl>("v") },
                { KeyCode.W, wKey = GetChildControl<ButtonControl>("w") },
                { KeyCode.X, xKey = GetChildControl<ButtonControl>("x") },
                { KeyCode.Y, yKey = GetChildControl<ButtonControl>("y") },
                { KeyCode.Z, zKey = GetChildControl<ButtonControl>("z") },
                { KeyCode.LeftCurlyBracket, leftCurlyBracketKey = GetChildControl<ButtonControl>("leftCurlyBracket") },
                { KeyCode.Pipe, pipeKey = GetChildControl<ButtonControl>("pipe") },
                { KeyCode.RightCurlyBracket, rightCurlyBracketKey = GetChildControl<ButtonControl>("rightCurlyBracket") },
                { KeyCode.Tilde, tildeKey = GetChildControl<ButtonControl>("tilde") },
                { KeyCode.Delete, deleteKey = GetChildControl<ButtonControl>("delete") },
                { KeyCode.Keypad0, keypad0Key = GetChildControl<ButtonControl>("keypad0") },
                { KeyCode.Keypad1, keypad1Key = GetChildControl<ButtonControl>("keypad1") },
                { KeyCode.Keypad2, keypad2Key = GetChildControl<ButtonControl>("keypad2") },
                { KeyCode.Keypad3, keypad3Key = GetChildControl<ButtonControl>("keypad3") },
                { KeyCode.Keypad4, keypad4Key = GetChildControl<ButtonControl>("keypad4") },
                { KeyCode.Keypad5, keypad5Key = GetChildControl<ButtonControl>("keypad5") },
                { KeyCode.Keypad6, keypad6Key = GetChildControl<ButtonControl>("keypad6") },
                { KeyCode.Keypad7, keypad7Key = GetChildControl<ButtonControl>("keypad7") },
                { KeyCode.Keypad8, keypad8Key = GetChildControl<ButtonControl>("keypad8") },
                { KeyCode.Keypad9, keypad9Key = GetChildControl<ButtonControl>("keypad9") },
                { KeyCode.KeypadPeriod, keypadPeriodKey = GetChildControl<ButtonControl>("keypadPeriod") },
                { KeyCode.KeypadDivide, keypadDivideKey = GetChildControl<ButtonControl>("keypadDivide") },
                { KeyCode.KeypadMultiply, keypadMultiplyKey = GetChildControl<ButtonControl>("keypadMultiply") },
                { KeyCode.KeypadMinus, keypadMinusKey = GetChildControl<ButtonControl>("keypadMinus") },
                { KeyCode.KeypadPlus, keypadPlusKey = GetChildControl<ButtonControl>("keypadPlus") },
                { KeyCode.KeypadEnter, keypadEnterKey = GetChildControl<ButtonControl>("keypadEnter") },
                { KeyCode.KeypadEquals, keypadEqualsKey = GetChildControl<ButtonControl>("keypadEquals") },
                { KeyCode.UpArrow, upArrowKey = GetChildControl<ButtonControl>("upArrow") },
                { KeyCode.DownArrow, downArrowKey = GetChildControl<ButtonControl>("downArrow") },
                { KeyCode.RightArrow, rightArrowKey = GetChildControl<ButtonControl>("rightArrow") },
                { KeyCode.LeftArrow, leftArrowKey = GetChildControl<ButtonControl>("leftArrow") },
                { KeyCode.Insert, insertKey = GetChildControl<ButtonControl>("insert") },
                { KeyCode.Home, homeKey = GetChildControl<ButtonControl>("home") },
                { KeyCode.End, endKey = GetChildControl<ButtonControl>("end") },
                { KeyCode.PageUp, pageUpKey = GetChildControl<ButtonControl>("pageUp") },
                { KeyCode.PageDown, pageDownKey = GetChildControl<ButtonControl>("pageDown") },
                { KeyCode.F1, f1Key = GetChildControl<ButtonControl>("f1") },
                { KeyCode.F2, f2Key = GetChildControl<ButtonControl>("f2") },
                { KeyCode.F3, f3Key = GetChildControl<ButtonControl>("f3") },
                { KeyCode.F4, f4Key = GetChildControl<ButtonControl>("f4") },
                { KeyCode.F5, f5Key = GetChildControl<ButtonControl>("f5") },
                { KeyCode.F6, f6Key = GetChildControl<ButtonControl>("f6") },
                { KeyCode.F7, f7Key = GetChildControl<ButtonControl>("f7") },
                { KeyCode.F8, f8Key = GetChildControl<ButtonControl>("f8") },
                { KeyCode.F9, f9Key = GetChildControl<ButtonControl>("f9") },
                { KeyCode.F10, f10Key = GetChildControl<ButtonControl>("f10") },
                { KeyCode.F11, f11Key = GetChildControl<ButtonControl>("f11") },
                { KeyCode.F12, f12Key = GetChildControl<ButtonControl>("f12") },
                { KeyCode.F13, f13Key = GetChildControl<ButtonControl>("f13") },
                { KeyCode.F14, f14Key = GetChildControl<ButtonControl>("f14") },
                { KeyCode.F15, f15Key = GetChildControl<ButtonControl>("f15") },
                { KeyCode.Numlock, numlockKey = GetChildControl<ButtonControl>("numlock") },
                { KeyCode.CapsLock, capsLockKey = GetChildControl<ButtonControl>("capsLock") },
                { KeyCode.ScrollLock, scrollLockKey = GetChildControl<ButtonControl>("scrollLock") },
                { KeyCode.RightShift, rightShiftKey = GetChildControl<ButtonControl>("rightShift") },
                { KeyCode.LeftShift, leftShiftKey = GetChildControl<ButtonControl>("leftShift") },
                { KeyCode.RightControl, rightControlKey = GetChildControl<ButtonControl>("rightControl") },
                { KeyCode.LeftControl, leftControlKey = GetChildControl<ButtonControl>("leftControl") },
                { KeyCode.RightAlt, rightAltKey = GetChildControl<ButtonControl>("rightAlt") },
                { KeyCode.LeftAlt, leftAltKey = GetChildControl<ButtonControl>("leftAlt") },
                { KeyCode.RightCommand, rightCommandKey = GetChildControl<ButtonControl>("rightCommand") },
                { KeyCode.LeftCommand, leftCommandKey = GetChildControl<ButtonControl>("leftCommand") },
                { KeyCode.LeftWindows, leftWindowsKey = GetChildControl<ButtonControl>("leftWindows") },
                { KeyCode.RightWindows, rightWindowsKey = GetChildControl<ButtonControl>("rightWindows") },
                { KeyCode.AltGr, altGrKey = GetChildControl<ButtonControl>("altGr") },
                { KeyCode.Help, helpKey = GetChildControl<ButtonControl>("help") },
                { KeyCode.Print, printKey = GetChildControl<ButtonControl>("print") },
                { KeyCode.SysReq, sysReqKey = GetChildControl<ButtonControl>("sysReq") },
                { KeyCode.Break, breakKey = GetChildControl<ButtonControl>("break") },
                { KeyCode.Menu, menuKey = GetChildControl<ButtonControl>("menu") },
                { KeyCode.Mouse0, mouse0Button = GetChildControl<ButtonControl>("mouse0") },
                { KeyCode.Mouse1, mouse1Button = GetChildControl<ButtonControl>("mouse1") },
                { KeyCode.Mouse2, mouse2Button = GetChildControl<ButtonControl>("mouse2") },
                { KeyCode.Mouse3, mouse3Button = GetChildControl<ButtonControl>("mouse3") },
                { KeyCode.Mouse4, mouse4Button = GetChildControl<ButtonControl>("mouse4") },
                { KeyCode.Mouse5, mouse5Button = GetChildControl<ButtonControl>("mouse5") },
                { KeyCode.Mouse6, mouse6Button = GetChildControl<ButtonControl>("mouse6") },
                { KeyCode.JoystickButton0, joystickButton0 = GetChildControl<ButtonControl>("joystickButton0") },
                { KeyCode.JoystickButton1, joystickButton1 = GetChildControl<ButtonControl>("joystickButton1") },
                { KeyCode.JoystickButton2, joystickButton2 = GetChildControl<ButtonControl>("joystickButton2") },
                { KeyCode.JoystickButton3, joystickButton3 = GetChildControl<ButtonControl>("joystickButton3") },
                { KeyCode.JoystickButton4, joystickButton4 = GetChildControl<ButtonControl>("joystickButton4") },
                { KeyCode.JoystickButton5, joystickButton5 = GetChildControl<ButtonControl>("joystickButton5") },
                { KeyCode.JoystickButton6, joystickButton6 = GetChildControl<ButtonControl>("joystickButton6") },
                { KeyCode.JoystickButton7, joystickButton7 = GetChildControl<ButtonControl>("joystickButton7") },
                { KeyCode.JoystickButton8, joystickButton8 = GetChildControl<ButtonControl>("joystickButton8") },
                { KeyCode.JoystickButton9, joystickButton9 = GetChildControl<ButtonControl>("joystickButton9") },
                { KeyCode.JoystickButton10, joystickButton10 = GetChildControl<ButtonControl>("joystickButton10") },
                { KeyCode.JoystickButton11, joystickButton11 = GetChildControl<ButtonControl>("joystickButton11") },
                { KeyCode.JoystickButton12, joystickButton12 = GetChildControl<ButtonControl>("joystickButton12") },
                { KeyCode.JoystickButton13, joystickButton13 = GetChildControl<ButtonControl>("joystickButton13") },
                { KeyCode.JoystickButton14, joystickButton14 = GetChildControl<ButtonControl>("joystickButton14") },
                { KeyCode.JoystickButton15, joystickButton15 = GetChildControl<ButtonControl>("joystickButton15") },
                { KeyCode.JoystickButton16, joystickButton16 = GetChildControl<ButtonControl>("joystickButton16") },
                { KeyCode.JoystickButton17, joystickButton17 = GetChildControl<ButtonControl>("joystickButton17") },
                { KeyCode.JoystickButton18, joystickButton18 = GetChildControl<ButtonControl>("joystickButton18") },
                { KeyCode.JoystickButton19, joystickButton19 = GetChildControl<ButtonControl>("joystickButton19") },
                { KeyCode.Joystick1Button0, joystick1Button0 = GetChildControl<ButtonControl>("joystick1Button0") },
                { KeyCode.Joystick1Button1, joystick1Button1 = GetChildControl<ButtonControl>("joystick1Button1") },
                { KeyCode.Joystick1Button2, joystick1Button2 = GetChildControl<ButtonControl>("joystick1Button2") },
                { KeyCode.Joystick1Button3, joystick1Button3 = GetChildControl<ButtonControl>("joystick1Button3") },
                { KeyCode.Joystick1Button4, joystick1Button4 = GetChildControl<ButtonControl>("joystick1Button4") },
                { KeyCode.Joystick1Button5, joystick1Button5 = GetChildControl<ButtonControl>("joystick1Button5") },
                { KeyCode.Joystick1Button6, joystick1Button6 = GetChildControl<ButtonControl>("joystick1Button6") },
                { KeyCode.Joystick1Button7, joystick1Button7 = GetChildControl<ButtonControl>("joystick1Button7") },
                { KeyCode.Joystick1Button8, joystick1Button8 = GetChildControl<ButtonControl>("joystick1Button8") },
                { KeyCode.Joystick1Button9, joystick1Button9 = GetChildControl<ButtonControl>("joystick1Button9") },
                { KeyCode.Joystick1Button10, joystick1Button10 = GetChildControl<ButtonControl>("joystick1Button10") },
                { KeyCode.Joystick1Button11, joystick1Button11 = GetChildControl<ButtonControl>("joystick1Button11") },
                { KeyCode.Joystick1Button12, joystick1Button12 = GetChildControl<ButtonControl>("joystick1Button12") },
                { KeyCode.Joystick1Button13, joystick1Button13 = GetChildControl<ButtonControl>("joystick1Button13") },
                { KeyCode.Joystick1Button14, joystick1Button14 = GetChildControl<ButtonControl>("joystick1Button14") },
                { KeyCode.Joystick1Button15, joystick1Button15 = GetChildControl<ButtonControl>("joystick1Button15") },
                { KeyCode.Joystick1Button16, joystick1Button16 = GetChildControl<ButtonControl>("joystick1Button16") },
                { KeyCode.Joystick1Button17, joystick1Button17 = GetChildControl<ButtonControl>("joystick1Button17") },
                { KeyCode.Joystick1Button18, joystick1Button18 = GetChildControl<ButtonControl>("joystick1Button18") },
                { KeyCode.Joystick1Button19, joystick1Button19 = GetChildControl<ButtonControl>("joystick1Button19") },
                { KeyCode.Joystick2Button0, joystick2Button0 = GetChildControl<ButtonControl>("joystick2Button0") },
                { KeyCode.Joystick2Button1, joystick2Button1 = GetChildControl<ButtonControl>("joystick2Button1") },
                { KeyCode.Joystick2Button2, joystick2Button2 = GetChildControl<ButtonControl>("joystick2Button2") },
                { KeyCode.Joystick2Button3, joystick2Button3 = GetChildControl<ButtonControl>("joystick2Button3") },
                { KeyCode.Joystick2Button4, joystick2Button4 = GetChildControl<ButtonControl>("joystick2Button4") },
                { KeyCode.Joystick2Button5, joystick2Button5 = GetChildControl<ButtonControl>("joystick2Button5") },
                { KeyCode.Joystick2Button6, joystick2Button6 = GetChildControl<ButtonControl>("joystick2Button6") },
                { KeyCode.Joystick2Button7, joystick2Button7 = GetChildControl<ButtonControl>("joystick2Button7") },
                { KeyCode.Joystick2Button8, joystick2Button8 = GetChildControl<ButtonControl>("joystick2Button8") },
                { KeyCode.Joystick2Button9, joystick2Button9 = GetChildControl<ButtonControl>("joystick2Button9") },
                { KeyCode.Joystick2Button10, joystick2Button10 = GetChildControl<ButtonControl>("joystick2Button10") },
                { KeyCode.Joystick2Button11, joystick2Button11 = GetChildControl<ButtonControl>("joystick2Button11") },
                { KeyCode.Joystick2Button12, joystick2Button12 = GetChildControl<ButtonControl>("joystick2Button12") },
                { KeyCode.Joystick2Button13, joystick2Button13 = GetChildControl<ButtonControl>("joystick2Button13") },
                { KeyCode.Joystick2Button14, joystick2Button14 = GetChildControl<ButtonControl>("joystick2Button14") },
                { KeyCode.Joystick2Button15, joystick2Button15 = GetChildControl<ButtonControl>("joystick2Button15") },
                { KeyCode.Joystick2Button16, joystick2Button16 = GetChildControl<ButtonControl>("joystick2Button16") },
                { KeyCode.Joystick2Button17, joystick2Button17 = GetChildControl<ButtonControl>("joystick2Button17") },
                { KeyCode.Joystick2Button18, joystick2Button18 = GetChildControl<ButtonControl>("joystick2Button18") },
                { KeyCode.Joystick2Button19, joystick2Button19 = GetChildControl<ButtonControl>("joystick2Button19") },
                { KeyCode.Joystick3Button0, joystick3Button0 = GetChildControl<ButtonControl>("joystick3Button0") },
                { KeyCode.Joystick3Button1, joystick3Button1 = GetChildControl<ButtonControl>("joystick3Button1") },
                { KeyCode.Joystick3Button2, joystick3Button2 = GetChildControl<ButtonControl>("joystick3Button2") },
                { KeyCode.Joystick3Button3, joystick3Button3 = GetChildControl<ButtonControl>("joystick3Button3") },
                { KeyCode.Joystick3Button4, joystick3Button4 = GetChildControl<ButtonControl>("joystick3Button4") },
                { KeyCode.Joystick3Button5, joystick3Button5 = GetChildControl<ButtonControl>("joystick3Button5") },
                { KeyCode.Joystick3Button6, joystick3Button6 = GetChildControl<ButtonControl>("joystick3Button6") },
                { KeyCode.Joystick3Button7, joystick3Button7 = GetChildControl<ButtonControl>("joystick3Button7") },
                { KeyCode.Joystick3Button8, joystick3Button8 = GetChildControl<ButtonControl>("joystick3Button8") },
                { KeyCode.Joystick3Button9, joystick3Button9 = GetChildControl<ButtonControl>("joystick3Button9") },
                { KeyCode.Joystick3Button10, joystick3Button10 = GetChildControl<ButtonControl>("joystick3Button10") },
                { KeyCode.Joystick3Button11, joystick3Button11 = GetChildControl<ButtonControl>("joystick3Button11") },
                { KeyCode.Joystick3Button12, joystick3Button12 = GetChildControl<ButtonControl>("joystick3Button12") },
                { KeyCode.Joystick3Button13, joystick3Button13 = GetChildControl<ButtonControl>("joystick3Button13") },
                { KeyCode.Joystick3Button14, joystick3Button14 = GetChildControl<ButtonControl>("joystick3Button14") },
                { KeyCode.Joystick3Button15, joystick3Button15 = GetChildControl<ButtonControl>("joystick3Button15") },
                { KeyCode.Joystick3Button16, joystick3Button16 = GetChildControl<ButtonControl>("joystick3Button16") },
                { KeyCode.Joystick3Button17, joystick3Button17 = GetChildControl<ButtonControl>("joystick3Button17") },
                { KeyCode.Joystick3Button18, joystick3Button18 = GetChildControl<ButtonControl>("joystick3Button18") },
                { KeyCode.Joystick3Button19, joystick3Button19 = GetChildControl<ButtonControl>("joystick3Button19") },
                { KeyCode.Joystick4Button0, joystick4Button0 = GetChildControl<ButtonControl>("joystick4Button0") },
                { KeyCode.Joystick4Button1, joystick4Button1 = GetChildControl<ButtonControl>("joystick4Button1") },
                { KeyCode.Joystick4Button2, joystick4Button2 = GetChildControl<ButtonControl>("joystick4Button2") },
                { KeyCode.Joystick4Button3, joystick4Button3 = GetChildControl<ButtonControl>("joystick4Button3") },
                { KeyCode.Joystick4Button4, joystick4Button4 = GetChildControl<ButtonControl>("joystick4Button4") },
                { KeyCode.Joystick4Button5, joystick4Button5 = GetChildControl<ButtonControl>("joystick4Button5") },
                { KeyCode.Joystick4Button6, joystick4Button6 = GetChildControl<ButtonControl>("joystick4Button6") },
                { KeyCode.Joystick4Button7, joystick4Button7 = GetChildControl<ButtonControl>("joystick4Button7") },
                { KeyCode.Joystick4Button8, joystick4Button8 = GetChildControl<ButtonControl>("joystick4Button8") },
                { KeyCode.Joystick4Button9, joystick4Button9 = GetChildControl<ButtonControl>("joystick4Button9") },
                { KeyCode.Joystick4Button10, joystick4Button10 = GetChildControl<ButtonControl>("joystick4Button10") },
                { KeyCode.Joystick4Button11, joystick4Button11 = GetChildControl<ButtonControl>("joystick4Button11") },
                { KeyCode.Joystick4Button12, joystick4Button12 = GetChildControl<ButtonControl>("joystick4Button12") },
                { KeyCode.Joystick4Button13, joystick4Button13 = GetChildControl<ButtonControl>("joystick4Button13") },
                { KeyCode.Joystick4Button14, joystick4Button14 = GetChildControl<ButtonControl>("joystick4Button14") },
                { KeyCode.Joystick4Button15, joystick4Button15 = GetChildControl<ButtonControl>("joystick4Button15") },
                { KeyCode.Joystick4Button16, joystick4Button16 = GetChildControl<ButtonControl>("joystick4Button16") },
                { KeyCode.Joystick4Button17, joystick4Button17 = GetChildControl<ButtonControl>("joystick4Button17") },
                { KeyCode.Joystick4Button18, joystick4Button18 = GetChildControl<ButtonControl>("joystick4Button18") },
                { KeyCode.Joystick4Button19, joystick4Button19 = GetChildControl<ButtonControl>("joystick4Button19") },
                { KeyCode.Joystick5Button0, joystick5Button0 = GetChildControl<ButtonControl>("joystick5Button0") },
                { KeyCode.Joystick5Button1, joystick5Button1 = GetChildControl<ButtonControl>("joystick5Button1") },
                { KeyCode.Joystick5Button2, joystick5Button2 = GetChildControl<ButtonControl>("joystick5Button2") },
                { KeyCode.Joystick5Button3, joystick5Button3 = GetChildControl<ButtonControl>("joystick5Button3") },
                { KeyCode.Joystick5Button4, joystick5Button4 = GetChildControl<ButtonControl>("joystick5Button4") },
                { KeyCode.Joystick5Button5, joystick5Button5 = GetChildControl<ButtonControl>("joystick5Button5") },
                { KeyCode.Joystick5Button6, joystick5Button6 = GetChildControl<ButtonControl>("joystick5Button6") },
                { KeyCode.Joystick5Button7, joystick5Button7 = GetChildControl<ButtonControl>("joystick5Button7") },
                { KeyCode.Joystick5Button8, joystick5Button8 = GetChildControl<ButtonControl>("joystick5Button8") },
                { KeyCode.Joystick5Button9, joystick5Button9 = GetChildControl<ButtonControl>("joystick5Button9") },
                { KeyCode.Joystick5Button10, joystick5Button10 = GetChildControl<ButtonControl>("joystick5Button10") },
                { KeyCode.Joystick5Button11, joystick5Button11 = GetChildControl<ButtonControl>("joystick5Button11") },
                { KeyCode.Joystick5Button12, joystick5Button12 = GetChildControl<ButtonControl>("joystick5Button12") },
                { KeyCode.Joystick5Button13, joystick5Button13 = GetChildControl<ButtonControl>("joystick5Button13") },
                { KeyCode.Joystick5Button14, joystick5Button14 = GetChildControl<ButtonControl>("joystick5Button14") },
                { KeyCode.Joystick5Button15, joystick5Button15 = GetChildControl<ButtonControl>("joystick5Button15") },
                { KeyCode.Joystick5Button16, joystick5Button16 = GetChildControl<ButtonControl>("joystick5Button16") },
                { KeyCode.Joystick5Button17, joystick5Button17 = GetChildControl<ButtonControl>("joystick5Button17") },
                { KeyCode.Joystick5Button18, joystick5Button18 = GetChildControl<ButtonControl>("joystick5Button18") },
                { KeyCode.Joystick5Button19, joystick5Button19 = GetChildControl<ButtonControl>("joystick5Button19") },
                { KeyCode.Joystick6Button0, joystick6Button0 = GetChildControl<ButtonControl>("joystick6Button0") },
                { KeyCode.Joystick6Button1, joystick6Button1 = GetChildControl<ButtonControl>("joystick6Button1") },
                { KeyCode.Joystick6Button2, joystick6Button2 = GetChildControl<ButtonControl>("joystick6Button2") },
                { KeyCode.Joystick6Button3, joystick6Button3 = GetChildControl<ButtonControl>("joystick6Button3") },
                { KeyCode.Joystick6Button4, joystick6Button4 = GetChildControl<ButtonControl>("joystick6Button4") },
                { KeyCode.Joystick6Button5, joystick6Button5 = GetChildControl<ButtonControl>("joystick6Button5") },
                { KeyCode.Joystick6Button6, joystick6Button6 = GetChildControl<ButtonControl>("joystick6Button6") },
                { KeyCode.Joystick6Button7, joystick6Button7 = GetChildControl<ButtonControl>("joystick6Button7") },
                { KeyCode.Joystick6Button8, joystick6Button8 = GetChildControl<ButtonControl>("joystick6Button8") },
                { KeyCode.Joystick6Button9, joystick6Button9 = GetChildControl<ButtonControl>("joystick6Button9") },
                { KeyCode.Joystick6Button10, joystick6Button10 = GetChildControl<ButtonControl>("joystick6Button10") },
                { KeyCode.Joystick6Button11, joystick6Button11 = GetChildControl<ButtonControl>("joystick6Button11") },
                { KeyCode.Joystick6Button12, joystick6Button12 = GetChildControl<ButtonControl>("joystick6Button12") },
                { KeyCode.Joystick6Button13, joystick6Button13 = GetChildControl<ButtonControl>("joystick6Button13") },
                { KeyCode.Joystick6Button14, joystick6Button14 = GetChildControl<ButtonControl>("joystick6Button14") },
                { KeyCode.Joystick6Button15, joystick6Button15 = GetChildControl<ButtonControl>("joystick6Button15") },
                { KeyCode.Joystick6Button16, joystick6Button16 = GetChildControl<ButtonControl>("joystick6Button16") },
                { KeyCode.Joystick6Button17, joystick6Button17 = GetChildControl<ButtonControl>("joystick6Button17") },
                { KeyCode.Joystick6Button18, joystick6Button18 = GetChildControl<ButtonControl>("joystick6Button18") },
                { KeyCode.Joystick6Button19, joystick6Button19 = GetChildControl<ButtonControl>("joystick6Button19") },
                { KeyCode.Joystick7Button0, joystick7Button0 = GetChildControl<ButtonControl>("joystick7Button0") },
                { KeyCode.Joystick7Button1, joystick7Button1 = GetChildControl<ButtonControl>("joystick7Button1") },
                { KeyCode.Joystick7Button2, joystick7Button2 = GetChildControl<ButtonControl>("joystick7Button2") },
                { KeyCode.Joystick7Button3, joystick7Button3 = GetChildControl<ButtonControl>("joystick7Button3") },
                { KeyCode.Joystick7Button4, joystick7Button4 = GetChildControl<ButtonControl>("joystick7Button4") },
                { KeyCode.Joystick7Button5, joystick7Button5 = GetChildControl<ButtonControl>("joystick7Button5") },
                { KeyCode.Joystick7Button6, joystick7Button6 = GetChildControl<ButtonControl>("joystick7Button6") },
                { KeyCode.Joystick7Button7, joystick7Button7 = GetChildControl<ButtonControl>("joystick7Button7") },
                { KeyCode.Joystick7Button8, joystick7Button8 = GetChildControl<ButtonControl>("joystick7Button8") },
                { KeyCode.Joystick7Button9, joystick7Button9 = GetChildControl<ButtonControl>("joystick7Button9") },
                { KeyCode.Joystick7Button10, joystick7Button10 = GetChildControl<ButtonControl>("joystick7Button10") },
                { KeyCode.Joystick7Button11, joystick7Button11 = GetChildControl<ButtonControl>("joystick7Button11") },
                { KeyCode.Joystick7Button12, joystick7Button12 = GetChildControl<ButtonControl>("joystick7Button12") },
                { KeyCode.Joystick7Button13, joystick7Button13 = GetChildControl<ButtonControl>("joystick7Button13") },
                { KeyCode.Joystick7Button14, joystick7Button14 = GetChildControl<ButtonControl>("joystick7Button14") },
                { KeyCode.Joystick7Button15, joystick7Button15 = GetChildControl<ButtonControl>("joystick7Button15") },
                { KeyCode.Joystick7Button16, joystick7Button16 = GetChildControl<ButtonControl>("joystick7Button16") },
                { KeyCode.Joystick7Button17, joystick7Button17 = GetChildControl<ButtonControl>("joystick7Button17") },
                { KeyCode.Joystick7Button18, joystick7Button18 = GetChildControl<ButtonControl>("joystick7Button18") },
                { KeyCode.Joystick7Button19, joystick7Button19 = GetChildControl<ButtonControl>("joystick7Button19") },
                { KeyCode.Joystick8Button0, joystick8Button0 = GetChildControl<ButtonControl>("joystick8Button0") },
                { KeyCode.Joystick8Button1, joystick8Button1 = GetChildControl<ButtonControl>("joystick8Button1") },
                { KeyCode.Joystick8Button2, joystick8Button2 = GetChildControl<ButtonControl>("joystick8Button2") },
                { KeyCode.Joystick8Button3, joystick8Button3 = GetChildControl<ButtonControl>("joystick8Button3") },
                { KeyCode.Joystick8Button4, joystick8Button4 = GetChildControl<ButtonControl>("joystick8Button4") },
                { KeyCode.Joystick8Button5, joystick8Button5 = GetChildControl<ButtonControl>("joystick8Button5") },
                { KeyCode.Joystick8Button6, joystick8Button6 = GetChildControl<ButtonControl>("joystick8Button6") },
                { KeyCode.Joystick8Button7, joystick8Button7 = GetChildControl<ButtonControl>("joystick8Button7") },
                { KeyCode.Joystick8Button8, joystick8Button8 = GetChildControl<ButtonControl>("joystick8Button8") },
                { KeyCode.Joystick8Button9, joystick8Button9 = GetChildControl<ButtonControl>("joystick8Button9") },
                { KeyCode.Joystick8Button10, joystick8Button10 = GetChildControl<ButtonControl>("joystick8Button10") },
                { KeyCode.Joystick8Button11, joystick8Button11 = GetChildControl<ButtonControl>("joystick8Button11") },
                { KeyCode.Joystick8Button12, joystick8Button12 = GetChildControl<ButtonControl>("joystick8Button12") },
                { KeyCode.Joystick8Button13, joystick8Button13 = GetChildControl<ButtonControl>("joystick8Button13") },
                { KeyCode.Joystick8Button14, joystick8Button14 = GetChildControl<ButtonControl>("joystick8Button14") },
                { KeyCode.Joystick8Button15, joystick8Button15 = GetChildControl<ButtonControl>("joystick8Button15") },
                { KeyCode.Joystick8Button16, joystick8Button16 = GetChildControl<ButtonControl>("joystick8Button16") },
                { KeyCode.Joystick8Button17, joystick8Button17 = GetChildControl<ButtonControl>("joystick8Button17") },
                { KeyCode.Joystick8Button18, joystick8Button18 = GetChildControl<ButtonControl>("joystick8Button18") },
                { KeyCode.Joystick8Button19, joystick8Button19 = GetChildControl<ButtonControl>("joystick8Button19") },
            };
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void RuntimeInitialize()
        {
            if (InputSystem.GetDevice<LegacyInput>() == null)
            {
                InputSystem.AddDevice<LegacyInput>();
            }
        }

        static LegacyInput()
        {
            InputSystem.RegisterLayout<LegacyInput>();
        }
    }
}
