namespace SistemaPDV.UI_formularios
{
    partial class frmCompraVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraVenda));
            this.dvgCompraVenda = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEnderecoDistribuidora = new System.Windows.Forms.TextBox();
            this.txtContatoDistribuidora = new System.Windows.Forms.TextBox();
            this.txtnomeDistribuidora = new System.Windows.Forms.TextBox();
            this.txtPesquisarDistribuidora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtemailDistribuidora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDistribuidora = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtinventarioProduto = new System.Windows.Forms.TextBox();
            this.txtavaliacaoProduto = new System.Windows.Forms.TextBox();
            this.txtnomeProduto = new System.Windows.Forms.TextBox();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtquantidadeProduto = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txttotalpago = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtvalortotal = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompraVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgCompraVenda
            // 
            this.dvgCompraVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCompraVenda.Location = new System.Drawing.Point(16, 406);
            this.dvgCompraVenda.Name = "dvgCompraVenda";
            this.dvgCompraVenda.RowHeadersWidth = 51;
            this.dvgCompraVenda.RowTemplate.Height = 24;
            this.dvgCompraVenda.Size = new System.Drawing.Size(576, 334);
            this.dvgCompraVenda.TabIndex = 85;
            this.dvgCompraVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCompraVenda_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(837, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(379, 52);
            this.button3.TabIndex = 82;
            this.button3.Text = "ADICIONAR DETALHES DO PRODUTO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(123, 746);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(382, 68);
            this.button2.TabIndex = 81;
            this.button2.Text = "CADASTRAR COMPRA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEnderecoDistribuidora
            // 
            this.txtEnderecoDistribuidora.Location = new System.Drawing.Point(123, 243);
            this.txtEnderecoDistribuidora.Multiline = true;
            this.txtEnderecoDistribuidora.Name = "txtEnderecoDistribuidora";
            this.txtEnderecoDistribuidora.Size = new System.Drawing.Size(469, 126);
            this.txtEnderecoDistribuidora.TabIndex = 79;
            // 
            // txtContatoDistribuidora
            // 
            this.txtContatoDistribuidora.Location = new System.Drawing.Point(124, 195);
            this.txtContatoDistribuidora.Name = "txtContatoDistribuidora";
            this.txtContatoDistribuidora.Size = new System.Drawing.Size(468, 22);
            this.txtContatoDistribuidora.TabIndex = 77;
            // 
            // txtnomeDistribuidora
            // 
            this.txtnomeDistribuidora.Location = new System.Drawing.Point(124, 119);
            this.txtnomeDistribuidora.Name = "txtnomeDistribuidora";
            this.txtnomeDistribuidora.Size = new System.Drawing.Size(468, 22);
            this.txtnomeDistribuidora.TabIndex = 76;
            // 
            // txtPesquisarDistribuidora
            // 
            this.txtPesquisarDistribuidora.Location = new System.Drawing.Point(123, 79);
            this.txtPesquisarDistribuidora.Name = "txtPesquisarDistribuidora";
            this.txtPesquisarDistribuidora.Size = new System.Drawing.Size(469, 22);
            this.txtPesquisarDistribuidora.TabIndex = 75;
            this.txtPesquisarDistribuidora.TextChanged += new System.EventHandler(this.txtPesquisarDistribuidora_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "Pesquisar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "Contato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(457, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "COMPRAS | VENDAS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(206, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "Detalhes - Distribuidora | Cliente";
            // 
            // txtemailDistribuidora
            // 
            this.txtemailDistribuidora.Location = new System.Drawing.Point(124, 156);
            this.txtemailDistribuidora.Name = "txtemailDistribuidora";
            this.txtemailDistribuidora.Size = new System.Drawing.Size(468, 22);
            this.txtemailDistribuidora.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Data:";
            // 
            // dateTimeDistribuidora
            // 
            this.dateTimeDistribuidora.Location = new System.Drawing.Point(836, 272);
            this.dateTimeDistribuidora.Name = "dateTimeDistribuidora";
            this.dateTimeDistribuidora.Size = new System.Drawing.Size(383, 22);
            this.dateTimeDistribuidora.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(210, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 17);
            this.label10.TabIndex = 90;
            this.label10.Text = "PRODUTOS ADICIONADOS";
            // 
            // txtinventarioProduto
            // 
            this.txtinventarioProduto.Location = new System.Drawing.Point(837, 190);
            this.txtinventarioProduto.Name = "txtinventarioProduto";
            this.txtinventarioProduto.Size = new System.Drawing.Size(382, 22);
            this.txtinventarioProduto.TabIndex = 98;
            this.txtinventarioProduto.TextChanged += new System.EventHandler(this.txtinventarioProduto_TextChanged);
            // 
            // txtavaliacaoProduto
            // 
            this.txtavaliacaoProduto.Location = new System.Drawing.Point(837, 229);
            this.txtavaliacaoProduto.Name = "txtavaliacaoProduto";
            this.txtavaliacaoProduto.Size = new System.Drawing.Size(382, 22);
            this.txtavaliacaoProduto.TabIndex = 97;
            this.txtavaliacaoProduto.TextChanged += new System.EventHandler(this.txtavaliacaoProduto_TextChanged);
            // 
            // txtnomeProduto
            // 
            this.txtnomeProduto.Location = new System.Drawing.Point(837, 153);
            this.txtnomeProduto.Name = "txtnomeProduto";
            this.txtnomeProduto.Size = new System.Drawing.Size(382, 22);
            this.txtnomeProduto.TabIndex = 96;
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.Location = new System.Drawing.Point(836, 113);
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(383, 22);
            this.txtPesquisarProduto.TabIndex = 95;
            this.txtPesquisarProduto.TextChanged += new System.EventHandler(this.txtPesquisarProduto_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(724, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 94;
            this.label8.Text = "Pesquisar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(724, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 93;
            this.label11.Text = "Nome:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(724, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 92;
            this.label12.Text = "Estoque:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(723, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 91;
            this.label13.Text = "Preço:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(932, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 13);
            this.label14.TabIndex = 99;
            this.label14.Text = "DETALHES DO PRODUTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1138, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 41);
            this.panel1.TabIndex = 100;
            // 
            // txtquantidadeProduto
            // 
            this.txtquantidadeProduto.Location = new System.Drawing.Point(837, 334);
            this.txtquantidadeProduto.Name = "txtquantidadeProduto";
            this.txtquantidadeProduto.Size = new System.Drawing.Size(382, 22);
            this.txtquantidadeProduto.TabIndex = 102;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.IndianRed;
            this.label15.Location = new System.Drawing.Point(673, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 16);
            this.label15.TabIndex = 101;
            this.label15.Text = "Adicionar Pacotes:";
            // 
            // txttotalpago
            // 
            this.txttotalpago.Location = new System.Drawing.Point(838, 653);
            this.txttotalpago.Name = "txttotalpago";
            this.txttotalpago.Size = new System.Drawing.Size(380, 22);
            this.txttotalpago.TabIndex = 112;
            this.txttotalpago.TextChanged += new System.EventHandler(this.txttotalpago_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.IndianRed;
            this.label16.Location = new System.Drawing.Point(655, 656);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 16);
            this.label16.TabIndex = 111;
            this.label16.Text = "Informe o Total Pago:";
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.Location = new System.Drawing.Point(837, 555);
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.Size = new System.Drawing.Size(379, 22);
            this.txtvalortotal.TabIndex = 109;
            this.txtvalortotal.TextChanged += new System.EventHandler(this.txtvalortotal_TextChanged);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(837, 506);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(381, 22);
            this.txtsubtotal.TabIndex = 107;
            this.txtsubtotal.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(726, 506);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 16);
            this.label17.TabIndex = 106;
            this.label17.Text = "Sub Total:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.IndianRed;
            this.label20.Location = new System.Drawing.Point(655, 558);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 16);
            this.label20.TabIndex = 103;
            this.label20.Text = "Informe o Valor Total:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(904, 481);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(197, 13);
            this.label21.TabIndex = 113;
            this.label21.Text = "DETALHES DA VENDA | COMPRA";
            // 
            // txttroco
            // 
            this.txttroco.Location = new System.Drawing.Point(837, 708);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(381, 22);
            this.txttroco.TabIndex = 115;
            this.txttroco.TextChanged += new System.EventHandler(this.txttroco_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label22.Location = new System.Drawing.Point(696, 714);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 16);
            this.label22.TabIndex = 114;
            this.label22.Text = "Valor do Troco:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(837, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 68);
            this.button1.TabIndex = 116;
            this.button1.Text = "CADASTRAR VENDA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.ForestGreen;
            this.label18.Location = new System.Drawing.Point(824, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(323, 33);
            this.label18.TabIndex = 68;
            this.label18.Text = "**--  MANNÁ PDV  --**";
            // 
            // frmCompraVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 828);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txttotalpago);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtvalortotal);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtquantidadeProduto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtinventarioProduto);
            this.Controls.Add(this.txtavaliacaoProduto);
            this.Controls.Add(this.txtnomeProduto);
            this.Controls.Add(this.txtPesquisarProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimeDistribuidora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemailDistribuidora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dvgCompraVenda);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEnderecoDistribuidora);
            this.Controls.Add(this.txtContatoDistribuidora);
            this.Controls.Add(this.txtnomeDistribuidora);
            this.Controls.Add(this.txtPesquisarDistribuidora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompraVenda";
            this.Load += new System.EventHandler(this.frmCompraVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCompraVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCompraVenda;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEnderecoDistribuidora;
        private System.Windows.Forms.TextBox txtContatoDistribuidora;
        private System.Windows.Forms.TextBox txtnomeDistribuidora;
        private System.Windows.Forms.TextBox txtPesquisarDistribuidora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtemailDistribuidora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDistribuidora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtinventarioProduto;
        private System.Windows.Forms.TextBox txtavaliacaoProduto;
        private System.Windows.Forms.TextBox txtnomeProduto;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtquantidadeProduto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txttotalpago;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtvalortotal;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
    }
}