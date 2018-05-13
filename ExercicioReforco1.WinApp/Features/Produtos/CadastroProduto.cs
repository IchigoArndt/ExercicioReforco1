using ExercicioReforco1.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioReforco1.WinApp.Features.Produtos
{
    public partial class CadastroProduto : Form
    {
        private Produto produto;
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        public Produto NovaProduto
        {
            get
            {
                return produto;
            }
            set
            {
                produto = value;

                txtId.Text = produto.Id.ToString();
                txtNome.Text = produto.Nome;
                txtPreco.Text = produto.PrecoVenda.ToString();
                txtPrecoCusto.Text = produto.PrecoCusto.ToString();
                if (produto.Disponivel == true)
                    ckDisponivel.Checked = true;
                else
                    ckDisponivel.Checked = false;
                dtpValidade.Text = produto.DataVencimento.ToString();
                dtpFabricacao.Text = produto.DataFabricacao.ToString();

                if (produto.Nome != null)
                {
                    txtNome.Text = produto.Nome.ToString();
                    btnCadastrar.Text = "Atualizar";
                }
                else
                {
                    btnCadastrar.Text = "Cadastrar";
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text != "")
                {
                    produto.Nome = txtNome.Text;

                    Double numero;

                    if (Double.TryParse(txtPreco.Text, out numero))
                        produto.PrecoVenda = numero;
                    else
                        throw new Exception("Valor inserido incorretamente para o campo Preço");
                    /////////////////////////////////////////////////
                    if (Double.TryParse(txtPrecoCusto.Text, out numero))
                        produto.PrecoCusto = numero;
                    else
                        throw new Exception("Valor inserido incorretamente para o campo Preço");

                    if (ckDisponivel.Checked)
                        produto.Disponivel = true;
                    else
                        produto.Disponivel = false;

                    produto.DataVencimento = Convert.ToDateTime(dtpValidade.Text.ToString());

                    produto.DataFabricacao = Convert.ToDateTime(dtpFabricacao.Text.ToString());

                    produto.valida();
                }
                else
                {
                    throw new Exception("O Nome não pode estar vazio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                DialogResult = DialogResult.None;
            }
        }
    }
}
