﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Loja
{
	public partial class MDIParent1 : Form
	{
		

		public MDIParent1()
		{
			InitializeComponent();
		}

		private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form childForm = new CadastrarProduto();
			childForm.MdiParent = this;
			childForm.Show();
		}

		private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form childForm = new CadastrarUsuario();
			childForm.MdiParent = this;
			childForm.Show();

		}

		private void saidaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form childForm = new SaidaEstoque();
			childForm.MdiParent = this;
			childForm.Show();
		}

		private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form childForm = new EntradaEstoque();
			childForm.MdiParent = this;
			childForm.Show();
		}

		private void informaçõesDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form childForm = new InformacaoDoSistema();
			childForm.MdiParent = this;
			childForm.Show();
		}
	}
}
