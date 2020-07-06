using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gym.Datos
{
    public abstract class ConeccionSql
    {
        private readonly string connectionString;

        public ConeccionSql()
        {
            this.connectionString = "Server= EDUVINO-PC\\EDU; DataBase= MyGym; integrated security= true";
        }

        protected SqlConnection GetConnection() => new SqlConnection(this.connectionString);
    }
}
