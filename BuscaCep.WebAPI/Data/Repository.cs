using System.Linq;
using BuscaCep.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BuscaCep.WebApi.Data
{
  public class Repository : IRepository
  {
        private readonly BuscaContext _context;

      public Repository(BuscaContext context)
      {
          _context = context;
      }

    public void Add<T>(T entity) where T : class
    {
      _context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
      
    }
    public bool SaveChanges()
    {
     return (_context.SaveChanges() > 0);
    }

    public Endereco[] GetEnderecos()
    {
      IQueryable<Endereco> query = _context.Enderecos;

      query = query.AsNoTracking().OrderBy(e => e.Id);

      return query.ToArray();
      }

    public Endereco[] GetEnderecoById(int enderecoId)
    {
      IQueryable<Endereco> query = _context.Enderecos;

      query = query.AsNoTracking().OrderBy(e => e.Id)
      .Where(endereco => endereco.Id == enderecoId);

      return query.ToArray();
    }
  }
}