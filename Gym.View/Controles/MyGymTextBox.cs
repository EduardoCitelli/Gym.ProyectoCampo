namespace Gym.View
{
    using Common;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MyGymTextBox : MyGymControl
    {
        private bool esObligatorio;

        public event EventHandler Text_Changed;

        public MyGymTextBox()
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
        public bool Obligatorio
        {
            get => this.picRequerido.VisibleNoColapsado;
            set
            {
                this.picRequerido.VisibleNoColapsado = value;
                this.esObligatorio = value;
            }
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
                this.txtDescripcion.Enabled = value;                
            }
        }

        [Category("MyGym")]
        public bool TextoPassword
        {
            get => this.txtDescripcion.UseSystemPasswordChar;
            set => this.txtDescripcion.UseSystemPasswordChar = value;
        }

        [Category("MyGym")]
        public char CaracterPassword
        {
            get => this.txtDescripcion.PasswordChar;
            set => this.txtDescripcion.PasswordChar = value;
        }

        public bool Validar()
        {
            if (!this.esObligatorio) return true;

            if (string.IsNullOrWhiteSpace(this.txtDescripcion.Text))
            {
                MessageBox.Show("El campo " + this.lblDescripcion.Text + " está incompleto, por favor completar","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void Focalizar() => this.txtDescripcion.Focus();

        public string GetValor() => this.txtDescripcion.Text;

        public void SetValor(string valor)
        {
            this.txtDescripcion.Text = valor;
            this.OnValueChanged();
        }

        public bool HasValue() => !this.GetValor().IsNullOrEmpty();

        public void Limpiar() => this.txtDescripcion.Clear();

        private void Txt_Enter(object sender, EventArgs e)
        {
            this.txtDescripcion.Focus();
            this.txtDescripcion.SelectAll();
        }

        private void txt_TextChanged(object sender, EventArgs e) => this.Text_Changed?.Invoke(this, e);
    }
}
