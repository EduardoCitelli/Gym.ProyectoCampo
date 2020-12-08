namespace Gym.View
{

    partial class DbBackupFrm
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
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelColores1 = new Gym.View.PanelColores();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label9 = new System.Windows.Forms.Label();
            this.ProgressBarEx5 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpan = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label8 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoOfFiles = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLastBackupInfo = new System.Windows.Forms.Label();
            this.pnlBotones = new Gym.View.PanelColores();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelColores1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FolderBrowserDialog1
            // 
            this.FolderBrowserDialog1.SelectedPath = "C:\\ProgramData\\PRM System\\Backup\\";
            // 
            // panelColores1
            // 
            this.panelColores1.ColorAbajo = System.Drawing.Color.LimeGreen;
            this.panelColores1.ColorArriba = System.Drawing.Color.DarkSeaGreen;
            this.panelColores1.Controls.Add(this.Panel1);
            this.panelColores1.Controls.Add(this.label3);
            this.panelColores1.Controls.Add(this.label1);
            this.panelColores1.Controls.Add(this.txtSpan);
            this.panelColores1.Controls.Add(this.Label21);
            this.panelColores1.Controls.Add(this.btnSave);
            this.panelColores1.Controls.Add(this.Label7);
            this.panelColores1.Controls.Add(this.LinkLabel1);
            this.panelColores1.Controls.Add(this.Label8);
            this.panelColores1.Controls.Add(this.DateTimePicker1);
            this.panelColores1.Controls.Add(this.btnBackup);
            this.panelColores1.Controls.Add(this.label4);
            this.panelColores1.Controls.Add(this.label5);
            this.panelColores1.Controls.Add(this.txtDbName);
            this.panelColores1.Controls.Add(this.label6);
            this.panelColores1.Controls.Add(this.label13);
            this.panelColores1.Controls.Add(this.label22);
            this.panelColores1.Controls.Add(this.label20);
            this.panelColores1.Controls.Add(this.linkLabel2);
            this.panelColores1.Controls.Add(this.linkLabel3);
            this.panelColores1.Controls.Add(this.label2);
            this.panelColores1.Controls.Add(this.txtNoOfFiles);
            this.panelColores1.Controls.Add(this.label10);
            this.panelColores1.Controls.Add(this.label11);
            this.panelColores1.Controls.Add(this.label12);
            this.panelColores1.Controls.Add(this.lblLastBackupInfo);
            this.panelColores1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColores1.Location = new System.Drawing.Point(0, 0);
            this.panelColores1.Name = "panelColores1";
            this.panelColores1.Size = new System.Drawing.Size(991, 507);
            this.panelColores1.TabIndex = 1375;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.ProgressBarEx5);
            this.Panel1.Location = new System.Drawing.Point(255, 181);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(446, 117);
            this.Panel1.TabIndex = 1354;
            this.Panel1.Visible = false;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label9.Location = new System.Drawing.Point(9, 23);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(238, 17);
            this.Label9.TabIndex = 33;
            this.Label9.Text = "Inicializando Backup, Por favor Espere...";
            // 
            // ProgressBarEx5
            // 
            this.ProgressBarEx5.Location = new System.Drawing.Point(12, 50);
            this.ProgressBarEx5.Name = "ProgressBarEx5";
            this.ProgressBarEx5.Size = new System.Drawing.Size(421, 18);
            this.ProgressBarEx5.TabIndex = 33;
            this.ProgressBarEx5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(378, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 1355;
            this.label3.Text = "Fecha : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 1367;
            this.label1.Text = "Auto Backup cada: ";
            // 
            // txtSpan
            // 
            this.txtSpan.Location = new System.Drawing.Point(175, 85);
            this.txtSpan.MaxLength = 2;
            this.txtSpan.Name = "txtSpan";
            this.txtSpan.Size = new System.Drawing.Size(57, 25);
            this.txtSpan.TabIndex = 1368;
            this.txtSpan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpan_KeyPress);
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.SeaGreen;
            this.Label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.White;
            this.Label21.Location = new System.Drawing.Point(2, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(987, 25);
            this.Label21.TabIndex = 3;
            this.Label21.Text = "CONFIGURACIÓN DE BACKUP";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(223, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 25);
            this.btnSave.TabIndex = 1349;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label7.Location = new System.Drawing.Point(24, 63);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(132, 17);
            this.Label7.TabIndex = 1351;
            this.Label7.Text = "Directorio a Guardar:";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel1.Location = new System.Drawing.Point(173, 63);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(0, 17);
            this.LinkLabel1.TabIndex = 1352;
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label8.Location = new System.Drawing.Point(8, 273);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(142, 25);
            this.Label8.TabIndex = 1353;
            this.Label8.Text = "Backup Manual";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Enabled = false;
            this.DateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(438, 28);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(114, 25);
            this.DateTimePicker1.TabIndex = 1348;
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.White;
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackup.Image = global::Gym.View.Properties.Resources.database;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(2, 472);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(987, 33);
            this.btnBackup.TabIndex = 1350;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(24, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 1356;
            this.label4.Text = "Carpeta Backup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(24, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 1358;
            this.label5.Text = "Nombre de Base de Datos: ";
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(201, 116);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(289, 25);
            this.txtDbName.TabIndex = 1359;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(24, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 1360;
            this.label6.Text = "Nombre Base de Datos";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(989, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(2, 505);
            this.label13.TabIndex = 1362;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(2, 505);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(989, 2);
            this.label22.TabIndex = 1363;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Dock = System.Windows.Forms.DockStyle.Left;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(2, 507);
            this.label20.TabIndex = 1364;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Location = new System.Drawing.Point(134, 307);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 17);
            this.linkLabel2.TabIndex = 1365;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Location = new System.Drawing.Point(134, 332);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(0, 17);
            this.linkLabel3.TabIndex = 1366;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(240, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 1369;
            this.label2.Text = "Numero de Archivos a Generar: ";
            // 
            // txtNoOfFiles
            // 
            this.txtNoOfFiles.Location = new System.Drawing.Point(443, 85);
            this.txtNoOfFiles.MaxLength = 2;
            this.txtNoOfFiles.Name = "txtNoOfFiles";
            this.txtNoOfFiles.Size = new System.Drawing.Size(57, 25);
            this.txtNoOfFiles.TabIndex = 1370;
            this.txtNoOfFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpan_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(8, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 25);
            this.label10.TabIndex = 1371;
            this.label10.Text = "Configuración de Backup";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(540, 2);
            this.label11.TabIndex = 1372;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(8, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 25);
            this.label12.TabIndex = 1373;
            this.label12.Text = "Info de ultimo Backup";
            // 
            // lblLastBackupInfo
            // 
            this.lblLastBackupInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblLastBackupInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastBackupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLastBackupInfo.Location = new System.Drawing.Point(24, 223);
            this.lblLastBackupInfo.Name = "lblLastBackupInfo";
            this.lblLastBackupInfo.Size = new System.Drawing.Size(506, 45);
            this.lblLastBackupInfo.TabIndex = 1374;
            this.lblLastBackupInfo.Text = "El ultimo backup fue {0} a las {1} en el destino {2}.";
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotones.ColorAbajo = System.Drawing.Color.White;
            this.pnlBotones.ColorArriba = System.Drawing.SystemColors.ActiveBorder;
            this.pnlBotones.Controls.Add(this.btnCerrar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 507);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBotones.Size = new System.Drawing.Size(991, 66);
            this.pnlBotones.TabIndex = 1375;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(898, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 52);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DbBackupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 573);
            this.Controls.Add(this.panelColores1);
            this.Controls.Add(this.pnlBotones);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DbBackupFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DbBackupFrm";
            this.Load += new System.EventHandler(this.DbBackupFrm_Load);
            this.panelColores1.ResumeLayout(false);
            this.panelColores1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ProgressBar ProgressBarEx5;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDbName;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnBackup;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog1;
        private System.Windows.Forms.Label linkLabel2;
        private System.Windows.Forms.Label linkLabel3;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpan;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.TextBox txtNoOfFiles;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lblLastBackupInfo;
        private PanelColores panelColores1;
        protected PanelColores pnlBotones;
        protected System.Windows.Forms.Button btnCerrar;
    }
}