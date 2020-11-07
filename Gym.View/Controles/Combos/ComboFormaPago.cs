namespace Gym.View
{
    using Gym.Domain;
    using System;

    public partial class ComboFormaPago : ComboBase
    {
        public ComboFormaPago()
        {
            this.InitializeComponent();
        }

        public EnumFormasPago GetValor() => (EnumFormasPago)this.combo.SelectedItem;

        public override void Refrescar()
        {
            this.combo.DataSource = null;

            this.ObtenerObjetos();
        }

        public override void SetValor(int idEntity) => this.combo.SelectedValue = idEntity;

        protected override void ObtenerObjetos() => this.combo.DataSource = Enum.GetValues(typeof(EnumFormasPago));
    }
}