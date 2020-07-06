namespace Gym.View
{
    partial class MyGymDate
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
            this.picObligatorio = new Gym.View.MyGymRequerido();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dte = new Gym.View.MyGymDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picObligatorio);
            this.splitContainer1.Panel1.Controls.Add(this.lblDescripcion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dte);
            this.splitContainer1.Size = new System.Drawing.Size(340, 26);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // picObligatorio
            // 
            this.picObligatorio.Dock = System.Windows.Forms.DockStyle.Right;
            this.picObligatorio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picObligatorio.Location = new System.Drawing.Point(144, 0);
            this.picObligatorio.Margin = new System.Windows.Forms.Padding(4);
            this.picObligatorio.Name = "picObligatorio";
            this.picObligatorio.Size = new System.Drawing.Size(36, 26);
            this.picObligatorio.TabIndex = 1;
            this.picObligatorio.TabStop = false;
            this.picObligatorio.VisibleNoColapsado = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescripcion.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(0, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(147, 26);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dte
            // 
            this.dte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dte.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte.Location = new System.Drawing.Point(0, 0);
            this.dte.Name = "dte";
            this.dte.Size = new System.Drawing.Size(156, 26);
            this.dte.TabIndex = 0;
            this.dte.Enter += new System.EventHandler(this.Dte_Enter);
            // 
            // MyGymDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MyGymDate";
            this.Size = new System.Drawing.Size(340, 26);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblDescripcion;
        private MyGymDateTimePicker dte;
        private MyGymRequerido picObligatorio;
    }
}
