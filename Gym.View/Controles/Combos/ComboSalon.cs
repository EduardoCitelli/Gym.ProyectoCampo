namespace Gym.View
{
    using System.Linq;
    using Gym.Domain;
    using Gym.Controladora;

    public partial class ComboSalon : ComboBase
    {
        private readonly SalonesController salonesController;

        public ComboSalon()
        {
            this.InitializeComponent();
            this.salonesController = new SalonesController();
        }

        public Salones GetValor() => (Salones)this.combo.SelectedItem;

        protected override void ObtenerObjetos() => this.combo.DataSource = this.salonesController.Listar().ToList();

        public override void SetValor(int idEntity) => this.combo.SelectedValue = idEntity;

        public override void Refrescar()
        {
            this.combo.DataSource = null;

            this.ObtenerObjetos();

            this.combo.DisplayMember = nameof(Salones.sal_Descripcion);
            this.combo.ValueMember = nameof(Salones.sal_Codigo);
        }
    }
}
