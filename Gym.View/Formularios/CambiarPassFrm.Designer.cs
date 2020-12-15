namespace Gym.View
{

    partial class CambiarPassFrm
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
            this.pnl = new Gym.View.PanelColores();
            this.pnlBotones = new Gym.View.PanelColores();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtPass = new Gym.View.MyGymTextBox();
            this.lblTitulo = new Gym.View.TituloLabel();
            this.pnl.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl.ColorArriba = System.Drawing.Color.Black;
            this.pnl.Controls.Add(this.pnlBotones);
            this.pnl.Controls.Add(this.txtPass);
            this.pnl.Controls.Add(this.lblTitulo);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(700, 273);
            this.pnl.TabIndex = 1;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotones.ColorAbajo = System.Drawing.Color.White;
            this.pnlBotones.ColorArriba = System.Drawing.SystemColors.ActiveBorder;
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Controls.Add(this.btnCerrar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 220);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBotones.Size = new System.Drawing.Size(700, 53);
            this.pnlBotones.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(5, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 39);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(607, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 39);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtPass
            // 
            this.txtPass.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.CaracterPassword = '●';
            this.txtPass.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.txtPass.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(103, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Obligatorio = true;
            this.txtPass.Size = new System.Drawing.Size(522, 26);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextoPassword = true;
            this.txtPass.Titulo = "Nueva Contraseña:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AlinearTexto = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Enabled = true;
            this.lblTitulo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.LabelBackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Location = new System.Drawing.Point(200, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TipoBorde = System.Windows.Forms.BorderStyle.None;
            this.lblTitulo.Titulo = "Cambiar Contraseña";
            // 
            // CambiarPassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 273);
            this.Controls.Add(this.pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarPassFrm";
            this.Text = "CambiarContraseñaFrm";
            this.pnl.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PanelColores pnl;
        protected PanelColores pnlBotones;
        protected System.Windows.Forms.Button btnAceptar;
        protected System.Windows.Forms.Button btnCerrar;
        private MyGymTextBox txtPass;
        private TituloLabel lblTitulo;
    }
}