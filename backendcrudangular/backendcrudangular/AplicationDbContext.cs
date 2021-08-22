using backendcrudangular.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendcrudangular
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Tarjeta> TarjetaCredito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options) 
        { 
        
        }
    }
}
