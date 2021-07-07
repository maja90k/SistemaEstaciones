using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstaciones_DAL
{
    public class EstacionDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>();

        public void Add(Estacion es)
        {
            estaciones.Add(es);
        }

        public void Remove(int idEstacion)
        {
            Estacion estacion = estaciones.Find(es => es.IdEstacion == idEstacion);
            estaciones.Remove(estacion);
        }

        public List<Estacion> GetAll()
        {
            return estaciones;
        }

        public List<Estacion> GetAll(int idEstacion)
        {
            return estaciones.FindAll(es => es.IdEstacion == idEstacion);
        }

    }
}
