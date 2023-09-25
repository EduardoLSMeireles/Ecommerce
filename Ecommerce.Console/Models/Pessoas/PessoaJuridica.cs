using System; 
namespace Ecommerce.Console.Models.Pessoas
{
	public class PessoaJuridica : Pessoa
	{
		public PessoaJuridica()
		{

		}
		public string CNPJ { get; set; }
		public string RS { get; set; }
	}
}