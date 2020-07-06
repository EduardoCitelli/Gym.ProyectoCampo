namespace Gym.View
{
    using System.Linq;
    using Gym.Controladora;
    using Gym.Domain;

    public partial class ComboGrupoUsuarios : ComboBase, IComboBase
    {
        private readonly GrupoUsuariosController controller;

        public ComboGrupoUsuarios()
        {
            this.InitializeComponent();
            this.controller = new GrupoUsuariosController();
        }

        public GrupoUsuarios GetValor() => (GrupoUsuarios)this.combo.SelectedItem;

        public void ObtenerObjetos() => this.combo.DataSource = this.controller.Listar().ToList();

        public void SetValor(int idGrupo) => this.combo.SelectedValue = idGrupo;

        public void Refrescar()
        {            
            this.combo.DataSource = null;

            var lista = this.controller.Listar().ToList();            

            this.combo.DataSource = lista.OrderBy(x => x.gus_Id).ToList();

            this.combo.DisplayMember = nameof(GrupoUsuarios.gus_Descripcion);

            this.combo.ValueMember = nameof(GrupoUsuarios.gus_Id);
        }        
    }
}
