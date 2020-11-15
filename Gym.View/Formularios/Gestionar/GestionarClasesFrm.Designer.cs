namespace Gym.View
{
    partial class GestionarClasesFrm
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
            this.btnAddAlumno = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.chkAlta = new Gym.View.MyGymChkBox();
            this.chkPendiente = new Gym.View.MyGymChkBox();
            this.btnBajaClase = new System.Windows.Forms.Button();
            this.btnAgregarClaseRecurrente = new System.Windows.Forms.Button();
            this.pnlBotones.SuspendLayout();
            this.pnlActualizar.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.pnlGrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnAgregarClaseRecurrente);
            this.pnlBotones.Controls.Add(this.btnAddAlumno);
            this.pnlBotones.Controls.Add(this.btnBajaClase);
            this.pnlBotones.Controls.Add(this.btnAlta);
            this.pnlBotones.Location = new System.Drawing.Point(0, 598);
            this.pnlBotones.Size = new System.Drawing.Size(1048, 66);
            this.pnlBotones.Controls.SetChildIndex(this.pnlActualizar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnAgregar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnBorrar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnModificar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnAlta, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnBajaClase, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnAddAlumno, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnAgregarClaseRecurrente, 0);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.Location = new System.Drawing.Point(173, 5);
            this.btnModificar.Size = new System.Drawing.Size(84, 52);
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.Location = new System.Drawing.Point(89, 5);
            this.btnBorrar.Size = new System.Drawing.Size(84, 52);
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Location = new System.Drawing.Point(5, 5);
            this.btnAgregar.Size = new System.Drawing.Size(84, 52);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.Location = new System.Drawing.Point(869, 5);
            this.pnlActualizar.Size = new System.Drawing.Size(170, 52);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Location = new System.Drawing.Point(86, 0);
            this.btnCerrar.Size = new System.Drawing.Size(84, 52);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.Location = new System.Drawing.Point(0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(86, 52);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Size = new System.Drawing.Size(1052, 668);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.chkPendiente);
            this.gbFiltros.Controls.Add(this.chkAlta);
            this.gbFiltros.Size = new System.Drawing.Size(1048, 65);
            this.gbFiltros.Controls.SetChildIndex(this.txtFiltroNombre, 0);
            this.gbFiltros.Controls.SetChildIndex(this.label1, 0);
            this.gbFiltros.Controls.SetChildIndex(this.chkAlta, 0);
            this.gbFiltros.Controls.SetChildIndex(this.chkPendiente, 0);
            // 
            // pnlGrd
            // 
            this.pnlGrd.Size = new System.Drawing.Size(1048, 507);
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.Size = new System.Drawing.Size(1048, 15);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.Text = "Descripción:";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(129, 31);
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1048, 26);
            this.lblTitulo.Titulo = "Clases";
            // 
            // btnAddAlumno
            // 
            this.btnAddAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAlumno.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddAlumno.FlatAppearance.BorderSize = 0;
            this.btnAddAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAlumno.Location = new System.Drawing.Point(425, 5);
            this.btnAddAlumno.Name = "btnAddAlumno";
            this.btnAddAlumno.Size = new System.Drawing.Size(96, 52);
            this.btnAddAlumno.TabIndex = 5;
            this.btnAddAlumno.Text = "Agregar/Eliminar Alumnos";
            this.btnAddAlumno.UseVisualStyleBackColor = false;
            this.btnAddAlumno.Click += new System.EventHandler(this.btnAddAlumno_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.Transparent;
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlta.FlatAppearance.BorderSize = 0;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlta.Location = new System.Drawing.Point(257, 5);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(84, 52);
            this.btnAlta.TabIndex = 7;
            this.btnAlta.Text = "Alta Clase";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // chkAlta
            // 
            this.chkAlta.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkAlta.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.chkAlta.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlta.Location = new System.Drawing.Point(244, 24);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(201, 26);
            this.chkAlta.TabIndex = 2;
            this.chkAlta.Titulo = "Alta:";
            this.chkAlta.ValueChanged += new System.EventHandler(this.chkAlta_ValueChanged);
            // 
            // chkPendiente
            // 
            this.chkPendiente.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkPendiente.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.chkPendiente.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPendiente.Location = new System.Drawing.Point(451, 23);
            this.chkPendiente.Name = "chkPendiente";
            this.chkPendiente.Size = new System.Drawing.Size(201, 26);
            this.chkPendiente.TabIndex = 3;
            this.chkPendiente.Titulo = "Pendiente:";
            this.chkPendiente.ValueChanged += new System.EventHandler(this.chkPendiente_ValueChanged);
            // 
            // btnBajaClase
            // 
            this.btnBajaClase.BackColor = System.Drawing.Color.Transparent;
            this.btnBajaClase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBajaClase.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBajaClase.FlatAppearance.BorderSize = 0;
            this.btnBajaClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaClase.Location = new System.Drawing.Point(341, 5);
            this.btnBajaClase.Name = "btnBajaClase";
            this.btnBajaClase.Size = new System.Drawing.Size(84, 52);
            this.btnBajaClase.TabIndex = 8;
            this.btnBajaClase.Text = "Baja Clase";
            this.btnBajaClase.UseVisualStyleBackColor = false;
            this.btnBajaClase.Click += new System.EventHandler(this.btnBajaClase_Click);
            // 
            // btnAgregarClaseRecurrente
            // 
            this.btnAgregarClaseRecurrente.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarClaseRecurrente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarClaseRecurrente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarClaseRecurrente.FlatAppearance.BorderSize = 0;
            this.btnAgregarClaseRecurrente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarClaseRecurrente.Location = new System.Drawing.Point(521, 5);
            this.btnAgregarClaseRecurrente.Name = "btnAgregarClaseRecurrente";
            this.btnAgregarClaseRecurrente.Size = new System.Drawing.Size(96, 52);
            this.btnAgregarClaseRecurrente.TabIndex = 9;
            this.btnAgregarClaseRecurrente.Text = "Agregar Clase Recurrente";
            this.btnAgregarClaseRecurrente.UseVisualStyleBackColor = false;
            this.btnAgregarClaseRecurrente.Click += new System.EventHandler(this.btnAgregarClaseRecurrente_Click);
            // 
            // GestionarClasesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 668);
            this.Name = "GestionarClasesFrm";
            this.Text = "GestionarClases";
            this.pnlBotones.ResumeLayout(false);
            this.pnlActualizar.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.pnlGrd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddAlumno;
        private System.Windows.Forms.Button btnAlta;
        private MyGymChkBox chkPendiente;
        private MyGymChkBox chkAlta;
        private System.Windows.Forms.Button btnBajaClase;
        private System.Windows.Forms.Button btnAgregarClaseRecurrente;
    }
}