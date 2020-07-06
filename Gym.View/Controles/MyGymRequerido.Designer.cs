namespace Gym.View
{
    partial class MyGymRequerido
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
            this.picRequired = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRequired)).BeginInit();
            this.SuspendLayout();
            // 
            // picRequired
            // 
            this.picRequired.BackColor = System.Drawing.Color.Transparent;
            this.picRequired.BackgroundImage = global::Gym.View.Properties.Resources.Math_multiply_icon;
            this.picRequired.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRequired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picRequired.Location = new System.Drawing.Point(0, 0);
            this.picRequired.Name = "picRequired";
            this.picRequired.Size = new System.Drawing.Size(36, 32);
            this.picRequired.TabIndex = 0;
            this.picRequired.TabStop = false;
            // 
            // MyGymRequerido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picRequired);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyGymRequerido";
            this.Size = new System.Drawing.Size(36, 32);
            ((System.ComponentModel.ISupportInitialize)(this.picRequired)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRequired;
    }
}
