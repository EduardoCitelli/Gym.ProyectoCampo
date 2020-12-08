namespace Gym.View
{
    using System;
    using System.IO;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Data.SqlClient;

    public partial class DbBackupFrm : Form
    {
        private SqlCommand cmd;
        private readonly SqlConnection sqlCon;
        private readonly string conString = "Data Source=EDU-PC\\EDU; Initial Catalog=MyGym;integrated security=True;MultipleActiveResultSets=True;";

        public DbBackupFrm()
        {
            this.InitializeComponent();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
        }

        private void DbBackupFrm_Load(object sender, EventArgs e)
        {
            this.LoadBackinfo();

            if (this.LinkLabel1.Text == string.Empty)
                this.LinkLabel1.Text = "Click para elegir el directorio";
        }

        private void LoadBackinfo()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            var dsData = new DataSet();

            this.cmd = new SqlCommand("DATABASE_BACKUP", this.sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };

            this.cmd.Parameters.AddWithValue("@ACTIONTYPE", "BACKUP_INFO");

            var sda = new SqlDataAdapter(this.cmd);
            sda.Fill(dsData);

            if (dsData.Tables.Count > 0)
            {
                if (dsData.Tables[0].Rows.Count > 0)
                {
                    this.LinkLabel1.Text = dsData.Tables[0].Rows[0]["Ubicacion"].ToString();

                    this.txtNoOfFiles.Text = dsData.Tables[0].Rows[0]["NumeroDeArchivos"].ToString();

                    this.txtSpan.Text = dsData.Tables[0].Rows[0]["IntervaloDias"].ToString();

                    this.txtDbName.Text = dsData.Tables[0].Rows[0]["DatabaseName"].ToString();

                    this.linkLabel2.Text = dsData.Tables[0].Rows[0]["Ubicacion"].ToString();

                    this.linkLabel3.Text = dsData.Tables[0].Rows[0]["DatabaseName"].ToString() + "-" + DateTime.Now.ToString("ddMMyyyyHHmmssfff") + ".bak";
                }

                this.lblLastBackupInfo.Text = dsData.Tables[1].Rows.Count > 0
                    ? string.Format("El ultimo Backup fue Hecho {0} a las {1} en el destino {2}.", dsData.Tables[1].Rows[0]["TipoBackup"].ToString(), dsData.Tables[1].Rows[0]["FechaBackUp"].ToString(), dsData.Tables[1].Rows[0]["Ubicacion"].ToString())
                    : "Sin Backups !!!";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (LinkLabel1.Text == "Click para elegir Carpeta")
                MessageBox.Show("Click para setear directorio", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (txtSpan.Text == string.Empty)
                MessageBox.Show("Ingrese cuantos archivos de respaldo requeridos ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                int numFlag;

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                this.cmd = new SqlCommand("DATABASE_BACKUP", this.sqlCon);
                this.cmd.CommandType = CommandType.StoredProcedure;

                this.cmd.Parameters.AddWithValue("@ACTIONTYPE", "INSERT_BACKUP_INFO");

                this.cmd.Parameters.AddWithValue("@DatabaseName", this.txtDbName.Text);

                this.cmd.Parameters.AddWithValue("@Location", this.LinkLabel1.Text);

                this.cmd.Parameters.AddWithValue("@DayInterval", this.txtSpan.Text);

                this.cmd.Parameters.AddWithValue("@SoftwareDate", this.DateTimePicker1.Text);

                this.cmd.Parameters.AddWithValue("@NoOfFiles", this.txtNoOfFiles.Text);

                numFlag = cmd.ExecuteNonQuery();

                if (numFlag > 0)
                {
                    MessageBox.Show("Información guardada correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadBackinfo();
                }
                else
                    MessageBox.Show("No se pudo guardar. Por favor intente nuevamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBarEx5.Value += 1;

            if (this.ProgressBarEx5.Value == 100)
            {
                this.ProgressBarEx5.Visible = false;
                this.Timer1.Stop();
                this.Panel1.Visible = false;
                this.ProgressBarEx5.Text = "Finalizado";
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.FolderBrowserDialog1.ShowDialog();

            this.LinkLabel1.Text = this.FolderBrowserDialog1.SelectedPath;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (this.linkLabel2.Text == string.Empty)
                MessageBox.Show("Por favor eligé la configuración del backup", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            else if (linkLabel3.Text == string.Empty)
                MessageBox.Show("Por favor eligé la configuración del backup", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                var filaPath = !this.linkLabel2.Text.EndsWith(@"\") ? this.linkLabel2.Text + @"\" + this.linkLabel3.Text : this.linkLabel2.Text + this.linkLabel3.Text;

                int numFlag;

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                this.cmd = new SqlCommand("DATABASE_BACKUP", this.sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                this.cmd.Parameters.AddWithValue("@ACTIONTYPE", "DB_BACKUP");

                this.cmd.Parameters.AddWithValue("@DATABASE", txtDbName.Text);

                this.cmd.Parameters.AddWithValue("@FILEPATH", filaPath);

                this.cmd.Parameters.AddWithValue("@BackupName", linkLabel3.Text);

                this.cmd.Parameters.AddWithValue("@SoftwareDate", DateTimePicker1.Text);

                this.cmd.Parameters.AddWithValue("@Type", "Manually");

                numFlag = this.cmd.ExecuteNonQuery();

                var dtLoc = new DataTable();

                this.cmd = new SqlCommand("DATABASE_BACKUP", this.sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };

                this.cmd.Parameters.AddWithValue("@ACTIONTYPE", "REMOVE_LOCATION");

                var da = new SqlDataAdapter(this.cmd);

                da.Fill(dtLoc);

                for (int i = 0; i < dtLoc.Rows.Count; i++)
                {
                    string delLoc = dtLoc.Rows[i][0].ToString();

                    string filepath = delLoc;

                    if (File.Exists(filepath))
                        File.Delete(filepath);
                }
                if (numFlag > 0)
                {
                    this.Panel1.Visible = true;

                    this.Panel1.Location = new Point(58, 138);

                    this.Panel1.Height = 117;

                    this.Panel1.Width = 446;

                    this.ProgressBarEx5.Visible = true;

                    this.ProgressBarEx5.Value = 0;

                    this.Timer1.Start();

                    this.LoadBackinfo();
                }
                else
                    MessageBox.Show("Por favor Intente nuevamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void txtSpan_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 46 && e.KeyChar != 8;
    }
}
