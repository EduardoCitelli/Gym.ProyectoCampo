namespace Gym.View
{
    partial class MyGymDateTime
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.myGymDate1 = new Gym.View.MyGymDate();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.myGymDate1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtHora);
            this.splitContainer1.Size = new System.Drawing.Size(340, 26);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtHora
            // 
            this.txtHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHora.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(0, 0);
            this.txtHora.Mask = "99:99";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(51, 26);
            this.txtHora.TabIndex = 0;
            // 
            // myGymDate1
            // 
            this.myGymDate1.BackColor = System.Drawing.Color.Transparent;
            this.myGymDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGymDate1.Location = new System.Drawing.Point(0, 0);
            this.myGymDate1.Name = "myGymDate1";
            this.myGymDate1.Size = new System.Drawing.Size(285, 26);
            this.myGymDate1.TabIndex = 0;
            // 
            // MyGymDateTime
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MyGymDateTime";
            this.Size = new System.Drawing.Size(340, 26);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyGymDate myGymDate1;
        private System.Windows.Forms.MaskedTextBox txtHora;
    }
}
