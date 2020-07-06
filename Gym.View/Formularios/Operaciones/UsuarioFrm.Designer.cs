namespace Gym.View
{
    partial class UsuarioFrm
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
            this.cboGrupo = new Gym.View.ComboGrupoUsuarios();
            this.txtNombre = new Gym.View.MyGymTextBox();
            this.txtApellido = new Gym.View.MyGymTextBox();
            this.txtUsuario = new Gym.View.MyGymTextBox();
            this.txtPass = new Gym.View.MyGymTextBox();
            this.txtEmail = new Gym.View.MyGymTextBox();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(398, 417);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 366);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.txtEmail);
            this.pnlContenido.Controls.Add(this.txtPass);
            this.pnlContenido.Controls.Add(this.txtUsuario);
            this.pnlContenido.Controls.Add(this.txtApellido);
            this.pnlContenido.Controls.Add(this.txtNombre);
            this.pnlContenido.Controls.Add(this.cboGrupo);
            this.pnlContenido.Size = new System.Drawing.Size(394, 369);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(135, 11);
            // 
            // cboGrupo
            // 
            this.cboGrupo.BackColor = System.Drawing.Color.Transparent;
            this.cboGrupo.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.cboGrupo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupo.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupo.LabelBackColor = System.Drawing.Color.Transparent;
            this.cboGrupo.Location = new System.Drawing.Point(18, 256);
            this.cboGrupo.Margin = new System.Windows.Forms.Padding(48, 29, 48, 29);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(340, 26);
            this.cboGrupo.TabIndex = 27;
            this.cboGrupo.Titulo = "Grupo:";
            // 
            // txtNombre
            // 
            this.txtNombre.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.CaracterPassword = '\0';
            this.txtNombre.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtNombre.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(18, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Obligatorio = true;
            this.txtNombre.Size = new System.Drawing.Size(340, 26);
            this.txtNombre.TabIndex = 28;
            this.txtNombre.TextoPassword = false;
            this.txtNombre.Titulo = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.CaracterPassword = '\0';
            this.txtApellido.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtApellido.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(18, 64);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Obligatorio = true;
            this.txtApellido.Size = new System.Drawing.Size(340, 26);
            this.txtApellido.TabIndex = 29;
            this.txtApellido.TextoPassword = false;
            this.txtApellido.Titulo = "Apellido:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.CaracterPassword = '\0';
            this.txtUsuario.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(18, 112);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Obligatorio = true;
            this.txtUsuario.Size = new System.Drawing.Size(340, 26);
            this.txtUsuario.TabIndex = 30;
            this.txtUsuario.TextoPassword = false;
            this.txtUsuario.Titulo = "Usuario:";
            // 
            // txtPass
            // 
            this.txtPass.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.CaracterPassword = '●';
            this.txtPass.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtPass.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(18, 159);
            this.txtPass.Name = "txtPass";
            this.txtPass.Obligatorio = true;
            this.txtPass.Size = new System.Drawing.Size(340, 26);
            this.txtPass.TabIndex = 31;
            this.txtPass.TextoPassword = true;
            this.txtPass.Titulo = "Contraseña:";
            // 
            // txtEmail
            // 
            this.txtEmail.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.CaracterPassword = '\0';
            this.txtEmail.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtEmail.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(18, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Obligatorio = true;
            this.txtEmail.Size = new System.Drawing.Size(340, 26);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.TextoPassword = false;
            this.txtEmail.Titulo = "Email:";
            // 
            // UsuarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(398, 417);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UsuarioFrm";
            this.Text = "Nuevo Usuario";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboGrupoUsuarios cboGrupo;
        private MyGymTextBox txtNombre;
        private MyGymTextBox txtEmail;
        private MyGymTextBox txtPass;
        private MyGymTextBox txtUsuario;
        private MyGymTextBox txtApellido;
    }
}