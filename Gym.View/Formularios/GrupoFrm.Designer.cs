namespace Gym.View
{
    partial class GrupoFrm
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
            this.txtNombre = new Gym.View.MyGymTextBox();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(398, 255);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 204);
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
            this.pnlContenido.Controls.Add(this.txtNombre);
            this.pnlContenido.Size = new System.Drawing.Size(394, 207);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(105, 18);
            this.lblTitulo.Text = "Nuevo Grupo";
            // 
            // txtNombre
            // 
            this.txtNombre.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.CaracterPassword = '\0';
            this.txtNombre.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtNombre.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(22, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Obligatorio = true;
            this.txtNombre.Size = new System.Drawing.Size(340, 26);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextoPassword = false;
            this.txtNombre.Titulo = "Nombre:";
            // 
            // GrupoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 255);
            this.Name = "GrupoFrm";
            this.Text = "GrupoFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyGymTextBox txtNombre;
    }
}