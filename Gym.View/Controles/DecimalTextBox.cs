namespace Gym.View
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class DecimalTextBox : MyGymControl
    {
        public DecimalTextBox()
        {
            this.InitializeComponent();
            this.decimales = 2;
        }

        private bool esObligatorio;

        [Category("MyGym")]
        public Font FontLabel
        {
            get => this.lblDescripcion.Font;
            set => this.lblDescripcion.Font = value;
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

        [Category("MyGym")]
        public int DigitosMaximo
        {
            get => this.txtDescripcion.MaxLength;
            set => this.txtDescripcion.MaxLength = value;
        }

        [Category("MyGym")]
        public string Mascara
        {
            get => this.txtDescripcion.Mask;
            set => this.txtDescripcion.Mask = value;
        }

        public bool Validar()
        {
            if (!this.esObligatorio) return true;

            if (string.IsNullOrWhiteSpace(this.txtDescripcion.Text) || this.GetValor() == 0)
            {
                MessageBox.Show("El campo " + this.lblDescripcion.Text + "está incompleto, por favor completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        public decimal GetValor()
        {
            if (string.IsNullOrEmpty(this.txtDescripcion.Text)) return 0M;
            else
            {
                var partes = this.txtDescripcion.Text.Split(',');

                if (!int.TryParse(partes[0].Replace('_', '0'), out var entero))
                    entero = 0;
                                
                if (!int.TryParse(partes[1].Trim().Replace('_', '0').TrimEnd('M', '2'), out var parteDecimal))
                    parteDecimal = 0;

                var decimales = parteDecimal >= 10 || partes[1].StartsWith("0") 
                                ? parteDecimal * Math.Pow(10, -2) : parteDecimal * Math.Pow(10, -1);

                var numero = entero + decimales;

                return Convert.ToDecimal(numero);
            }
        }

        public void SetValor(decimal valor)
        {
            this.txtDescripcion.Text = valor.ToString("000000.00");
        }

        private void SetearMascara() => this.txtDescripcion.Mask = "{double:9." + this.decimales + "}";

        private int decimales;

        [Category("Solver"), DefaultValue(2)]
        public int Decimales
        {
            get => this.decimales;

            set
            {
                this.decimales = value;
                this.SetearMascara();
            }
        }

        //protected void LeerTeclado(KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Enter:
        //            this.codigo = $"0{this.codigo.TrimStart('0')}";
        //            this.SetValor(this.codigo);
        //            this.codigo = string.Empty;
        //            break;

        //        case Keys.Back:
        //            this.codigo = this.GetValor().Trim().TrimStart('-');
        //            break;

        //        default:
        //            var caracter = (char)e.KeyValue;
        //            if (this.codigo.Length == 12)
        //            {
        //                this.codigo = this.codigo.Substring(1, 11) + caracter;
        //            }
        //            else
        //            {
        //                this.codigo += caracter;
        //            }

        //            break;
        //    }
        //}
    }
}
