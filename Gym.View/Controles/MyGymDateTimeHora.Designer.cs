namespace Gym.View
{
    partial class MyGymDateTimeHora
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
            this.myGymDate1 = new Gym.View.MyGymDate();
            this.numHora = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.myGymDate1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.numHora);
            this.splitContainer1.Size = new System.Drawing.Size(340, 26);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // myGymDate1
            // 
            this.myGymDate1.BackColor = System.Drawing.Color.Transparent;
            this.myGymDate1.Descripcion = "Descripción:";
            this.myGymDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGymDate1.Location = new System.Drawing.Point(0, 0);
            this.myGymDate1.Margin = new System.Windows.Forms.Padding(4);
            this.myGymDate1.Name = "myGymDate1";
            this.myGymDate1.Size = new System.Drawing.Size(285, 26);
            this.myGymDate1.TabIndex = 0;
            // 
            // numHora
            // 
            this.numHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHora.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHora.Location = new System.Drawing.Point(0, 0);
            this.numHora.Margin = new System.Windows.Forms.Padding(4);
            this.numHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHora.Name = "numHora";
            this.numHora.ReadOnly = true;
            this.numHora.Size = new System.Drawing.Size(51, 26);
            this.numHora.TabIndex = 0;
            // 
            // MyGymDateTimeHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyGymDateTimeHora";
            this.Size = new System.Drawing.Size(340, 26);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numHora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyGymDate myGymDate1;
        private System.Windows.Forms.NumericUpDown numHora;
    }
}
