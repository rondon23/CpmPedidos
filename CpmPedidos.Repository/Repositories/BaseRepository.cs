using CpmPedidos.Domain.Entities;
using CpmPedidos.Interfaces.Repositories;
using CpmPedidos.Repository.Common;
using System;
using System.Collections.Generic;

namespace CpmPedidos.Repository.Repositories
{
    public class BaseRepository
    {
        protected const int TamanhoPagina = 5;

        protected readonly ApplicationDbContext DbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}

