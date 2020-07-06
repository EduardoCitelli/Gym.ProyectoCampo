namespace Gym.View
{
    partial class TipoMembresiasFrm
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.numCantMeses = new System.Windows.Forms.NumericUpDown();
            this.numCantClases = new System.Windows.Forms.NumericUpDown();
            this.chkMensual = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantClases)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Size = new System.Drawing.Size(376, 367);
            // 
            // pnlBotones
            // 
            this.pnlBotones.Location = new System.Drawing.Point(0, 316);
            this.pnlBotones.Size = new System.Drawing.Size(372, 47);
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
            this.pnlContenido.Controls.Add(this.label4);
            this.pnlContenido.Controls.Add(this.label3);
            this.pnlContenido.Controls.Add(this.label2);
            this.pnlContenido.Controls.Add(this.label1);
            this.pnlContenido.Controls.Add(this.chkMensual);
            this.pnlContenido.Controls.Add(this.numCantClases);
            this.pnlContenido.Controls.Add(this.numCantMeses);
            this.pnlContenido.Controls.Add(this.txtDescripcion);
            this.pnlContenido.Size = new System.Drawing.Size(372, 319);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Size = new System.Drawing.Size(372, 44);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(89, 14);
            this.lblTitulo.Size = new System.Drawing.Size(174, 18);
            this.lblTitulo.Text = "Nuevo Tipo Membresia";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(209, 22);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 26);
            this.txtDescripcion.TabIndex = 0;
            // 
            // numCantMeses
            // 
            this.numCantMeses.Location = new System.Drawing.Point(209, 128);
            this.numCantMeses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantMeses.Name = "numCantMeses";
            this.numCantMeses.Size = new System.Drawing.Size(120, 26);
            this.numCantMeses.TabIndex = 2;
            this.numCantMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCantMeses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCantClases
            // 
            this.numCantClases.Location = new System.Drawing.Point(210, 188);
            this.numCantClases.Name = "numCantClases";
            this.numCantClases.Size = new System.Drawing.Size(120, 26);
            this.numCantClases.TabIndex = 3;
            this.numCantClases.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkMensual
            // 
            this.chkMensual.AutoSize = true;
            this.chkMensual.BackColor = System.Drawing.Color.Transparent;
            this.chkMensual.Location = new System.Drawing.Point(209, 86);
            this.chkMensual.Name = "chkMensual";
            this.chkMensual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMensual.Size = new System.Drawing.Size(15, 14);
            this.chkMensual.TabIndex = 1;
            this.chkMensual.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de Clases:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de Meses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Es Mensual:";
            // 
            // TipoMembresiasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 367);
            this.Name = "TipoMembresiasFrm";
            this.Text = "TipoMembresiasFrm";
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMensual;
        private System.Windows.Forms.NumericUpDown numCantMeses;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown numCantClases;
    }
}