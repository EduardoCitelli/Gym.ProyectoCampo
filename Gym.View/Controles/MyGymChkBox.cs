namespace Gym.View
{
    using System;
    using System.ComponentModel;
    using System.Drawing;

    public partial class MyGymChkBox : MyGymControl
    {
        public MyGymChkBox()
        {
            this.InitializeComponent();
        }

        [Category("MyGym")]
        public Font FontLabel
        {
            get => this.lblDescripcion.Font;
            set => this.lblDescripcion.Font = value;
        }

        [Category("MyGym")]
        public Color ColorTexto
        {
            get => this.lblDescripcion.ForeColor;
            set => this.lblDescripcion.ForeColor = value;
        }

        [Category("MyGym")]
        public ContentAlignment AlinearTexto
        {
            get => this.lblDescripcion.TextAlign;
            set => this.lblDescripcion.TextAlign = value;
        }

        [Category("MyGym")]
        public string Titulo
        {
            get => this.lblDescripcion.Text;
            set => this.lblDescripcion.Text = value;
        }

        [Category("MyGym"), DefaultValue(true)]
        public bool Habilitado
        {
            get => this.Enabled;
            set
            {
                this.Enabled = value;
                this.chk.Enabled = value;
            }
        }

        public bool GetValor() => this.chk.Checked;

        public void SetValor(bool valor) => this.chk.Checked = valor;

        public void Limpiar() => this.chk.Checked = false;

        public void Completar() => this.chk.Checked = true;

        private void Chk_CheckedChanged(object sender, EventArgs e) => this.OnValueChanged();
    }
}
