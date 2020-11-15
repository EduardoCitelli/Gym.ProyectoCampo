namespace Gym.View.Formularios
{
    partial class ClaseRecurrenteFrm
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
            this.comboTitular = new Gym.View.ComboProfesor();
            this.comboSalon = new Gym.View.ComboSalon();
            this.comboAuxiliar = new Gym.View.ComboProfesor();
            this.comboActividad = new Gym.View.ComboActividad();
            this.numDuracion = new Gym.View.MyGymEntero();
            this.txtDescripcion = new Gym.View.MyGymTextBox();
            this.listBoxDias = new System.Windows.Forms.CheckedListBox();
            this.tituloLabel1 = new Gym.View.TituloLabel();
            this.dtInicio = new Gym.View.MyGymDateTimeHora();
            this.numMeses = new Gym.View.MyGymEntero();
            this.lblHS = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(800, 585);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 534);
            this.pnlBotones.Size = new System.Drawing.Size(796, 47);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(676, 0);
            this.btnSalir.Size = new System.Drawing.Size(118, 45);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(107, 45);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.lblHS);
            this.pnlContenido.Controls.Add(this.numMeses);
            this.pnlContenido.Controls.Add(this.dtInicio);
            this.pnlContenido.Controls.Add(this.tituloLabel1);
            this.pnlContenido.Controls.Add(this.listBoxDias);
            this.pnlContenido.Controls.Add(this.comboTitular);
            this.pnlContenido.Controls.Add(this.comboSalon);
            this.pnlContenido.Controls.Add(this.comboAuxiliar);
            this.pnlContenido.Controls.Add(this.comboActividad);
            this.pnlContenido.Controls.Add(this.numDuracion);
            this.pnlContenido.Controls.Add(this.txtDescripcion);
            this.pnlContenido.Size = new System.Drawing.Size(796, 537);
            this.pnlContenido.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(796, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(313, 6);
            this.lblTitulo.Size = new System.Drawing.Size(182, 18);
            this.lblTitulo.Text = "Nueva Clase Recurrente";
            // 
            // comboTitular
            // 
            this.comboTitular.BackColor = System.Drawing.Color.Transparent;
            this.comboTitular.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboTitular.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTitular.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTitular.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboTitular.Location = new System.Drawing.Point(425, 25);
            this.comboTitular.Margin = new System.Windows.Forms.Padding(4);
            this.comboTitular.Name = "comboTitular";
            this.comboTitular.Size = new System.Drawing.Size(340, 26);
            this.comboTitular.TabIndex = 5;
            this.comboTitular.Titulo = "Prof. Titular";
            // 
            // comboSalon
            // 
            this.comboSalon.BackColor = System.Drawing.Color.Transparent;
            this.comboSalon.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboSalon.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSalon.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSalon.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboSalon.Location = new System.Drawing.Point(425, 174);
            this.comboSalon.Margin = new System.Windows.Forms.Padding(4);
            this.comboSalon.Name = "comboSalon";
            this.comboSalon.Size = new System.Drawing.Size(340, 26);
            this.comboSalon.TabIndex = 8;
            this.comboSalon.Titulo = "Salon:";
            // 
            // comboAuxiliar
            // 
            this.comboAuxiliar.BackColor = System.Drawing.Color.Transparent;
            this.comboAuxiliar.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboAuxiliar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAuxiliar.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAuxiliar.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboAuxiliar.Location = new System.Drawing.Point(425, 71);
            this.comboAuxiliar.Margin = new System.Windows.Forms.Padding(4);
            this.comboAuxiliar.Name = "comboAuxiliar";
            this.comboAuxiliar.PermiteNulo = true;
            this.comboAuxiliar.Size = new System.Drawing.Size(340, 26);
            this.comboAuxiliar.TabIndex = 6;
            this.comboAuxiliar.Titulo = "Prof. Aux";
            // 
            // comboActividad
            // 
            this.comboActividad.BackColor = System.Drawing.Color.Transparent;
            this.comboActividad.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.comboActividad.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboActividad.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboActividad.LabelBackColor = System.Drawing.Color.Transparent;
            this.comboActividad.Location = new System.Drawing.Point(425, 120);
            this.comboActividad.Margin = new System.Windows.Forms.Padding(4);
            this.comboActividad.Name = "comboActividad";
            this.comboActividad.Size = new System.Drawing.Size(340, 26);
            this.comboActividad.TabIndex = 7;
            this.comboActividad.Titulo = "Actividad:";
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
            this.numDuracion.Location = new System.Drawing.Point(18, 71);
            this.numDuracion.Maximo = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDuracion.Minimo = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuracion.Name = "numDuracion";
            this.numDuracion.Obligatorio = true;
            this.numDuracion.Size = new System.Drawing.Size(340, 26);
            this.numDuracion.TabIndex = 1;
            this.numDuracion.Titulo = "Duración:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.CaracterPassword = '\0';
            this.txtDescripcion.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(18, 25);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Obligatorio = true;
            this.txtDescripcion.Size = new System.Drawing.Size(340, 26);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.TextoPassword = false;
            this.txtDescripcion.Titulo = "Descripción:";
            // 
            // listBoxDias
            // 
            this.listBoxDias.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxDias.FormattingEnabled = true;
            this.listBoxDias.Location = new System.Drawing.Point(18, 243);
            this.listBoxDias.Name = "listBoxDias";
            this.listBoxDias.Size = new System.Drawing.Size(340, 233);
            this.listBoxDias.TabIndex = 4;
            // 
            // tituloLabel1
            // 
            this.tituloLabel1.AlinearTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.tituloLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel1.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.tituloLabel1.Enabled = true;
            this.tituloLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel1.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel1.LabelBackColor = System.Drawing.Color.Transparent;
            this.tituloLabel1.Location = new System.Drawing.Point(20, 211);
            this.tituloLabel1.Name = "tituloLabel1";
            this.tituloLabel1.Size = new System.Drawing.Size(338, 26);
            this.tituloLabel1.TabIndex = 15;
            this.tituloLabel1.TipoBorde = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tituloLabel1.Titulo = "Días de la semana:";
            // 
            // dtInicio
            // 
            this.dtInicio.BackColor = System.Drawing.Color.Transparent;
            this.dtInicio.Descripcion = "Inicio:";
            this.dtInicio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Location = new System.Drawing.Point(18, 120);
            this.dtInicio.Margin = new System.Windows.Forms.Padding(6);
            this.dtInicio.MostrarSoloHora = true;
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(305, 26);
            this.dtInicio.TabIndex = 3;
            // 
            // numMeses
            // 
            this.numMeses.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numMeses.BackColor = System.Drawing.Color.Transparent;
            this.numMeses.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numMeses.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMeses.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMeses.Location = new System.Drawing.Point(18, 164);
            this.numMeses.Maximo = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numMeses.Minimo = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMeses.Name = "numMeses";
            this.numMeses.Obligatorio = true;
            this.numMeses.Size = new System.Drawing.Size(340, 36);
            this.numMeses.TabIndex = 3;
            this.numMeses.Titulo = "Cantidad de Meses:";
            // 
            // lblHS
            // 
            this.lblHS.AutoSize = true;
            this.lblHS.BackColor = System.Drawing.Color.Transparent;
            this.lblHS.Location = new System.Drawing.Point(332, 128);
            this.lblHS.Name = "lblHS";
            this.lblHS.Size = new System.Drawing.Size(26, 18);
            this.lblHS.TabIndex = 16;
            this.lblHS.Text = "Hs";
            // 
            // ClaseRecurrenteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Name = "ClaseRecurrenteFrm";
            this.Text = "ClaseRecurrenteFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TituloLabel tituloLabel1;
        private System.Windows.Forms.CheckedListBox listBoxDias;
        private ComboProfesor comboTitular;
        private ComboSalon comboSalon;
        private ComboProfesor comboAuxiliar;
        private ComboActividad comboActividad;
        private MyGymEntero numDuracion;
        private MyGymTextBox txtDescripcion;
        private MyGymDateTimeHora dtInicio;
        private MyGymEntero numMeses;
        private System.Windows.Forms.Label lblHS;
    }
}