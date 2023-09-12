using DGVPrinterHelper;
using SistemaPDV.BLL_Classes;
using SistemaPDV.DAL_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaPDV.UI_formularios
{
    public partial class frmCompraVenda : Form
    {
        public frmCompraVenda()
        {
            InitializeComponent();
        }
        CliDisDAL dcDAL = new CliDisDAL();
        produtosDAL pDAL = new produtosDAL();
        DataTable transacaoDT = new DataTable();

        userDAL_Classes udal = new userDAL_Classes();
        CompraVendaDAL tDAL = new CompraVendaDAL();
        DetalhesCompraVendaDAL tdDAL = new DetalhesCompraVendaDAL();

        DGVPrinter teste = new DGVPrinter();

        private void frmCompraVenda_Load(object sender, EventArgs e)
        {
            transacaoDT.Columns.Add("Nome Produto");
            transacaoDT.Columns.Add("Preço");
            transacaoDT.Columns.Add("Quantidade");
            transacaoDT.Columns.Add("Total");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtPesquisarDistribuidora_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtPesquisarDistribuidora.Text;
            if(keyword == "")
            {
                txtnomeDistribuidora.Text = "";
                txtemailDistribuidora.Text = "";
                txtContatoDistribuidora.Text = "";
                txtEnderecoDistribuidora.Text = "";
                return;
            }

            CliDisBLL dc = dcDAL.PesquisarCliDisTransacao(keyword);

            txtnomeDistribuidora.Text = dc.nome;
            txtemailDistribuidora.Text = dc.email;
            txtContatoDistribuidora.Text = dc.contato;
            txtEnderecoDistribuidora.Text = dc.endereco;
        }

        private void txtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtPesquisarProduto.Text;
            if (keyword == "")
            {
                txtnomeProduto.Text = "";
                txtinventarioProduto.Text = "";
                txtavaliacaoProduto.Text = "";
                txtquantidadeProduto.Text = "";
                return;
            }

            produtosBLL p = pDAL.PesquisarProdutosTransacao(keyword);

            txtnomeProduto.Text = p.nome;
            //txtinventarioProduto.Text = p.quant.ToString();
            //txtinventarioProduto.Text = p.quant.ToString();
            

            if (txtinventarioProduto.Text != "")
            {
                p.quant += Convert.ToDecimal(txtinventarioProduto.Text);
                //txtavaliacaoProduto.Text = Convert.ToString(p.avaliacao + p.quant); 
            }

            txtinventarioProduto.Text = p.quant.ToString();


            txtavaliacaoProduto.Text = p.avaliacao.ToString();
                       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string produtoNome = txtnomeProduto.Text;
            decimal Preco = decimal.Parse(txtavaliacaoProduto.Text);
            decimal Avaliacao = decimal.Parse(txtavaliacaoProduto.Text);
            decimal Quant = decimal.Parse(txtquantidadeProduto.Text);
            decimal Total = Avaliacao * Quant;

            decimal subtotal = decimal.Parse(txtsubtotal.Text);
            subtotal = subtotal + Total;

            if(produtoNome == "")
            {
                MessageBox.Show("FAVOR, SELECIONE UM PRODUTO PRIMEIRO");
            }
            else
            {
                transacaoDT.Rows.Add(produtoNome, Preco, Quant, Total);
                dvgCompraVenda.DataSource = transacaoDT;

                txtsubtotal.Text = subtotal.ToString();

                txtPesquisarProduto.Text = "";
                txtnomeProduto.Text = "";
                txtinventarioProduto.Text = "";
                txtavaliacaoProduto.Text = "";
                txtquantidadeProduto.Text = "";
            }
        }

        private void txtvalortotal_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {
            string valor = txtdesconto.Text;

            if(valor == "")
            {
                MessageBox.Show("FAVOR, INSERIR O DESCONTO PRIMEIRO");
            }
            else
            {
                decimal subtotal = decimal.Parse(txtsubtotal.Text);
                decimal desconto = decimal.Parse(txtdesconto.Text);

                decimal totalgeral = ((100 - desconto) / 100) * subtotal;

                txtvalortotal.Text = totalgeral.ToString();
            }
        }
        */
        /*
        private void txtimposto_TextChanged(object sender, EventArgs e)
        {
            string checar = txtvalortotal.Text;

            if(checar == "")
            {
                MessageBox.Show("FAVOR, INSIRA DESCONTO E VALOR TOTAL");
            }
            else
            {
                decimal anterior = decimal.Parse(txtvalortotal.Text);
                decimal imposto = decimal.Parse(txtimposto.Text);

                decimal totalgeralimposto = ((100 + imposto) / 100) * anterior;

                txtvalortotal.Text = totalgeralimposto.ToString();
            }
        }
        */

        private void txttotalpago_TextChanged(object sender, EventArgs e)
        {

            decimal gvalor;
            decimal valorpago;

            if (decimal.TryParse(txtvalortotal.Text, out gvalor) && decimal.TryParse(txttotalpago.Text, out valorpago))
            {
                decimal valorretornado = valorpago - gvalor;
                txttroco.Text = valorretornado.ToString();
            }
            
            


            //decimal gvalor = decimal.Parse(txtvalortotal.Text);
            //decimal valorpago = decimal.Parse(txttotalpago.Text);
            //decimal valorretornado = valorpago - gvalor;
            //txttroco.Text = valorretornado.ToString();

            /*
            string input = "";

            decimal gvalor = 0;
            decimal valorpago = 0;

            if (Decimal.TryParse(input, out gvalor))
            {
                gvalor = Decimal.Parse(txtvalortotal.Text);
                valorpago = Decimal.Parse(txttotalpago.Text);
            }       

            decimal valorretornado = valorpago - gvalor;

            txttroco.Text = valorretornado.ToString();
            */
        }

        private void txttroco_TextChanged(object sender, EventArgs e)
        {
           /* 
            decimal gvalor = decimal.Parse(txtvalortotal.Text);
            



            decimal valorpago = decimal.Parse(txttotalpago.Text);


            decimal valorretornado = valorpago - gvalor;

           */
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompraVendaBLL transacao = new CompraVendaBLL();
            
            string distClienteNome = txtnomeDistribuidora.Text;
            CliDisBLL dc = dcDAL.pegarDistClienteIDnome(distClienteNome);
            transacao.cliente_id = dc.id;
            transacao.total_geral = Math.Round(decimal.Parse(txtvalortotal.Text), 2);
            transacao.transacao_data = DateTime.Now;
            //transacao.imposto = decimal.Parse(txtimposto.Text);
            //transacao.desconto = decimal.Parse(txtdesconto.Text);

            string usuario = frmLogin.logado_sistema;
            userBLL_Class u = udal.GETIDfromnomeusuario(usuario);
            transacao.add_por = u.id;
            transacao.transacaoDetalhes = transacaoDT;

            bool sucesso = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transacaoID = -1;
                bool w = tDAL.Insert(transacao, out transacaoID);
                for(int i = 0; i < transacaoDT.Rows.Count; i++)
                {
                    DetalhesCompraVendaBLL transacaoDetalhes = new DetalhesCompraVendaBLL();
                    string produtoNome = transacaoDT.Rows[i][0].ToString();
                    produtosBLL p = pDAL.pegarProdutoIDnome(produtoNome);

                    transacaoDetalhes.produto_id = p.id;
                    transacaoDetalhes.avaliacao = decimal.Parse(transacaoDT.Rows[i][1].ToString());
                    transacaoDetalhes.quanti = decimal.Parse(transacaoDT.Rows[i][2].ToString());
                    transacaoDetalhes.total = Math.Round(decimal.Parse(transacaoDT.Rows[i][3].ToString()), 2);

                    transacaoDetalhes.cliente_id = dc.id;
                    transacaoDetalhes.add_data = DateTime.Now;
                    transacaoDetalhes.add_por = u.id;

                    string transacaoTipo = label1.Text;

                    bool x = false;
                    if(transacaoTipo == "COMPRAS | VENDAS")
                    {
                        x = pDAL.IncProduto(transacaoDetalhes.produto_id, transacaoDetalhes.quanti);
                    }

                    bool y = tdDAL.Insert(transacaoDetalhes);
                    sucesso = w && y;
                }

                if (sucesso == true)
                {
                    scope.Complete();


                    MessageBox.Show("DADOS SALVOS COM SUCESSO");
                    dvgCompraVenda.DataSource = null;
                    dvgCompraVenda.Rows.Clear();

                    txtPesquisarDistribuidora.Text = "";
                    txtPesquisarProduto.Text = "";
                    txtnomeDistribuidora.Text = "";
                    txtnomeProduto.Text = "";
                    txtemailDistribuidora.Text = "";
                    txtContatoDistribuidora.Text = "";
                    txtEnderecoDistribuidora.Text = "";
                    txtinventarioProduto.Text = "";
                    txtavaliacaoProduto.Text = "";
                    txtquantidadeProduto.Text = "";
                    txtsubtotal.Text = "";
                    //txtdesconto.Text = "";
                    //txtimposto.Text = "";
                    txtvalortotal.Text = "";
                    txttotalpago.Text = "";
                    txttroco.Text = "";
                }
                else
                {
                    MessageBox.Show("NÃO FOI POSSÍVEL SALVAR OS DADOS");
                }
            }
        }


        // SEGUNDO BOTÃO


        private void button1_Click(object sender, EventArgs e)
        {
            CompraVendaBLL transacao = new CompraVendaBLL();

            string distClienteNome = txtnomeDistribuidora.Text;
            CliDisBLL dc = dcDAL.pegarDistClienteIDnome(distClienteNome);
            transacao.cliente_id = dc.id;
            transacao.total_geral = Math.Round(decimal.Parse(txtvalortotal.Text), 2);
            transacao.transacao_data = DateTime.Now;
            //transacao.imposto = decimal.Parse(txtimposto.Text);
            //transacao.desconto = decimal.Parse(txtdesconto.Text);

            string usuario = frmLogin.logado_sistema;
            userBLL_Class u = udal.GETIDfromnomeusuario(usuario);
            transacao.add_por = u.id;
            transacao.transacaoDetalhes = transacaoDT;

            bool sucesso = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int transacaoID = -1;
                bool w = tDAL.Insert(transacao, out transacaoID);
                for (int i = 0; i < transacaoDT.Rows.Count; i++)
                {
                    DetalhesCompraVendaBLL transacaoDetalhes = new DetalhesCompraVendaBLL();
                    string produtoNome = transacaoDT.Rows[i][0].ToString();
                    produtosBLL p = pDAL.pegarProdutoIDnome(produtoNome);

                    transacaoDetalhes.produto_id = p.id;
                    transacaoDetalhes.avaliacao = decimal.Parse(transacaoDT.Rows[i][1].ToString());
                    transacaoDetalhes.quanti = decimal.Parse(transacaoDT.Rows[i][2].ToString());
                    transacaoDetalhes.total = Math.Round(decimal.Parse(transacaoDT.Rows[i][3].ToString()), 2);

                    transacaoDetalhes.cliente_id = dc.id;
                    transacaoDetalhes.add_data = DateTime.Now;
                    transacaoDetalhes.add_por = u.id;

                    string transacaoTipo = label1.Text;

                    bool x = false;
                    if (transacaoTipo == "COMPRAS | VENDAS")
                    {
                        x = pDAL.DescProduto(transacaoDetalhes.produto_id, transacaoDetalhes.quanti);
                    }

                    bool y = tdDAL.Insert(transacaoDetalhes);
                    sucesso = w && y;
                }

                if (sucesso == true)
                {
                    scope.Complete();


                    DGVPrinter printer = new DGVPrinter();

                    printer.Title = "\r\n\r\n MANNÁ LANCHES";
                    printer.SubTitle = "Sua lanchonete favorita!!! \r\n Telefone: 83 8710-6518 \r\n\r\n";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Valor total: " + txtvalortotal.Text + " $" + "\r\n" + "Valor pago: " + txttotalpago.Text + " $" + "\r\n" + "Troco: " + txttroco.Text + " $" + "\r\n" + "OBRIGADO POR COMPRAR CONOSCO!!!" + " \r\n" + "Deus é fiel!";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dvgCompraVenda);

                    MessageBox.Show("DADOS SALVOS COM SUCESSO");
                    dvgCompraVenda.DataSource = null;
                    dvgCompraVenda.Rows.Clear();

                    txtPesquisarDistribuidora.Text = "";
                    txtPesquisarProduto.Text = "";
                    txtnomeDistribuidora.Text = "";
                    txtnomeProduto.Text = "";
                    txtemailDistribuidora.Text = "";
                    txtContatoDistribuidora.Text = "";
                    txtEnderecoDistribuidora.Text = "";
                    txtinventarioProduto.Text = "";
                    txtavaliacaoProduto.Text = "";
                    txtquantidadeProduto.Text = "";
                    txtsubtotal.Text = "";
                    //txtdesconto.Text = "";
                    //txtimposto.Text = "";
                    txtvalortotal.Text = "";
                    txttotalpago.Text = "";
                    txttroco.Text = "";
                }
                else
                {
                    MessageBox.Show("NÃO FOI POSSÍVEL SALVAR OS DADOS");
                }
            }
        }

        private void txtinventarioProduto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtavaliacaoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgCompraVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
