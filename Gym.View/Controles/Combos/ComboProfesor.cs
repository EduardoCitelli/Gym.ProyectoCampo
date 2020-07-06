namespace Gym.View
{
    using Gym.Controladora;
    using Gym.Domain;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    
    public partial class ComboProfesor : ComboBase, IComboBase
    {
        private readonly ProfesoresController profesoresController;

        public ComboProfesor()
        {
            this.InitializeComponent();
            this.profesoresController = new ProfesoresController();
        }

        [Category("MyGym"), DefaultValue(false)]
        public bool PermiteNulo { get; set; }

        public Profesores GetValor() => (Profesores)this.combo.SelectedItem;

        public void ObtenerObjetos() => this.combo.DataSource = this.profesoresController.Listar().ToList();        

        private void ObtenerObjetosConNulo()
        {
            var lista = new List<Profesores>();

            lista.Add(new Profesores() { pro_Codigo = 0, pro_Nombre = "" });

            lista.AddRange(this.profesoresController.Listar().ToList());

            this.combo.DataSource = lista.OrderBy(x => x.pro_Codigo).ToList();
        }

        public void SetValor(int idEntity) => this.combo.SelectedValue = idEntity;

        public void Refrescar()
        {
            this.combo.DataSource = null;

            if (!this.PermiteNulo) this.ObtenerObjetos();
            else this.ObtenerObjetosConNulo();

            this.combo.DisplayMember = nameof(Profesores.pro_Nombre);
            this.combo.ValueMember = nameof(Profesores.pro_Codigo);
        }
    }
}