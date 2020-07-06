namespace Gym.View
{
    partial class SocioFrm
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
            this.numCodigo = new Gym.View.MyGymEntero();
            this.numTelefono = new Gym.View.MyGymEntero();
            this.numDni = new Gym.View.MyGymEntero();
            this.txtNombre = new Gym.View.MyGymTextBox();
            this.txtEmail = new Gym.View.MyGymTextBox();
            this.txtApellido = new Gym.View.MyGymTextBox();
            this.dtNacimiento = new Gym.View.MyGymDate();
            this.txtDomicilio = new Gym.View.MyGymTextBox();
            this.comboSexo = new Gym.View.Controles.ComboSexo();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(766, 390);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 339);
            this.pnlBotones.Size = new System.Drawing.Size(762, 47);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(633, 4);
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
            this.pnlContenido.Controls.Add(this.comboSexo);
            this.pnlContenido.Controls.Add(this.txtDomicilio);
            this.pnlContenido.Controls.Add(this.dtNacimiento);
            this.pnlContenido.Controls.Add(this.txtApellido);
            this.pnlContenido.Controls.Add(this.txtEmail);
            this.pnlContenido.Controls.Add(this.txtNombre);
            this.pnlContenido.Controls.Add(this.numDni);
            this.pnlContenido.Controls.Add(this.numTelefono);
            this.pnlContenido.Controls.Add(this.numCodigo);
            this.pnlContenido.Size = new System.Drawing.Size(762, 342);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(762, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(310, 6);
            this.lblTitulo.Size = new System.Drawing.Size(95, 18);
            this.lblTitulo.Text = "Nuevo Socio";
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
            this.numCodigo.Location = new System.Drawing.Point(199, 18);
            this.numCodigo.Maximo = new decimal(new int[] {
            999999,
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
            this.numTelefono.Location = new System.Drawing.Point(9, 224);
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
            // numDni
            // 
            this.numDni.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numDni.BackColor = System.Drawing.Color.Transparent;
            this.numDni.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numDni.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDni.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDni.Location = new System.Drawing.Point(9, 173);
            this.numDni.Maximo = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numDni.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numDni.Name = "numDni";
            this.numDni.Obligatorio = true;
            this.numDni.Size = new System.Drawing.Size(340, 26);
            this.numDni.TabIndex = 3;
            this.numDni.Titulo = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.CaracterPassword = '\0';
            this.txtNombre.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtNombre.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(9, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Obligatorio = true;
            this.txtNombre.Size = new System.Drawing.Size(340, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextoPassword = false;
            this.txtNombre.Titulo = "Nombre:";
            // 
            // txtEmail
            // 
            this.txtEmail.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.CaracterPassword = '\0';
            this.txtEmail.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtEmail.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(411, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Obligatorio = true;
            this.txtEmail.Size = new System.Drawing.Size(340, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextoPassword = false;
            this.txtEmail.Titulo = "E-Mail";
            // 
            // txtApellido
            // 
            this.txtApellido.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.CaracterPassword = '\0';
            this.txtApellido.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtApellido.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(9, 118);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Obligatorio = true;
            this.txtApellido.Size = new System.Drawing.Size(340, 26);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextoPassword = false;
            this.txtApellido.Titulo = "Apellido";
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.dtNacimiento.Descripcion = "Fecha Nacimiento:";
            this.dtNacimiento.Location = new System.Drawing.Point(411, 118);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(340, 26);
            this.dtNacimiento.TabIndex = 6;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.txtDomicilio.CaracterPassword = '\0';
            this.txtDomicilio.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtDomicilio.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(411, 69);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Obligatorio = true;
            this.txtDomicilio.Size = new System.Drawing.Size(340, 26);
            this.txtDomicilio.TabIndex = 5;
            this.txtDomicilio.TextoPassword = false;
            this.txtDomicilio.Titulo = "Domicilio:";
            // 
            // comboSexo
            // 
            this.comboSexo.BackColor = System.Drawing.Color.Transparent;
            this.comboSexo.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboSexo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboSexo.Location = new System.Drawing.Point(411, 224);
            this.comboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(340, 26);
            this.comboSexo.TabIndex = 8;
            this.comboSexo.Titulo = "Sexo:";
            // 
            // SocioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 390);
            this.Name = "SocioFrm";
            this.Text = "SocioFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGymEntero numTelefono;
        private MyGymEntero numCodigo;
        private MyGymEntero numDni;
        private MyGymTextBox txtApellido;
        private MyGymTextBox txtEmail;
        private MyGymTextBox txtNombre;
        private MyGymDate dtNacimiento;
        private MyGymTextBox txtDomicilio;
        private Controles.ComboSexo comboSexo;
    }
}