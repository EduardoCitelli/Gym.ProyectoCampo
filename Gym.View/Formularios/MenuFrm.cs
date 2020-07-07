namespace Gym.View
{    
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Common;
    using Common.Cache;

    public partial class MenuFrm : Form
    {
        private readonly FormulariosManager Manager;

        public MenuFrm()
        {
            this.InitializeComponent();

            this.lblUsuario.Titulo = UserLogeado.UserName;

            this.lblGrupo.Titulo = UserLogeado.TipoUsuario;

            this.Manager = new FormulariosManager();
        }

        public void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms[nameof(GestionarUsuariosFrm)] == null)
                this.toolUsuarios.BackColor = Color.Transparent;

            if (Application.OpenForms[nameof(GestionarGruposFrm)] == null)
                this.toolUsuarios.BackColor = Color.Transparent;

            if (Application.OpenForms[nameof(GestionarTiposMembresiaFrm)] == null)
                this.dropDownMembresias.BackColor = Color.Transparent;

            if (Application.OpenForms[nameof(GestionarMembresiasFrm)] == null)
                this.dropDownMembresias.BackColor = Color.Transparent;

            if (Application.OpenForms[nameof(GestionarActividadesFrm)] == null)
                this.btnActividades.BackColor = Color.Transparent;

            if (Application.OpenForms[nameof(GestionarSalonesFrm)] == null)
                this.btnSalones.BackColor = Color.Transparent;

            if (Application.OpenForms[nameof(GestionarProfesoresFrm)] == null)
                this.btnProfesores.BackColor = Color.Transparent;

            if (Application.OpenForms[nameof(GestionarSociosFrm)] == null)
                this.btnSocios.BackColor = Color.Transparent;

            if (Application.OpenForms[nameof(GestionarClasesFrm)] == null)
                this.btnClases.BackColor = Color.Transparent;
        }

        private void btnUsuarios_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarUsuariosFrm>(this.pnlFormularios, this, sender);

        private void btnGrupos_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarGruposFrm>(this.pnlFormularios, this, sender);

        private void btnTipoMembresias_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarTiposMembresiaFrm>(this.pnlFormularios, this, sender);

        private void btnMembresias_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarMembresiasFrm>(this.pnlFormularios, this, sender);

        private void btnActividades_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarActividadesFrm>(this.pnlFormularios, this, sender);

        private void btnSalones_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarSalonesFrm>(this.pnlFormularios, this, sender);

        private void btnSocios_Click(object sender, EventArgs e)
            => this.Manager.AbrirFormulario<GestionarSociosFrm>(this.pnlFormularios, this, sender);

        private void btnProfesores_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarProfesoresFrm>(this.pnlFormularios, this, sender);

        private void btnClases_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarClasesFrm>(this.pnlFormularios, this, sender);

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var mensaje = MessageBox.Show("¿Desea desconectarse?", $"Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensaje == DialogResult.Yes) this.Close();
        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {
            switch (UserLogeado.NumeroTipoUsuario)
            {
                case (int)EnumTipoUsuarios.EmpAdministrativo:
                    this.toolConfiguracion.Visible = false;
                    this.btnProfesores.Visible = false;
                    break;

                case (int)EnumTipoUsuarios.DueñoGimnasio:
                    this.toolConfiguracion.Visible = false;
                    break;
            }
        }        
    }
}