namespace Gym.View
{
    using System.Linq;
    using Gym.Domain;
    using Gym.Controladora;

    public partial class ComboSalon : ComboBase, IComboBase
    {
        private readonly SalonesController salonesController;

        public ComboSalon()
        {
            this.InitializeComponent();
            this.salonesController = new SalonesController();
        }

        public Salones GetValor() => (Salones)this.combo.SelectedItem;

        public void ObtenerObjetos() => this.combo.DataSource = this.salonesController.Listar().ToList();

        public void SetValor(int idEntity) => this.combo.SelectedValue = idEntity;

        public void Refrescar()
        {
            this.combo.DataSource = null;

            this.ObtenerObjetos();

            this.combo.DisplayMember = nameof(Salones.sal_Descripcion);
            this.combo.ValueMember = nameof(Salones.sal_Codigo);
        }
    }
}
