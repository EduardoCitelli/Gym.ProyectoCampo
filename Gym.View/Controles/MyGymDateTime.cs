namespace Gym.View
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;

    public partial class MyGymDateTime : MyGymControl
    {
        public MyGymDateTime()
        {
            this.InitializeComponent();
        }

        [Category("MyGym")]
        public string Descripcion
        {
            get => this.myGymDate1.Descripcion;

            set => this.myGymDate1.Descripcion = value;
        }

        [Category("MyGym"), DefaultValue(true)]
        public bool Habilitado
        {
            get => this.myGymDate1.Habilitado;

            set
            {
                this.myGymDate1.Habilitado = value;
                this.TabStop = value;
                this.HabilitarHora();
            }
        }

        //[Category("MyGym"), DefaultValue(true)]
        //public bool Requerido
        //{
        //    get
        //    {
        //        return this.svrDate1.Requerido;
        //    }

        //    set
        //    {
        //        this.svrDate1.Requerido = value;
        //    }
        //}

        public void Focalizar() => this.myGymDate1.Focalizar();

        public void SetValor(DateTime? value)
        {
            var valorAnt = this.GetValor();

            if (value.HasValue)
            {
                if (!valorAnt.HasValue || value.Value != valorAnt.Value)
                {
                    this.myGymDate1.SetValor(value.Value);
                    this.txtHora.Text = FormatHoraMinuto(value.Value.Hour.ToString(CultureInfo.InvariantCulture)) + FormatHoraMinuto(value.Value.Minute.ToString(CultureInfo.InvariantCulture));
                    //this.OnValueChanged();
                }
            }
            else
            {
                if (valorAnt.HasValue)
                {
                    this.myGymDate1.SetValor(null);
                    this.txtHora.Text = @"    ";
                    //this.OnValueChanged();
                }
            }
        }

        public DateTime? GetValor()
        {
            if (this.myGymDate1.GetValor() != null)
            {
                var date = this.myGymDate1.GetValor();

                Debug.Assert(date != null, "date != null");

                var ano = date.Value.Year;

                var mes = date.Value.Month;

                var dia = date.Value.Day;

                var partesHora = this.txtHora.Text.Split(':');


                if (!int.TryParse(partesHora[0], out var hora))
                    hora = 0;

                if (!int.TryParse(partesHora[1], out var min))
                    min = 0;

                var result = new DateTime(ano, mes, dia, hora, min, 0);

                return result;
            }

            return null;
        }

        public bool HasValue() => this.myGymDate1.HasValue();

        //public void Limpiar()
        //{
        //    if (this.Requerido)
        //        this.SetValor(DateTime.Now);
        //    else
        //    {
        //        this.svrDate1.Chequeado = false;
        //        this.SetValor(null);
        //        this.txtHora.Enabled = false;
        //    }
        //}

        private static string FormatHoraMinuto(string value) => ("0" + value).Substring(value.Length - 1);

        private void HabilitarHora() => this.txtHora.Enabled = this.myGymDate1.Habilitado;

        //private void SvrDate1_ValueChanged(object sender, EventArgs e)
        //{
        //    this.HabilitarHora();
        //    this.OnValueChanged();
        //}
    }
}
