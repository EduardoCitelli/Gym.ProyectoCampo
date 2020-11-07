namespace Gym.View
{
    using System.Linq;
    using Gym.Controladora;
    using Gym.Domain;

    public partial class ComboMembresias : ComboBase
    {
        private readonly MembresiasController controller;

        public ComboMembresias()
        {
            this.InitializeComponent();
            this.controller = new MembresiasController();
        }

        protected override void ObtenerObjetos() => this.combo.DataSource = this.controller.Listar().ToList();

        public Membresias GetValor() => (Membresias)this.combo.SelectedItem;

        public override void SetValor(int idEntity) => this.combo.SelectedValue = idEntity;

        public override void Refrescar()
        {
            this.combo.DataSource = null;

            this.ObtenerObjetos();

            this.combo.DisplayMember = nameof(Membresias.mem_Descripcion);
            this.combo.ValueMember = nameof(Membresias.mem_Codigo);
        }
    }
}
