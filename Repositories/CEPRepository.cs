using ApiCep2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCep2.Repositories
{
    public class CEPRepository
    {
        // VOLTADO PARA O BANCO DE DADOS
        private readonly CEPContexto _context;

        public CEPRepository(CEPContexto context)
        {
            _context = context;
        }

        public object ObterCep(string cep)
        {
            return _context.CEP.SingleOrDefault(X => X.Cep.Equals(cep));
        }

        public object ObterCepsPesquisados()
        {
            return _context.CEP.ToList();
        }

        public void AdicionarCepPesquisa(CEP cep)
        {
            if (ObterCep(cep.Cep) == null)
            {
                cep.Cep = cep.Cep.Replace("-", "");

                _context.CEP.Add(cep);
                _context.SaveChanges();
            }
        }
    }
}
