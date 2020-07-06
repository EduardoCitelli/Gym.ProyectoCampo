namespace Gym.View
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MyGymDecimal : MyGymControl
    {
        private bool esObligatorio;

        public MyGymDecimal()
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

        [Category("MyGym"), DefaultValue(true)]
        public bool Habilitado
        {
            get => this.num.Enabled;

            set
            {
                this.num.Enabled = value;
                this.TabStop = value;
            }
        }

        [Category("MyGym"), DefaultValue(int.MaxValue)]
        public decimal Maximo
        {
            get => this.num.Maximum;

            set => this.num.Maximum = value;
        }

        [Category("MyGym"), DefaultValue(0)]
        public decimal Minimo
        {
            get => this.num.Minimum;

            set => this.num.Minimum = value;
        }

        [Category("MyGym"), DefaultValue(1)]
        public decimal Incremento
        {
            get { return this.num.Increment; }

            set { this.num.Increment = value; }
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
            get => this.picObligatorio.VisibleNoColapsado;
            set
            {
                this.picObligatorio.VisibleNoColapsado = value;
                this.esObligatorio = value;
            }
        }

        [Category("MyGym")]
        public string Titulo
        {
            get => this.lblDescripcion.Text;
            set => this.lblDescripcion.Text = value;
        }

        public bool Validar()
        {
            if (!this.esObligatorio) return true;

            if (this.GetValor() == 0)
            {
                MessageBox.Show("El campo " + this.lblDescripcion.Text + " está en 0, por favor completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        
        public decimal GetValor() => this.num.Value;

        public void Focalizar() => this.num.Focus();

        public bool HasFocus() => this.num.Focused;

        public void SetValor(decimal value)
        {
            if (this.num.Value != value)
            {
                this.num.Value = value;
                this.OnValueChanged();
            }
        }

        public bool HasValue() => this.GetValor() != 0;

        public void Limpiar() => this.SetValor(0);

        decimal valorAlEntrar;

        private void Num_Enter(object sender, EventArgs e)
        {
            this.valorAlEntrar = this.GetValor();
            this.num.Select(0, this.num.ToString().Length);
        }

        private void num_Leave(object sender, EventArgs e)
        {
            this.OnLeaveControl();
            if (this.valorAlEntrar != this.GetValor())
                this.OnValueChanged();
        }
    }
}
