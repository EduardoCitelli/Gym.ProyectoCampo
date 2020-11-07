namespace Gym.View
{
    using System.ComponentModel;
    using System.Drawing;
    
    public abstract partial class ComboBase : MyGymControl, IComboBase
    {
        public ComboBase()
        {
            this.InitializeComponent();
        }

        [Category("MyGym"), DefaultValue("Titulo")]
        public string Titulo
        {
            get => this.lbl.Text;
            set => this.lbl.Text = value;
        }

        [Category("MyGym")]
        public Color LabelBackColor
        {
            get => this.lbl.BackColor;
            set => this.lbl.BackColor = value;
        }

        [Category("MyGym")]
        public Color ColorTexto
        {
            get => this.lbl.ForeColor;
            set => this.lbl.ForeColor = value;
        }

        [Category("MyGym")]
        public Font FontLabel
        {
            get => this.lbl.Font;
            set => this.lbl.Font = value;
        }

        [Category("MyGym"), DefaultValue(false)]
        public bool PermitirValorCero { get; set; }        

        public void Focalizar() => this.combo.Focus();

        public bool HasFocus() => this.combo.Focused;

        protected abstract void ObtenerObjetos();

        public abstract void Refrescar();

        public abstract void SetValor(int idEntity);

        private void combo_ValueMemberChanged(object sender, System.EventArgs e) => this.OnValueChanged();

        private void combo_SelectedIndexChanged(object sender, System.EventArgs e) => this.OnValueChanged();

        //public virtual T GetObjeto<T>() where T : class
        //{
        //    var ds = (IEnumerable<T>)this.combo.DataSource;
        //    var value = this.GetValor();
        //    var result = value == null ? null : ds.SingleOrDefault(obj => (int)typeof(T).GetProperty(this.ObtenerValueMember()).GetValue(obj) == (int)value);
        //    return result;
        //}

        //public object GetDataSource() => this.combo.DataSource;

        //public object valorASeleccionar { get; set; }

        //protected abstract string ObtenerValueMember();

        //protected abstract object ObtenerDatos();

        //public virtual T GetValor<T>() where T : class => this.combo.IsDisposed ? null : (T)this.combo.SelectedValue;

        //public virtual void SetValor(object value)
        //{
        //    this.valorASeleccionar = value;
        //    var cambiarPorNull = value is int && (int)value == 0 && !this.PermitirValorCero;
        //    this.combo.SelectedValue = cambiarPorNull ? null : value;
        //}
    }
}
