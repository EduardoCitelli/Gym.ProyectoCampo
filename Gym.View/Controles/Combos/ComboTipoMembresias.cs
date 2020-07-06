namespace Gym.View
{
    using System.Data;
    using System.Linq;
    using Gym.Controladora;
    using Gym.Domain;

    public partial class ComboTipoMembresias : ComboBase, IComboBase
    {
        private readonly TipoMembresiasController Controller;

        public ComboTipoMembresias()
        {
            this.InitializeComponent();
            this.Controller = new TipoMembresiasController();
        }

        public TipoMembresias GetValor() => (TipoMembresias)this.combo.SelectedItem;

        public void ObtenerObjetos() => this.combo.DataSource = this.Controller.Listar().ToList();

        public void SetValor(int idEntity) => this.combo.SelectedValue = idEntity;

        public void Refrescar()
        {
            this.combo.DataSource = null;

            var lista = this.Controller.Listar().ToList();

            this.combo.DataSource = lista.OrderBy(x => x.tmm_Id).ToList();

            this.combo.DisplayMember = nameof(TipoMembresias.tmm_Descripcion);

            this.combo.ValueMember = nameof(TipoMembresias.tmm_Id);
        }
    }
}
