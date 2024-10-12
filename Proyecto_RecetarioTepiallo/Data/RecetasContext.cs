using Microsoft.EntityFrameworkCore;
using Proyecto_RecetarioTepiallo.Models;
using System;

namespace Proyecto_RecetarioTepiallo.Data
{
    public class RecetasContext: DbContext
    {
        public RecetasContext(DbContextOptions<RecetasContext> o) : base(o) { }
        public DbSet<Recetas> RecetasSet { get; set; }
    }
}
