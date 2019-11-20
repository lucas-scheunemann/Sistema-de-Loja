using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
			try
			{
				/*conexão com BD
				 Seleciona todos os dados da tabela produtos*/
				SqlConnection CON = new SqlConnection();
				CON.ConnectionString = Properties.Settings.Default.CST;
				SqlCommand COM = new SqlCommand();
				COM.CommandType = System.Data.CommandType.Text;
				COM.CommandText = "SELECT * FROM tb_produtos";
				COM.Connection = CON;

				SqlDataReader DR;
				IList<produto_DTO> listProdutoDTO = new List<produto_DTO>();

				CON.Open();
				DR = COM.ExecuteReader();
				if (DR.HasRows)
				{
					while (DR.Read())
					{
						produto_DTO pdt = new produto_DTO();
						/*nome dos objetos criados em produtos_DTO
						 Cada objeto é privado para a lista, possibilitando que no final
						 você tenha uma lista com todos os produtos*/
						pdt.cod_produto = Convert.ToInt32(DR["cod_produto"]);
						pdt.nome = Convert.ToString(DR["nome"]);
						pdt.preco = Convert.ToDouble(DR["preco"]);
						pdt.quantidade = Convert.ToInt32(DR["quantidade"]);

						listProdutoDTO.Add(pdt);

					}
				}


				return listProdutoDTO;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int insereProduto(produto_DTO PDT)
		{
			try
			{
				/*
				 Conexão com BD
				 inserindo dados na tb_produtos
				 */
				SqlConnection CON = new SqlConnection();
				CON.ConnectionString = Properties.Settings.Default.CST;
				SqlCommand CM = new SqlCommand();
				CM.CommandType = System.Data.CommandType.Text;
				CM.CommandText = "INSERT INTO tb_produtos (nome, preco, quantidade) VALUES " +
					"(@nome, @preco, @quantidade)";
				CM.Parameters.Add("nome", System.Data.SqlDbType.NVarChar).Value = PDT.nome;
				CM.Parameters.Add("preco", System.Data.SqlDbType.Money).Value = PDT.preco;
				CM.Parameters.Add("quantidade", System.Data.SqlDbType.Int).Value = PDT.quantidade;

				CM.Connection = CON;

				CON.Open();
				int qtd = CM.ExecuteNonQuery();
				return qtd;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}
		public int editaProduto(produto_DTO PDT)
		{
			try
			{
				/*
				 Conexão com BD
				 editando dados na tb_produtos 
				 */
				SqlConnection CON = new SqlConnection();
				CON.ConnectionString = Properties.Settings.Default.CST;
				SqlCommand CM = new SqlCommand();
				CM.CommandType = System.Data.CommandType.Text;
				CM.CommandText = "UPDATE tb_produtos SET " +
					"nome = @nome, preco = @preco WHERE " +
					"cod_produto = @cod_produto";
				CM.Parameters.Add("nome", System.Data.SqlDbType.NVarChar).Value = PDT.nome;
				CM.Parameters.Add("preco", System.Data.SqlDbType.Money).Value = PDT.preco;
				CM.Parameters.Add("cod_produto", System.Data.SqlDbType.Int).Value = PDT.cod_produto;

				CM.Connection = CON;

				CON.Open();
				int qtd = CM.ExecuteNonQuery();
				return qtd;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			
		}
		public int deletaProduto(produto_DTO PDT)
		{
			return 0;
		}
	}
}
