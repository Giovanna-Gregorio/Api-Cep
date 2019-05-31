using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCep2.Models
{
    public class CEPContexto : DbContext
    {
        public CEPContexto(DbContextOptions<CEPContexto> options) : base(options)
        {
        }
        public DbSet<CEP> CEP { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CEP>().HasKey(x => x.Cep);
            base.OnModelCreating(builder);
        }
    }
}
