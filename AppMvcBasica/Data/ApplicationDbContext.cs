using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMvcBasica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<AppMvcBasica.Models.Produto> Produto { get; set; }
        public DbSet<AppMvcBasica.Models.Fornecedor> Fornecedor { get; set; }
        public DbSet<AppMvcBasica.Models.Endereco> Endereco { get; set; }
    }
}
