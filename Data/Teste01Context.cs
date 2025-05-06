using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teste01.Models;

namespace Teste01.Data
{
    public class Teste01Context : DbContext
    {
        public Teste01Context (DbContextOptions<Teste01Context> options)
            : base(options)
        {
        }

        public DbSet<Teste01.Models.Departamento> Departamento { get; set; } = default!;
    }
}
