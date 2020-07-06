namespace Gym.Domain
{    
    public partial class Membresias
    {
        public int GetMeses() => this.Tipo.tmm_CantidadMeses;

        public int? GetClases() => this.Tipo.tmm_CantidadClases;
    }
}
