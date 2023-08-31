using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFacil.Models.ServiFacilModels
{
    public class Empresas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<int> IdServicio { get; set; }
        public List<Contactos> Contacto { get; set; } 
        public string Ubicacion { get; set; }
    }
}
