using BuscaCep.WebApi.Models;

namespace BuscaCep.WebApi.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        bool SaveChanges();
        Endereco[] GetEnderecos();
        Endereco[] GetEnderecoById(int enderecoId);

    }

}