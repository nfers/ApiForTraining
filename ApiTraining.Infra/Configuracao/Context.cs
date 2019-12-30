using ApiForTraining.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiForTraining.Infra.Configuracao
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetStringConnectionConfig());

            base.OnConfiguring(optionsBuilder);
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=db_ApiTraining;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

             return strCon;
        }
    }
}
