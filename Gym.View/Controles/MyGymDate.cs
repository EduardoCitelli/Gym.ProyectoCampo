namespace Gym.View
{
    using System;
    using System.ComponentModel;
    
    public partial class MyGymDate : MyGymControl
    {
        public MyGymDate()
        {
            this.InitializeComponent();
        }

        [Category("MyGym")]
        public string Descripcion
        {
            get => this.lblDescripcion.Text;

            set => this.lblDescripcion.Text = value;
        }

        [Category("MyGym"), DefaultValue(true)]
        public bool Habilitado
        {
            get
            {
                return this.dte.Enabled;
            }

            set
            {
                this.dte.Enabled = value;
                this.TabStop = value;
                this.dte.TabStop = value;
            }
        }

        [Category("MyGym"), DefaultValue(false)]
        public bool OcultarDia
        {
            get => this.splitContainer1.Panel2Collapsed;

            set => this.splitContainer1.Panel2Collapsed = value;
        }

        public void Focalizar() => this.dte.Focus();

        public void SetValor(DateTime? value)
        {
            if (value.HasValue && value.Value != DateTime.MinValue)
            {
                this.dte.Checked = true;
                this.dte.Value = value.Value;
            }
            else
                this.dte.Checked = false;
        }

        public DateTime? GetValor() => this.dte.Checked && this.dte.Value != DateTime.MinValue ? (DateTime?)this.dte.Value.Date : null;

        public bool HasValue() => this.dte.Checked && this.dte.Value != DateTime.MinValue;

        public void Limpiar() => this.dte.Checked = false;

        private void Dte_Enter(object sender, EventArgs e)
        {
            this.dte.Focus();
            this.dte.Select();
        }

        private void Dte_ValueChangedSpecial(object sender, EventArgs e)
        {
            this.OnValueChanged();
        }
    }
}
