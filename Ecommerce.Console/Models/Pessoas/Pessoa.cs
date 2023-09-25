using System;
using Ecommerce.Console.Models.Enderecos;

namespace Ecommerce.Console.Models.Pessoas
{
	public class Pessoa
	{
		public Pessoa() //construtor
		{

		}
		public int Id { set; get; }

		public List<Endereco> Endereco { set; get; } //propriedades automaticas
		public string Email { set; get; }
		public string Telefone { set; get; }
	}
}