namespace Gym.MVC.Models
{
    using Gym.Domain;

    public class MembresiasActivasModel
    {
        public MembresiasActivasModel(VwMembresiasActivas membresias)
        {
            this.Codigo = membresias.Codigo;
            this.Membresia = membresias.Membresia;
            this.Cantidad = membresias.Cantidad;
        }

        public int Codigo { get; set; }

        public string Membresia { get; set; }

        public int Cantidad { get; set; }
    }
}