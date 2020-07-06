namespace Gym.View
{
    partial class FormABMBase
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
            this.pnlContainer = new Gym.View.PanelColores();
            this.pnlBotones = new Gym.View.PanelColores();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlContenido = new Gym.View.PanelColores();
            this.pnlTitulo = new Gym.View.PanelColores();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainer.ColorAbajo = System.Drawing.Color.Empty;
            this.pnlContainer.ColorArriba = System.Drawing.Color.Empty;
            this.pnlContainer.Controls.Add(this.pnlBotones);
            this.pnlContainer.Controls.Add(this.pnlContenido);
            this.pnlContainer.Controls.Add(this.pnlTitulo);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(398, 475);
            this.pnlContainer.TabIndex = 14;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotones.ColorAbajo = System.Drawing.SystemColors.ActiveBorder;
            this.pnlBotones.ColorArriba = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 424);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(394, 47);
            this.pnlBotones.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(269, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 38);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(6, 6);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 35);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenido.ColorAbajo = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlContenido.ColorArriba = System.Drawing.SystemColors.AppWorkspace;
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 44);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(394, 427);
            this.pnlContenido.TabIndex = 18;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.ColorAbajo = System.Drawing.Color.SeaGreen;
            this.pnlTitulo.ColorArriba = System.Drawing.Color.MediumSeaGreen;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(394, 44);
            this.pnlTitulo.TabIndex = 16;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(142, 13);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 18);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Nuevo Usuario";
            // 
            // FormABMBase
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(398, 475);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormABMBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormABMBase";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormABMBase_MouseDown);
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected PanelColores pnlContainer;
        protected PanelColores pnlBotones;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Button btnGuardar;
        protected PanelColores pnlContenido;
        protected PanelColores pnlTitulo;
        protected System.Windows.Forms.Label lblTitulo;
    }
}