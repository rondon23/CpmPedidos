using System;
using System.Collections.Generic;

namespace CpmPedidos.Domain.Entities
{
	public class Imagem: BaseDomain
	{
		public string Nome { get; set; }
		public string NomeArquivo { get; set; }

		public bool Principal { get; set; }

		public virtual List<Produto> Produtos { get; set; }
	}
}

