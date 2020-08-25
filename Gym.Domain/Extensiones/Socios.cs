namespace Gym.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Socios
    {
        [NotMapped]
        public bool Chk { get; set; }

        public bool VerificarMembresia()
        {
            return !this.soc_mem_Id.HasValue
                   ? false : !this.MembresiaMesVigente()
                   ? false : this.MembresiaClasesVigente();
        }

        private bool MembresiaMesVigente() => !this.soc_FechaVtoMembresia.HasValue ? false :
                                               this.soc_FechaVtoMembresia.Value >= DateTime.Today;

        private bool MembresiaClasesVigente() => this.Membresia.Tipo.tmm_EsMensual ? true :
                                                 this.soc_CantidadClasesDisponibles.Value > 0;
    }
}
