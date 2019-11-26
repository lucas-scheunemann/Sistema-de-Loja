using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Loja.BLL;
using Loja.DTO;

namespace Sistema_Loja
{
	public partial class SaidaEstoque : Form
	{
		public SaidaEstoque()
		{
			InitializeComponent();
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

		private void SaidaEstoque_Load(object sender, EventArgs e)
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				/* objeto produto PDT */
				produto_DTO PDT = new produto_DTO();
				PDT.cod_produto = int.Parse(lblCodigo.Text);
				if (int.Parse(txtQuantidade.Text) <= 0)
				{
					MessageBox.Show("valor inválido.");
				}
				else
				{
					PDT.quantidade = int.Parse(lblQuantidade.Text) - int.Parse(txtQuantidade.Text);
					if (PDT.quantidade < 0)
					{
						MessageBox.Show("Valor inválido.");
					}
					else
					{
						/*  método insereProduto em ProdutoBLL */
						int x = new ProdutoBLL().retiraQuantidade(PDT);
						if (x > 0)
						{
							MessageBox.Show("retirado com sucesso!");
						}
					}
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
