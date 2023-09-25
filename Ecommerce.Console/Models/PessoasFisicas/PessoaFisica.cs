using System;
using Ecommerce.Console.Models.Pessoas;

namespace Ecommerce.Console.Models.PessoasFisicas
{
	public class PessoaFisica
    {
		public PessoaFisica()
		{

		}
		public DateTime Nascimento { set; get; }
		public string RG { set; get; }
		public string Nome { set; get; }

        public int Id { set; get; }

        public string Endereco { set; get; } //propriedades automaticas
        public string Email { set; get; }
        public string Telefone { set; get; }
    }
}
