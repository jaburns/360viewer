using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GamePadView
{
    public partial class ViewForm : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct XInputState
        {
            public UInt32 dwPacketNumber;
            public UInt16 wButtons;
            public Byte bLeftTrigger;
            public Byte bRightTrigger;
            public Int16 sThumbLX;
            public Int16 sThumbLY;
            public Int16 sThumbRX;
            public Int16 sThumbRY;
        }

        public static class XInput
        {
            [DllImport("xinput9_1_0.dll")]
            static public extern uint XInputGetState(uint userIndex, ref XInputState inputState);
        }

        private enum XBoxControllerInput
        {
            A, B, X, Y, RTrigger, RShoulder, LTrigger, LShoulder, DUp, DDown, DLeft, DRight, Start, Back, LStick, RStick
        };

        private const int STICK_DISTANCE = 9;
        private const int TRIGGER_THRESHOLD = 50;

        private int StickOriginX;
        private int StickOriginY;
        private int StickOriginX2;
        private int StickOriginY2;

        public ViewForm()
        {
            InitializeComponent();

            StickOriginX = stick.Left;
            StickOriginY = stick.Top;
            StickOriginX2 = stick2.Left;
            StickOriginY2 = stick2.Top;

            timer1.Enabled = true;
        }

        private List<XBoxControllerInput> getCurrentInputs(XInputState state)
        {
            List<XBoxControllerInput> ret = new List<XBoxControllerInput>();

            if ((state.wButtons & 0x1000) != 0) ret.Add(XBoxControllerInput.A);
            if ((state.wButtons & 0x2000) != 0) ret.Add(XBoxControllerInput.B);
            if ((state.wButtons & 0x4000) != 0) ret.Add(XBoxControllerInput.X);
            if ((state.wButtons & 0x8000) != 0) ret.Add(XBoxControllerInput.Y);

            if ((state.wButtons & 0x0001) != 0) ret.Add(XBoxControllerInput.DUp);
            if ((state.wButtons & 0x0002) != 0) ret.Add(XBoxControllerInput.DDown);
            if ((state.wButtons & 0x0004) != 0) ret.Add(XBoxControllerInput.DLeft);
            if ((state.wButtons & 0x0008) != 0) ret.Add(XBoxControllerInput.DRight);

            if ((state.wButtons & 0x0010) != 0) ret.Add(XBoxControllerInput.Start);
            if ((state.wButtons & 0x0020) != 0) ret.Add(XBoxControllerInput.Back);
            if ((state.wButtons & 0x0040) != 0) ret.Add(XBoxControllerInput.LStick);
            if ((state.wButtons & 0x0080) != 0) ret.Add(XBoxControllerInput.RStick);

            if ((state.wButtons & 0x0100) != 0) ret.Add(XBoxControllerInput.LShoulder);
            if ((state.wButtons & 0x0200) != 0) ret.Add(XBoxControllerInput.RShoulder);

            if (state.bLeftTrigger > TRIGGER_THRESHOLD) ret.Add(XBoxControllerInput.LTrigger);
            if (state.bRightTrigger > TRIGGER_THRESHOLD) ret.Add(XBoxControllerInput.RTrigger);

            return ret;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            XInputState state = new XInputState();
            XInput.XInputGetState(0, ref state);
            List<XBoxControllerInput> currentInputs = getCurrentInputs(state);

            btn_a.Visible = currentInputs.Contains(XBoxControllerInput.A);
            btn_b.Visible = currentInputs.Contains(XBoxControllerInput.B);
            btn_x.Visible = currentInputs.Contains(XBoxControllerInput.X);
            btn_y.Visible = currentInputs.Contains(XBoxControllerInput.Y);

            btn_R.Visible = currentInputs.Contains(XBoxControllerInput.RShoulder);
            btn_L.Visible = currentInputs.Contains(XBoxControllerInput.LShoulder);

            btn_Ddown.Visible = currentInputs.Contains(XBoxControllerInput.DDown);
            btn_Dup.Visible = currentInputs.Contains(XBoxControllerInput.DUp);
            btn_Dleft.Visible = currentInputs.Contains(XBoxControllerInput.DLeft);
            btn_Dright.Visible = currentInputs.Contains(XBoxControllerInput.DRight);

            btn_start.Visible = currentInputs.Contains(XBoxControllerInput.Start);
            btn_back.Visible = currentInputs.Contains(XBoxControllerInput.Back);

            btnR_trig.Visible = currentInputs.Contains(XBoxControllerInput.RTrigger);
            btnL_trig.Visible = currentInputs.Contains(XBoxControllerInput.LTrigger);

            stick.Left = StickOriginX + STICK_DISTANCE * state.sThumbLX / 32768;
            stick.Top = StickOriginY - STICK_DISTANCE * state.sThumbLY / 32768;
            stick2.Left = StickOriginX2 + STICK_DISTANCE * state.sThumbRX / 32768;
            stick2.Top = StickOriginY2 - STICK_DISTANCE * state.sThumbRY / 32768;
        }
    }
}
