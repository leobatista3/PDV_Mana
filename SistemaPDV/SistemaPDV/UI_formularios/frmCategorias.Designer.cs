namespace SistemaPDV.UI_formularios
{
    partial class frmCategorias
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
            this.btnatualizarcategoria = new System.Windows.Forms.Button();
            this.txttitulocategoria = new System.Windows.Forms.TextBox();
            this.tsobrenome = new System.Windows.Forms.Label();
            this.btnexcluircategoria = new System.Windows.Forms.Button();
            this.btncadastrarcategoria = new System.Windows.Forms.Button();
            this.txtpesquisarcategoria = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dvgcategoria = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnatualizarcategoria
            // 
            this.btnatualizarcategoria.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnatualizarcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnatualizarcategoria.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnatualizarcategoria.Location = new System.Drawing.Point(402, 451);
            this.btnatualizarcategoria.Name = "btnatualizarcategoria";
            this.btnatualizarcategoria.Size = new System.Drawing.Size(225, 45);
            this.btnatualizarcategoria.TabIndex = 57;
            this.btnatualizarcategoria.Text = "ATUALIZAR";
            this.btnatualizarcategoria.UseVisualStyleBackColor = false;
            this.btnatualizarcategoria.Click += new System.EventHandler(this.btnatualizarcategoria_Click);
            // 
            // txttitulocategoria
            // 
            this.txttitulocategoria.Location = new System.Drawing.Point(163, 131);
            this.txttitulocategoria.Name = "txttitulocategoria";
            this.txttitulocategoria.Size = new System.Drawing.Size(274, 22);
            this.txttitulocategoria.TabIndex = 54;
            // 
            // tsobrenome
            // 
            this.tsobrenome.AutoSize = true;
            this.tsobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsobrenome.Location = new System.Drawing.Point(14, 177);
            this.tsobrenome.Name = "tsobrenome";
            this.tsobrenome.Size = new System.Drawing.Size(95, 22);
            this.tsobrenome.TabIndex = 53;
            this.tsobrenome.Text = "Descrição:";
            // 
            // btnexcluircategoria
            // 
            this.btnexcluircategoria.BackColor = System.Drawing.Color.Red;
            this.btnexcluircategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluircategoria.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnexcluircategoria.Location = new System.Drawing.Point(814, 451);
            this.btnexcluircategoria.Name = "btnexcluircategoria";
            this.btnexcluircategoria.Size = new System.Drawing.Size(225, 45);
            this.btnexcluircategoria.TabIndex = 52;
            this.btnexcluircategoria.Text = "EXCLUIR";
            this.btnexcluircategoria.UseVisualStyleBackColor = false;
            this.btnexcluircategoria.Click += new System.EventHandler(this.btnexcluircategoria_Click);
            // 
            // btncadastrarcategoria
            // 
            this.btncadastrarcategoria.BackColor = System.Drawing.Color.Lime;
            this.btncadastrarcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarcategoria.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btncadastrarcategoria.Location = new System.Drawing.Point(18, 451);
            this.btncadastrarcategoria.Name = "btncadastrarcategoria";
            this.btncadastrarcategoria.Size = new System.Drawing.Size(225, 45);
            this.btncadastrarcategoria.TabIndex = 51;
            this.btncadastrarcategoria.Text = "CADASTRAR";
            this.btncadastrarcategoria.UseVisualStyleBackColor = false;
            this.btncadastrarcategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpesquisarcategoria
            // 
            this.txtpesquisarcategoria.Location = new System.Drawing.Point(646, 94);
            this.txtpesquisarcategoria.Name = "txtpesquisarcategoria";
            this.txtpesquisarcategoria.Size = new System.Drawing.Size(409, 22);
            this.txtpesquisarcategoria.TabIndex = 50;
            this.txtpesquisarcategoria.TextChanged += new System.EventHandler(this.txtpesquisarcategoria_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(466, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 22);
            this.label10.TabIndex = 49;
            this.label10.Text = "Pesquisar categoria:";
            // 
            // dvgcategoria
            // 
            this.dvgcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgcategoria.Location = new System.Drawing.Point(470, 122);
            this.dvgcategoria.Name = "dvgcategoria";
            this.dvgcategoria.RowHeadersWidth = 51;
            this.dvgcategoria.RowTemplate.Height = 24;
            this.dvgcategoria.Size = new System.Drawing.Size(585, 288);
            this.dvgcategoria.TabIndex = 48;
            this.dvgcategoria.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgcategoria_RowHeaderMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Categoria ID:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(163, 177);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(274, 233);
            this.txtdescricao.TabIndex = 43;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(163, 92);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(274, 22);
            this.txtid.TabIndex = 33;
            this.txtid.ReadOnlyChanged += new System.EventHandler(this.txtid_ReadOnlyChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Título Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 36);
            this.label1.TabIndex = 58;
            this.label1.Text = "CADASTRO DE CATEGORIAS";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnatualizarcategoria);
            this.Controls.Add(this.txttitulocategoria);
            this.Controls.Add(this.tsobrenome);
            this.Controls.Add(this.btnexcluircategoria);
            this.Controls.Add(this.btncadastrarcategoria);
            this.Controls.Add(this.txtpesquisarcategoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dvgcategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgcategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnatualizarcategoria;
        private System.Windows.Forms.TextBox txttitulocategoria;
        private System.Windows.Forms.Label tsobrenome;
        private System.Windows.Forms.Button btnexcluircategoria;
        private System.Windows.Forms.Button btncadastrarcategoria;
        private System.Windows.Forms.TextBox txtpesquisarcategoria;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dvgcategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}