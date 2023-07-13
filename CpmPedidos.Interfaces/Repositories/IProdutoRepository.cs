using System;
using System.Collections.Generic;
using CpmPedidos.Domain.Entities;

namespace CpmPedidos.Interfaces.Repositories
{
	public interface IProdutoRepository
	{
		List<Produto> Get();
	}
}

