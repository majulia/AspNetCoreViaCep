namespace BuscaCep.WebApi.Models
{
  
    public class Endereco
    {
        public Endereco(int id, string cep, string logradouro, string complemento, string bairro, string localidade, string uf)
        {
         this.Id = id;
          this.Cep = cep;
          this.Logradouro = logradouro;
          this.Complemento = complemento;
          this.Bairro = bairro;
          this.Localidade = localidade;
          this.Uf = uf;

        }
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }

    }

}