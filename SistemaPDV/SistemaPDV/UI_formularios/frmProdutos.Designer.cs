namespace SistemaPDV.UI_formularios
{
    partial class frmProdutos
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
            this.btnatualizarProduto = new System.Windows.Forms.Button();
            this.txtnomeProduto = new System.Windows.Forms.TextBox();
            this.tsobrenome = new System.Windows.Forms.Label();
            this.btnexcluirProduto = new System.Windows.Forms.Button();
            this.btncadastrarProduto = new System.Windows.Forms.Button();
            this.txtpesquisarProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dvgProduto = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtidProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtavaliacaoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcategoriaProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnatualizarProduto
            // 
            this.btnatualizarProduto.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnatualizarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizarProduto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnatualizarProduto.Location = new System.Drawing.Point(172, 608);
            this.btnatualizarProduto.Name = "btnatualizarProduto";
            this.btnatualizarProduto.Size = new System.Drawing.Size(146, 45);
            this.btnatualizarProduto.TabIndex = 69;
            this.btnatualizarProduto.Text = "ATUALIZAR";
            this.btnatualizarProduto.UseVisualStyleBackColor = false;
            this.btnatualizarProduto.Click += new System.EventHandler(this.btnatualizarProduto_Click);
            // 
            // txtnomeProduto
            // 
            this.txtnomeProduto.Location = new System.Drawing.Point(189, 134);
            this.txtnomeProduto.Name = "txtnomeProduto";
            this.txtnomeProduto.Size = new System.Drawing.Size(286, 22);
            this.txtnomeProduto.TabIndex = 68;
            // 
            // tsobrenome
            // 
            this.tsobrenome.AutoSize = true;
            this.tsobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsobrenome.Location = new System.Drawing.Point(12, 423);
            this.tsobrenome.Name = "tsobrenome";
            this.tsobrenome.Size = new System.Drawing.Size(95, 22);
            this.tsobrenome.TabIndex = 67;
            this.tsobrenome.Text = "Descrição:";
            // 
            // btnexcluirProduto
            // 
            this.btnexcluirProduto.BackColor = System.Drawing.Color.Red;
            this.btnexcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluirProduto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnexcluirProduto.Location = new System.Drawing.Point(323, 608);
            this.btnexcluirProduto.Name = "btnexcluirProduto";
            this.btnexcluirProduto.Size = new System.Drawing.Size(152, 45);
            this.btnexcluirProduto.TabIndex = 66;
            this.btnexcluirProduto.Text = "EXCLUIR";
            this.btnexcluirProduto.UseVisualStyleBackColor = false;
            this.btnexcluirProduto.Click += new System.EventHandler(this.btnexcluirProduto_Click);
            // 
            // btncadastrarProduto
            // 
            this.btncadastrarProduto.BackColor = System.Drawing.Color.Lime;
            this.btncadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarProduto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btncadastrarProduto.Location = new System.Drawing.Point(12, 608);
            this.btncadastrarProduto.Name = "btncadastrarProduto";
            this.btncadastrarProduto.Size = new System.Drawing.Size(154, 45);
            this.btncadastrarProduto.TabIndex = 65;
            this.btncadastrarProduto.Text = "CADASTRAR";
            this.btncadastrarProduto.UseVisualStyleBackColor = false;
            this.btncadastrarProduto.Click += new System.EventHandler(this.btncadastrarProduto_Click);
            // 
            // txtpesquisarProduto
            // 
            this.txtpesquisarProduto.Location = new System.Drawing.Point(680, 82);
            this.txtpesquisarProduto.Name = "txtpesquisarProduto";
            this.txtpesquisarProduto.Size = new System.Drawing.Size(409, 22);
            this.txtpesquisarProduto.TabIndex = 64;
            this.txtpesquisarProduto.TextChanged += new System.EventHandler(this.txtpesquisarProduto_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(502, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 22);
            this.label10.TabIndex = 63;
            this.label10.Text = "Pesquisar Produtos:";
            // 
            // dvgProduto
            // 
            this.dvgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduto.Location = new System.Drawing.Point(504, 123);
            this.dvgProduto.Name = "dvgProduto";
            this.dvgProduto.RowHeadersWidth = 51;
            this.dvgProduto.RowTemplate.Height = 24;
            this.dvgProduto.Size = new System.Drawing.Size(585, 530);
            this.dvgProduto.TabIndex = 62;
            this.dvgProduto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgProduto_RowHeaderMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 61;
            this.label9.Text = "Produto ID:";
            // 
            // txtdescricaoProduto
            // 
            this.txtdescricaoProduto.Location = new System.Drawing.Point(113, 297);
            this.txtdescricaoProduto.Multiline = true;
            this.txtdescricaoProduto.Name = "txtdescricaoProduto";
            this.txtdescricaoProduto.Size = new System.Drawing.Size(362, 273);
            this.txtdescricaoProduto.TabIndex = 60;
            // 
            // txtidProduto
            // 
            this.txtidProduto.Location = new System.Drawing.Point(189, 84);
            this.txtidProduto.Name = "txtidProduto";
            this.txtidProduto.ReadOnly = true;
            this.txtidProduto.Size = new System.Drawing.Size(285, 22);
            this.txtidProduto.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nome do Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(333, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 36);
            this.label1.TabIndex = 70;
            this.label1.Text = "CADASTRO DE PRODUTOS";
            // 
            // txtavaliacaoProduto
            // 
            this.txtavaliacaoProduto.Location = new System.Drawing.Point(189, 233);
            this.txtavaliacaoProduto.Name = "txtavaliacaoProduto";
            this.txtavaliacaoProduto.Size = new System.Drawing.Size(286, 22);
            this.txtavaliacaoProduto.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Categoria:";
            // 
            // cmbcategoriaProduto
            // 
            this.cmbcategoriaProduto.FormattingEnabled = true;
            this.cmbcategoriaProduto.Items.AddRange(new object[] {
            "Usuario",
            "Admin"});
            this.cmbcategoriaProduto.Location = new System.Drawing.Point(189, 180);
            this.cmbcategoriaProduto.Name = "cmbcategoriaProduto";
            this.cmbcategoriaProduto.Size = new System.Drawing.Size(282, 24);
            this.cmbcategoriaProduto.TabIndex = 74;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 678);
            this.Controls.Add(this.cmbcategoriaProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtavaliacaoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnatualizarProduto);
            this.Controls.Add(this.txtnomeProduto);
            this.Controls.Add(this.tsobrenome);
            this.Controls.Add(this.btnexcluirProduto);
            this.Controls.Add(this.btncadastrarProduto);
            this.Controls.Add(this.txtpesquisarProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dvgProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdescricaoProduto);
            this.Controls.Add(this.txtidProduto);
            this.Controls.Add(this.label2);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnatualizarProduto;
        private System.Windows.Forms.TextBox txtnomeProduto;
        private System.Windows.Forms.Label tsobrenome;
        private System.Windows.Forms.Button btnexcluirProduto;
        private System.Windows.Forms.Button btncadastrarProduto;
        private System.Windows.Forms.TextBox txtpesquisarProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dvgProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescricaoProduto;
        private System.Windows.Forms.TextBox txtidProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtavaliacaoProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcategoriaProduto;
    }
}