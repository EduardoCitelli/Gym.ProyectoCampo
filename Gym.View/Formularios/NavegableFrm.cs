namespace Gym.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class NavegableFrm : Form
    {
        public NavegableFrm()
        {
            this.InitializeComponent();
        }

        public void Navigate(string url)
        {
            this.wb.Navigate(url);
        }

        private void btnCerrar_Click(object sender, EventArgs e) => this.Close();
    }
}
