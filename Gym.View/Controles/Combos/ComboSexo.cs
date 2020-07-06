namespace Gym.View.Controles
{
    using System.Collections.Generic;
    
    public partial class ComboSexo : ComboBase
    {
        private List<SexoModel> source = new List<SexoModel>();

        public ComboSexo()
        {
            this.InitializeComponent();
        }

        public void ObtenerObjetos()
        {            
            this.source.Add(new SexoModel() { Valor = "M", Descripcion= "Masculino" });
            this.source.Add(new SexoModel() { Valor = "F", Descripcion = "Femenino" });

            this.combo.DataSource = this.source;
        }

        public void Refrescar()
        {
            this.combo.DataSource = null;

            this.ObtenerObjetos();

            this.combo.DisplayMember = nameof(SexoModel.Descripcion);
            this.combo.ValueMember = nameof(SexoModel.Valor);
        }

        public void SetValor(string valor) => this.combo.SelectedValue = valor;

        public string GetValor() => ((SexoModel)this.combo.SelectedItem).Valor;
    }
}
