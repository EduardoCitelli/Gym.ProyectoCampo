namespace Gym.View
{
    partial class ComboBase
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
            this.combo = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo
            // 
            this.combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(183, 0);
            this.combo.Margin = new System.Windows.Forms.Padding(4);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(157, 26);
            this.combo.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(183, 26);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Descripcion:";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.combo);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComboBase";
            this.Size = new System.Drawing.Size(340, 26);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label lbl;
    }
}
