using System.Net.Http;
using BuscaCep.WebApi.Models;
using Newtonsoft.Json;

namespace BuscaCep.WebApi.Services
{
    public class ViaCepService
    {
      public Endereco GetEnderecoByCep(string cep){
          var client = new HttpClient();

          string uri = $"https://viacep.com.br/ws/{cep}/json/";

          var response = client.GetAsync(uri).Result;
        if (response.IsSuccessStatusCode)
        {
            string json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Endereco>(json);
        }

     return null;
    }

    }
}