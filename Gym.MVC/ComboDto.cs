namespace Gym.MVC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Web;

    [DataContract]
    public class ComboDto
    {
        public ComboDto()
        {
        }

        public ComboDto(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }

        public ComboDto(string id, string descripcion)
        {
            this.IdString = id;
            this.Descripcion = descripcion;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public string IdString { get; set; }
    }
}