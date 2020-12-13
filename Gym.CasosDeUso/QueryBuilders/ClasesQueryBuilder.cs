namespace Gym.CasosDeUso
{
    using Common;
    using Gym.Domain;
    using System;
    using System.Linq.Expressions;

    public class ClasesQueryBuilder : IClasesQueryBuilder
    {
        public Expression<Func<Clases, bool>> ObtenerQuerySalonOcupado(Clases clase)
        {
            Expression<Func<Clases, bool>> query = x => true;

            query = query.And(this.QueryMismoSalon(clase.cls_sal_Codigo));

            query = query.And(this.QueryEstadoAlta());

            query = query.And(this.QueryDistintoId(clase.cls_Id));

            query = query.And(this.QueryHorarioOcupado(clase.cls_FechaInicio, clase.cls_FechaFinal));

            return query;
        }

        public Expression<Func<Clases, bool>> ObtenerQueryProfesorOcupado(Clases clase)
        {
            Expression<Func<Clases, bool>> query = x => true;

            query = query.And(this.QueryMismoProfesor(clase.cls_pro_Titular));

            query = query.And(this.QueryEstadoAlta());

            query = query.And(this.QueryDistintoId(clase.cls_Id));

            query = query.And(this.QueryHorarioOcupado(clase.cls_FechaInicio, clase.cls_FechaFinal));

            return query;
        }

        private Expression<Func<Clases, bool>> QueryMismoSalon(int CodigoSalon) => x => x.cls_sal_Codigo == CodigoSalon;

        private Expression<Func<Clases, bool>> QueryMismoProfesor(int CodigoProfesor) => x => x.cls_pro_Titular == CodigoProfesor;

        private Expression<Func<Clases, bool>> QueryEstadoAlta() => x => x.cls_Estado == "A";

        private Expression<Func<Clases, bool>> QueryDistintoId(int idClase) => x => x.cls_Id != idClase;

        private Expression<Func<Clases, bool>> QueryHorarioOcupado(DateTime horarioInicio, DateTime horarioFinal) => x => x.cls_FechaInicio <= horarioInicio && x.cls_FechaFinal > horarioInicio
                                                                                                                       || x.cls_FechaInicio < horarioFinal && x.cls_FechaFinal >= horarioFinal;
    }
}
