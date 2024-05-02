using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Progra_4_Progreso_1.Models;

namespace Progra_4_Progreso_1.Data
{
    public class Progra_4_Progreso_1Context : DbContext
    {
        public Progra_4_Progreso_1Context (DbContextOptions<Progra_4_Progreso_1Context> options)
            : base(options)
        {
        }

        public DbSet<Progra_4_Progreso_1.Models.Ricardo> Ricardo { get; set; } = default!;

        public DbSet<Progra_4_Progreso_1.Models.Carrera>? Carrera { get; set; }
    }
}
