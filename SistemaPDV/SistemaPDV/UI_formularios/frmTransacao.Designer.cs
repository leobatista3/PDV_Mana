namespace SistemaPDV.UI_formularios
{
    partial class frmTransacao
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
            this.dvgTransacao = new System.Windows.Forms.DataGridView();
            this.btnTransacao = new System.Windows.Forms.Button();
            this.cmbTipoTransacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTransacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTransacao
            // 
            this.dvgTransacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTransacao.Location = new System.Drawing.Point(15, 135);
            this.dvgTransacao.Name = "dvgTransacao";
            this.dvgTransacao.RowHeadersWidth = 51;
            this.dvgTransacao.RowTemplate.Height = 24;
            this.dvgTransacao.Size = new System.Drawing.Size(1146, 572);
            this.dvgTransacao.TabIndex = 70;
            // 
            // btnTransacao
            // 
            this.btnTransacao.BackColor = System.Drawing.Color.OliveDrab;
            this.btnTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacao.Location = new System.Drawing.Point(827, 89);
            this.btnTransacao.Name = "btnTransacao";
            this.btnTransacao.Size = new System.Drawing.Size(120, 31);
            this.btnTransacao.TabIndex = 69;
            this.btnTransacao.Text = "BUSCAR:";
            this.btnTransacao.UseVisualStyleBackColor = false;
            this.btnTransacao.Click += new System.EventHandler(this.btnTransacao_Click);
            // 
            // cmbTipoTransacao
            // 
            this.cmbTipoTransacao.FormattingEnabled = true;
            this.cmbTipoTransacao.Items.AddRange(new object[] {
            "Compras",
            "Vendas"});
            this.cmbTipoTransacao.Location = new System.Drawing.Point(332, 93);
            this.cmbTipoTransacao.Name = "cmbTipoTransacao";
            this.cmbTipoTransacao.Size = new System.Drawing.Size(489, 24);
            this.cmbTipoTransacao.TabIndex = 68;
            this.cmbTipoTransacao.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTransacao_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 67;
            this.label7.Text = "Tipo da Transação:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 71;
            this.label1.Text = "TRANSAÇÕES";
            // 
            // frmTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgTransacao);
            this.Controls.Add(this.btnTransacao);
            this.Controls.Add(this.cmbTipoTransacao);
            this.Controls.Add(this.label7);
            this.Name = "frmTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransacao";
            this.Load += new System.EventHandler(this.frmTransacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTransacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTransacao;
        private System.Windows.Forms.Button btnTransacao;
        private System.Windows.Forms.ComboBox cmbTipoTransacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}