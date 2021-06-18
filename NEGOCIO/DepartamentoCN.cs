using DATOS;
using ENTIDAD;
using System.Collections.Generic;

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
            if(departamento != null)
                obj.Editar(departamento);


        }

        public static void Eliminar(int id)
        {
            obj.Eliminar(id);
        }
    }
}
