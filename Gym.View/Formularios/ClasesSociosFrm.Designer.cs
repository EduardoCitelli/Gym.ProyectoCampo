namespace Gym.View
{
    partial class ClasesSociosFrm
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
            this.grdClasesSocios = new Gym.View.GridColores();
            this.btnEliminarClase = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasesSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(800, 450);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnEliminarClase);
            this.pnlBotones.Location = new System.Drawing.Point(0, 399);
            this.pnlBotones.Size = new System.Drawing.Size(796, 47);
            this.pnlBotones.Controls.SetChildIndex(this.btnGuardar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnSalir, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnEliminarClase, 0);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(676, 0);
            this.btnSalir.Size = new System.Drawing.Size(118, 45);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(107, 45);
            this.btnGuardar.Text = "Agregar a Clase";
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.grdClasesSocios);
            this.pnlContenido.Size = new System.Drawing.Size(796, 402);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(796, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(326, 6);
            this.lblTitulo.Size = new System.Drawing.Size(113, 18);
            this.lblTitulo.Text = "Clases de Socio";
            // 
            // grdClasesSocios
            // 
            this.grdClasesSocios.ColorAbajo = System.Drawing.Color.Empty;
            this.grdClasesSocios.ColorArriba = System.Drawing.Color.Empty;
            this.grdClasesSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClasesSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClasesSocios.Location = new System.Drawing.Point(0, 0);
            this.grdClasesSocios.Name = "grdClasesSocios";
            this.grdClasesSocios.Size = new System.Drawing.Size(794, 400);
            this.grdClasesSocios.TabIndex = 0;
            // 
            // btnEliminarClase
            // 
            this.btnEliminarClase.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarClase.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminarClase.FlatAppearance.BorderSize = 0;
            this.btnEliminarClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClase.Location = new System.Drawing.Point(107, 0);
            this.btnEliminarClase.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminarClase.Name = "btnEliminarClase";
            this.btnEliminarClase.Size = new System.Drawing.Size(107, 45);
            this.btnEliminarClase.TabIndex = 7;
            this.btnEliminarClase.Text = "Eliminar de Clase";
            this.btnEliminarClase.UseVisualStyleBackColor = false;
            // 
            // ClasesSociosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ClasesSociosFrm";
            this.Text = "ClasesSociosFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasesSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GridColores grdClasesSocios;
        protected System.Windows.Forms.Button btnEliminarClase;
    }
}