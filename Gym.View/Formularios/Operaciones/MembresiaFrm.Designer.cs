namespace Gym.View
{
    partial class MembresiaFrm
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
            this.txtDescripcion = new Gym.View.MyGymTextBox();
            this.numCodigo = new Gym.View.MyGymEntero();
            this.numPrecio = new Gym.View.DecimalTextBox();
            this.chkPremium = new Gym.View.MyGymChkBox();
            this.cboTipoMembresia = new Gym.View.ComboTipoMembresias();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(388, 377);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 326);
            this.pnlBotones.Size = new System.Drawing.Size(384, 47);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(259, 4);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.cboTipoMembresia);
            this.pnlContenido.Controls.Add(this.chkPremium);
            this.pnlContenido.Controls.Add(this.numPrecio);
            this.pnlContenido.Controls.Add(this.numCodigo);
            this.pnlContenido.Controls.Add(this.txtDescripcion);
            this.pnlContenido.Size = new System.Drawing.Size(384, 329);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(384, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(113, 13);
            this.lblTitulo.Size = new System.Drawing.Size(139, 18);
            this.lblTitulo.Text = "Nueva Membresía";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(6, 123);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(21, 15, 21, 15);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Obligatorio = true;
            this.txtDescripcion.Size = new System.Drawing.Size(340, 26);
            this.txtDescripcion.TabIndex = 10;
            this.txtDescripcion.Titulo = "Descripción:";
            // 
            // numCodigo
            // 
            this.numCodigo.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numCodigo.BackColor = System.Drawing.Color.Transparent;
            this.numCodigo.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numCodigo.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCodigo.Location = new System.Drawing.Point(6, 74);
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Obligatorio = true;
            this.numCodigo.Size = new System.Drawing.Size(340, 26);
            this.numCodigo.TabIndex = 11;
            this.numCodigo.Titulo = "Codigo:";
            // 
            // numPrecio
            // 
            this.numPrecio.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numPrecio.BackColor = System.Drawing.Color.Transparent;
            this.numPrecio.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numPrecio.DigitosMaximo = 32767;
            this.numPrecio.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecio.Location = new System.Drawing.Point(6, 223);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Obligatorio = true;
            this.numPrecio.Size = new System.Drawing.Size(340, 26);
            this.numPrecio.TabIndex = 12;
            this.numPrecio.Titulo = "Precio:";
            // 
            // chkPremium
            // 
            this.chkPremium.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkPremium.BackColor = System.Drawing.Color.Transparent;
            this.chkPremium.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.chkPremium.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPremium.Location = new System.Drawing.Point(6, 173);
            this.chkPremium.Name = "chkPremium";
            this.chkPremium.Size = new System.Drawing.Size(340, 26);
            this.chkPremium.TabIndex = 13;
            this.chkPremium.Titulo = "Premium:";
            // 
            // cboTipoMembresia
            // 
            this.cboTipoMembresia.BackColor = System.Drawing.Color.Transparent;
            this.cboTipoMembresia.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.cboTipoMembresia.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMembresia.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMembresia.LabelBackColor = System.Drawing.Color.Transparent;
            this.cboTipoMembresia.Location = new System.Drawing.Point(6, 21);
            this.cboTipoMembresia.Margin = new System.Windows.Forms.Padding(32, 21, 32, 21);
            this.cboTipoMembresia.Name = "cboTipoMembresia";
            this.cboTipoMembresia.Size = new System.Drawing.Size(340, 26);
            this.cboTipoMembresia.TabIndex = 14;
            this.cboTipoMembresia.Titulo = "Tipo Membresía:";
            // 
            // MembresiaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 377);
            this.Name = "MembresiaFrm";
            this.Text = "MembresiaFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MyGymTextBox txtDescripcion;
        private MyGymEntero numCodigo;
        private DecimalTextBox numPrecio;
        private MyGymChkBox chkPremium;
        private ComboTipoMembresias cboTipoMembresia;
    }
}