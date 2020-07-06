namespace Gym.View
{
    using System;
    using System.Windows.Forms;

    public partial class MyGymControl : UserControl
    {
        public MyGymControl()
        {
            this.InitializeComponent();
        }

        public event EventHandler ValueChanged;

        public event EventHandler LeaveControl;

        public event EventHandler PresionaEnter;

        protected virtual void OnValueChanged() => this.ValueChanged?.Invoke(this, EventArgs.Empty);

        protected virtual void OnLeaveControl() => this.LeaveControl?.Invoke(this, EventArgs.Empty);

        protected virtual void AlPresionarEnter() => this.PresionaEnter?.Invoke(this, EventArgs.Empty);
    }
}
