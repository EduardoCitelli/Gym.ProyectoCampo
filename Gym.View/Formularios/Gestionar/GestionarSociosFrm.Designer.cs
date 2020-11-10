namespace Gym.View
{
    partial class GestionarSociosFrm
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
            this.btnVerClases = new System.Windows.Forms.Button();
            this.btnProcesarPago = new System.Windows.Forms.Button();
            this.btnVerificarVenc = new System.Windows.Forms.Button();
            this.numCodigoSocio = new Gym.View.MyGymEntero();
            this.chkActivos = new Gym.View.MyGymChkBox();
            this.pnlBotones.SuspendLayout();
            this.pnlActualizar.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.pnlGrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnVerificarVenc);
            this.pnlBotones.Controls.Add(this.btnProcesarPago);
            this.pnlBotones.Controls.Add(this.btnVerClases);
            this.pnlBotones.Location = new System.Drawing.Point(0, 704);
            this.pnlBotones.Size = new System.Drawing.Size(1263, 66);
            this.pnlBotones.Controls.SetChildIndex(this.pnlActualizar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnAgregar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnBorrar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnModificar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnVerClases, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnProcesarPago, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnVerificarVenc, 0);
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
            this.pnlActualizar.Location = new System.Drawing.Point(1069, 5);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Location = new System.Drawing.Point(20, 0);
            this.btnCerrar.Size = new System.Drawing.Size(84, 52);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.Location = new System.Drawing.Point(104, 0);
            this.btnActualizar.Size = new System.Drawing.Size(81, 52);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Size = new System.Drawing.Size(1267, 774);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.chkActivos);
            this.gbFiltros.Controls.Add(this.numCodigoSocio);
            this.gbFiltros.Size = new System.Drawing.Size(1263, 65);
            this.gbFiltros.Controls.SetChildIndex(this.txtFiltroNombre, 0);
            this.gbFiltros.Controls.SetChildIndex(this.label1, 0);
            this.gbFiltros.Controls.SetChildIndex(this.numCodigoSocio, 0);
            this.gbFiltros.Controls.SetChildIndex(this.chkActivos, 0);
            // 
            // pnlGrd
            // 
            this.pnlGrd.Size = new System.Drawing.Size(1263, 613);
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.Size = new System.Drawing.Size(1263, 15);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(314, 26);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(399, 26);
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(1263, 26);
            this.lblTitulo.Titulo = "Socios";
            // 
            // btnVerClases
            // 
            this.btnVerClases.BackColor = System.Drawing.Color.Transparent;
            this.btnVerClases.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerClases.FlatAppearance.BorderSize = 0;
            this.btnVerClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClases.Location = new System.Drawing.Point(257, 5);
            this.btnVerClases.Name = "btnVerClases";
            this.btnVerClases.Size = new System.Drawing.Size(84, 52);
            this.btnVerClases.TabIndex = 5;
            this.btnVerClases.Text = "Ver Clases";
            this.btnVerClases.UseVisualStyleBackColor = false;
            this.btnVerClases.Click += new System.EventHandler(this.btnVerClases_Click);
            // 
            // btnProcesarPago
            // 
            this.btnProcesarPago.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesarPago.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProcesarPago.FlatAppearance.BorderSize = 0;
            this.btnProcesarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarPago.Location = new System.Drawing.Point(341, 5);
            this.btnProcesarPago.Name = "btnProcesarPago";
            this.btnProcesarPago.Size = new System.Drawing.Size(84, 52);
            this.btnProcesarPago.TabIndex = 6;
            this.btnProcesarPago.Text = "Procesar Pago";
            this.btnProcesarPago.UseVisualStyleBackColor = false;
            this.btnProcesarPago.Click += new System.EventHandler(this.btnProcesarPago_Click);
            // 
            // btnVerificarVenc
            // 
            this.btnVerificarVenc.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificarVenc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerificarVenc.FlatAppearance.BorderSize = 0;
            this.btnVerificarVenc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarVenc.Location = new System.Drawing.Point(425, 5);
            this.btnVerificarVenc.Name = "btnVerificarVenc";
            this.btnVerificarVenc.Size = new System.Drawing.Size(100, 52);
            this.btnVerificarVenc.TabIndex = 7;
            this.btnVerificarVenc.Text = "Verificar Vencimientos Membresías";
            this.btnVerificarVenc.UseVisualStyleBackColor = false;
            this.btnVerificarVenc.Click += new System.EventHandler(this.btnVerificarVenc_Click);
            // 
            // numCodigoSocio
            // 
            this.numCodigoSocio.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numCodigoSocio.BackColor = System.Drawing.Color.Transparent;
            this.numCodigoSocio.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numCodigoSocio.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCodigoSocio.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCodigoSocio.Location = new System.Drawing.Point(14, 23);
            this.numCodigoSocio.Maximo = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCodigoSocio.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numCodigoSocio.Name = "numCodigoSocio";
            this.numCodigoSocio.Obligatorio = false;
            this.numCodigoSocio.Size = new System.Drawing.Size(280, 26);
            this.numCodigoSocio.TabIndex = 2;
            this.numCodigoSocio.Titulo = "Codigo Socio:";
            this.numCodigoSocio.ValueChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
            // 
            // chkActivos
            // 
            this.chkActivos.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkActivos.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.chkActivos.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivos.Location = new System.Drawing.Point(564, 23);
            this.chkActivos.Name = "chkActivos";
            this.chkActivos.Size = new System.Drawing.Size(201, 26);
            this.chkActivos.TabIndex = 4;
            this.chkActivos.Titulo = "Solo Activos:";
            this.chkActivos.ValueChanged += new System.EventHandler(this.chkActivos_ValueChanged);
            // 
            // GestionarSociosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 774);
            this.Name = "GestionarSociosFrm";
            this.Text = "GestionarSociosFrm";
            this.pnlBotones.ResumeLayout(false);
            this.pnlActualizar.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.pnlGrd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerificarVenc;
        private System.Windows.Forms.Button btnProcesarPago;
        private System.Windows.Forms.Button btnVerClases;
        private MyGymEntero numCodigoSocio;
        private MyGymChkBox chkActivos;
    }
}