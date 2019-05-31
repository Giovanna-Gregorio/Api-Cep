using ApiCep2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCep2.Repositories
{
    public class Service
    {
        //"PRECISO DOS DADOS DE UM CEP - ONDE E COMO VAI BUSCAR NÃO IMPORTA"
        private readonly CEPRepository _cepRepository;
        public Service(CEPRepository cepRepository)
        {
            _cepRepository = cepRepository;
        }

        public dynamic ObterCep(string cep)
        {
            if (string.IsNullOrEmpty(cep))
                return null;

            var cepRetorno = _cepRepository.ObterCep(cep);

            if (cepRetorno == null)
            {
                cepRetorno = new ApiCepService().ObterCep(cep);

                if (cepRetorno != null)
                    _cepRepository.AdicionarCepPesquisa((CEP)cepRetorno);
            }

            return cepRetorno;
        }

        public dynamic ObterCepsPesquisados()
        {
            return _cepRepository.ObterCepsPesquisados();
        }
    }
}
