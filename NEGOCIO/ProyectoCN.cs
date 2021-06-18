using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DATOS;

namespace NEGOCIO
{
    public class ProyectoCN
    {
        private static ProyectoDALC obj = new ProyectoDALC();

        // estáticos porque en la presentación no se necesita instanciar 
        public static List<Proyecto> ListarProyectos()
        {
            return obj.ListarProyectos();
        }

        public static void Agregar(Proyecto proyecto)
        {
            if(obj.Agregar(proyecto))
            {
                // hacer algo.... 
            }
    
        }
    }
}
