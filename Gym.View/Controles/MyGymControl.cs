namespace Gym.View
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public partial class MyGymControl : UserControl
    {
        public MyGymControl()
        {
            this.InitializeComponent();
        }

        [Category("MyGym")]
        public event EventHandler ValueChanged;

        [Category("MyGym")]
        public event EventHandler LeaveControl;

        [Category("MyGym")]
        public event EventHandler PresionaEnter;

        protected virtual void OnValueChanged() => this.ValueChanged?.Invoke(this, EventArgs.Empty);

        protected virtual void OnLeaveControl() => this.LeaveControl?.Invoke(this, EventArgs.Empty);

        protected virtual void AlPresionarEnter() => this.PresionaEnter?.Invoke(this, EventArgs.Empty);
    }
}
