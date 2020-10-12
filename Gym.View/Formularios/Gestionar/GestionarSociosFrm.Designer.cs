namespace Gym.View
{
    partial class GestionarSociosFrm
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
            this.btnVerClases = new System.Windows.Forms.Button();
            this.btnProcesarPago = new System.Windows.Forms.Button();
            this.btnVerificarVenc = new System.Windows.Forms.Button();
            this.myGymEntero1 = new Gym.View.MyGymEntero();
            this.pnlBotones.SuspendLayout();
            this.pnlActualizar.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.pnlGrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnVerificarVenc);
            this.pnlBotones.Controls.Add(this.btnProcesarPago);
            this.pnlBotones.Controls.Add(this.btnVerClases);
            this.pnlBotones.Controls.SetChildIndex(this.pnlActualizar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnAgregar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnBorrar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnModificar, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnVerClases, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnProcesarPago, 0);
            this.pnlBotones.Controls.SetChildIndex(this.btnVerificarVenc, 0);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.Location = new System.Drawing.Point(192, 8);
            this.btnModificar.Size = new System.Drawing.Size(84, 49);
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.Location = new System.Drawing.Point(102, 8);
            this.btnBorrar.Size = new System.Drawing.Size(84, 49);
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.Location = new System.Drawing.Point(12, 8);
            this.btnAgregar.Size = new System.Drawing.Size(84, 49);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.myGymEntero1);
            this.gbFiltros.Controls.SetChildIndex(this.txtFiltroNombre, 0);
            this.gbFiltros.Controls.SetChildIndex(this.label1, 0);
            this.gbFiltros.Controls.SetChildIndex(this.myGymEntero1, 0);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Titulo = "Socios";
            // 
            // btnVerClases
            // 
            this.btnVerClases.BackColor = System.Drawing.Color.Transparent;
            this.btnVerClases.FlatAppearance.BorderSize = 0;
            this.btnVerClases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerClases.Location = new System.Drawing.Point(292, 8);
            this.btnVerClases.Name = "btnVerClases";
            this.btnVerClases.Size = new System.Drawing.Size(84, 49);
            this.btnVerClases.TabIndex = 5;
            this.btnVerClases.Text = "Ver Clases";
            this.btnVerClases.UseVisualStyleBackColor = false;
            // 
            // btnProcesarPago
            // 
            this.btnProcesarPago.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesarPago.FlatAppearance.BorderSize = 0;
            this.btnProcesarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesarPago.Location = new System.Drawing.Point(382, 8);
            this.btnProcesarPago.Name = "btnProcesarPago";
            this.btnProcesarPago.Size = new System.Drawing.Size(84, 49);
            this.btnProcesarPago.TabIndex = 6;
            this.btnProcesarPago.Text = "Procesar Pago";
            this.btnProcesarPago.UseVisualStyleBackColor = false;
            // 
            // btnVerificarVenc
            // 
            this.btnVerificarVenc.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificarVenc.FlatAppearance.BorderSize = 0;
            this.btnVerificarVenc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarVenc.Location = new System.Drawing.Point(472, 8);
            this.btnVerificarVenc.Name = "btnVerificarVenc";
            this.btnVerificarVenc.Size = new System.Drawing.Size(100, 49);
            this.btnVerificarVenc.TabIndex = 7;
            this.btnVerificarVenc.Text = "Verificar Vencimientos Membresías";
            this.btnVerificarVenc.UseVisualStyleBackColor = false;
            // 
            // myGymEntero1
            // 
            this.myGymEntero1.AlinearTexto = System.Drawing.ContentAlignment.MiddleLeft;
            this.myGymEntero1.BackColor = System.Drawing.Color.Transparent;
            this.myGymEntero1.ColorTexto = System.Drawing.SystemColors.ControlText;
            this.myGymEntero1.FontLabel = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myGymEntero1.Incremento = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.myGymEntero1.Location = new System.Drawing.Point(234, 24);
            this.myGymEntero1.Maximo = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.myGymEntero1.Minimo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.myGymEntero1.Name = "myGymEntero1";
            this.myGymEntero1.Obligatorio = false;
            this.myGymEntero1.Size = new System.Drawing.Size(340, 26);
            this.myGymEntero1.TabIndex = 2;
            this.myGymEntero1.Titulo = "Codigo Socio:";
            // 
            // GestionarSociosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "GestionarSociosFrm";
            this.Text = "GestionarSociosFrm";
            this.pnlBotones.ResumeLayout(false);
            this.pnlActualizar.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.pnlGrd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerificarVenc;
        private System.Windows.Forms.Button btnProcesarPago;
        private System.Windows.Forms.Button btnVerClases;
        private MyGymEntero myGymEntero1;
    }
}