using Microsoft.EntityFrameworkCore;
using ServiFacil.Models.ServiFacilModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiFacil.Context.Context
{
    public class ServiFacilContext:DbContext
    {
        public DbSet<Citas> Citas { get; set; } 
        public DbSet<Clientes> Clientes { get; set; } 
        public DbSet<Empresas> Empresas { get; set; } 
        public DbSet<Servicios> Servicios { get; set; }   
    }
}
