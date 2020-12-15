namespace Gym.MVC.Models
{
    using Gym.Domain;

    public class FormaPagoModel
    {
        public FormaPagoModel(VwFormasPago forma)
        {
            this.FormaPago = forma.FormaPago;
            this.Cantidad = forma.Cantidad;
            this.ValorTotal = forma.ValorTotal;
        }

        public string FormaPago { get; set; }

        public int Cantidad { get; set; }

        public decimal ValorTotal { get; set; }
    }
}