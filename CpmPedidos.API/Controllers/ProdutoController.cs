using System;
using System.Collections.Generic;
using CpmPedidos.Domain.Entities;
using CpmPedidos.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CpmPedidos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : AppBaseController
    {

        public ProdutoController(IServiceProvider serviceProvider): base(serviceProvider)
        {
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
           var rep = (IProdutoRepository)ServiceProvider.GetService(typeof(IProdutoRepository));
            return rep.Get();
        }

    }
}

