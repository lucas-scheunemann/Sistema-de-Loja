using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Loja.DTO;
using Loja.BLL;

namespace Sistema_Loja
{
	public partial class CadastrarUsuario : Form
	{
		public CadastrarUsuario()
		{
			InitializeComponent();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void CadastrarUsuario_Load(object sender, EventArgs e)
		{
			try
			{
				IList<usuario_DTO> listUsuario_DTO = new List<usuario_DTO>();
				listUsuario_DTO = new UsuarioBLL().cargaUsuario();

				/*Preencher dados no DataGridView*/
				dataGridView1.DataSource = listUsuario_DTO;

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
