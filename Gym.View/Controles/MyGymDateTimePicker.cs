namespace Gym.View
{
    using System;
    using System.Windows.Forms;
    using System.Diagnostics;

    public partial class MyGymDateTimePicker : DateTimePicker
    {
        public MyGymDateTimePicker()
        {
            this.InitializeComponent();
        }

        private const int WM_REFLECT = 0x2000;
        private const int WM_NOTIFY = 0x004E;
        private const uint DTN_DATETIMECHANGE = 0xFFFFFD09;

        public event EventHandler ValueChangedSpecial;

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust"), DebuggerStepThrough]
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (!this.DesignMode)
            {
                switch (m.Msg)
                {
                    case WM_REFLECT + WM_NOTIFY:
                        var nm = (NMHDR)m.GetLParam(typeof(NMHDR));
                        if (nm.Code == DTN_DATETIMECHANGE)
                            OnValueChangedSpecial();
                        break;
                }
            }
        }

        protected virtual void OnValueChangedSpecial()
        {
            if (ValueChangedSpecial != null)
                this.ValueChangedSpecial(this, EventArgs.Empty);
        }

        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]

        private struct NMHDR
        {
            public IntPtr HwndFrom;
            public uint IdFrom;
            public uint Code;
        }
    }
}
