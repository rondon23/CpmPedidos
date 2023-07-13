using CpmPedidos.Domain.Entities;
using CpmPedidos.Interfaces.Repositories;
using System.Linq;
using System.Collections.Generic;

namespace CpmPedidos.Repository.Repositories
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public List<Produto> Get()
        {
            return DbContext.Produtos.ToList();
        }
    }
}

