using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class ProyectoDALC // usar "repositorio"
    {

        public List<Proyecto> ListarProyectos()
        {
            using(var db = new ProyectosDBEntities())
            {
                return db.Proyecto.ToList();
            }
        }

        public bool Agregar(Proyecto proyecto) // algunos usan bool para saber si se guardó bien...
        {
            using (var db = new ProyectosDBEntities())
            {
                db.Proyecto.Add(proyecto);
                db.SaveChanges();
                return true;
            }
        }



    }
}
