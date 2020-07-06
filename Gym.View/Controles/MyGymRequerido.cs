namespace Gym.View
{
    using System.Windows.Forms;

    public partial class MyGymRequerido : UserControl
    {
        public MyGymRequerido()
        {
            this.InitializeComponent();
        }

        public bool VisibleNoColapsado
        {
            get => this.picRequired.Visible;

            set => this.picRequired.Visible = value;
        }
    }
}
