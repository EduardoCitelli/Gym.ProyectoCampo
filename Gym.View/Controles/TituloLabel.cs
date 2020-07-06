namespace Gym.View
{
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class TituloLabel : UserControl
    {
        public TituloLabel()
        {
            this.InitializeComponent();
            this.Enabled = false;
        }
        
        [Category("MyGym"), DefaultValue("Titulo")]
        public string Titulo
        {
            get => this.lbl.Text;
            set => this.lbl.Text = value;
        }

        [DefaultValue(false)]
        public new bool Enabled
        {
            get => base.Enabled;

            set => base.Enabled = value;
        }

        [Category("MyGym")]
        public BorderStyle TipoBorde
        {
            get => this.lbl.BorderStyle;
            set => this.lbl.BorderStyle = value;
        }

        [Category("MyGym")]
        public Color LabelBackColor
        {
            get => this.lbl.BackColor;
            set => this.lbl.BackColor = value;
        }

        [Category("MyGym")]
        public ContentAlignment AlinearTexto
        {
            get => this.lbl.TextAlign;
            set => this.lbl.TextAlign = value;
        }

        [Category("MyGym")]
        public Color ColorTexto
        {
            get => this.lbl.ForeColor;
            set => this.lbl.ForeColor = value;
        }

        [Category("MyGym")]
        public Font FontLabel
        {
            get => this.lbl.Font;
            set => this.lbl.Font = value;
        }
    }
}
