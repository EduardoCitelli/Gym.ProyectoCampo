namespace Gym.View
{
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public class FormulariosManager
    {   
        public void AbrirFormulario<MyForm>(PanelColores panel, MenuFrm menu, object btn, string url) where MyForm : Form, new()
        {
            Form formulario;

            formulario = panel.Controls.OfType<MyForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MyForm
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panel.Controls.Add(formulario);

                panel.Tag = formulario;

                formulario.Show();

                formulario.BringToFront();

                formulario.FormClosed += new FormClosedEventHandler(menu.CloseForms);

                var tipo = btn.GetType();

                if (tipo.Name == nameof(Button)) ((Button)btn).BackColor = Color.SpringGreen;                
                else ((ToolStripMenuItem)btn).BackColor = Color.SpringGreen;
            }
            else
                formulario.BringToFront();

            if (formulario.GetType() == typeof(NavegableFrm))
                ((NavegableFrm)formulario).Navigate(url);
        }
    }
}
