using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;
using Loja.DAL;

namespace Loja.BLL
{
	public class UsuarioBLL
	{
		/*método cargaUsuario, retorna uma lista de objetos usuario DTO
		 * (composto por varios atributos), vai até o BD e busca todos os usuários
		 * Usamos o try e catch caso dê algum erro, retorna para a camada view
		 * Executar o método cargaUsuario (será criado na DAL)
		 * */
		 public IList<usuario_DTO> cargaUsuario()
		{
			try
			{
				return new UsuarioDAL().cargaUsuario();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
