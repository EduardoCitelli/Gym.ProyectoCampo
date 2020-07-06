namespace Gym.View
{
    partial class ClaseFrm
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
            this.dtInicio = new Gym.View.MyGymDateTimeHora();
            this.numDuracion = new Gym.View.MyGymEntero();
            this.comboActividad = new Gym.View.ComboActividad();
            this.comboAuxiliar = new Gym.View.ComboProfesor();
            this.comboSalon = new Gym.View.ComboSalon();
            this.comboTitular = new Gym.View.ComboProfesor();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(772, 337);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 286);
            this.pnlBotones.Size = new System.Drawing.Size(768, 47);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(638, 4);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.comboTitular);
            this.pnlContenido.Controls.Add(this.comboSalon);
            this.pnlContenido.Controls.Add(this.comboAuxiliar);
            this.pnlContenido.Controls.Add(this.comboActividad);
            this.pnlContenido.Controls.Add(this.numDuracion);
            this.pnlContenido.Controls.Add(this.dtInicio);
            this.pnlContenido.Controls.Add(this.txtDescripcion);
            this.pnlContenido.Size = new System.Drawing.Size(768, 289);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(768, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(318, 11);
            this.lblTitulo.Size = new System.Drawing.Size(98, 18);
            this.lblTitulo.Text = "Nueva Clase";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.CaracterPassword = '\0';
            this.txtDescripcion.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(9, 31);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Obligatorio = true;
            this.txtDescripcion.Size = new System.Drawing.Size(340, 26);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.TextoPassword = false;
            this.txtDescripcion.Titulo = "Descripción:";
            // 
            // dtInicio
            // 
            this.dtInicio.BackColor = System.Drawing.Color.Transparent;
            this.dtInicio.Descripcion = "Inicio:";
            this.dtInicio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Location = new System.Drawing.Point(9, 77);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(6);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(340, 26);
            this.dtInicio.TabIndex = 1;
            // 
            // numDuracion
            // 
            this.numDuracion.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numDuracion.BackColor = System.Drawing.Color.Transparent;
            this.numDuracion.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numDuracion.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDuracion.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracion.Location = new System.Drawing.Point(9, 126);
            this.numDuracion.Maximo = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDuracion.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Obligatorio = true;
            this.numDuracion.Size = new System.Drawing.Size(340, 26);
            this.numDuracion.TabIndex = 2;
            this.numDuracion.Titulo = "Duración:";
            // 
            // comboActividad
            // 
            this.comboActividad.BackColor = System.Drawing.Color.Transparent;
            this.comboActividad.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboActividad.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboActividad.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboActividad.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboActividad.Location = new System.Drawing.Point(416, 126);
            this.comboActividad.Margin = new System.Windows.Forms.Padding(4);
            this.comboActividad.Name = "comboActividad";
            this.comboActividad.Size = new System.Drawing.Size(340, 26);
            this.comboActividad.TabIndex = 3;
            this.comboActividad.Titulo = "Actividad:";
            // 
            // comboAuxiliar
            // 
            this.comboAuxiliar.BackColor = System.Drawing.Color.Transparent;
            this.comboAuxiliar.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboAuxiliar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAuxiliar.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAuxiliar.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboAuxiliar.Location = new System.Drawing.Point(416, 77);
            this.comboAuxiliar.Margin = new System.Windows.Forms.Padding(4);
            this.comboAuxiliar.Name = "comboAuxiliar";
            this.comboAuxiliar.PermiteNulo = true;
            this.comboAuxiliar.Size = new System.Drawing.Size(340, 26);
            this.comboAuxiliar.TabIndex = 4;
            this.comboAuxiliar.Titulo = "Prof. Aux";
            // 
            // comboSalon
            // 
            this.comboSalon.BackColor = System.Drawing.Color.Transparent;
            this.comboSalon.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboSalon.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSalon.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSalon.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboSalon.Location = new System.Drawing.Point(416, 180);
            this.comboSalon.Margin = new System.Windows.Forms.Padding(4);
            this.comboSalon.Name = "comboSalon";
            this.comboSalon.Size = new System.Drawing.Size(340, 26);
            this.comboSalon.TabIndex = 5;
            this.comboSalon.Titulo = "Salon:";
            // 
            // comboTitular
            // 
            this.comboTitular.BackColor = System.Drawing.Color.Transparent;
            this.comboTitular.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboTitular.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTitular.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTitular.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboTitular.Location = new System.Drawing.Point(416, 31);
            this.comboTitular.Margin = new System.Windows.Forms.Padding(4);
            this.comboTitular.Name = "comboTitular";
            this.comboTitular.Size = new System.Drawing.Size(340, 26);
            this.comboTitular.TabIndex = 6;
            this.comboTitular.Titulo = "Prof. Titular";
            // 
            // ClaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 337);
            this.Name = "ClaseFrm";
            this.Text = "ClaseFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboProfesor comboTitular;
        private ComboSalon comboSalon;
        private ComboProfesor comboAuxiliar;
        private ComboActividad comboActividad;
        private MyGymEntero numDuracion;
        private MyGymDateTimeHora dtInicio;
        private MyGymTextBox txtDescripcion;
    }
}