using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;

namespace Loja.DAL
{
	public class UsuarioDAL
	{
		/*metodo cargaUsuario, retorna uma lista de objetos usuario_DTO
		 * (composto de varios atributos), vai ate o BD e bisca todos os usuarios
		 * Usamos o ty e catch caso dê algum erro, retorna para a camada view
		 * Executar o método cargaUsuario(sera criado na DAL) */

		public IList<usuario_DTO> cargaUsuario()
		{
			try
			{
				/*conexão com BD
				 * Seleciona todos os dados da tb_usuarios*/
				SqlConnection con = new SqlConnection();
				con.ConnectionString = Properties.Settings.Default.CST;
				SqlCommand CM = new SqlCommand();
				CM.CommandType = System.Data.CommandType.Text;
				CM.CommandText = "SELECT * FROM tb_usuarios";
				CM.Connection = con;

				SqlDataReader DR;
				IList<usuario_DTO> listUsuarioDTO = new List<usuario_DTO>();

				con.Open();
				DR = CM.ExecuteReader();
				if (DR.HasRows)
				{
					while (DR.Read())
					{
						usuario_DTO usu = new usuario_DTO();

						/*nome dos objetos criados na DTO
						 * Cada objeto criado é privado para a lsita, possibilitando
						 * que no final vc tenha uma lista com vários usuários */
						usu.cod_usuario = Convert.ToInt32(DR["cod_usuario"]);
						usu.perfil = Convert.ToInt32(DR["perfil"]);
						usu.cadastro = Convert.ToDateTime(DR["cadastro"]);
						usu.nome = Convert.ToString(DR["nome"]);
						usu.email = Convert.ToString(DR["email"]);
						usu.login = Convert.ToString(DR["login"]);
						usu.senha = Convert.ToString(DR["senha"]);
						usu.situacao = Convert.ToString(DR["situacao"]);

						listUsuarioDTO.Add(usu);
					}
				}
				return listUsuarioDTO;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
