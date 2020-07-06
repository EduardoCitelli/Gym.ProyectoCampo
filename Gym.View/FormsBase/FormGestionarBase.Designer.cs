namespace Gym.View
{
    partial class FormGestionarBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlContenedor = new Gym.View.PanelColores();
            this.pnlGrd = new Gym.View.PanelColores();
            this.grd = new Gym.View.GridColores();
            this.pnlEspacio = new Gym.View.PanelColores();
            this.pnlBotones = new Gym.View.PanelColores();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pnlActualizar = new Gym.View.PanelColores();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.pnlContenedor.SuspendLayout();
            this.pnlGrd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.pnlActualizar.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(12, 16);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(93, 17);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 26);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContenedor.ColorAbajo = System.Drawing.Color.SeaGreen;
            this.pnlContenedor.ColorArriba = System.Drawing.Color.MediumSeaGreen;
            this.pnlContenedor.Controls.Add(this.pnlGrd);
            this.pnlContenedor.Controls.Add(this.pnlBotones);
            this.pnlContenedor.Controls.Add(this.gbFiltros);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 3;
            // 
            // pnlGrd
            // 
            this.pnlGrd.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrd.ColorAbajo = System.Drawing.Color.Lime;
            this.pnlGrd.ColorArriba = System.Drawing.Color.SeaGreen;
            this.pnlGrd.Controls.Add(this.grd);
            this.pnlGrd.Controls.Add(this.pnlEspacio);
            this.pnlGrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrd.Location = new System.Drawing.Point(0, 65);
            this.pnlGrd.Name = "pnlGrd";
            this.pnlGrd.Size = new System.Drawing.Size(796, 315);
            this.pnlGrd.TabIndex = 2;
            // 
            // grd
            // 
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            this.grd.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd.ColorAbajo = System.Drawing.Color.PaleGreen;
            this.grd.ColorArriba = System.Drawing.Color.SeaGreen;
            this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.EnableHeadersVisualStyles = false;
            this.grd.GridColor = System.Drawing.Color.SeaGreen;
            this.grd.Location = new System.Drawing.Point(0, 15);
            this.grd.Margin = new System.Windows.Forms.Padding(5);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grd.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent;
            this.grd.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grd.Size = new System.Drawing.Size(796, 300);
            this.grd.TabIndex = 0;
            // 
            // pnlEspacio
            // 
            this.pnlEspacio.BackColor = System.Drawing.Color.Transparent;
            this.pnlEspacio.ColorAbajo = System.Drawing.Color.Empty;
            this.pnlEspacio.ColorArriba = System.Drawing.Color.Empty;
            this.pnlEspacio.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspacio.Location = new System.Drawing.Point(0, 0);
            this.pnlEspacio.Name = "pnlEspacio";
            this.pnlEspacio.Size = new System.Drawing.Size(796, 15);
            this.pnlEspacio.TabIndex = 2;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotones.ColorAbajo = System.Drawing.Color.White;
            this.pnlBotones.ColorArriba = System.Drawing.SystemColors.ActiveBorder;
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnBorrar);
            this.pnlBotones.Controls.Add(this.btnAgregar);
            this.pnlBotones.Controls.Add(this.pnlActualizar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 380);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBotones.Size = new System.Drawing.Size(796, 66);
            this.pnlBotones.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(192, 16);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 32);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(102, 16);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 32);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.BackColor = System.Drawing.Color.Transparent;
            this.pnlActualizar.ColorAbajo = System.Drawing.Color.Empty;
            this.pnlActualizar.ColorArriba = System.Drawing.Color.Empty;
            this.pnlActualizar.Controls.Add(this.btnCerrar);
            this.pnlActualizar.Controls.Add(this.btnActualizar);
            this.pnlActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlActualizar.Location = new System.Drawing.Point(602, 5);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(185, 52);
            this.pnlActualizar.TabIndex = 1;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(3, 17);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(81, 26);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.txtFiltroNombre);
            this.gbFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbFiltros.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(796, 65);
            this.gbFiltros.TabIndex = 3;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtFiltroNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltroNombre.Location = new System.Drawing.Point(117, 32);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(100, 17);
            this.txtFiltroNombre.TabIndex = 0;
            // 
            // FormGestionarBase
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionarBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestionarBase";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlGrd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.pnlActualizar.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected PanelColores pnlBotones;
        protected System.Windows.Forms.Button btnModificar;
        protected System.Windows.Forms.Button btnBorrar;
        protected System.Windows.Forms.Button btnAgregar;
        protected PanelColores pnlActualizar;
        protected System.Windows.Forms.Button btnCerrar;
        protected System.Windows.Forms.Button btnActualizar;
        protected PanelColores pnlContenedor;
        protected System.Windows.Forms.GroupBox gbFiltros;
        protected PanelColores pnlGrd;
        protected GridColores grd;
        protected PanelColores pnlEspacio;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtFiltroNombre;
    }
}