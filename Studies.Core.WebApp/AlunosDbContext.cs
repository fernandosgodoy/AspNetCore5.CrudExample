using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studies.Core.WebApp
{
    public class AlunosDbContext
        : DbContext
    {
        public AlunosDbContext(DbContextOptions<AlunosDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
