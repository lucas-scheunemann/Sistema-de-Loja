namespace Sistema_Loja
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Login";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "senha";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "cadastro";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 134);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "situação";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(28, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "perfil";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(63, 6);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(294, 20);
			this.txtNome.TabIndex = 7;
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(62, 30);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(100, 20);
			this.txtLogin.TabIndex = 8;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(62, 55);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(295, 20);
			this.txtEmail.TabIndex = 9;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(62, 81);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(100, 20);
			this.txtSenha.TabIndex = 10;
			this.txtSenha.UseSystemPasswordChar = true;
			// 
			// txtCadastro
			// 
			this.txtCadastro.Location = new System.Drawing.Point(62, 107);
			this.txtCadastro.Name = "txtCadastro";
			this.txtCadastro.Size = new System.Drawing.Size(100, 20);
			this.txtCadastro.TabIndex = 11;
			// 
			// cboSituacao
			// 
			this.cboSituacao.FormattingEnabled = true;
			this.cboSituacao.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
			this.cboSituacao.Location = new System.Drawing.Point(62, 132);
			this.cboSituacao.Name = "cboSituacao";
			this.cboSituacao.Size = new System.Drawing.Size(101, 21);
			this.cboSituacao.TabIndex = 12;
			// 
			// cboPerfil
			// 
			this.cboPerfil.FormattingEnabled = true;
			this.cboPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Operador",
            "Gerencial"});
			this.cboPerfil.Location = new System.Drawing.Point(62, 157);
			this.cboPerfil.Name = "cboPerfil";
			this.cboPerfil.Size = new System.Drawing.Size(101, 21);
			this.cboPerfil.TabIndex = 13;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 193);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(344, 145);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// CadastrarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 391);
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
	}
}