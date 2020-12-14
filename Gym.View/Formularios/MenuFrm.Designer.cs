namespace Gym.View
{
    partial class MenuFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFrm));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlContenedor = new Gym.View.PanelColores();
            this.pnlFormularios = new Gym.View.PanelColores();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new Gym.View.PanelColores();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnSalones = new System.Windows.Forms.Button();
            this.btnActividades = new System.Windows.Forms.Button();
            this.lblGrupo = new Gym.View.TituloLabel();
            this.lblUsuario = new Gym.View.TituloLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClases = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnSocios = new System.Windows.Forms.Button();
            this.pbPanel = new System.Windows.Forms.PictureBox();
            this.toolConfiguracion = new System.Windows.Forms.ToolStrip();
            this.dropDownMembresias = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnTipoMembresias = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMembresias = new System.Windows.Forms.ToolStripMenuItem();
            this.toolUsuarios = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnGrupo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownNavegables = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnHorariosSemana = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor.SuspendLayout();
            this.pnlFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanel)).BeginInit();
            this.toolConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnLogOut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlContenedor.ColorAbajo = System.Drawing.Color.Empty;
            this.pnlContenedor.ColorArriba = System.Drawing.Color.Empty;
            this.pnlContenedor.Controls.Add(this.pnlFormularios);
            this.pnlContenedor.Controls.Add(this.panelMenu);
            this.pnlContenedor.Controls.Add(this.toolConfiguracion);
            resources.ApplyResources(this.pnlContenedor, "pnlContenedor");
            this.pnlContenedor.Name = "pnlContenedor";
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.ColorAbajo = System.Drawing.Color.PaleGreen;
            this.pnlFormularios.ColorArriba = System.Drawing.Color.SeaGreen;
            this.pnlFormularios.Controls.Add(this.picLogo);
            resources.ApplyResources(this.pnlFormularios, "pnlFormularios");
            this.pnlFormularios.Name = "pnlFormularios";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.ColorAbajo = System.Drawing.Color.DarkSeaGreen;
            this.panelMenu.ColorArriba = System.Drawing.Color.MediumSeaGreen;
            this.panelMenu.Controls.Add(this.btnBackup);
            this.panelMenu.Controls.Add(this.btnSalones);
            this.panelMenu.Controls.Add(this.btnActividades);
            this.panelMenu.Controls.Add(this.lblGrupo);
            this.panelMenu.Controls.Add(this.lblUsuario);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnClases);
            this.panelMenu.Controls.Add(this.btnProfesores);
            this.panelMenu.Controls.Add(this.btnSocios);
            this.panelMenu.Controls.Add(this.pbPanel);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnBackup.ForeColor = System.Drawing.Color.Black;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnSalones
            // 
            this.btnSalones.BackColor = System.Drawing.Color.Transparent;
            this.btnSalones.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSalones, "btnSalones");
            this.btnSalones.FlatAppearance.BorderSize = 0;
            this.btnSalones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnSalones.ForeColor = System.Drawing.Color.Black;
            this.btnSalones.Name = "btnSalones";
            this.btnSalones.UseVisualStyleBackColor = false;
            this.btnSalones.Click += new System.EventHandler(this.btnSalones_Click);
            // 
            // btnActividades
            // 
            this.btnActividades.BackColor = System.Drawing.Color.Transparent;
            this.btnActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnActividades, "btnActividades");
            this.btnActividades.FlatAppearance.BorderSize = 0;
            this.btnActividades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnActividades.ForeColor = System.Drawing.Color.Black;
            this.btnActividades.Name = "btnActividades";
            this.btnActividades.UseVisualStyleBackColor = false;
            this.btnActividades.Click += new System.EventHandler(this.btnActividades_Click);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AlinearTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.ColorTexto = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.lblGrupo, "lblGrupo");
            this.lblGrupo.FontLabel = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.LabelBackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.TipoBorde = System.Windows.Forms.BorderStyle.None;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AlinearTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ColorTexto = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.FontLabel = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.LabelBackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.TipoBorde = System.Windows.Forms.BorderStyle.None;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // btnClases
            // 
            this.btnClases.BackColor = System.Drawing.Color.Transparent;
            this.btnClases.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnClases, "btnClases");
            this.btnClases.FlatAppearance.BorderSize = 0;
            this.btnClases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnClases.ForeColor = System.Drawing.Color.Black;
            this.btnClases.Name = "btnClases";
            this.btnClases.UseVisualStyleBackColor = false;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.BackColor = System.Drawing.Color.Transparent;
            this.btnProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnProfesores, "btnProfesores");
            this.btnProfesores.FlatAppearance.BorderSize = 0;
            this.btnProfesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnProfesores.ForeColor = System.Drawing.Color.Black;
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.UseVisualStyleBackColor = false;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnSocios
            // 
            this.btnSocios.BackColor = System.Drawing.Color.Transparent;
            this.btnSocios.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSocios, "btnSocios");
            this.btnSocios.FlatAppearance.BorderSize = 0;
            this.btnSocios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSocios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnSocios.ForeColor = System.Drawing.Color.Black;
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.UseVisualStyleBackColor = false;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // pbPanel
            // 
            this.pbPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbPanel, "pbPanel");
            this.pbPanel.Name = "pbPanel";
            this.pbPanel.TabStop = false;
            // 
            // toolConfiguracion
            // 
            this.toolConfiguracion.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.toolConfiguracion, "toolConfiguracion");
            this.toolConfiguracion.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolConfiguracion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropDownMembresias,
            this.toolUsuarios,
            this.dropDownNavegables});
            this.toolConfiguracion.Name = "toolConfiguracion";
            this.toolConfiguracion.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolConfiguracion.TabStop = true;
            // 
            // dropDownMembresias
            // 
            this.dropDownMembresias.AutoToolTip = false;
            this.dropDownMembresias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTipoMembresias,
            this.btnMembresias});
            resources.ApplyResources(this.dropDownMembresias, "dropDownMembresias");
            this.dropDownMembresias.Name = "dropDownMembresias";
            this.dropDownMembresias.ShowDropDownArrow = false;
            // 
            // btnTipoMembresias
            // 
            this.btnTipoMembresias.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnTipoMembresias, "btnTipoMembresias");
            this.btnTipoMembresias.Name = "btnTipoMembresias";
            this.btnTipoMembresias.Click += new System.EventHandler(this.btnTipoMembresias_Click);
            // 
            // btnMembresias
            // 
            resources.ApplyResources(this.btnMembresias, "btnMembresias");
            this.btnMembresias.Name = "btnMembresias";
            this.btnMembresias.Click += new System.EventHandler(this.btnMembresias_Click);
            // 
            // toolUsuarios
            // 
            this.toolUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGrupo,
            this.btnUsuarios});
            resources.ApplyResources(this.toolUsuarios, "toolUsuarios");
            this.toolUsuarios.Name = "toolUsuarios";
            this.toolUsuarios.ShowDropDownArrow = false;
            // 
            // btnGrupo
            // 
            resources.ApplyResources(this.btnGrupo, "btnGrupo");
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnUsuarios
            // 
            resources.ApplyResources(this.btnUsuarios, "btnUsuarios");
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // dropDownNavegables
            // 
            this.dropDownNavegables.AutoToolTip = false;
            this.dropDownNavegables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHorariosSemana,
            this.lOGSToolStripMenuItem,
            this.ventasToolStripMenuItem});
            resources.ApplyResources(this.dropDownNavegables, "dropDownNavegables");
            this.dropDownNavegables.Name = "dropDownNavegables";
            this.dropDownNavegables.ShowDropDownArrow = false;
            // 
            // btnHorariosSemana
            // 
            this.btnHorariosSemana.Image = global::Gym.View.Properties.Resources.calendar_week;
            this.btnHorariosSemana.Name = "btnHorariosSemana";
            resources.ApplyResources(this.btnHorariosSemana, "btnHorariosSemana");
            this.btnHorariosSemana.Click += new System.EventHandler(this.BtnHorariosSemana_Click);
            // 
            // lOGSToolStripMenuItem
            // 
            resources.ApplyResources(this.lOGSToolStripMenuItem, "lOGSToolStripMenuItem");
            this.lOGSToolStripMenuItem.Name = "lOGSToolStripMenuItem";
            this.lOGSToolStripMenuItem.Click += new System.EventHandler(this.LOGSToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            resources.ApplyResources(this.ventasToolStripMenuItem, "ventasToolStripMenuItem");
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.VentasToolStripMenuItem_Click);
            // 
            // MenuFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogOut;
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MenuFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuFrm_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanel)).EndInit();
            this.toolConfiguracion.ResumeLayout(false);
            this.toolConfiguracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelColores panelMenu;
        private System.Windows.Forms.Button btnClases;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnSocios;
        private PanelColores pnlContenedor;
        private System.Windows.Forms.PictureBox pbPanel;
        private System.Windows.Forms.Label label1;
        private PanelColores pnlFormularios;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolConfiguracion;
        private System.Windows.Forms.ToolStripDropDownButton dropDownMembresias;
        private System.Windows.Forms.ToolStripMenuItem btnTipoMembresias;
        private System.Windows.Forms.ToolStripMenuItem btnMembresias;
        private TituloLabel lblGrupo;
        private TituloLabel lblUsuario;
        private System.Windows.Forms.Button btnActividades;
        private System.Windows.Forms.ToolStripDropDownButton toolUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnGrupo;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.Button btnSalones;
        private System.Windows.Forms.ToolStripDropDownButton dropDownNavegables;
        private System.Windows.Forms.ToolStripMenuItem btnHorariosSemana;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.ToolStripMenuItem lOGSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    }
}