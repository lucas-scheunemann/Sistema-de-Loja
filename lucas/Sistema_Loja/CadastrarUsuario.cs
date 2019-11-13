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
			/*Linha atual que estiver selecionada aaprecera nos campos
			 * acoma do dataGrid */
			int sel = dataGridView1.CurrentRow.Index;
			/*Valor de cada datagrid sera enviado ao seu respectivo textbox*/

			txtNome.Text = Convert.ToString(dataGridView1["nome", sel].Value);
			txtLogin.Text = Convert.ToString(dataGridView1["login", sel].Value);
			txtEmail.Text = Convert.ToString(dataGridView1["email", sel].Value);
			txtSenha.Text = Convert.ToString(dataGridView1["senha", sel].Value);
			txtCadastro.Text = Convert.ToString(dataGridView1["cadastro", sel].Value);

			/*Condição se a situação for igual a "A" entao o combobox ficará
			 * Ativo senao "Inativo"*/

			if (Convert.ToString(dataGridView1["situacao", sel].Value) == "A")
			{
				cboSituacao.Text = "Ativo";

			}
			else
			{
				cboSituacao.Text = "Inativo";
				cboPerfil.Text = Convert.ToString(dataGridView1["perfil", sel].Value);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
