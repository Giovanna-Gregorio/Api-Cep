using ApiCep2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCep2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CEPController : ControllerBase
    {
        //HttpContext.Request.Headers["Authorization"].ToString();

        private readonly Service _service;
        public CEPController(Service service)
        {
            _service = service;
        }

        [HttpGet("{cep}")]
        public dynamic Get(string cep)
        {
            var result = _service.ObterCep(cep);

            if (result == null)
                return NotFound();

            return result;
        }


        [HttpGet]
        [Route("Todos")]
        public dynamic Todos()
        {
            var result = _service.ObterCepsPesquisados();

            if (result == null)
                return NotFound();

            return result;
        }

    }
}
