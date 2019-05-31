using ApiCep2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiCep2.Repositories
{
    public class ApiCepService
    {
        //FAZ A REQUISIÇÃO A UMA API - OBTÉM RESULTADO EM JSON
        public dynamic ObterCep(string cep)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://viacep.com.br/ws/");

            var result = httpClient.GetAsync($"{cep}/json").Result.Content.ReadAsStringAsync().Result;

            if (result != null)
                return JsonConvert.DeserializeObject<CEP>(result);

            return null;
        }
    }
}
