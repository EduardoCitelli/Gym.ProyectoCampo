namespace Gym.View
{
    using System.Linq;
    using Gym.Controladora;
    using Gym.Domain;

    public partial class ComboGrupoUsuarios : ComboBase
    {
        private readonly GrupoUsuariosController controller;

        public ComboGrupoUsuarios()
        {
            this.InitializeComponent();
            this.controller = new GrupoUsuariosController();
        }

        public GrupoUsuarios GetValor() => (GrupoUsuarios)this.combo.SelectedItem;

        protected override void ObtenerObjetos() => this.combo.DataSource = this.controller.Listar().ToList();

        public override void SetValor(int idGrupo) => this.combo.SelectedValue = idGrupo;

        public override void Refrescar()
        {            
            this.combo.DataSource = null;

            var lista = this.controller.Listar().ToList();            

            this.combo.DataSource = lista.OrderBy(x => x.gus_Id).ToList();

            this.combo.DisplayMember = nameof(GrupoUsuarios.gus_Descripcion);

            this.combo.ValueMember = nameof(GrupoUsuarios.gus_Id);
        }        
    }
}
