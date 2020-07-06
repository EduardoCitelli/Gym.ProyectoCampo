namespace Gym.View
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;

    public partial class MyGymDateTimeHora : MyGymControl
    {
        public MyGymDateTimeHora()
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
                this.numHora.Enabled = value;
                this.TabStop = value;
                this.HabilitarHora();
            }
        }

        public void Focalizar() => this.myGymDate1.Focalizar();

        public void SetValor(DateTime? value)
        {
            var valorAnt = this.GetValor();

            if (value.HasValue)
            {
                if (!valorAnt.HasValue || value.Value != valorAnt.Value)
                {
                    this.myGymDate1.SetValor(value.Value);
                    this.numHora.Value = value.Value.Hour;
                    this.OnValueChanged();
                }
            }
            else
            {
                if (valorAnt.HasValue)
                {
                    this.myGymDate1.SetValor(null);
                    this.numHora.Value = 0;
                    this.OnValueChanged();
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

                var hora = Convert.ToInt32(this.numHora.Value);

                var result = new DateTime(ano, mes, dia, hora, 0, 0);

                return result;
            }

            return null;
        }

        public bool HasValue() => this.myGymDate1.HasValue();

        private void HabilitarHora() => this.numHora.Enabled = this.myGymDate1.Habilitado;
    }
}
