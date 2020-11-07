namespace Gym.View
{
    using System.Linq;
    using Gym.Controladora;
    using Gym.Domain;

    public partial class ComboActividad : ComboBase
    {
        private readonly ActividadesController actividadesController;

        public ComboActividad()
        {
            this.InitializeComponent();
            this.actividadesController = new ActividadesController();
        }

        public Actividades GetValor() => (Actividades)this.combo.SelectedItem;

        protected override void ObtenerObjetos() => this.combo.DataSource = this.actividadesController.Listar().ToList();

        public override void SetValor(int idEntity) => this.combo.SelectedValue = idEntity;

        public override void Refrescar()
        {
            this.combo.DataSource = null;

            this.ObtenerObjetos();

            this.combo.DisplayMember = nameof(Actividades.act_Descripcion);
            this.combo.ValueMember = nameof(Actividades.act_Codigo);
        }
    }
}