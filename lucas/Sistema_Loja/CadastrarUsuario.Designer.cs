﻿namespace Sistema_Loja
{
	partial class CadastrarUsuario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtCadastro = new System.Windows.Forms.TextBox();
			this.cboSituacao = new System.Windows.Forms.ComboBox();
			this.cboPerfil = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnDeletar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.lblModo = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Login";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "senha";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "cadastro";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 199);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "situação";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(27, 225);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "perfil";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(62, 71);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(294, 20);
			this.txtNome.TabIndex = 7;
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(61, 95);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(170, 20);
			this.txtLogin.TabIndex = 8;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(61, 120);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(295, 20);
			this.txtEmail.TabIndex = 9;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(61, 146);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(170, 20);
			this.txtSenha.TabIndex = 10;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// txtCadastro
			// 
			this.txtCadastro.Location = new System.Drawing.Point(61, 172);
			this.txtCadastro.Name = "txtCadastro";
			this.txtCadastro.Size = new System.Drawing.Size(170, 20);
			this.txtCadastro.TabIndex = 11;
			// 
			// cboSituacao
			// 
			this.cboSituacao.FormattingEnabled = true;
			this.cboSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
			this.cboSituacao.Location = new System.Drawing.Point(61, 197);
			this.cboSituacao.Name = "cboSituacao";
			this.cboSituacao.Size = new System.Drawing.Size(128, 21);
			this.cboSituacao.TabIndex = 12;
			// 
			// cboPerfil
			// 
			this.cboPerfil.FormattingEnabled = true;
			this.cboPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Operador",
            "Gerencial"});
			this.cboPerfil.Location = new System.Drawing.Point(61, 222);
			this.cboPerfil.Name = "cboPerfil";
			this.cboPerfil.Size = new System.Drawing.Size(128, 21);
			this.cboPerfil.TabIndex = 13;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 258);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(344, 145);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(22, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(209, 24);
			this.label8.TabIndex = 15;
			this.label8.Text = "Cadastro de Usuários";
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.Location = new System.Drawing.Point(8, 42);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(60, 23);
			this.btnNovo.TabIndex = 16;
			this.btnNovo.Text = "NOVO";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(74, 42);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(65, 23);
			this.btnEditar.TabIndex = 17;
			this.btnEditar.Text = "EDITAR";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnDeletar
			// 
			this.btnDeletar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeletar.Location = new System.Drawing.Point(145, 42);
			this.btnDeletar.Name = "btnDeletar";
			this.btnDeletar.Size = new System.Drawing.Size(86, 23);
			this.btnDeletar.TabIndex = 18;
			this.btnDeletar.Text = "DELETAR";
			this.btnDeletar.UseVisualStyleBackColor = false;
			this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.Red;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(236, 42);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(90, 23);
			this.btnCancelar.TabIndex = 19;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.BackColor = System.Drawing.Color.GreenYellow;
			this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmar.Location = new System.Drawing.Point(332, 42);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(94, 23);
			this.btnConfirmar.TabIndex = 20;
			this.btnConfirmar.Text = "CONFIRMAR";
			this.btnConfirmar.UseVisualStyleBackColor = false;
			this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
			// 
			// lblModo
			// 
			this.lblModo.AutoSize = true;
			this.lblModo.Location = new System.Drawing.Point(329, 9);
			this.lblModo.Name = "lblModo";
			this.lblModo.Size = new System.Drawing.Size(46, 13);
			this.lblModo.TabIndex = 21;
			this.lblModo.Text = "MODO: ";
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(272, 98);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(13, 13);
			this.lblCodigo.TabIndex = 22;
			this.lblCodigo.Text = "0";
			this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(233, 98);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "código:";
			// 
			// CadastrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 460);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.lblModo);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnDeletar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnNovo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cboPerfil);
			this.Controls.Add(this.cboSituacao);
			this.Controls.Add(this.txtCadastro);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CadastrarUsuario";
			this.Text = "CadastrarUsuario";
			this.Load += new System.EventHandler(this.CadastrarUsuario_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtCadastro;
		private System.Windows.Forms.ComboBox cboSituacao;
		private System.Windows.Forms.ComboBox cboPerfil;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnNovo;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnDeletar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Label lblModo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label label9;
	}
}