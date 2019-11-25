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
	public partial class EntradaEstoque : Form
	{
		public EntradaEstoque()
		{
			InitializeComponent();
		}

		private void EntradaEstoque_Load(object sender, EventArgs e)
		{
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			/*linha selecionada atualmente aparecerá nos campos acima do grid*/
			int sel = dataGridView1.CurrentRow.Index;

			/*valor de cada coluna será jogada em cada textBox e no label código*/
			lblProduto.Text = Convert.ToString(dataGridView1["nome", sel].Value);
			lblCodigo.Text = Convert.ToString(dataGridView1["cod_produto", sel].Value);
			lblQuantidade.Text = Convert.ToString(dataGridView1["quantidade", sel].Value);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				/* objeto produto PDT */
				produto_DTO PDT = new produto_DTO();
				PDT.cod_produto = int.Parse(lblCodigo.Text);
				PDT.quantidade = int.Parse(txtQuantidade.Text) + int.Parse(lblQuantidade.Text);
				/*  método insereProduto em ProdutoBLL */
				int x = new ProdutoBLL().addQuantidade(PDT);
				if (x > 0)
				{
					MessageBox.Show("gravado com sucesso!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro inesperado, ", ex.Message);
			}
			carregaGrid();
		}
	}
}
