using DATOS;
using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEGOCIO
{
    public class DepartamentoCN
    {
        private static DepartamentoDALC obj = new DepartamentoDALC();
        public static List<Departamento> ListarDepartamentos()
        {
            return obj.ListarDepartamentos();
        }

        public static void Agregar(Departamento departamento)
        {
            obj.Agregar(departamento);
        }

        public static Departamento Detail(int id)
        {
            return obj.Detail(id);
        }

        public static void Editar(Departamento departamento)
        {
            obj.Editar(departamento);
        }
    }
}
