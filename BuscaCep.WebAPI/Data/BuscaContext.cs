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
                    new Endereco(1, "12515160", "Rua Alfonso Giannico", "", "Pedregulho", "Guaratinguetá", "SP"),
                    new Endereco(2, "12345678", "Rua Alfonso Giannico", "", "Pedregulho", "Guaratinguetá", "SP"),
                    new Endereco(3, "87654321", "Rua Alfonso Giannico", "", "Pedregulho", "Guaratinguetá", "SP"),
                });
        }

    }
}