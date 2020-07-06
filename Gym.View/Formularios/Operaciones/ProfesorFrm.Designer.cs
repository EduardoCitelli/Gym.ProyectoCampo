namespace Gym.View
{
    partial class ProfesorFrm
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
            this.numTelefono = new Gym.View.MyGymEntero();
            this.numCodigo = new Gym.View.MyGymEntero();
            this.numDNI = new Gym.View.MyGymEntero();
            this.txtEmail = new Gym.View.MyGymTextBox();
            this.txtDireccion = new Gym.View.MyGymTextBox();
            this.txtApellido = new Gym.View.MyGymTextBox();
            this.txtNombre = new Gym.View.MyGymTextBox();
            this.dtNacimiento = new Gym.View.MyGymDate();
            this.numSueldo = new Gym.View.MyGymDecimal();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(800, 404);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 353);
            this.pnlBotones.Size = new System.Drawing.Size(796, 47);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(664, 3);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.numSueldo);
            this.pnlContenido.Controls.Add(this.dtNacimiento);
            this.pnlContenido.Controls.Add(this.txtNombre);
            this.pnlContenido.Controls.Add(this.txtApellido);
            this.pnlContenido.Controls.Add(this.txtDireccion);
            this.pnlContenido.Controls.Add(this.txtEmail);
            this.pnlContenido.Controls.Add(this.numDNI);
            this.pnlContenido.Controls.Add(this.numCodigo);
            this.pnlContenido.Controls.Add(this.numTelefono);
            this.pnlContenido.Size = new System.Drawing.Size(796, 356);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(796, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(326, 11);
            this.lblTitulo.Size = new System.Drawing.Size(121, 18);
            this.lblTitulo.Text = "Nuevo Profesor";
            // 
            // numTelefono
            // 
            this.numTelefono.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numTelefono.BackColor = System.Drawing.Color.Transparent;
            this.numTelefono.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numTelefono.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTelefono.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTelefono.Location = new System.Drawing.Point(432, 71);
            this.numTelefono.Maximo = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numTelefono.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numTelefono.Name = "numTelefono";
            this.numTelefono.Obligatorio = true;
            this.numTelefono.Size = new System.Drawing.Size(340, 26);
            this.numTelefono.TabIndex = 5;
            this.numTelefono.Titulo = "Telefono:";
            // 
            // numCodigo
            // 
            this.numCodigo.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numCodigo.BackColor = System.Drawing.Color.Transparent;
            this.numCodigo.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numCodigo.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCodigo.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCodigo.Location = new System.Drawing.Point(207, 21);
            this.numCodigo.Maximo = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCodigo.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Obligatorio = true;
            this.numCodigo.Size = new System.Drawing.Size(340, 26);
            this.numCodigo.TabIndex = 0;
            this.numCodigo.Titulo = "Código:";
            // 
            // numDNI
            // 
            this.numDNI.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numDNI.BackColor = System.Drawing.Color.Transparent;
            this.numDNI.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numDNI.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDNI.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDNI.Location = new System.Drawing.Point(19, 175);
            this.numDNI.Maximo = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDNI.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numDNI.Name = "numDNI";
            this.numDNI.Obligatorio = true;
            this.numDNI.Size = new System.Drawing.Size(340, 26);
            this.numDNI.TabIndex = 3;
            this.numDNI.Titulo = "DNI:";
            // 
            // txtEmail
            // 
            this.txtEmail.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.CaracterPassword = '\0';
            this.txtEmail.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtEmail.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(432, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Obligatorio = true;
            this.txtEmail.Size = new System.Drawing.Size(340, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextoPassword = false;
            this.txtEmail.Titulo = "E-Mail:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.CaracterPassword = '\0';
            this.txtDireccion.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtDireccion.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(432, 121);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Obligatorio = true;
            this.txtDireccion.Size = new System.Drawing.Size(340, 26);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.TextoPassword = false;
            this.txtDireccion.Titulo = "Dirección:";
            // 
            // txtApellido
            // 
            this.txtApellido.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.CaracterPassword = '\0';
            this.txtApellido.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtApellido.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(19, 121);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Obligatorio = true;
            this.txtApellido.Size = new System.Drawing.Size(340, 26);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextoPassword = false;
            this.txtApellido.Titulo = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.CaracterPassword = '\0';
            this.txtNombre.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtNombre.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(19, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Obligatorio = true;
            this.txtNombre.Size = new System.Drawing.Size(340, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextoPassword = false;
            this.txtNombre.Titulo = "Nombre:";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.dtNacimiento.Descripcion = "Fecha Nacimiento:";
            this.dtNacimiento.Location = new System.Drawing.Point(19, 230);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(340, 26);
            this.dtNacimiento.TabIndex = 4;
            // 
            // numSueldo
            // 
            this.numSueldo.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numSueldo.BackColor = System.Drawing.Color.Transparent;
            this.numSueldo.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numSueldo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSueldo.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSueldo.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSueldo.Location = new System.Drawing.Point(432, 230);
            this.numSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.numSueldo.Maximo = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numSueldo.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numSueldo.Name = "numSueldo";
            this.numSueldo.Obligatorio = true;
            this.numSueldo.Size = new System.Drawing.Size(340, 26);
            this.numSueldo.TabIndex = 8;
            this.numSueldo.Titulo = "Sueldo:";
            // 
            // ProfesorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Name = "ProfesorFrm";
            this.Text = "ProfesorFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGymEntero numTelefono;
        private MyGymDate dtNacimiento;
        private MyGymTextBox txtNombre;
        private MyGymTextBox txtApellido;
        private MyGymTextBox txtDireccion;
        private MyGymTextBox txtEmail;
        private MyGymEntero numDNI;
        private MyGymEntero numCodigo;
        private MyGymDecimal numSueldo;
    }
}