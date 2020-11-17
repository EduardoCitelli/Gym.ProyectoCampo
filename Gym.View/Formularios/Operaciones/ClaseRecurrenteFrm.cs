namespace Gym.View.Formularios
{
    using Common;
    using Gym.Controladora;
    using Gym.Domain;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ClaseRecurrenteFrm : FormABMBase
    {
        private readonly ClasesController clasesController;

        public ClaseRecurrenteFrm(ClasesController clasesController)
        {
            this.InitializeComponent();

            this.clasesController = clasesController;

            this.CargarCombos();            
        }

        private void CargarCombos()
        {
            this.comboActividad.Refrescar();
            this.comboAuxiliar.Refrescar();
            this.comboTitular.Refrescar();
            this.comboSalon.Refrescar();
            this.CargarListBox();
        }

        private void CargarListBox()
        {
            this.listBoxDias.DataSource = null;
            this.listBoxDias.DataSource = DateTimeExtensionMethods.GetWeeksDays().Where(x => x != DayOfWeek.Sunday).ToList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.Validar()) return;

            var diasParaDarDeAlta = new List<DateTime>();

            foreach (var day in this.listBoxDias.CheckedItems.Cast<DayOfWeek>().ToList())
            {
                this.CargarFechasMesActual(diasParaDarDeAlta, day);
            }

            if (this.numMeses.GetValor() >= 2)
            {
                var anio = DateTime.Today.Month + 1 > 12 ? DateTime.Today.Year + 1 : DateTime.Today.Year;
                var mes = DateTime.Today.Month + 1 > 12 ? 1 : DateTime.Today.Month + 1;

                foreach (var day in this.listBoxDias.CheckedItems.Cast<DayOfWeek>().ToList())
                {
                    this.CargarFechasMesSiguiente(diasParaDarDeAlta, anio, mes, day);
                }
            }

            if (this.numMeses.GetValor() == 3)
            {
                var anio = DateTime.Today.Month + 2 > 12 ? DateTime.Today.Year + 1 : DateTime.Today.Year;
                var mes = DateTime.Today.Month + 2 > 13 ? 2 : DateTime.Today.Month + 2 > 12 ? 1 : DateTime.Today.Month + 2;

                foreach (var day in this.listBoxDias.CheckedItems.Cast<DayOfWeek>().ToList())
                {
                    this.CargarFechasMesDespuesDelSiguiente(diasParaDarDeAlta, anio, mes, day);
                }
            }

            var clases = new List<Clases>();

            foreach (var dia in diasParaDarDeAlta.OrderBy(x => x))
            {
                var hora = this.dtInicio.GetHora().Value.Hour;

                var inicio = dia.AddHours(hora);

                var clase = new Clases()
                {
                    cls_Descripcion = this.txtDescripcion.GetValor(),
                    cls_FechaInicio = inicio,
                    cls_FechaFinal = inicio.AddHours(this.numDuracion.GetValor()),
                    cls_act_Codigo = this.comboActividad.GetValor().act_Codigo,
                    cls_sal_Codigo = this.comboSalon.GetValor().sal_Codigo,
                    cls_pro_Titular = this.comboTitular.GetValor().pro_Codigo,
                    cls_Estado = "P"
                };

                var codigoAuxiliar = this.comboAuxiliar.GetValor().pro_Codigo;

                if (codigoAuxiliar != 0)
                    clase.cls_pro_Auxiliar = codigoAuxiliar;

                clases.Add(clase);
            }

            var exito = false;

            try
            {
                var mensaje = $"Está a punto de un alta reccurente de {this.comboActividad.GetValor().act_Descripcion} a las {this.dtInicio.GetHora().Value.Hour}Hs por {this.numMeses.GetValor()} meses, está seguro de realizar la acción?";

                var result = MessageBox.Show(mensaje, "ALTA RECURRENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    exito = this.clasesController.GuardarClasesRecurrente(clases);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregar Clase Recurrente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (exito)
            {
                MessageBox.Show("Alta Masiva Realizada Correctamente", "ALTA RECURRENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CargarFechasMesDespuesDelSiguiente(List<DateTime> diasParaDarDeAlta, int anio, int mes, DayOfWeek day)
        {
            var diasDelMes = DateTimeExtensionMethods.TodosLosDiasDelMes(anio, mes);

            diasDelMes = diasDelMes.Where(x => x.DayOfWeek == day && x > DateTime.Today).ToList();

            diasParaDarDeAlta.AddRange(diasDelMes);
        }

        private void CargarFechasMesSiguiente(List<DateTime> diasParaDarDeAlta, int anio, int mes, DayOfWeek day)
        {
            var diasDelMes = DateTimeExtensionMethods.TodosLosDiasDelMes(anio, mes);

            diasDelMes = diasDelMes.Where(x => x.DayOfWeek == day && x > DateTime.Today).ToList();

            diasParaDarDeAlta.AddRange(diasDelMes);
        }

        private void CargarFechasMesActual(List<DateTime> diasParaDarDeAlta, DayOfWeek day)
        {
            var diasDelMes = DateTimeExtensionMethods.TodosLosDiasDelMes(DateTime.Today.Year, DateTime.Today.Month);

            diasDelMes = diasDelMes.Where(x => x.DayOfWeek == day && x > DateTime.Today).ToList();

            diasParaDarDeAlta.AddRange(diasDelMes);
        }

        private bool Validar() => !this.txtDescripcion.Validar() ? false : this.numDuracion.Validar();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
