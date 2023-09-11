namespace SistemaPDV.UI_formularios
{
    partial class frmInventario
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
            this.dvgInventario = new System.Windows.Forms.DataGridView();
            this.btnInventario = new System.Windows.Forms.Button();
            this.cmbTipoInventario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(479, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 76;
            this.label1.Text = "INVENTÁRIO";
            // 
            // dvgInventario
            // 
            this.dvgInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInventario.Location = new System.Drawing.Point(7, 149);
            this.dvgInventario.Name = "dvgInventario";
            this.dvgInventario.RowHeadersWidth = 51;
            this.dvgInventario.RowTemplate.Height = 24;
            this.dvgInventario.Size = new System.Drawing.Size(1146, 572);
            this.dvgInventario.TabIndex = 75;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.OliveDrab;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Location = new System.Drawing.Point(819, 103);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(120, 31);
            this.btnInventario.TabIndex = 74;
            this.btnInventario.Text = "BUSCAR:";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // cmbTipoInventario
            // 
            this.cmbTipoInventario.FormattingEnabled = true;
            this.cmbTipoInventario.Items.AddRange(new object[] {
            "Compras",
            "Vendas"});
            this.cmbTipoInventario.Location = new System.Drawing.Point(324, 107);
            this.cmbTipoInventario.Name = "cmbTipoInventario";
            this.cmbTipoInventario.Size = new System.Drawing.Size(489, 24);
            this.cmbTipoInventario.TabIndex = 73;
            this.cmbTipoInventario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoInventario_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(164, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Tipo da Transação:";
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgInventario);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.cmbTipoInventario);
            this.Controls.Add(this.label7);
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgInventario;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.ComboBox cmbTipoInventario;
        private System.Windows.Forms.Label label7;
    }
}