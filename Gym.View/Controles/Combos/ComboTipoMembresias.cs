namespace Gym.View
{
    using System.Data;
    using System.Linq;
    using Gym.Controladora;
    using Gym.Domain;

    public partial class ComboTipoMembresias : ComboBase
    {
        private readonly TipoMembresiasController Controller;

        public ComboTipoMembresias()
        {
            this.InitializeComponent();
            this.Controller = new TipoMembresiasController();
        }

        public TipoMembresias GetValor() => (TipoMembresias)this.combo.SelectedItem;

        protected override void ObtenerObjetos() => this.combo.DataSource = this.Controller.Listar().ToList();

        public override void SetValor(int idEntity) => this.combo.SelectedValue = idEntity;

        public override void Refrescar()
        {
            this.combo.DataSource = null;

            this.ObtenerObjetos();

            this.combo.DisplayMember = nameof(TipoMembresias.tmm_Descripcion);

            this.combo.ValueMember = nameof(TipoMembresias.tmm_Id);
        }
    }
}
