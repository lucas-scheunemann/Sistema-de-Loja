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
	public partial class CadastrarProduto : Form
	{
		string modo = "";

		public CadastrarProduto()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			modo = "EDITAR";
			lblModo.Text = "MODO: EDITAR";
		}

		private void CadastrarProduto_Load(object sender, EventArgs e)
		{
			/*método carrega Grid
			 para atualizar os dados da tabela, basta chamar o método*/
			carregaGrid();
		}
		private void carregaGrid()
		{
			try
			{
				IList<produto_DTO> listProduto_DTO = new List<produto_DTO>();
				listProduto_DTO = new ProdutoBLL().cargaProduto();

				/*preenche os dados no dataGridView*/
				dataGridView1.DataSource = listProduto_DTO;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			modo = "NOVO";
			lblModo.Text = "MODO: NOVO";

			/*limpa camos para inserção de novas variáveis*/
			limpar_campos();
		}

		private void limpar_campos()
		{
			txtNome.Text = "";
			txtPreco.Text = "";
			lblCodigo.Text = "0";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			modo = "DELETAR";
			lblModo.Text = "MODO: DELETAR";
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			modo = "";
			lblModo.Text = "MODO:";
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			/*aqui ficarão as funções do funcionamento do sistema, dependendo de qual
			 modo o sistema se encontra*/
			if (modo == "NOVO")
			{
			}
			if (modo == "DELETAR")
			{
			}
			if (modo == "EDITAR")
			{
			}

			carregaGrid();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*linha selecionada atualmente aparecerá nos campos acima do grid*/
			int sel = dataGridView1.CurrentRow.Index;

			/*valor de cada coluna será jogada em cada textBox e no label código*/

			txtNome.Text = Convert.ToString(dataGridView1["nome", sel].Value);
			txtPreco.Text = Convert.ToString(dataGridView1["preco", sel].Value);
			lblCodigo.Text = Convert.ToString(dataGridView1["cod_produto", sel].Value);
		}
	}
}
