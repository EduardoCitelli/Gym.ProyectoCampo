namespace Gym.View
{
    partial class SalonFrm
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
            this.txtDescripcion = new Gym.View.MyGymTextBox();
            this.numCapacidad = new Gym.View.MyGymEntero();
            this.numPiso = new Gym.View.MyGymEntero();
            this.numNumero = new Gym.View.MyGymEntero();
            this.numTamanio = new Gym.View.MyGymDecimal();
            this.tituloLabel1 = new Gym.View.TituloLabel();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(800, 309);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 258);
            this.pnlBotones.Size = new System.Drawing.Size(796, 47);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(646, 2);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(22, 6);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.tituloLabel1);
            this.pnlContenido.Controls.Add(this.numTamanio);
            this.pnlContenido.Controls.Add(this.numNumero);
            this.pnlContenido.Controls.Add(this.numPiso);
            this.pnlContenido.Controls.Add(this.numCapacidad);
            this.pnlContenido.Controls.Add(this.txtDescripcion);
            this.pnlContenido.Controls.Add(this.numCodigo);
            this.pnlContenido.Size = new System.Drawing.Size(796, 261);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(796, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(345, 6);
            this.lblTitulo.Size = new System.Drawing.Size(97, 18);
            this.lblTitulo.Text = "Nuevo Salon";
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
            this.numCodigo.Location = new System.Drawing.Point(22, 26);
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
            // txtDescripcion
            // 
            this.txtDescripcion.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.CaracterPassword = '\0';
            this.txtDescripcion.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(22, 79);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Obligatorio = true;
            this.txtDescripcion.Size = new System.Drawing.Size(340, 26);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.TextoPassword = false;
            this.txtDescripcion.Titulo = "Descripción:";
            // 
            // numCapacidad
            // 
            this.numCapacidad.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numCapacidad.BackColor = System.Drawing.Color.Transparent;
            this.numCapacidad.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numCapacidad.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCapacidad.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Location = new System.Drawing.Point(424, 26);
            this.numCapacidad.Maximo = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCapacidad.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Obligatorio = true;
            this.numCapacidad.Size = new System.Drawing.Size(340, 26);
            this.numCapacidad.TabIndex = 3;
            this.numCapacidad.Titulo = "Capacidad: ";
            // 
            // numPiso
            // 
            this.numPiso.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numPiso.BackColor = System.Drawing.Color.Transparent;
            this.numPiso.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numPiso.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPiso.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPiso.Location = new System.Drawing.Point(424, 133);
            this.numPiso.Maximo = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPiso.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numPiso.Name = "numPiso";
            this.numPiso.Obligatorio = false;
            this.numPiso.Size = new System.Drawing.Size(340, 26);
            this.numPiso.TabIndex = 5;
            this.numPiso.Titulo = "Piso:";
            // 
            // numNumero
            // 
            this.numNumero.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numNumero.BackColor = System.Drawing.Color.Transparent;
            this.numNumero.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numNumero.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumero.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumero.Location = new System.Drawing.Point(424, 79);
            this.numNumero.Maximo = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numNumero.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numNumero.Name = "numNumero";
            this.numNumero.Obligatorio = true;
            this.numNumero.Size = new System.Drawing.Size(340, 26);
            this.numNumero.TabIndex = 4;
            this.numNumero.Titulo = "Numero:";
            // 
            // numTamanio
            // 
            this.numTamanio.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numTamanio.BackColor = System.Drawing.Color.Transparent;
            this.numTamanio.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numTamanio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTamanio.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTamanio.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTamanio.Location = new System.Drawing.Point(22, 133);
            this.numTamanio.Margin = new System.Windows.Forms.Padding(4);
            this.numTamanio.Maximo = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTamanio.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numTamanio.Name = "numTamanio";
            this.numTamanio.Obligatorio = true;
            this.numTamanio.Size = new System.Drawing.Size(340, 26);
            this.numTamanio.TabIndex = 6;
            this.numTamanio.Titulo = "Tamaño:";
            // 
            // tituloLabel1
            // 
            this.tituloLabel1.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.tituloLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tituloLabel1.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.tituloLabel1.Enabled = true;
            this.tituloLabel1.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel1.LabelBackColor = System.Drawing.Color.Transparent;
            this.tituloLabel1.Location = new System.Drawing.Point(368, 133);
            this.tituloLabel1.Name = "tituloLabel1";
            this.tituloLabel1.Size = new System.Drawing.Size(37, 26);
            this.tituloLabel1.TabIndex = 7;
            this.tituloLabel1.TipoBorde = System.Windows.Forms.BorderStyle.None;
            this.tituloLabel1.Titulo = "M2";
            // 
            // SalonFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Name = "SalonFrm";
            this.Text = "SalonFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGymEntero numCodigo;
        private MyGymEntero numNumero;
        private MyGymEntero numPiso;
        private MyGymEntero numCapacidad;
        private MyGymTextBox txtDescripcion;
        private MyGymDecimal numTamanio;
        private TituloLabel tituloLabel1;
    }
}