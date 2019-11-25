namespace Sistema_Loja
{
	partial class EntradaEstoque
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblProduto = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblQuantidade = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 177);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(447, 150);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.BackColor = System.Drawing.Color.LawnGreen;
			this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdicionar.Location = new System.Drawing.Point(324, 123);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(135, 48);
			this.btnAdicionar.TabIndex = 1;
			this.btnAdicionar.Text = "ADICIONAR";
			this.btnAdicionar.UseVisualStyleBackColor = false;
			this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "produto:";
			// 
			// lblProduto
			// 
			this.lblProduto.AutoSize = true;
			this.lblProduto.Location = new System.Drawing.Point(116, 48);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(10, 13);
			this.lblProduto.TabIndex = 3;
			this.lblProduto.Text = "-";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "quantidade:";
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(113, 90);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(66, 20);
			this.txtQuantidade.TabIndex = 5;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(116, 26);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(13, 13);
			this.lblCodigo.TabIndex = 6;
			this.lblCodigo.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(68, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "código:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "quantidade anterior:";
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Location = new System.Drawing.Point(116, 71);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(13, 13);
			this.lblQuantidade.TabIndex = 9;
			this.lblQuantidade.Text = "0";
			// 
			// EntradaEstoque
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 339);
			this.Controls.Add(this.lblQuantidade);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblProduto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.dataGridView1);
			this.Name = "EntradaEstoque";
			this.Text = "EntradaEstoque";
			this.Load += new System.EventHandler(this.EntradaEstoque_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblQuantidade;
	}
}