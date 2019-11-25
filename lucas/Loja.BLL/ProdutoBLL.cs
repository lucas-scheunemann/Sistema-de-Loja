using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Loja.DTO;
using Loja.DAL;

namespace Loja.BLL
{
	public class ProdutoBLL
	/*método cargaProduto, retorna uma lista de objetos produto_DTO
		 * (composto por varios atributos), vai até o BD e busca todos os produtos
		 * Usamos o try e catch caso dê algum erro, retorna para a camada view
		 * Executar o método cargaUsuario (será criado na DAL)
		 * */
	{
		public IList<produto_DTO> cargaProduto()
		{
			try
			{
				return new ProdutoDAL().cargaProduto();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int insereProduto(produto_DTO PDT)
		{ //insere produto será criado na DAL
			try
			{
				return new ProdutoDAL().insereProduto(PDT);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int editaProduto(produto_DTO PDT)
		{ //edita produto será criado na DAL
			try
			{
				return new ProdutoDAL().editaProduto(PDT);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int deletaProduto(produto_DTO PDT)
		{ //deleta produto será criado na DAL
			try
			{
				return new ProdutoDAL().deletaProduto(PDT);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public int addQuantidade(produto_DTO PDT)
		{
			try
			{
				return new ProdutoDAL().addQuantidade(PDT);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
