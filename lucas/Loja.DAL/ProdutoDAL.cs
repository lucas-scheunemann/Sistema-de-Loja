using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Loja.DTO;

namespace Loja.DAL
{
	public class ProdutoDAL
	{
		/*metodo cargaProduto, retorna uma lista de objetos produto_DTO
		 * (composto de varios atributos), vai ate o BD e bisca todos os produtos
		 * Usamos o ty e catch caso dê algum erro, retorna para a camada view
		 * Executar o método cargaProduto(sera criado na DAL) */

		public IList<produto_DTO> cargaProduto()
		{

			IList<produto_DTO> listProdutoDTO = new List<produto_DTO>();

			return listProdutoDTO;
		}
		public int insereProduto(produto_DTO PDT)
		{
			return 0;
		}
		public int editaProduto(produto_DTO PDT)
		{
			return 0;
		}
		public int deletaProduto(produto_DTO PDT)
		{
			return 0;
		}
	}
}
