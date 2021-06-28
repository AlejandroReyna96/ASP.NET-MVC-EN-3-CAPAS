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

        public Departamento Detail(int id)
        {
            using(var db = new ProyectosDBEntities())
            {
                return db.Departamento.Find(id);
            }
        }

        public void Editar(Departamento departamento)
        {
            using (var db = new ProyectosDBEntities())
            {
                var departamentoNuevo = db.Departamento.Find(departamento.DepartamentoId);

                if(departamentoNuevo != null)
                    departamentoNuevo.NombreDepartamento = departamento.NombreDepartamento;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using(var db = new ProyectosDBEntities())
            {
                var departamento = db.Departamento.Find(id);
                db.Departamento.Remove(departamento);
                db.SaveChanges();
            }
        }
    }
}
