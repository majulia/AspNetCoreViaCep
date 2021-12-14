using System.Collections.Generic;
using BuscaCep.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BuscaCep.WebApi.Data
{
    public class BuscaContext : DbContext
    {
        public BuscaContext(DbContextOptions<BuscaContext> options) : base(options){ }

        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){

            builder.Entity<Endereco>()
                .HasData(new List<Endereco>(){
                    new Endereco(1, "01001-000", "Praça da Sé", "lado ímpar", "Sé", "São Paulo", "SP"),
                    new Endereco(2, "01001-000", "Praça da Sé", "lado ímpar", "Sé", "São Paulo", "SP"),
                    new Endereco(3, "01001-000", "Praça da Sé", "lado ímpar", "Sé", "São Paulo", "SP"),
                });
        }

    }
}