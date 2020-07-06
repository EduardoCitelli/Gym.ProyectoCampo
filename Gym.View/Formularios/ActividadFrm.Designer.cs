namespace Gym.View
{
    partial class ActividadFrm
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
            this.numMinimo = new Gym.View.MyGymEntero();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(381, 286);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 235);
            this.pnlBotones.Size = new System.Drawing.Size(377, 47);
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
            this.pnlContenido.Controls.Add(this.numMinimo);
            this.pnlContenido.Controls.Add(this.numCodigo);
            this.pnlContenido.Controls.Add(this.txtDescripcion);
            this.pnlContenido.Size = new System.Drawing.Size(377, 238);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(377, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(128, 18);
            this.lblTitulo.Text = "Nueva Actividad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(16, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Obligatorio = true;
            this.txtDescripcion.Size = new System.Drawing.Size(340, 26);
            this.txtDescripcion.TabIndex = 0;
            this.txtDescripcion.Titulo = "Descripción:";
            // 
            // numCodigo
            // 
            this.numCodigo.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numCodigo.BackColor = System.Drawing.Color.Transparent;
            this.numCodigo.ColorTexto = System.Drawing.SystemColors.ControlText;            
            this.numCodigo.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCodigo.Location = new System.Drawing.Point(16, 22);
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Obligatorio = true;
            this.numCodigo.Size = new System.Drawing.Size(340, 26);
            this.numCodigo.TabIndex = 1;
            this.numCodigo.Titulo = "Código:";
            // 
            // numMinimo
            // 
            this.numMinimo.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.numMinimo.BackColor = System.Drawing.Color.Transparent;
            this.numMinimo.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.numMinimo.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMinimo.Location = new System.Drawing.Point(16, 124);
            this.numMinimo.Name = "numMinimo";
            this.numMinimo.Obligatorio = true;
            this.numMinimo.Size = new System.Drawing.Size(340, 26);
            this.numMinimo.TabIndex = 2;
            this.numMinimo.Titulo = "Minimo Alumnos:";
            // 
            // ActividadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 286);
            this.Name = "ActividadFrm";
            this.Text = "ActividadFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGymTextBox txtDescripcion;
        private MyGymEntero numCodigo;
        private MyGymEntero numMinimo;
    }
}