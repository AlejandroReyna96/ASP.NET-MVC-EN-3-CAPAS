using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DepartamentoDALC
    {
        public List<Departamento> ListarDepartamentos()
        {
            using (var db = new ProyectosDBEntities())
            {
                return db.Departamento.ToList();
            }
        }

        public void Agregar(Departamento departamento)
        {
            using (var db = new ProyectosDBEntities())
            {
                db.Departamento.Add(departamento);
                db.SaveChanges();
            }
        }

    }
}
