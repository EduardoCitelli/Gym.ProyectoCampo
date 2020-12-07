namespace Gym.View
{
    using Gym.Auditoria;
    using System;
    using System.Windows.Forms;

    public partial class FormGestionarBase : Form
    {
        protected LogService log = LogService.GetInstancia();

        public FormGestionarBase()
        {
            this.InitializeComponent();
        }

        protected bool NoSelecciono() => this.grd.CurrentRow == null;

        protected bool ValidarEliminar()
        {
            if (this.NoSelecciono())
            {
                var solucion = "Debe Seleccionar un elemento de la grilla para eliminar";
                var caption = "Eliminar";
                MessageBox.Show(solucion, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        protected virtual bool ValidarModificar()
        {
            if (this.NoSelecciono())
            {
                var solucion = "Debe Seleccionar un elemento de la grilla para Modificar";
                var caption = "Modificar";
                MessageBox.Show(solucion, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        protected int ObtenerCodigo(string nombreColumna) => Convert.ToInt32(this.grd.CurrentRow.Cells[nombreColumna].Value);

        protected string ObtenerDescripcion(string nombreColumna) => this.grd.CurrentRow.Cells[nombreColumna].Value.ToString();
    }
}