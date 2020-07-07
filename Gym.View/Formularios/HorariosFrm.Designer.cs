namespace Gym.View.Formularios
{
    partial class HorariosFrm
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
            this.colLunes = new Gym.View.Controles.MyGymCalendario();
            this.colMartes = new Gym.View.Controles.MyGymCalendario();
            this.colMiercoles = new Gym.View.Controles.MyGymCalendario();
            this.colJueves = new Gym.View.Controles.MyGymCalendario();
            this.colViernes = new Gym.View.Controles.MyGymCalendario();
            this.colSabado = new Gym.View.Controles.MyGymCalendario();
            this.SuspendLayout();
            // 
            // colLunes
            // 
            this.colLunes.AutoScroll = true;
            this.colLunes.Dock = System.Windows.Forms.DockStyle.Left;
            this.colLunes.Location = new System.Drawing.Point(0, 0);
            this.colLunes.Name = "colLunes";
            this.colLunes.Size = new System.Drawing.Size(196, 450);
            this.colLunes.TabIndex = 0;
            this.colLunes.Text = "myGymCalendario1";
            // 
            // colMartes
            // 
            this.colMartes.AutoScroll = true;
            this.colMartes.Dock = System.Windows.Forms.DockStyle.Left;
            this.colMartes.Location = new System.Drawing.Point(196, 0);
            this.colMartes.Name = "colMartes";
            this.colMartes.Size = new System.Drawing.Size(196, 450);
            this.colMartes.TabIndex = 1;
            this.colMartes.Text = "myGymCalendario2";
            // 
            // colMiercoles
            // 
            this.colMiercoles.AutoScroll = true;
            this.colMiercoles.Dock = System.Windows.Forms.DockStyle.Left;
            this.colMiercoles.Location = new System.Drawing.Point(392, 0);
            this.colMiercoles.Name = "colMiercoles";
            this.colMiercoles.Size = new System.Drawing.Size(196, 450);
            this.colMiercoles.TabIndex = 1;
            this.colMiercoles.Text = "myGymCalendario3";
            // 
            // colJueves
            // 
            this.colJueves.AutoScroll = true;
            this.colJueves.Dock = System.Windows.Forms.DockStyle.Left;
            this.colJueves.Location = new System.Drawing.Point(588, 0);
            this.colJueves.Name = "colJueves";
            this.colJueves.Size = new System.Drawing.Size(196, 450);
            this.colJueves.TabIndex = 2;
            this.colJueves.Text = "myGymCalendario4";
            // 
            // colViernes
            // 
            this.colViernes.AutoScroll = true;
            this.colViernes.Dock = System.Windows.Forms.DockStyle.Left;
            this.colViernes.Location = new System.Drawing.Point(784, 0);
            this.colViernes.Name = "colViernes";
            this.colViernes.Size = new System.Drawing.Size(196, 450);
            this.colViernes.TabIndex = 3;
            this.colViernes.Text = "myGymCalendario5";
            // 
            // colSabado
            // 
            this.colSabado.AutoScroll = true;
            this.colSabado.Dock = System.Windows.Forms.DockStyle.Left;
            this.colSabado.Location = new System.Drawing.Point(980, 0);
            this.colSabado.Name = "colSabado";
            this.colSabado.Size = new System.Drawing.Size(196, 450);
            this.colSabado.TabIndex = 4;
            this.colSabado.Text = "myGymCalendario6";
            // 
            // HorariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.colSabado);
            this.Controls.Add(this.colViernes);
            this.Controls.Add(this.colJueves);
            this.Controls.Add(this.colMiercoles);
            this.Controls.Add(this.colMartes);
            this.Controls.Add(this.colLunes);
            this.Name = "HorariosFrm";
            this.Text = "HorariosFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.MyGymCalendario colLunes;
        private Controles.MyGymCalendario colMartes;
        private Controles.MyGymCalendario colMiercoles;
        private Controles.MyGymCalendario colJueves;
        private Controles.MyGymCalendario colViernes;
        private Controles.MyGymCalendario colSabado;
    }
}