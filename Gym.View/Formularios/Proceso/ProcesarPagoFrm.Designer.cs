namespace Gym.View
{
    partial class ProcesarPagoFrm
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
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.lblEmail = new Gym.View.TituloLabel();
            this.lblDomicilio = new Gym.View.TituloLabel();
            this.lblSocio = new Gym.View.TituloLabel();
            this.gbMembresia = new System.Windows.Forms.GroupBox();
            this.cboActividad = new Gym.View.ComboActividad();
            this.lblPrecio = new Gym.View.TituloLabel();
            this.cboMembresias = new Gym.View.ComboMembresias();
            this.gbMembresiasSocio = new System.Windows.Forms.GroupBox();
            this.grdMembresiasSocios = new Gym.View.GridColores();
            this.gbFormaPago = new System.Windows.Forms.GroupBox();
            this.cboFormaPago = new Gym.View.ComboFormaPago();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.gbSocio.SuspendLayout();
            this.gbMembresia.SuspendLayout();
            this.gbMembresiasSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembresiasSocios)).BeginInit();
            this.gbFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(940, 755);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 704);
            this.pnlBotones.Size = new System.Drawing.Size(936, 47);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(804, 4);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.gbMembresiasSocio);
            this.pnlContenido.Controls.Add(this.gbFormaPago);
            this.pnlContenido.Controls.Add(this.gbMembresia);
            this.pnlContenido.Controls.Add(this.gbSocio);
            this.pnlContenido.Size = new System.Drawing.Size(936, 707);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(936, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(393, 6);
            // 
            // gbSocio
            // 
            this.gbSocio.BackColor = System.Drawing.Color.Transparent;
            this.gbSocio.Controls.Add(this.lblEmail);
            this.gbSocio.Controls.Add(this.lblDomicilio);
            this.gbSocio.Controls.Add(this.lblSocio);
            this.gbSocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSocio.Location = new System.Drawing.Point(0, 0);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Size = new System.Drawing.Size(934, 116);
            this.gbSocio.TabIndex = 0;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Datos Socio";
            // 
            // lblEmail
            // 
            this.lblEmail.AlinearTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmail.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Enabled = true;
            this.lblEmail.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.LabelBackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(3, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(928, 31);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.TipoBorde = System.Windows.Forms.BorderStyle.None;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AlinearTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDomicilio.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.lblDomicilio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDomicilio.Enabled = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.LabelBackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Location = new System.Drawing.Point(3, 83);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(928, 30);
            this.lblDomicilio.TabIndex = 2;
            this.lblDomicilio.TipoBorde = System.Windows.Forms.BorderStyle.None;
            // 
            // lblSocio
            // 
            this.lblSocio.AlinearTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSocio.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.lblSocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSocio.Enabled = true;
            this.lblSocio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.LabelBackColor = System.Drawing.Color.Transparent;
            this.lblSocio.Location = new System.Drawing.Point(3, 22);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(928, 30);
            this.lblSocio.TabIndex = 0;
            this.lblSocio.TipoBorde = System.Windows.Forms.BorderStyle.None;
            // 
            // gbMembresia
            // 
            this.gbMembresia.BackColor = System.Drawing.Color.Transparent;
            this.gbMembresia.Controls.Add(this.cboActividad);
            this.gbMembresia.Controls.Add(this.lblPrecio);
            this.gbMembresia.Controls.Add(this.cboMembresias);
            this.gbMembresia.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMembresia.Location = new System.Drawing.Point(0, 116);
            this.gbMembresia.Name = "gbMembresia";
            this.gbMembresia.Size = new System.Drawing.Size(934, 125);
            this.gbMembresia.TabIndex = 1;
            this.gbMembresia.TabStop = false;
            this.gbMembresia.Text = "Datos Membresía";
            // 
            // cboActividad
            // 
            this.cboActividad.BackColor = System.Drawing.Color.Transparent;
            this.cboActividad.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.cboActividad.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActividad.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActividad.LabelBackColor = System.Drawing.Color.Transparent;
            this.cboActividad.Location = new System.Drawing.Point(10, 69);
            this.cboActividad.Margin = new System.Windows.Forms.Padding(4);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(547, 26);
            this.cboActividad.TabIndex = 2;
            this.cboActividad.Titulo = "Actividad:";
            this.cboActividad.Visible = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrecio.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.lblPrecio.Enabled = true;
            this.lblPrecio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.LabelBackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Location = new System.Drawing.Point(686, 25);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(236, 26);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.TipoBorde = System.Windows.Forms.BorderStyle.None;
            // 
            // cboMembresias
            // 
            this.cboMembresias.BackColor = System.Drawing.Color.Transparent;
            this.cboMembresias.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.cboMembresias.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembresias.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembresias.LabelBackColor = System.Drawing.Color.Transparent;
            this.cboMembresias.Location = new System.Drawing.Point(10, 26);
            this.cboMembresias.Margin = new System.Windows.Forms.Padding(4);
            this.cboMembresias.Name = "cboMembresias";
            this.cboMembresias.Size = new System.Drawing.Size(547, 26);
            this.cboMembresias.TabIndex = 0;
            this.cboMembresias.Titulo = "Membresía:";
            this.cboMembresias.ValueChanged += new System.EventHandler(this.cboMembresias_ValueChanged);
            // 
            // gbMembresiasSocio
            // 
            this.gbMembresiasSocio.BackColor = System.Drawing.Color.Transparent;
            this.gbMembresiasSocio.Controls.Add(this.grdMembresiasSocios);
            this.gbMembresiasSocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMembresiasSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMembresiasSocio.Location = new System.Drawing.Point(0, 325);
            this.gbMembresiasSocio.Name = "gbMembresiasSocio";
            this.gbMembresiasSocio.Size = new System.Drawing.Size(934, 380);
            this.gbMembresiasSocio.TabIndex = 2;
            this.gbMembresiasSocio.TabStop = false;
            this.gbMembresiasSocio.Text = "Membresias de Socio";
            // 
            // grdMembresiasSocios
            // 
            this.grdMembresiasSocios.ColorAbajo = System.Drawing.Color.DarkSeaGreen;
            this.grdMembresiasSocios.ColorArriba = System.Drawing.Color.ForestGreen;
            this.grdMembresiasSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMembresiasSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMembresiasSocios.Location = new System.Drawing.Point(3, 22);
            this.grdMembresiasSocios.Name = "grdMembresiasSocios";
            this.grdMembresiasSocios.Size = new System.Drawing.Size(928, 355);
            this.grdMembresiasSocios.TabIndex = 0;
            // 
            // gbFormaPago
            // 
            this.gbFormaPago.BackColor = System.Drawing.Color.Transparent;
            this.gbFormaPago.Controls.Add(this.cboFormaPago);
            this.gbFormaPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFormaPago.Location = new System.Drawing.Point(0, 241);
            this.gbFormaPago.Name = "gbFormaPago";
            this.gbFormaPago.Size = new System.Drawing.Size(934, 84);
            this.gbFormaPago.TabIndex = 1;
            this.gbFormaPago.TabStop = false;
            this.gbFormaPago.Text = "Forma De Pago";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.BackColor = System.Drawing.Color.Transparent;
            this.cboFormaPago.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.cboFormaPago.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.LabelBackColor = System.Drawing.Color.Transparent;
            this.cboFormaPago.Location = new System.Drawing.Point(10, 39);
            this.cboFormaPago.Margin = new System.Windows.Forms.Padding(4);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(547, 26);
            this.cboFormaPago.TabIndex = 0;
            this.cboFormaPago.Titulo = "Forma de Pago:";
            // 
            // ProcesarPagoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 755);
            this.Name = "ProcesarPagoFrm";
            this.Text = "ProcesarPago";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.gbSocio.ResumeLayout(false);
            this.gbMembresia.ResumeLayout(false);
            this.gbMembresiasSocio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMembresiasSocios)).EndInit();
            this.gbFormaPago.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSocio;
        private TituloLabel lblSocio;
        private TituloLabel lblDomicilio;
        private TituloLabel lblEmail;
        private System.Windows.Forms.GroupBox gbMembresia;
        private ComboActividad cboActividad;
        private TituloLabel lblPrecio;
        private ComboMembresias cboMembresias;
        private System.Windows.Forms.GroupBox gbMembresiasSocio;
        private GridColores grdMembresiasSocios;
        private System.Windows.Forms.GroupBox gbFormaPago;
        private ComboFormaPago cboFormaPago;
    }
}