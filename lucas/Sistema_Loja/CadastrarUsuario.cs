﻿using System;
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
		string modo = "";
		public CadastrarUsuario()
		{
			InitializeComponent();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void CadastrarUsuario_Load(object sender, EventArgs e)
		/* método CarregaGrid
		 * para atualizar os dados do grid,
		 * basta chamar o método */
		{
			carregaGrid();
		}
		private void carregaGrid() {
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
			lblCodigo.Text = Convert.ToString(dataGridView1["cod_usuario", sel].Value);
			/*Condição se a situação for igual a "A" entao o combobox ficará
			 * Ativo senao "Inativo"*/

			if (Convert.ToString(dataGridView1["situacao", sel].Value) == "A")
			{
				cboSituacao.Text = "Ativo";

			}
			else
			{
				cboSituacao.Text = "Inativo";
				
			}

			switch (Convert.ToString(dataGridView1["perfil", sel].Value))
			{
				case "1":
					cboPerfil.Text = "Admnistrador";
					break;
				case "2":
					cboPerfil.Text = "Operador";
					break;
				case "3":
					cboPerfil.Text = "Gerencial";
					break;
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnDeletar_Click(object sender, EventArgs e)
		{
			modo = "deleta";
			lblModo.Text = "MODO: DELETAR";
		}

		private void btnNovo_Click(object sender, EventArgs e)
		{
			/*Chamando método limpar campos que foi criado */
			limpar_campos();

			/*inserindo data atual automaticamente no txtCadastro */
			txtCadastro.Text = Convert.ToString(System.DateTime.Now);

			/*apos clicar no botao noovo, modo passa a ser "novo" (incluindo um registro)*/
			modo = "novo";
			lblModo.Text = "MODO: NOVO";
		}
		/* Criando metodo limpar campos, para que todas as vezes 
		 * que for necessário limpar nao sera necessario repetir o
		 * codigo, apenas chamar o metodo */
		private void limpar_campos()
		{
			txtNome.Text = "";
			txtLogin.Text = "";
			txtEmail.Text = "";
			txtSenha.Text = "";
			txtCadastro.Text = "";
			cboPerfil.Text = "";
			cboSituacao.Text = "";
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			if (modo == "novo")
			{
				/*tratamento de erros, exibe msg*/
				try
				{
					/* Objeto USU */
					usuario_DTO USU = new usuario_DTO();
					USU.nome = txtNome.Text;
					USU.login = txtLogin.Text;
					USU.email = txtEmail.Text;
					USU.cadastro = System.DateTime.Now;
					USU.senha = txtSenha.Text;
					USU.cod_usuario = int.Parse(lblCodigo.Text);
					if (cboSituacao.Text == "Ativo")
					{
						USU.situacao = "A";
					}
					else
					{
						USU.situacao = "I";
					}
					switch (cboPerfil.Text)
					{
						case "Administrador":
							USU.perfil = 1;
							break;
						case "Operador":
							USU.perfil = 2;
							break;
						case "Gerencial":
							USU.perfil = 3;
							break;
					}

					/*método insere usuário na classe UsuarioBLL*/
					int x = new UsuarioBLL().insereUsuario(USU);
					if (x > 0)
					{
						MessageBox.Show("Gravado com Sucesso!");
					}
					/*Recarrega o Grid*/
					carregaGrid();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro inesperado" + ex.Message);
				}
			}
			

			/*após clicar num usuário e então em editar*/
			if (modo == "altera")
			{
				/*tratamento de erros, exibe msg*/
				try
				{
					/* Objeto USU */
					usuario_DTO USU = new usuario_DTO();
					USU.nome = txtNome.Text;
					USU.login = txtLogin.Text;
					USU.email = txtEmail.Text;
					USU.cadastro = System.DateTime.Now;
					USU.senha = txtSenha.Text;
					USU.cod_usuario = int.Parse(lblCodigo.Text);
					if (cboSituacao.Text == "Ativo")
					{
						USU.situacao = "A";
					}
					else
					{
						USU.situacao = "I";
					}
					switch (cboPerfil.Text)
					{
						case "Administrador":
							USU.perfil = 1;
							break;
						case "Operador":
							USU.perfil = 2;
							break;
						case "Gerencial":
							USU.perfil = 3;
							break;
					}

					/*método edita usuário na classe BLL*/
					int x = new UsuarioBLL().editaUsuario(USU);
					if (x > 0)
					{
						MessageBox.Show("Editado com Sucesso!");
					}
					else
					{
						MessageBox.Show("Nada foi alterado!");
					}
					/*Recarrega o Grid*/
					carregaGrid();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro inesperado" + ex.Message);
				}

			}
			if (modo == "deleta")
			{
				/*tratamento de erros, exibe msg*/
				try
				{
					/* Objeto USU */
					usuario_DTO USU = new usuario_DTO();
					USU.cod_usuario = int.Parse(lblCodigo.Text);

					/*método deleta usuário na classe BLL*/
					int x = new UsuarioBLL().deletaUsuario(USU);
					if (x > 0)
					{
						MessageBox.Show("Deletado com Sucesso!");
						lblCodigo.Text = "0";
					}
					else
					{
						MessageBox.Show("Nada foi alterado!");
					}
					/*Recarrega o Grid*/
					carregaGrid();

				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro inesperado" + ex.Message);
				}
			}
			
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			modo = "altera";
			lblModo.Text = "MODO: EDITAR";

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			modo = "";
			lblModo.Text = "MODO:";
		}

		private void lblCodigo_Click(object sender, EventArgs e)
		{

		}
	}
}
