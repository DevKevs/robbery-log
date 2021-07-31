using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rob_master.Models;

namespace Rob_master.Data
{
    public class Dataprocess
    {
        robosContext db = new robosContext();
        public void AddRobo(Denuncias obj)
        {
            db.Denuncias.Add(obj);
            db.SaveChanges();
        }

        public void UpdateRobo(Denuncias obj)
        {
            var query = from r in db.Denuncias
                        where r.Id == obj.Id
                        select r;
            Denuncias registro = query.First();
            registro.Cedula = obj.Cedula;
            registro.Nombre = obj.Nombre;
            registro.Descripcion = obj.Descripcion;
            registro.Valor = obj.Valor;
            registro.Lugar = obj.Lugar;
            registro.Latitud = obj.Latitud;
            registro.Longitud = obj.Longitud;

            db.SaveChanges();
        }
    }
}
