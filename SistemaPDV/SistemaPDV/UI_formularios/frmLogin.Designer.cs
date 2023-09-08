namespace SistemaPDV.UI_formularios
{
    partial class frmLogin
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsobrenome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.cmbtipousuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(294, 125);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(409, 22);
            this.txtusuario.TabIndex = 38;
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.AutoSize = true;
            this.txtsobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsobrenome.Location = new System.Drawing.Point(110, 125);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(77, 22);
            this.txtsobrenome.TabIndex = 37;
            this.txtsobrenome.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipo_Usuario:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(294, 166);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(409, 22);
            this.txtsenha.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Senha:";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Lime;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnlogin.Location = new System.Drawing.Point(294, 295);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(225, 45);
            this.btnlogin.TabIndex = 39;
            this.btnlogin.Text = "ENTRAR";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbtipousuario
            // 
            this.cmbtipousuario.FormattingEnabled = true;
            this.cmbtipousuario.Items.AddRange(new object[] {
            "Usuario",
            "Admin"});
            this.cmbtipousuario.Location = new System.Drawing.Point(294, 207);
            this.cmbtipousuario.Name = "cmbtipousuario";
            this.cmbtipousuario.Size = new System.Drawing.Size(197, 24);
            this.cmbtipousuario.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(257, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 39);
            this.label5.TabIndex = 41;
            this.label5.Text = "TELA DE LOGIN";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbtipousuario);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label3);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label txtsobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ComboBox cmbtipousuario;
        private System.Windows.Forms.Label label5;
    }
}