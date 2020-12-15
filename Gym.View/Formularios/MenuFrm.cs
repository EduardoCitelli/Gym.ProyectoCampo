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

            this.picLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            this.picLogo.Anchor = AnchorStyles.None;

            this.AjustarImagen();
        }

        private void AjustarImagen()
        {
            this.picLogo.Location = new Point(this.picLogo.Parent.ClientSize.Width / 2 - this.picLogo.Width / 2, this.picLogo.Parent.ClientSize.Height / 2 - this.picLogo.Height / 2);
            this.picLogo.Refresh();
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

            if (Application.OpenForms[nameof(DbBackupFrm)] == null)
                this.btnBackup.BackColor = Color.Transparent;
        }

        private void btnUsuarios_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarUsuariosFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void btnGrupos_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarGruposFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void btnTipoMembresias_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarTiposMembresiaFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void btnMembresias_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarMembresiasFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void btnActividades_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarActividadesFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void btnSalones_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarSalonesFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void btnSocios_Click(object sender, EventArgs e)
            => this.Manager.AbrirFormulario<GestionarSociosFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void btnProfesores_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarProfesoresFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void btnClases_Click(object sender, EventArgs e) 
            => this.Manager.AbrirFormulario<GestionarClasesFrm>(this.pnlFormularios, this, sender, string.Empty);

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
                    this.dropDownMembresias.Visible = false;
                    this.toolUsuarios.Visible = false;
                    this.lOGSToolStripMenuItem.Visible = false;
                    this.btnProfesores.Visible = false;
                    this.btnBackup.Visible = false;
                    this.btnSalones.Visible = false;
                    this.reportesVariosToolStripMenuItem.Visible = false;
                    this.ventasToolStripMenuItem.Visible = false;
                    break;

                case (int)EnumTipoUsuarios.DueñoGimnasio:
                    this.dropDownMembresias.Visible = false;
                    this.toolUsuarios.Visible = false;
                    this.lOGSToolStripMenuItem.Visible = false;
                    break;
            }
        }

        private void BtnHorariosSemana_Click(object sender, EventArgs e) => this.Manager.AbrirFormulario<NavegableFrm>(this.pnlFormularios, this, sender, UrlNavegables.GetUrlHorarios());

        private void btnBackup_Click(object sender, EventArgs e) => this.Manager.AbrirFormulario<DbBackupFrm>(this.pnlFormularios, this, sender, string.Empty);

        private void LOGSToolStripMenuItem_Click(object sender, EventArgs e) => this.Manager.AbrirFormulario<NavegableFrm>(this.pnlFormularios, this, sender, UrlNavegables.GetUrlLogs());

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e) => this.Manager.AbrirFormulario<NavegableFrm>(this.pnlFormularios, this, sender, UrlNavegables.GetUrlVentas());

        private void ReportesVariosToolStripMenuItem_Click(object sender, EventArgs e) => this.Manager.AbrirFormulario<NavegableFrm>(this.pnlFormularios, this, sender, UrlNavegables.GetUrlDatos());

        private void pbPanel_DoubleClick(object sender, EventArgs e)
        {
            var frm = new CambiarPassFrm();
            frm.ShowDialog();
        }

        
    }
}