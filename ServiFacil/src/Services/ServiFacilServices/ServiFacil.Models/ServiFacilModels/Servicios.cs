using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFacil.Models.ServiFacilModels
{
    public class Servicios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public string NombreServicio { get; set; }
        public double Valor { get; set; } 
        public string DuracionEstimada { get; set; }


    }
}
