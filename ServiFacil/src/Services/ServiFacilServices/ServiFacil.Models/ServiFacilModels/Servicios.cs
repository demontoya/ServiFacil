using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFacil.Models.ServiFacilModels
{
    public class Servicios
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string NombreServicio { get; set; }
        public double Valor { get; set; } 
        public string DuracionEstimada { get; set; }


    }
}
